using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MyEditor
{
	//See https://stackoverflow.com/questions/3823188/how-can-i-sync-the-scrolling-of-two-multiline-textboxes
	class MyTBox : TextBox
	{
		public MyTBox() {
			this.Multiline = true;
			this.ScrollBars = ScrollBars.Vertical;
		}
		public Control Buddy { get; set; }
		public Label Label { get; set; }

		private static bool scrolling;   // In case buddy tries to scroll us
		protected override void WndProc(ref Message m) {
			base.WndProc(ref m);
			// Trap WM_VSCROLL message and pass to buddy
			if ((m.Msg == 0x115 || m.Msg == 522) && !scrolling && Buddy != null && Buddy.IsHandleCreated) {
				scrolling = true;
				SendMessage(Buddy.Handle, m.Msg, m.WParam, m.LParam);
				scrolling = false;
			}
			if (this.Label != null) {
				switch (m.Msg) {
					case 32:
					case 132:
					case 512:
					case 673:
						break;
					default:
						this.Label.Text = m.Msg.ToString();
						break;
				}
			}
		}
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
	}
}
