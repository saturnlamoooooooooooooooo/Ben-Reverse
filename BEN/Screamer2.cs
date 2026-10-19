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
	// Token: 0x02000017 RID: 23
	[DesignerGenerated]
	public partial class Screamer2 : Form
	{
		// Token: 0x06000126 RID: 294 RVA: 0x0000E822 File Offset: 0x0000CA22
		public Screamer2()
		{
			base.Load += this.Screamer2_Load;
			this.appPath = Application.StartupPath;
			this.sec = 2;
			this.InitializeComponent();
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000129 RID: 297 RVA: 0x0000EA0E File Offset: 0x0000CC0E
		// (set) Token: 0x0600012A RID: 298 RVA: 0x0000EA18 File Offset: 0x0000CC18
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

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600012B RID: 299 RVA: 0x0000EA5B File Offset: 0x0000CC5B
		// (set) Token: 0x0600012C RID: 300 RVA: 0x0000EA64 File Offset: 0x0000CC64
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

		// Token: 0x0600012D RID: 301 RVA: 0x0000EAA8 File Offset: 0x0000CCA8
		private void Screamer2_Load(object sender, EventArgs e)
		{
			this.Timer1.Start();
			base.KeyPreview = true;
			Cursor.Hide();
			this.PictureBox1.Image = Image.FromFile(this.appPath + "\\assets\\gifs\\MoshedBenblackNoiser.gif");
			new SoundPlayer(Resources.mega6).Play();
		}

		// Token: 0x0600012E RID: 302 RVA: 0x0000EAFC File Offset: 0x0000CCFC
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.sec = Operators.SubtractObject(this.sec, 1);
			if (Operators.ConditionalCompareObjectEqual(this.sec, 0, false))
			{
				new SoundPlayer(Resources.mega6).Stop();
				Cursor.Show();
				MyProject.Forms.SecondGame.TopMost = true;
				this.PictureBox1.Visible = false;
				this.Timer1.Stop();
				this.sec = 2;
				base.Hide();
				MyProject.Forms.SecondGame.remetMusique();
				base.Close();
			}
		}

		// Token: 0x0600012F RID: 303 RVA: 0x0000EB96 File Offset: 0x0000CD96
		private void PictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0400008E RID: 142
		private string appPath;

		// Token: 0x0400008F RID: 143
		private object sec;
	}
}
