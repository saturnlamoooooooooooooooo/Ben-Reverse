namespace BEN
{
	// Token: 0x0200000D RID: 13
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Finalstep : global::System.Windows.Forms.Form
	{
		// Token: 0x0600008C RID: 140 RVA: 0x00004E38 File Offset: 0x00003038
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

		// Token: 0x0600008D RID: 141 RVA: 0x00004E78 File Offset: 0x00003078
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.Timer2 = new global::System.Windows.Forms.Timer(this.components);
			this.Tasktimer = new global::System.Windows.Forms.Timer(this.components);
			this.GotyouTimer = new global::System.Windows.Forms.Timer(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			base.SuspendLayout();
			this.PictureBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.PictureBox1.Location = new global::System.Drawing.Point(0, 0);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new global::System.Drawing.Size(177, 160);
			this.PictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureBox1.TabIndex = 0;
			this.PictureBox1.TabStop = false;
			this.PictureBox1.Visible = false;
			this.Timer1.Interval = 1000;
			this.Timer2.Interval = 500;
			this.Tasktimer.Interval = 700;
			this.GotyouTimer.Interval = 1000;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(177, 160);
			base.Controls.Add(this.PictureBox1);
			this.ForeColor = global::System.Drawing.Color.Black;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Finalstep";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			base.TopMost = true;
			base.WindowState = global::System.Windows.Forms.FormWindowState.Maximized;
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400002B RID: 43
		private global::System.ComponentModel.IContainer components;
	}
}
