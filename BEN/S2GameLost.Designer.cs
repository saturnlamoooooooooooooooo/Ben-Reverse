namespace BEN
{
	// Token: 0x02000015 RID: 21
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class S2GameLost : global::System.Windows.Forms.Form
	{
		// Token: 0x06000113 RID: 275 RVA: 0x0000E108 File Offset: 0x0000C308
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.components != null)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06000114 RID: 276 RVA: 0x0000E148 File Offset: 0x0000C348
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			base.SuspendLayout();
			this.Timer1.Interval = 1000;
			this.PictureBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.PictureBox1.Location = new global::System.Drawing.Point(0, 0);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new global::System.Drawing.Size(205, 121);
			this.PictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureBox1.TabIndex = 0;
			this.PictureBox1.TabStop = false;
			this.PictureBox1.Visible = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(205, 121);
			base.ControlBox = false;
			base.Controls.Add(this.PictureBox1);
			this.ForeColor = global::System.Drawing.Color.Black;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "S2GameLost";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			base.TopMost = true;
			base.WindowState = global::System.Windows.Forms.FormWindowState.Maximized;
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000080 RID: 128
		private global::System.ComponentModel.IContainer components;
	}
}
