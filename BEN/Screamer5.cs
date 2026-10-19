using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Media;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using BEN.My;
using BEN.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

namespace BEN
{
	// Token: 0x0200001A RID: 26
	[DesignerGenerated]
	public partial class Screamer5 : Form
	{
		// Token: 0x06000144 RID: 324 RVA: 0x0000F208 File Offset: 0x0000D408
		public Screamer5()
		{
			base.Load += this.Screamer5_Load;
			base.FormClosing += this.Screamer5_FormClosing;
			this.appPath = Application.StartupPath;
			this.sec = 50;
			this.canQuit = false;
			this.InitializeComponent();
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000147 RID: 327 RVA: 0x0000F41F File Offset: 0x0000D61F
		// (set) Token: 0x06000148 RID: 328 RVA: 0x0000F428 File Offset: 0x0000D628
		internal virtual Timer Timer1
		{
			[CompilerGenerated]
			get
			{
				return this._Timer1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Timer1_Tick);
				Timer timer = this._Timer1;
				if (timer != null)
				{
					timer.Tick -= eventHandler;
				}
				this._Timer1 = value;
				timer = this._Timer1;
				if (timer != null)
				{
					timer.Tick += eventHandler;
				}
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000149 RID: 329 RVA: 0x0000F46B File Offset: 0x0000D66B
		// (set) Token: 0x0600014A RID: 330 RVA: 0x0000F474 File Offset: 0x0000D674
		internal virtual PictureBox PictureBox1
		{
			[CompilerGenerated]
			get
			{
				return this._PictureBox1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.PictureBox1_Click);
				PictureBox pictureBox = this._PictureBox1;
				if (pictureBox != null)
				{
					pictureBox.Click -= eventHandler;
				}
				this._PictureBox1 = value;
				pictureBox = this._PictureBox1;
				if (pictureBox != null)
				{
					pictureBox.Click += eventHandler;
				}
			}
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0000F4B8 File Offset: 0x0000D6B8
		private void Screamer5_Load(object sender, EventArgs e)
		{
			Cursor.Hide();
			this.PictureBox1.Image = Image.FromFile(this.appPath + "\\assets\\gifs\\TEDNE.gif");
			this.PictureBox1.Visible = true;
			new SoundPlayer(Resources._2).Play();
			this.Timer1.Start();
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0000F510 File Offset: 0x0000D710
		private void Screamer5_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!this.canQuit)
			{
				e.Cancel = true;
			}
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0000F524 File Offset: 0x0000D724
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.sec = Operators.SubtractObject(this.sec, 1);
			if (Operators.ConditionalCompareObjectEqual(this.sec, 48, false))
			{
				this.canQuit = true;
				MyProject.Forms.ThirdGame.getScreamed = true;
				MyProject.Forms.ThirdGame.TimerDecompo.Start();
				Cursor.Show();
				new SoundPlayer(Resources._2).Stop();
				base.Close();
			}
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0000F5A2 File Offset: 0x0000D7A2
		private void PictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0400009D RID: 157
		private string appPath;

		// Token: 0x0400009E RID: 158
		private object sec;

		// Token: 0x0400009F RID: 159
		private bool canQuit;
	}
}
