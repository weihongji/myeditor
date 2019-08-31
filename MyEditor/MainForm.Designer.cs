namespace MyEditor
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.btnMyEditor = new System.Windows.Forms.Button();
			this.btnScintillaEditor = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnMyEditor
			// 
			this.btnMyEditor.Location = new System.Drawing.Point(86, 41);
			this.btnMyEditor.Name = "btnMyEditor";
			this.btnMyEditor.Size = new System.Drawing.Size(113, 32);
			this.btnMyEditor.TabIndex = 0;
			this.btnMyEditor.Text = "My &Editor";
			this.btnMyEditor.UseVisualStyleBackColor = true;
			this.btnMyEditor.Click += new System.EventHandler(this.btnMyEditor_Click);
			// 
			// btnScintillaEditor
			// 
			this.btnScintillaEditor.Location = new System.Drawing.Point(86, 89);
			this.btnScintillaEditor.Name = "btnScintillaEditor";
			this.btnScintillaEditor.Size = new System.Drawing.Size(113, 32);
			this.btnScintillaEditor.TabIndex = 0;
			this.btnScintillaEditor.Text = "&Scintilla Editor";
			this.btnScintillaEditor.UseVisualStyleBackColor = true;
			this.btnScintillaEditor.Click += new System.EventHandler(this.btnScintillaEditor_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 233);
			this.Controls.Add(this.btnScintillaEditor);
			this.Controls.Add(this.btnMyEditor);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Open Forms";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnMyEditor;
		private System.Windows.Forms.Button btnScintillaEditor;
	}
}