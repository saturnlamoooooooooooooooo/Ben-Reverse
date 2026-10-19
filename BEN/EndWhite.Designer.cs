namespace BEN
{
	// Token: 0x0200000C RID: 12
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class EndWhite : global::System.Windows.Forms.Form
	{
		// Token: 0x06000082 RID: 130 RVA: 0x000049C8 File Offset: 0x00002BC8
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

		// Token: 0x06000083 RID: 131 RVA: 0x00004A08 File Offset: 0x00002C08
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			base.SuspendLayout();
			this.Timer1.Interval = 1000;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.ButtonHighlight;
			base.ClientSize = new global::System.Drawing.Size(213, 172);
			base.ControlBox = false;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "EndWhite";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			base.TopMost = true;
			base.WindowState = global::System.Windows.Forms.FormWindowState.Maximized;
			base.ResumeLayout(false);
		}

		// Token: 0x04000024 RID: 36
		private global::System.ComponentModel.IContainer components;
	}
}
