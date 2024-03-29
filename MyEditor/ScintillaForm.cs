﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScintillaNET;

namespace MyEditor
{
	// https://github.com/jacobslusser/ScintillaNET
	
	public partial class ScintillaForm : Form
	{
		public ScintillaForm() {
			InitializeComponent();
		}

		private void ScintillaForm_Load(object sender, EventArgs e) {
			var nums = textBox1.Margins[1];
			nums.Width = 30;
			nums.Type = MarginType.Number;
			nums.Sensitive = true;
			nums.Mask = 0;

			var margin = textBox1.Margins[2];
			margin.Width = 10;

			textBox1.Styles[Style.Default].Font = "Microsoft Sans Serif";
			textBox1.Styles[Style.Default].Size = 11;

			textBox1.SetSelectionBackColor(true, IntToColor(0x0078D7));
		}

		public static Color IntToColor(int rgb) {
			return Color.FromArgb(255, (byte)(rgb >> 16), (byte)(rgb >> 8), (byte)rgb);
		}

		private void textBox1_Click(object sender, EventArgs e) {
			ShowPosition();
		}

		private void textBox1_KeyDown(object sender, KeyEventArgs e) {
			// Tab pressing is captured by the editor. Let's change the behavior to what normal textboxes work.
			if (e.KeyCode == Keys.Tab) {
				if (e.Control) { // Enter a tab when Ctrl+Tab is pressed
					textBox1.ReplaceSelection("\t");
				}
				else if (!e.Alt) { // A single Tab pressed (not combined with Ctrl, Alt)
					e.SuppressKeyPress = true;
					this.SelectNextControl(ActiveControl, !e.Shift, true, true, true);
					return;
				}
			}
			ShowPosition();
		}

		private void textBox1_KeyUp(object sender, KeyEventArgs e) {
			ShowPosition();
		}

		private void ShowPosition() {
			statusLabel1.Text = String.Format("Cursor position: {0} / {1}", textBox1.SelectionStart.ToString("#,0"), textBox1.Text.Length.ToString("#,0"));
		}
	}
}
