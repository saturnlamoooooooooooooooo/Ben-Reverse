namespace BEN
{
	// Token: 0x02000008 RID: 8
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Andcredits : global::System.Windows.Forms.Form
	{
		// Token: 0x06000051 RID: 81 RVA: 0x00002920 File Offset: 0x00000B20
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

		// Token: 0x06000052 RID: 82 RVA: 0x00002960 File Offset: 0x00000B60
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
			this.PictureBox1.Size = new global::System.Drawing.Size(701, 484);
			this.PictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureBox1.TabIndex = 0;
			this.PictureBox1.TabStop = false;
			this.PictureBox1.Visible = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(701, 484);
			base.Controls.Add(this.PictureBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Andcredits";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			base.TopMost = true;
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400000B RID: 11
		private global::System.ComponentModel.IContainer components;
	}
}
