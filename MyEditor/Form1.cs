using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyEditor
{
	public partial class Form1 : Form
	{
		private bool formActivated = false;

		public Form1() {
			InitializeComponent();
		}

		private void MyEditor_Load(object sender, EventArgs e) {
			setEditorSize();
			textBox1.SelectionLength = 0;
		}

		private void panel1_Resize(object sender, EventArgs e) {
			setEditorSize();
		}

		private void setEditorSize() {
			var tbox = textBox1;
			tbox.Width = tbox.Parent.Width - 40;
		}

		private void Form1_Activated(object sender, EventArgs e) {
			if (!formActivated) {
				textBox1.SelectionLength = 0;
				formActivated = true;
			}
		}
	}
}
