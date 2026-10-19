namespace BEN
{
	// Token: 0x02000011 RID: 17
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class InstallShield : global::System.Windows.Forms.Form
	{
		// Token: 0x060000D2 RID: 210 RVA: 0x0000BB34 File Offset: 0x00009D34
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

		// Token: 0x060000D3 RID: 211 RVA: 0x0000BB74 File Offset: 0x00009D74
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::BEN.InstallShield));
			this.RichTextBox1 = new global::System.Windows.Forms.RichTextBox();
			this.RichTextBox2 = new global::System.Windows.Forms.RichTextBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.Button3 = new global::System.Windows.Forms.Button();
			this.ProgressBar1 = new global::System.Windows.Forms.ProgressBar();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.TimerEA = new global::System.Windows.Forms.Timer(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			base.SuspendLayout();
			this.RichTextBox1.BackColor = global::System.Drawing.Color.White;
			this.RichTextBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.RichTextBox1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.RichTextBox1.Location = new global::System.Drawing.Point(211, 36);
			this.RichTextBox1.Name = "RichTextBox1";
			this.RichTextBox1.ReadOnly = true;
			this.RichTextBox1.Size = new global::System.Drawing.Size(326, 50);
			this.RichTextBox1.TabIndex = 1;
			this.RichTextBox1.TabStop = false;
			this.RichTextBox1.Text = "Welcome to the InstallShield Wizard for \nThe Legend of Zelda : Majora's Mask";
			this.RichTextBox2.BackColor = global::System.Drawing.Color.White;
			this.RichTextBox2.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.RichTextBox2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.RichTextBox2.Location = new global::System.Drawing.Point(207, 109);
			this.RichTextBox2.Name = "RichTextBox2";
			this.RichTextBox2.ReadOnly = true;
			this.RichTextBox2.Size = new global::System.Drawing.Size(330, 165);
			this.RichTextBox2.TabIndex = 2;
			this.RichTextBox2.TabStop = false;
			this.RichTextBox2.Text = componentResourceManager.GetString("RichTextBox2.Text");
			this.Button1.Location = new global::System.Drawing.Point(462, 382);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(75, 23);
			this.Button1.TabIndex = 3;
			this.Button1.TabStop = false;
			this.Button1.Text = "Exit";
			this.Button1.UseVisualStyleBackColor = true;
			this.Button2.Location = new global::System.Drawing.Point(371, 382);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(75, 23);
			this.Button2.TabIndex = 4;
			this.Button2.TabStop = false;
			this.Button2.Text = "Next >";
			this.Button2.UseVisualStyleBackColor = true;
			this.Button3.Enabled = false;
			this.Button3.Location = new global::System.Drawing.Point(290, 382);
			this.Button3.Name = "Button3";
			this.Button3.Size = new global::System.Drawing.Size(75, 23);
			this.Button3.TabIndex = 5;
			this.Button3.TabStop = false;
			this.Button3.Text = "< Back";
			this.Button3.UseVisualStyleBackColor = true;
			this.ProgressBar1.Location = new global::System.Drawing.Point(207, 331);
			this.ProgressBar1.Name = "ProgressBar1";
			this.ProgressBar1.Size = new global::System.Drawing.Size(330, 23);
			this.ProgressBar1.TabIndex = 6;
			this.ProgressBar1.Visible = false;
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.999999f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new global::System.Drawing.Point(204, 314);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(19, 15);
			this.Label1.TabIndex = 7;
			this.Label1.Text = "---";
			this.Label1.Visible = false;
			this.Timer1.Interval = 50;
			this.PictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("PictureBox1.Image");
			this.PictureBox1.Location = new global::System.Drawing.Point(0, 0);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new global::System.Drawing.Size(558, 370);
			this.PictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureBox1.TabIndex = 0;
			this.PictureBox1.TabStop = false;
			this.TimerEA.Interval = 1000;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(557, 418);
			base.Controls.Add(this.Label1);
			base.Controls.Add(this.ProgressBar1);
			base.Controls.Add(this.Button3);
			base.Controls.Add(this.Button2);
			base.Controls.Add(this.Button1);
			base.Controls.Add(this.RichTextBox2);
			base.Controls.Add(this.RichTextBox1);
			base.Controls.Add(this.PictureBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "InstallShield";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TLOZ : Majora's Mask  - InstallShield Wizard";
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400005B RID: 91
		private global::System.ComponentModel.IContainer components;
	}
}
