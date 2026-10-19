using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using BEN.My;
using BEN.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace BEN
{
	// Token: 0x0200000A RID: 10
	[DesignerGenerated]
	public partial class checkPlay : Form
	{
		// Token: 0x06000060 RID: 96 RVA: 0x000033AC File Offset: 0x000015AC
		public checkPlay()
		{
			base.Load += this.checkPlay_Load;
			this.appPath = Application.StartupPath;
			this.s3 = 1000;
			this.s2 = 1000;
			this.s1 = 1000;
			this.InitializeComponent();
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000063 RID: 99 RVA: 0x0000360A File Offset: 0x0000180A
		// (set) Token: 0x06000064 RID: 100 RVA: 0x00003612 File Offset: 0x00001812
		internal virtual PictureBox PictureBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000065 RID: 101 RVA: 0x0000361B File Offset: 0x0000181B
		// (set) Token: 0x06000066 RID: 102 RVA: 0x00003624 File Offset: 0x00001824
		internal virtual global::System.Windows.Forms.Timer Timer3
		{
			[CompilerGenerated]
			get
			{
				return this._Timer3;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Timer3_Tick);
				global::System.Windows.Forms.Timer timer = this._Timer3;
				if (timer != null)
				{
					timer.Tick -= eventHandler;
				}
				this._Timer3 = value;
				timer = this._Timer3;
				if (timer != null)
				{
					timer.Tick += eventHandler;
				}
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00003667 File Offset: 0x00001867
		// (set) Token: 0x06000068 RID: 104 RVA: 0x00003670 File Offset: 0x00001870
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

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000069 RID: 105 RVA: 0x000036B3 File Offset: 0x000018B3
		// (set) Token: 0x0600006A RID: 106 RVA: 0x000036BC File Offset: 0x000018BC
		internal virtual global::System.Windows.Forms.Timer Timer2
		{
			[CompilerGenerated]
			get
			{
				return this._Timer2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Timer2_Tick);
				global::System.Windows.Forms.Timer timer = this._Timer2;
				if (timer != null)
				{
					timer.Tick -= eventHandler;
				}
				this._Timer2 = value;
				timer = this._Timer2;
				if (timer != null)
				{
					timer.Tick += eventHandler;
				}
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00003700 File Offset: 0x00001900
		private void checkPlay_Load(object sender, EventArgs e)
		{
			base.Activate();
			base.KeyPreview = true;
			if (MyProject.Computer.FileSystem.FileExists(this.appPath + "\\datas\\gamedataDeath1.dat"))
			{
				string text = MyProject.Computer.FileSystem.ReadAllText(this.appPath + "\\datas\\gamedataDeath1.dat");
				if (text.Contains("diedGame1"))
				{
					Thread.Sleep(3000);
					MyProject.Computer.Audio.Play(this.appPath + "\\assets\\MessageFromHell.wav", AudioPlayMode.Background);
					MessageBox.Show("So you're back.", "");
					Thread.Sleep(3000);
					MyProject.Computer.Audio.Play(this.appPath + "\\assets\\MessageFromHell.wav", AudioPlayMode.Background);
					MessageBox.Show("You decided to continue ?", "");
					Thread.Sleep(3000);
					MyProject.Computer.Audio.Play(this.appPath + "\\assets\\MessageFromHell.wav", AudioPlayMode.Background);
					MessageBox.Show("I see.", "");
					Thread.Sleep(3000);
					MyProject.Computer.Audio.Play(this.appPath + "\\assets\\MessageFromHell.wav", AudioPlayMode.Background);
					this.PictureBox1.Image = Resources.igif;
					MessageBox.Show("But you didn't have to do that because...", "");
					Thread.Sleep(3000);
					this.Timer1.Start();
					return;
				}
				if (text.Contains("diedGame2"))
				{
					Thread.Sleep(3000);
					MyProject.Computer.Audio.Play(this.appPath + "\\assets\\MessageFromHell.wav", AudioPlayMode.Background);
					MessageBox.Show("So you're back, again.", "");
					Thread.Sleep(3000);
					MyProject.Computer.Audio.Play(this.appPath + "\\assets\\MessageFromHell.wav", AudioPlayMode.Background);
					MessageBox.Show("You can win ?", "");
					Thread.Sleep(3000);
					MyProject.Computer.Audio.Play(this.appPath + "\\assets\\MessageFromHell.wav", AudioPlayMode.Background);
					MessageBox.Show("I see.", "");
					Thread.Sleep(3000);
					MyProject.Computer.Audio.Play(this.appPath + "\\assets\\MessageFromHell.wav", AudioPlayMode.Background);
					this.PictureBox1.Image = Resources.detergif;
					MessageBox.Show("I can feel it, in your heart...", "");
					Thread.Sleep(3000);
					this.Timer2.Start();
					return;
				}
				if (text.Contains("diedGame3"))
				{
					Thread.Sleep(3000);
					MyProject.Computer.Audio.Play(this.appPath + "\\assets\\MessageFromHell.wav", AudioPlayMode.Background);
					MessageBox.Show("I don't understand.", "");
					Thread.Sleep(3000);
					MyProject.Computer.Audio.Play(this.appPath + "\\assets\\MessageFromHell.wav", AudioPlayMode.Background);
					MessageBox.Show("Why are you coming back ?", "");
					Thread.Sleep(3000);
					MyProject.Computer.Audio.Play(this.appPath + "\\assets\\MessageFromHell.wav", AudioPlayMode.Background);
					MessageBox.Show("Giving up and starting over...", "");
					Thread.Sleep(3000);
					MyProject.Computer.Audio.Play(this.appPath + "\\assets\\MessageFromHell.wav", AudioPlayMode.Background);
					this.PictureBox1.Image = Resources.evengif;
					MessageBox.Show("Anyway.", "");
					Thread.Sleep(3000);
					this.Timer3.Start();
					return;
				}
				if (text.Contains("gamepassed"))
				{
					string text2 = MyProject.Computer.FileSystem.ReadAllText(this.appPath + "\\datas\\game2ad.dat");
					if (text2.Contains("no"))
					{
						MyProject.Forms.SecondGame.alreadyDead = false;
						base.Hide();
						MyProject.Forms.SecondGame.Show();
						return;
					}
					if (text2.Contains("yes"))
					{
						MyProject.Forms.SecondGame.alreadyDead = true;
						base.Hide();
						MyProject.Forms.SecondGame.Show();
						return;
					}
					if (text2.Contains("game2passed"))
					{
						MyProject.Forms.SecondGame.gameIsPassed = true;
						MyProject.Forms.nextSecondGame.Show();
						return;
					}
					if (text2.Contains("thirdgame"))
					{
						MyProject.Forms.SecondGame.gameIsPassed = true;
						MyProject.Forms.ThirdGame.Show();
						return;
					}
					if (text2.Contains("finalroute"))
					{
						MyProject.Forms.SecondGame.gameIsPassed = true;
						MyProject.Forms.Finalstep.Show();
						return;
					}
					if (text2.Contains("credits"))
					{
						MyProject.Forms.SecondGame.gameIsPassed = true;
						MyProject.Forms.Andcredits.Show();
						return;
					}
					if (text2.Contains(""))
					{
						base.Hide();
						MyProject.Forms.nextFirstGames.Show();
						return;
					}
				}
				else if (!text.Contains("diedGame1") || text.Contains("diedGame2") || text.Contains("diedGame3") || text.Contains("gamepassed"))
				{
					base.Hide();
					MyProject.Forms.InstallShield.Show();
					return;
				}
			}
			else if (!MyProject.Computer.FileSystem.FileExists(this.appPath + "\\datas\\gamedataDeath1.dat"))
			{
				base.Hide();
				MyProject.Forms.InstallShield.Show();
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00003CA8 File Offset: 0x00001EA8
		private void Timer3_Tick(object sender, EventArgs e)
		{
			this.s3 = Operators.SubtractObject(this.s3, 1);
			if (Operators.ConditionalCompareObjectEqual(this.s3, 950, false))
			{
				Cursor.Hide();
				this.PictureBox1.Visible = true;
				base.TransparencyKey = default(Color);
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Boom.wav", AudioPlayMode.Background);
			}
			if (Operators.ConditionalCompareObjectEqual(this.s3, 898, false))
			{
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Boom.wav", AudioPlayMode.Background);
				this.PictureBox1.Image = Resources.deadgif;
			}
			if (Operators.ConditionalCompareObjectEqual(this.s3, 847, false))
			{
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Boom.wav", AudioPlayMode.Background);
				this.PictureBox1.Image = Resources.wellgif;
			}
			if (Operators.ConditionalCompareObjectEqual(this.s3, 798, false))
			{
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Boom.wav", AudioPlayMode.Background);
				this.PictureBox1.Image = Resources.begif;
			}
			if (Operators.ConditionalCompareObjectEqual(this.s3, 741, false))
			{
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Boom.wav", AudioPlayMode.Background);
				this.PictureBox1.Image = Resources.togethergif;
			}
			if (Operators.ConditionalCompareObjectEqual(this.s3, 640, false))
			{
				this.PictureBox1.Visible = false;
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\MessageFromHell.wav", AudioPlayMode.Background);
			}
			if (Operators.ConditionalCompareObjectEqual(this.s3, 440, false))
			{
				this.Timer3.Stop();
				this.s3 = 1000;
				MyProject.Computer.Audio.Stop();
				base.TransparencyKey = Color.Black;
				Cursor.Show();
				MyProject.Forms.Game3.Show();
				MyProject.Forms.Game3.GameTimer3.Start();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Game5Music.wav", AudioPlayMode.Background);
				base.Hide();
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00003F28 File Offset: 0x00002128
		private void Timer2_Tick(object sender, EventArgs e)
		{
			this.s2 = Operators.SubtractObject(this.s2, 1);
			if (Operators.ConditionalCompareObjectEqual(this.s2, 950, false))
			{
				Cursor.Hide();
				this.PictureBox1.Visible = true;
				base.TransparencyKey = default(Color);
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Boom.wav", AudioPlayMode.Background);
			}
			if (Operators.ConditionalCompareObjectEqual(this.s2, 849, false))
			{
				this.PictureBox1.Visible = false;
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\MessageFromHell.wav", AudioPlayMode.Background);
			}
			if (Operators.ConditionalCompareObjectEqual(this.s2, 649, false))
			{
				this.Timer2.Stop();
				this.s2 = 1000;
				MyProject.Computer.Audio.Stop();
				base.TransparencyKey = Color.Black;
				Cursor.Show();
				MyProject.Forms.Game2.Show();
				MyProject.Forms.Game2.GameTimer2.Start();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Game2Music.wav", AudioPlayMode.Background);
				base.Hide();
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00004088 File Offset: 0x00002288
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.s1 = Operators.SubtractObject(this.s1, 1);
			if (Operators.ConditionalCompareObjectEqual(this.s1, 950, false))
			{
				Cursor.Hide();
				this.PictureBox1.Visible = true;
				base.TransparencyKey = default(Color);
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Boom.wav", AudioPlayMode.Background);
			}
			if (Operators.ConditionalCompareObjectEqual(this.s1, 898, false))
			{
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Boom.wav", AudioPlayMode.Background);
				this.PictureBox1.Image = Resources.wasgif;
			}
			if (Operators.ConditionalCompareObjectEqual(this.s1, 847, false))
			{
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Boom.wav", AudioPlayMode.Background);
				this.PictureBox1.Image = Resources.cominggif;
			}
			if (Operators.ConditionalCompareObjectEqual(this.s1, 798, false))
			{
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Boom.wav", AudioPlayMode.Background);
				this.PictureBox1.Image = Resources.forgif;
			}
			if (Operators.ConditionalCompareObjectEqual(this.s1, 741, false))
			{
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Boom.wav", AudioPlayMode.Background);
				this.PictureBox1.Image = Resources.yougif;
			}
			if (Operators.ConditionalCompareObjectEqual(this.s1, 640, false))
			{
				this.PictureBox1.Visible = false;
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\MessageFromHell.wav", AudioPlayMode.Background);
			}
			if (Operators.ConditionalCompareObjectEqual(this.s1, 440, false))
			{
				this.Timer1.Stop();
				this.s1 = 1000;
				MyProject.Computer.Audio.Stop();
				base.TransparencyKey = Color.Black;
				Cursor.Show();
				MyProject.Forms.Game1.Show();
				MyProject.Forms.Game1.Timer1.Enabled = false;
				MyProject.Forms.Game1.Timer1.Stop();
				MyProject.Forms.Game1.GameTimer.Start();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Game1Music.wav", AudioPlayMode.Background);
				base.Hide();
			}
		}

		// Token: 0x04000019 RID: 25
		private string appPath;

		// Token: 0x0400001A RID: 26
		private object s3;

		// Token: 0x0400001B RID: 27
		private object s2;

		// Token: 0x0400001C RID: 28
		private object s1;
	}
}
