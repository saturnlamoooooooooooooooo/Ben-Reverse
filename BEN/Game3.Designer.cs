namespace BEN
{
	// Token: 0x02000010 RID: 16
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Game3 : global::System.Windows.Forms.Form
	{
		// Token: 0x060000BE RID: 190 RVA: 0x00009A5C File Offset: 0x00007C5C
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

		// Token: 0x060000BF RID: 191 RVA: 0x00009A9C File Offset: 0x00007C9C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.GameTimer3 = new global::System.Windows.Forms.Timer(this.components);
			this.ChoiceDeathTimer3 = new global::System.Windows.Forms.Timer(this.components);
			this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			base.SuspendLayout();
			this.GameTimer3.Interval = 1000;
			this.ChoiceDeathTimer3.Interval = 128;
			this.PictureBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.PictureBox1.Location = new global::System.Drawing.Point(0, 0);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new global::System.Drawing.Size(207, 120);
			this.PictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureBox1.TabIndex = 2;
			this.PictureBox1.TabStop = false;
			this.PictureBox1.Visible = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(207, 120);
			base.ControlBox = false;
			base.Controls.Add(this.PictureBox1);
			this.ForeColor = global::System.Drawing.Color.Black;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Game3";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			base.TopMost = true;
			base.TransparencyKey = global::System.Drawing.Color.Black;
			base.WindowState = global::System.Windows.Forms.FormWindowState.Maximized;
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400004D RID: 77
		private global::System.ComponentModel.IContainer components;
	}
}
