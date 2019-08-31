using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyEditor
{
	public partial class MainForm : Form
	{
		public MainForm() {
			InitializeComponent();
		}

		private void btnMyEditor_Click(object sender, EventArgs e) {
			var form = new Form1();
			form.Show();
		}

		private void btnScintillaEditor_Click(object sender, EventArgs e) {
			var form = new ScintillaForm();
			form.Show();
		}
	}
}
