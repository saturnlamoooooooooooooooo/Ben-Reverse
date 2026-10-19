using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
	// Token: 0x0200000E RID: 14
	[DesignerGenerated]
	public partial class Game1 : Form
	{
		// Token: 0x0600009F RID: 159 RVA: 0x00006578 File Offset: 0x00004778
		public Game1()
		{
			base.Load += this.Game1_Load;
			base.FormClosing += this.Game1_FormClosing;
			this.sec = 100;
			this.gamesec = 120;
			this.deathsec = 500;
			this.appPath = Application.StartupPath;
			this.documentsPath = MyProject.Computer.FileSystem.SpecialDirectories.MyDocuments;
			this.canquit = false;
			this.InitializeComponent();
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x0000681F File Offset: 0x00004A1F
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x00006828 File Offset: 0x00004A28
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

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x0000686B File Offset: 0x00004A6B
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x00006874 File Offset: 0x00004A74
		internal virtual global::System.Windows.Forms.Timer GameTimer
		{
			[CompilerGenerated]
			get
			{
				return this._GameTimer;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.GameTimer_Tick);
				global::System.Windows.Forms.Timer timer = this._GameTimer;
				if (timer != null)
				{
					timer.Tick -= eventHandler;
				}
				this._GameTimer = value;
				timer = this._GameTimer;
				if (timer != null)
				{
					timer.Tick += eventHandler;
				}
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x000068B7 File Offset: 0x00004AB7
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x000068BF File Offset: 0x00004ABF
		internal virtual PictureBox PictureBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x000068C8 File Offset: 0x00004AC8
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x000068D0 File Offset: 0x00004AD0
		internal virtual global::System.Windows.Forms.Timer ChoiceDeathTimer
		{
			[CompilerGenerated]
			get
			{
				return this._ChoiceDeathTimer;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ChoiceDeathTimer_Tick);
				global::System.Windows.Forms.Timer timer = this._ChoiceDeathTimer;
				if (timer != null)
				{
					timer.Tick -= eventHandler;
				}
				this._ChoiceDeathTimer = value;
				timer = this._ChoiceDeathTimer;
				if (timer != null)
				{
					timer.Tick += eventHandler;
				}
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00006913 File Offset: 0x00004B13
		private void Game1_Load(object sender, EventArgs e)
		{
			base.Activate();
			base.KeyPreview = true;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00006924 File Offset: 0x00004B24
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.sec = Operators.SubtractObject(this.sec, 1);
			if (Operators.ConditionalCompareObjectEqual(this.sec, 99, false))
			{
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\BenMusic5.wav", AudioPlayMode.BackgroundLoop);
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 97, false))
			{
				this.Timer1.Stop();
				MessageBox.Show("plAY wiTh mE", "");
				this.Timer1.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 95, false))
			{
				this.Timer1.Stop();
				MessageBox.Show("aND i'LL leAVE", "");
				this.Timer1.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 93, false))
			{
				this.Timer1.Stop();
				MessageBox.Show("lisTEN to ME", "");
				this.Timer1.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 91, false))
			{
				this.Timer1.Stop();
				MessageBox.Show("fOCus...", "");
				this.Timer1.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 89, false))
			{
				this.Timer1.Stop();
				MessageBox.Show("i wILL crEATE a sEcREt fILe oN yoUR ComPUTer.", "");
				this.Timer1.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 87, false))
			{
				this.Timer1.Stop();
				MessageBox.Show("yoU haVE TWo mINUteS tO fInD and dElEte iT.", "");
				this.Timer1.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 85, false))
			{
				this.Timer1.Stop();
				MessageBox.Show("reMEMbER to cHEcK eVEryWhEre", "");
				this.Timer1.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 83, false))
			{
				this.Timer1.Stop();
				MessageBox.Show("iF yOU haVeN't fOUnD aNd delEtEd tHE fiLe wItHin tWo minUTes...", "");
				this.Timer1.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 81, false))
			{
				this.Timer1.Stop();
				MessageBox.Show("iT wILL bE OVer.", "");
				base.TransparencyKey = default(Color);
				MyProject.Computer.Audio.Stop();
				this.Timer1.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 80, false))
			{
				this.Timer1.Stop();
				new SoundPlayer(Resources.mega7).Play();
				base.TransparencyKey = Color.Black;
				MessageBox.Show("O\u0336\u0351\u0352\u0305\u0311\u0313\u0300\u0342\u032c\u0330\u031eR\u0336\u0302\u0357\u0314\u030e\u030a\u030a\u033f\u035b\u030d\u034a\u0307\u0315\u030d\u030f\u0317\u0359\u0328\u0320\u031f\u032b\u0325\u0329 \u0334\u0344\u0351\u0346\u0317\u0331\u0345\u033c\u0331 \u0334\u0313\u0340\u034c\u0310\u0358\u0309\u0311\u030e\u033f\u034c\u0306\u030d\u0314\u0320\u0326\u0320\u031c\u031d\u0318\u0359\u0324\u0339\u0318\u0359 \u0334\u0309\u0306\u0360\u0304\u0343\u0351\u033f\u0300\u0308\u0310\u031b\u035b\u0355\u033a\u031e\u0345\u035a\u032a \u0335\u0305\u0304\u030b\u0305\u0331\u032d\u031f\u0356\u035a\u0348\u0330\u0354\u0349\u0330\u0348\u035cN\u0334\u0358\u0315\u030c\u0341\u0350\u035d\u0340\u0302\u0304\u035d\u0344\u0330\u0326\u0325\u0317\u0355\u031c\u0349\u032c\u032b\u032f\u034dO\u0338\u0304\u0346\u0344\u0344\u0301\u0351\u0325\u0318\u0317\u034e\u0339\u032d\u031e\u0331\u0349\u0318\u0332\u0329\u032d\u0322T\u0335\u031a\u0301\u030f\u0343\u0308\u0343\u0350\u0328\u032c\u0328", "");
				this.Timer1.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 79, false))
			{
				this.Timer1.Stop();
				MessageBox.Show("LET\u0489 \u0360 \u0358 T\u0322HE\u035e \u035d \u0337S\u0361H\u0360OW\u035c \u0361 \u0360BE\u035eG\u0328I\u031bN \u0334 \u035e !\u031b");
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Game1Music.wav", AudioPlayMode.Background);
				this.GameTimer.Start();
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00006C5C File Offset: 0x00004E5C
		private void GameTimer_Tick(object sender, EventArgs e)
		{
			this.gamesec = Operators.SubtractObject(this.gamesec, 1);
			if (Operators.ConditionalCompareObjectEqual(this.gamesec, 119, false))
			{
				try
				{
					if (MyProject.Computer.FileSystem.FileExists(this.documentsPath + "\\DROWNED.ben"))
					{
						MyProject.Computer.FileSystem.DeleteFile(this.documentsPath + "\\DROWNED.ben");
						File.WriteAllText(this.documentsPath + "\\DROWNED.ben", Resources.DROWNED);
					}
					else if (!MyProject.Computer.FileSystem.FileExists(this.documentsPath + "\\DROWNED.ben"))
					{
						File.WriteAllText(this.documentsPath + "\\DROWNED.ben", Resources.DROWNED);
					}
				}
				catch (Exception ex)
				{
				}
			}
			if (Operators.ConditionalCompareObjectEqual(this.gamesec, 110, false) && !MyProject.Computer.FileSystem.FileExists(this.documentsPath + "\\DROWNED.ben"))
			{
				this.GameTimer.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\WinSoundEffect1.wav", AudioPlayMode.WaitToComplete);
				MessageBox.Show("goOD.", "");
				Thread.Sleep(2000);
				MessageBox.Show("vERy gOOd...", "");
				Thread.Sleep(2000);
				MessageBox.Show("bUT iT'S nOt OveR yET.", "");
				MessageBox.Show("theRE'S anoTHER fILE.\r\ngOOD LucK.", "");
				this.canquit = true;
				base.Hide();
				MyProject.Forms.Game2.Show();
				base.Close();
			}
			if (Operators.ConditionalCompareObjectEqual(this.gamesec, 100, false) && !MyProject.Computer.FileSystem.FileExists(this.documentsPath + "\\DROWNED.ben"))
			{
				this.GameTimer.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\WinSoundEffect1.wav", AudioPlayMode.WaitToComplete);
				MessageBox.Show("goOD.", "");
				Thread.Sleep(2000);
				MessageBox.Show("vERy gOOd...", "");
				Thread.Sleep(2000);
				MessageBox.Show("bUT iT'S nOt OveR yET.", "");
				MessageBox.Show("theRE'S anoTHER fILE.\r\ngOOD LucK.", "");
				this.canquit = true;
				base.Hide();
				MyProject.Forms.Game2.Show();
				base.Close();
			}
			if (Operators.ConditionalCompareObjectEqual(this.gamesec, 90, false) && !MyProject.Computer.FileSystem.FileExists(this.documentsPath + "\\DROWNED.ben"))
			{
				this.GameTimer.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\WinSoundEffect1.wav", AudioPlayMode.WaitToComplete);
				MessageBox.Show("goOD.", "");
				Thread.Sleep(2000);
				MessageBox.Show("vERy gOOd...", "");
				Thread.Sleep(2000);
				MessageBox.Show("bUT iT'S nOt OveR yET.", "");
				MessageBox.Show("theRE'S anoTHER fILE.\r\ngOOD LucK.", "");
				this.canquit = true;
				base.Hide();
				MyProject.Forms.Game2.Show();
				base.Close();
			}
			if (Operators.ConditionalCompareObjectEqual(this.gamesec, 80, false) && !MyProject.Computer.FileSystem.FileExists(this.documentsPath + "\\DROWNED.ben"))
			{
				this.GameTimer.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\WinSoundEffect1.wav", AudioPlayMode.WaitToComplete);
				MessageBox.Show("goOD.", "");
				Thread.Sleep(2000);
				MessageBox.Show("vERy gOOd...", "");
				Thread.Sleep(2000);
				MessageBox.Show("bUT iT'S nOt OveR yET.", "");
				MessageBox.Show("theRE'S anoTHER fILE.\r\ngOOD LucK.", "");
				this.canquit = true;
				base.Hide();
				MyProject.Forms.Game2.Show();
				base.Close();
			}
			if (Operators.ConditionalCompareObjectEqual(this.gamesec, 70, false) && !MyProject.Computer.FileSystem.FileExists(this.documentsPath + "\\DROWNED.ben"))
			{
				this.GameTimer.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\WinSoundEffect1.wav", AudioPlayMode.WaitToComplete);
				MessageBox.Show("goOD.", "");
				Thread.Sleep(2000);
				MessageBox.Show("vERy gOOd...", "");
				Thread.Sleep(2000);
				MessageBox.Show("bUT iT'S nOt OveR yET.", "");
				MessageBox.Show("theRE'S anoTHER fILE.\r\ngOOD LucK.", "");
				this.canquit = true;
				base.Hide();
				MyProject.Forms.Game2.Show();
				base.Close();
			}
			if (Operators.ConditionalCompareObjectEqual(this.gamesec, 60, false) && !MyProject.Computer.FileSystem.FileExists(this.documentsPath + "\\DROWNED.ben"))
			{
				this.GameTimer.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\WinSoundEffect1.wav", AudioPlayMode.WaitToComplete);
				MessageBox.Show("goOD.", "");
				Thread.Sleep(2000);
				MessageBox.Show("vERy gOOd...", "");
				Thread.Sleep(2000);
				MessageBox.Show("bUT iT'S nOt OveR yET.", "");
				MessageBox.Show("theRE'S anoTHER fILE.\r\ngOOD LucK.", "");
				this.canquit = true;
				base.Hide();
				MyProject.Forms.Game2.Show();
				base.Close();
			}
			if (Operators.ConditionalCompareObjectEqual(this.gamesec, 50, false) && !MyProject.Computer.FileSystem.FileExists(this.documentsPath + "\\DROWNED.ben"))
			{
				this.GameTimer.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\WinSoundEffect1.wav", AudioPlayMode.WaitToComplete);
				MessageBox.Show("goOD.", "");
				Thread.Sleep(2000);
				MessageBox.Show("vERy gOOd...", "");
				Thread.Sleep(2000);
				MessageBox.Show("bUT iT'S nOt OveR yET.", "");
				MessageBox.Show("theRE'S anoTHER fILE.\r\ngOOD LucK.", "");
				this.canquit = true;
				base.Hide();
				MyProject.Forms.Game2.Show();
				base.Close();
			}
			if (Operators.ConditionalCompareObjectEqual(this.gamesec, 40, false) && !MyProject.Computer.FileSystem.FileExists(this.documentsPath + "\\DROWNED.ben"))
			{
				this.GameTimer.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\WinSoundEffect1.wav", AudioPlayMode.WaitToComplete);
				MessageBox.Show("goOD.", "");
				Thread.Sleep(2000);
				MessageBox.Show("vERy gOOd...", "");
				Thread.Sleep(2000);
				MessageBox.Show("bUT iT'S nOt OveR yET.", "");
				MessageBox.Show("theRE'S anoTHER fILE.\r\ngOOD LucK.", "");
				this.canquit = true;
				base.Hide();
				MyProject.Forms.Game2.Show();
				base.Close();
			}
			if (Operators.ConditionalCompareObjectEqual(this.gamesec, 30, false) && !MyProject.Computer.FileSystem.FileExists(this.documentsPath + "\\DROWNED.ben"))
			{
				this.GameTimer.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\WinSoundEffect1.wav", AudioPlayMode.WaitToComplete);
				MessageBox.Show("goOD.", "");
				Thread.Sleep(2000);
				MessageBox.Show("vERy gOOd...", "");
				Thread.Sleep(2000);
				MessageBox.Show("bUT iT'S nOt OveR yET.", "");
				MessageBox.Show("theRE'S anoTHER fILE.\r\ngOOD LucK.", "");
				this.canquit = true;
				base.Hide();
				MyProject.Forms.Game2.Show();
				base.Close();
			}
			if (Operators.ConditionalCompareObjectEqual(this.gamesec, 20, false) && !MyProject.Computer.FileSystem.FileExists(this.documentsPath + "\\DROWNED.ben"))
			{
				this.GameTimer.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\WinSoundEffect1.wav", AudioPlayMode.WaitToComplete);
				MessageBox.Show("goOD.", "");
				Thread.Sleep(2000);
				MessageBox.Show("vERy gOOd...", "");
				Thread.Sleep(2000);
				MessageBox.Show("bUT iT'S nOt OveR yET.", "");
				MessageBox.Show("theRE'S anoTHER fILE.\r\ngOOD LucK.", "");
				this.canquit = true;
				base.Hide();
				MyProject.Forms.Game2.Show();
				base.Close();
			}
			if (Operators.ConditionalCompareObjectEqual(this.gamesec, 10, false) && !MyProject.Computer.FileSystem.FileExists(this.documentsPath + "\\DROWNED.ben"))
			{
				this.GameTimer.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\WinSoundEffect1.wav", AudioPlayMode.WaitToComplete);
				MessageBox.Show("goOD.", "");
				Thread.Sleep(2000);
				MessageBox.Show("vERy gOOd...", "");
				Thread.Sleep(2000);
				MessageBox.Show("bUT iT'S nOt OveR yET.", "");
				MessageBox.Show("theRE'S anoTHER fILE.\r\ngOOD LucK.", "");
				this.canquit = true;
				base.Hide();
				MyProject.Forms.Game2.Show();
				base.Close();
			}
			if (Operators.ConditionalCompareObjectEqual(this.gamesec, 1, false) && !MyProject.Computer.FileSystem.FileExists(this.documentsPath + "\\DROWNED.ben"))
			{
				this.GameTimer.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\WinSoundEffect1.wav", AudioPlayMode.WaitToComplete);
				MessageBox.Show("goOD.", "");
				Thread.Sleep(2000);
				MessageBox.Show("vERy gOOd...", "");
				Thread.Sleep(2000);
				MessageBox.Show("bUT iT'S nOt OveR yET.", "");
				MessageBox.Show("theRE'S anoTHER fILE.\r\ngOOD LucK.", "");
				this.canquit = true;
				base.Hide();
				MyProject.Forms.Game2.Show();
				base.Close();
			}
			if (Operators.ConditionalCompareObjectEqual(this.gamesec, 0, false))
			{
				base.TransparencyKey = default(Color);
				Cursor.Hide();
				this.PictureBox1.Image = Resources.MOSHED_2018_11_16_0_20_9;
			}
			if (Operators.ConditionalCompareObjectEqual(this.gamesec, -1, false))
			{
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Game123Screamer.wav", AudioPlayMode.Background);
				this.PictureBox1.Visible = true;
			}
			if (Operators.ConditionalCompareObjectEqual(this.gamesec, -2, false))
			{
				this.PictureBox1.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.gamesec, -5, false))
			{
				this.GameTimer.Stop();
				Cursor.Show();
				if (MyProject.Computer.FileSystem.FileExists(this.documentsPath + "\\DROWNED.ben"))
				{
					try
					{
						MyProject.Computer.FileSystem.DeleteFile(this.documentsPath + "\\DROWNED.ben");
					}
					catch (Exception ex2)
					{
					}
				}
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Hey!.wav", AudioPlayMode.Background);
				base.Activate();
				if (Interaction.MsgBox("Hey ! Don't give up.\r\nYou have to live !", MsgBoxStyle.YesNo, "GA\u035c\u032e\u0347M\u0336\u0347\u0354\u0339\u032a\u035aE\u0353\u032f\u031d\u035a\u0347\u0316 \u033c\u0348O\u0336\u0349\u0320\u0320\u0325V\u0331\u0324\u032b\u0356\u032dE\u0358\u0319\u0356\u0317\u0331\u032dR\u0328\u0329\u031e\u032f\u0325\u0354\u0359") == MsgBoxResult.Yes)
				{
					MyProject.Computer.Audio.Play(this.appPath + "\\assets\\LiveSwipe.wav", AudioPlayMode.Background);
					Thread.Sleep(2000);
					this.gamesec = 120;
					MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Game1Music.wav", AudioPlayMode.Background);
					base.TransparencyKey = Color.Black;
					this.GameTimer.Start();
					return;
				}
				MessageBox.Show("No ?", "...");
				if (Interaction.MsgBox("Are you giving up already ?", MsgBoxStyle.YesNo, "FLESRUOYEVAS") == MsgBoxResult.Yes)
				{
					MessageBox.Show("It's sad...");
					this.ChoiceDeathTimer.Start();
					return;
				}
				MessageBox.Show("Then fight !", "FLESRUOYEVASFLESRUOYEVASFLESRUOYEVAS");
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\LiveSwipe.wav", AudioPlayMode.Background);
				Thread.Sleep(2000);
				this.gamesec = 120;
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Game1Music.wav", AudioPlayMode.Background);
				base.TransparencyKey = Color.Black;
				this.GameTimer.Start();
			}
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00007A24 File Offset: 0x00005C24
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void ChoiceDeathTimer_Tick(object sender, EventArgs e)
		{
			this.deathsec = Operators.SubtractObject(this.deathsec, 1);
			if (Operators.ConditionalCompareObjectEqual(this.deathsec, 485, false))
			{
				this.ChoiceDeathTimer.Stop();
				MessageBox.Show("i hAD a lOT of fUN . . .");
				this.ChoiceDeathTimer.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.deathsec, 475, false))
			{
				this.ChoiceDeathTimer.Stop();
				MessageBox.Show("bUT doN'T ForGET ;");
				try
				{
					File.WriteAllText(this.appPath + "\\datas\\gamedataDeath1.dat", "diedGame1");
				}
				catch (Exception ex)
				{
				}
				this.PictureBox1.Image = Resources.MOSHED_2018_11_16_0_20_35;
				this.ChoiceDeathTimer.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.deathsec, 468, false))
			{
				new SoundPlayer(Resources.mega4).Play();
				Cursor.Hide();
				this.PictureBox1.Image = Image.FromFile(this.appPath + "\\assets\\gifs\\YOUARESTUCKED.gif");
				this.PictureBox1.Visible = true;
			}
			if (Operators.ConditionalCompareObjectEqual(this.deathsec, 460, false))
			{
				Cursor.Show();
				new SoundPlayer(Resources.mega4).Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\YOURDEATH.wav", AudioPlayMode.Background);
				this.PictureBox1.Image = Resources.MOSHED_2018_11_16_0_20_35;
				Cursor.Position = new Point(50, 78);
				SendKeys.Send("{CAPSLOCK}");
			}
			if (Operators.ConditionalCompareObjectEqual(this.deathsec, 459, false))
			{
				Cursor.Position = new Point(123, -12);
				SendKeys.Send("{NUMLOCK}");
			}
			if (Operators.ConditionalCompareObjectEqual(this.deathsec, 458, false))
			{
				Cursor.Position = new Point(47, -98);
				SendKeys.Send("{SCROLLLOCK}");
			}
			if (Operators.ConditionalCompareObjectEqual(this.deathsec, 457, false))
			{
				Cursor.Position = new Point(2, 169);
				SendKeys.Send("{CAPSLOCK}");
			}
			if (Operators.ConditionalCompareObjectEqual(this.deathsec, 456, false))
			{
				Cursor.Position = new Point(420, 69);
				SendKeys.Send("{NUMLOCK}");
			}
			if (Operators.ConditionalCompareObjectEqual(this.deathsec, 455, false))
			{
				this.PictureBox1.Image = Resources.MOSHED_2018_11_16_0_22_24;
				Cursor.Position = new Point(77, -78);
				SendKeys.Send("{SCROLLLOCK}");
			}
			if (Operators.ConditionalCompareObjectEqual(this.deathsec, 454, false))
			{
				Cursor.Position = new Point(-58, 148);
				SendKeys.Send("{CAPSLOCK}");
			}
			if (Operators.ConditionalCompareObjectEqual(this.deathsec, 453, false))
			{
				Cursor.Position = new Point(-187, 254);
				SendKeys.Send("{NUMLOCK}");
			}
			if (Operators.ConditionalCompareObjectEqual(this.deathsec, 452, false))
			{
				Cursor.Position = new Point(152, 245);
				SendKeys.Send("{SCROLLLOCK}");
			}
			if (Operators.ConditionalCompareObjectEqual(this.deathsec, 451, false))
			{
				Cursor.Position = new Point(-43, -98);
				SendKeys.Send("{CAPSLOCK}");
			}
			if (Operators.ConditionalCompareObjectEqual(this.deathsec, 450, false))
			{
				this.PictureBox1.Image = Resources.MOSHED_2018_11_16_0_20_9;
				Cursor.Position = new Point(50, 78);
				SendKeys.Send("{NUMLOCK}");
			}
			if (Operators.ConditionalCompareObjectEqual(this.deathsec, 449, false))
			{
				Cursor.Position = new Point(854, 718);
				SendKeys.Send("{SCROLLLOCK}");
			}
			if (Operators.ConditionalCompareObjectEqual(this.deathsec, 448, false))
			{
				Cursor.Position = new Point(540, -478);
				SendKeys.Send("{CAPSLOCK}");
			}
			if (Operators.ConditionalCompareObjectEqual(this.deathsec, 447, false))
			{
				Cursor.Position = new Point(840, -82);
				SendKeys.Send("{NUMLOCK}");
			}
			if (Operators.ConditionalCompareObjectEqual(this.deathsec, 446, false))
			{
				Cursor.Position = new Point(-830, -220);
				SendKeys.Send("{SCROLLLOCK}");
			}
			if (Operators.ConditionalCompareObjectEqual(this.deathsec, 445, false))
			{
				this.PictureBox1.Image = Resources.MOSHED_2018_11_16_0_18_8;
				Cursor.Position = new Point(-187, 254);
				SendKeys.Send("{CAPSLOCK}");
			}
			if (Operators.ConditionalCompareObjectEqual(this.deathsec, 444, false))
			{
				Cursor.Position = new Point(50, 78);
				SendKeys.Send("{NUMLOCK}");
			}
			if (Operators.ConditionalCompareObjectEqual(this.deathsec, 443, false))
			{
				Cursor.Position = new Point(254, 748);
				SendKeys.Send("{SCROLLLOCK}");
			}
			if (Operators.ConditionalCompareObjectEqual(this.deathsec, 442, false))
			{
				Cursor.Position = new Point(398, 487);
				SendKeys.Send("{CAPSLOCK}");
			}
			if (Operators.ConditionalCompareObjectEqual(this.deathsec, 441, false))
			{
				Cursor.Position = new Point(666, -666);
				SendKeys.Send("{NUMLOCK}");
			}
			if (Operators.ConditionalCompareObjectEqual(this.deathsec, 440, false))
			{
				this.PictureBox1.Image = Resources.MOSHED_2018_11_16_0_18_57;
				Cursor.Position = new Point(-666, 666);
				SendKeys.Send("{SCROLLLOCK}");
			}
			if (Operators.ConditionalCompareObjectEqual(this.deathsec, 439, false))
			{
				Cursor.Position = new Point(623, -421);
				SendKeys.Send("{CAPSLOCK}");
			}
			if (Operators.ConditionalCompareObjectEqual(this.deathsec, 438, false))
			{
				Cursor.Position = new Point(20, 65);
				SendKeys.Send("{NUMLOCK}");
			}
			if (Operators.ConditionalCompareObjectEqual(this.deathsec, 437, false))
			{
				Cursor.Position = new Point(-91, 21);
				SendKeys.Send("{SCROLLLOCK}");
			}
			if (Operators.ConditionalCompareObjectEqual(this.deathsec, 436, false))
			{
				Cursor.Position = new Point(495, -128);
				SendKeys.Send("{CAPSLOCK}");
			}
			if (Operators.ConditionalCompareObjectEqual(this.deathsec, 435, false))
			{
				ProjectData.EndApp();
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x000080FC File Offset: 0x000062FC
		private void Game1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!this.canquit)
			{
				e.Cancel = true;
			}
		}

		// Token: 0x0400003E RID: 62
		private object sec;

		// Token: 0x0400003F RID: 63
		private object gamesec;

		// Token: 0x04000040 RID: 64
		private object deathsec;

		// Token: 0x04000041 RID: 65
		private string appPath;

		// Token: 0x04000042 RID: 66
		private string documentsPath;

		// Token: 0x04000043 RID: 67
		private bool canquit;
	}
}
