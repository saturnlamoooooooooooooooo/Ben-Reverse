using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Media;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using BEN.My;
using BEN.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace BEN
{
	// Token: 0x02000015 RID: 21
	[DesignerGenerated]
	public partial class S2GameLost : Form
	{
		// Token: 0x06000112 RID: 274 RVA: 0x0000E0AC File Offset: 0x0000C2AC
		public S2GameLost()
		{
			base.Load += this.S2GameLost_Load;
			base.FormClosing += this.S2GameLost_FormClosing;
			this.appPath = Application.StartupPath;
			this.sec = 50;
			this.canQuit = false;
			this.InitializeComponent();
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000115 RID: 277 RVA: 0x0000E2C3 File Offset: 0x0000C4C3
		// (set) Token: 0x06000116 RID: 278 RVA: 0x0000E2CC File Offset: 0x0000C4CC
		internal virtual global::System.Windows.Forms.Timer Timer1
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
				global::System.Windows.Forms.Timer timer = this._Timer1;
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

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000117 RID: 279 RVA: 0x0000E30F File Offset: 0x0000C50F
		// (set) Token: 0x06000118 RID: 280 RVA: 0x0000E318 File Offset: 0x0000C518
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

		// Token: 0x06000119 RID: 281 RVA: 0x0000E35B File Offset: 0x0000C55B
		private void S2GameLost_Load(object sender, EventArgs e)
		{
			this.Timer1.Start();
			Cursor.Hide();
			this.PictureBox1.Image = Resources.MoshedCreepysmile;
			this.PictureBox1.Visible = true;
			new SoundPlayer(Resources._4).Play();
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0000E398 File Offset: 0x0000C598
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.sec = Operators.SubtractObject(this.sec, 1);
			if (Operators.ConditionalCompareObjectEqual(this.sec, 48, false))
			{
				new SoundPlayer(Resources._4).Stop();
				this.PictureBox1.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 45, false))
			{
				this.Timer1.Stop();
				this.sec = 50;
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Hey!.wav", AudioPlayMode.Background);
				base.Activate();
				Cursor.Show();
				if (Interaction.MsgBox("You have to do it !", MsgBoxStyle.YesNo, "revoemag") == MsgBoxResult.Yes)
				{
					this.canQuit = true;
					base.Hide();
					MyProject.Forms.SecondGame.Show();
					base.Close();
					return;
				}
				Thread.Sleep(1000);
				MessageBox.Show("...");
				Thread.Sleep(1000);
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Laughing.wav", AudioPlayMode.BackgroundLoop);
				MessageBox.Show("YO\u0360U\u0360  \u035d \u035e\u0340\u0337AR\u0322E  \u035f\u035eS\u0362TU\u031b\u0361CK\u0358\u0361ED\u0328 \u0358 \u0315\u0321HE\u0335\u0327R\u0328\u035d\u0334E\u0335\u0335");
				MyProject.Computer.Audio.Stop();
				this.canQuit = true;
				base.Hide();
				MyProject.Forms.SecondGame.Show();
				base.Close();
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0000E4F8 File Offset: 0x0000C6F8
		private void S2GameLost_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!this.canQuit)
			{
				e.Cancel = true;
			}
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0000E509 File Offset: 0x0000C709
		private void PictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x04000083 RID: 131
		private string appPath;

		// Token: 0x04000084 RID: 132
		private object sec;

		// Token: 0x04000085 RID: 133
		private bool canQuit;
	}
}
