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
	// Token: 0x0200000F RID: 15
	[DesignerGenerated]
	public partial class Game2 : Form
	{
		// Token: 0x060000AF RID: 175 RVA: 0x00008110 File Offset: 0x00006310
		public Game2()
		{
			base.Load += this.Game2_Load;
			base.FormClosing += this.Game2_FormClosing;
			this.canquit = false;
			this.appPath = Application.StartupPath;
			this.gamesec = 120;
			this.deathsec = 500;
			this.desktopPath = MyProject.Computer.FileSystem.SpecialDirectories.Desktop;
			this.InitializeComponent();
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x00008386 File Offset: 0x00006586
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x00008390 File Offset: 0x00006590
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

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x000083D3 File Offset: 0x000065D3
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x000083DC File Offset: 0x000065DC
		internal virtual global::System.Windows.Forms.Timer GameTimer2
		{
			[CompilerGenerated]
			get
			{
				return this._GameTimer2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.GameTimer2_Tick);
				global::System.Windows.Forms.Timer timer = this._GameTimer2;
				if (timer != null)
				{
					timer.Tick -= eventHandler;
				}
				this._GameTimer2 = value;
				timer = this._GameTimer2;
				if (timer != null)
				{
					timer.Tick += eventHandler;
				}
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x0000841F File Offset: 0x0000661F
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x00008428 File Offset: 0x00006628
		internal virtual global::System.Windows.Forms.Timer ChoiceDeathTimer2
		{
			[CompilerGenerated]
			get
			{
				return this._ChoiceDeathTimer2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ChoiceDeathTimer2_Tick);
				global::System.Windows.Forms.Timer timer = this._ChoiceDeathTimer2;
				if (timer != null)
				{
					timer.Tick -= eventHandler;
				}
				this._ChoiceDeathTimer2 = value;
				timer = this._ChoiceDeathTimer2;
				if (timer != null)
				{
					timer.Tick += eventHandler;
				}
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000846B File Offset: 0x0000666B
		private void Game2_Load(object sender, EventArgs e)
		{
			base.Activate();
			base.KeyPreview = true;
			MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Game2Music.wav", AudioPlayMode.Background);
			this.GameTimer2.Start();
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000084A8 File Offset: 0x000066A8
		private void GameTimer2_Tick(object sender, EventArgs e)
		{
			this.gamesec = Operators.SubtractObject(this.gamesec, 1);
			if (Operators.ConditionalCompareObjectEqual(this.gamesec, 119, false))
			{
				try
				{
					if (MyProject.Computer.FileSystem.FileExists(this.desktopPath + "\\MAJORAS.ben"))
					{
						MyProject.Computer.FileSystem.DeleteFile(this.desktopPath + "\\MAJORAS.ben");
						File.WriteAllText(this.desktopPath + "\\MAJORAS.ben", Resources.MAJORAS);
					}
					else if (!MyProject.Computer.FileSystem.FileExists(this.desktopPath + "\\MAJORAS.ben"))
					{
						File.WriteAllText(this.desktopPath + "\\MAJORAS.ben", Resources.MAJORAS);
					}
				}
				catch (Exception ex)
				{
				}
			}
			if (Operators.ConditionalCompareObjectEqual(this.gamesec, 110, false) && !MyProject.Computer.FileSystem.FileExists(this.desktopPath + "\\MAJORAS.ben"))
			{
				this.GameTimer2.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\WinSoundEffect2.wav", AudioPlayMode.WaitToComplete);
				MessageBox.Show("thAt wAs eaSY.", "");
				Thread.Sleep(2000);
				MessageBox.Show("evEn, veRY EAsy...", "");
				Thread.Sleep(2000);
				MessageBox.Show("tHIs tIME YOu wiLL BE lUCKleSS.", "");
				Thread.Sleep(1000);
				MessageBox.Show("thERe'S aNOthER fiLE.\r\ngOOd lUCK.", "");
				this.canquit = true;
				base.Hide();
				MyProject.Forms.Game3.Show();
				base.Close();
			}
			if (Operators.ConditionalCompareObjectEqual(this.gamesec, 100, false) && !MyProject.Computer.FileSystem.FileExists(this.desktopPath + "\\MAJORAS.ben"))
			{
				this.GameTimer2.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\WinSoundEffect2.wav", AudioPlayMode.WaitToComplete);
				MessageBox.Show("thAt wAs eaSY.", "");
				Thread.Sleep(2000);
				MessageBox.Show("evEn, veRY EAsy...", "");
				Thread.Sleep(2000);
				MessageBox.Show("tHIs tIME YOu wiLL BE lUCKleSS.", "");
				Thread.Sleep(1000);
				MessageBox.Show("thERe'S aNOthER fiLE.\r\ngOOd lUCK.", "");
				this.canquit = true;
				base.Hide();
				MyProject.Forms.Game3.Show();
				base.Close();
			}
			if (Operators.ConditionalCompareObjectEqual(this.gamesec, 90, false) && !MyProject.Computer.FileSystem.FileExists(this.desktopPath + "\\MAJORAS.ben"))
			{
				this.GameTimer2.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\WinSoundEffect2.wav", AudioPlayMode.WaitToComplete);
				MessageBox.Show("thAt wAs eaSY.", "");
				Thread.Sleep(2000);
				MessageBox.Show("evEn, veRY EAsy...", "");
				Thread.Sleep(2000);
				MessageBox.Show("tHIs tIME YOu wiLL BE lUCKleSS.", "");
				Thread.Sleep(1000);
				MessageBox.Show("thERe'S aNOthER fiLE.\r\ngOOd lUCK.", "");
				this.canquit = true;
				base.Hide();
				MyProject.Forms.Game3.Show();
				base.Close();
			}
			if (Operators.ConditionalCompareObjectEqual(this.gamesec, 80, false) && !MyProject.Computer.FileSystem.FileExists(this.desktopPath + "\\MAJORAS.ben"))
			{
				this.GameTimer2.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\WinSoundEffect2.wav", AudioPlayMode.WaitToComplete);
				MessageBox.Show("thAt wAs eaSY.", "");
				Thread.Sleep(2000);
				MessageBox.Show("evEn, veRY EAsy...", "");
				Thread.Sleep(2000);
				MessageBox.Show("tHIs tIME YOu wiLL BE lUCKleSS.", "");
				Thread.Sleep(1000);
				MessageBox.Show("thERe'S aNOthER fiLE.\r\ngOOd lUCK.", "");
				this.canquit = true;
				base.Hide();
				MyProject.Forms.Game3.Show();
				base.Close();
			}
			if (Operators.ConditionalCompareObjectEqual(this.gamesec, 70, false) && !MyProject.Computer.FileSystem.FileExists(this.desktopPath + "\\MAJORAS.ben"))
			{
				this.GameTimer2.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\WinSoundEffect2.wav", AudioPlayMode.WaitToComplete);
				MessageBox.Show("thAt wAs eaSY.", "");
				Thread.Sleep(2000);
				MessageBox.Show("evEn, veRY EAsy...", "");
				Thread.Sleep(2000);
				MessageBox.Show("tHIs tIME YOu wiLL BE lUCKleSS.", "");
				Thread.Sleep(1000);
				MessageBox.Show("thERe'S aNOthER fiLE.\r\ngOOd lUCK.", "");
				this.canquit = true;
				base.Hide();
				MyProject.Forms.Game3.Show();
				base.Close();
			}
			if (Operators.ConditionalCompareObjectEqual(this.gamesec, 60, false) && !MyProject.Computer.FileSystem.FileExists(this.desktopPath + "\\MAJORAS.ben"))
			{
				this.GameTimer2.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\WinSoundEffect2.wav", AudioPlayMode.WaitToComplete);
				MessageBox.Show("thAt wAs eaSY.", "");
				Thread.Sleep(2000);
				MessageBox.Show("evEn, veRY EAsy...", "");
				Thread.Sleep(2000);
				MessageBox.Show("tHIs tIME YOu wiLL BE lUCKleSS.", "");
				Thread.Sleep(1000);
				MessageBox.Show("thERe'S aNOthER fiLE.\r\ngOOd lUCK.", "");
				this.canquit = true;
				base.Hide();
				MyProject.Forms.Game3.Show();
				base.Close();
			}
			if (Operators.ConditionalCompareObjectEqual(this.gamesec, 50, false) && !MyProject.Computer.FileSystem.FileExists(this.desktopPath + "\\MAJORAS.ben"))
			{
				this.GameTimer2.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\WinSoundEffect2.wav", AudioPlayMode.WaitToComplete);
				MessageBox.Show("thAt wAs eaSY.", "");
				Thread.Sleep(2000);
				MessageBox.Show("evEn, veRY EAsy...", "");
				Thread.Sleep(2000);
				MessageBox.Show("tHIs tIME YOu wiLL BE lUCKleSS.", "");
				Thread.Sleep(1000);
				MessageBox.Show("thERe'S aNOthER fiLE.\r\ngOOd lUCK.", "");
				this.canquit = true;
				base.Hide();
				MyProject.Forms.Game3.Show();
				base.Close();
			}
			if (Operators.ConditionalCompareObjectEqual(this.gamesec, 40, false) && !MyProject.Computer.FileSystem.FileExists(this.desktopPath + "\\MAJORAS.ben"))
			{
				this.GameTimer2.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\WinSoundEffect2.wav", AudioPlayMode.WaitToComplete);
				MessageBox.Show("thAt wAs eaSY.", "");
				Thread.Sleep(2000);
				MessageBox.Show("evEn, veRY EAsy...", "");
				Thread.Sleep(2000);
				MessageBox.Show("tHIs tIME YOu wiLL BE lUCKleSS.", "");
				Thread.Sleep(1000);
				MessageBox.Show("thERe'S aNOthER fiLE.\r\ngOOd lUCK.", "");
				this.canquit = true;
				base.Hide();
				MyProject.Forms.Game3.Show();
				base.Close();
			}
			if (Operators.ConditionalCompareObjectEqual(this.gamesec, 30, false) && !MyProject.Computer.FileSystem.FileExists(this.desktopPath + "\\MAJORAS.ben"))
			{
				this.GameTimer2.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\WinSoundEffect2.wav", AudioPlayMode.WaitToComplete);
				MessageBox.Show("thAt wAs eaSY.", "");
				Thread.Sleep(2000);
				MessageBox.Show("evEn, veRY EAsy...", "");
				Thread.Sleep(2000);
				MessageBox.Show("tHIs tIME YOu wiLL BE lUCKleSS.", "");
				Thread.Sleep(1000);
				MessageBox.Show("thERe'S aNOthER fiLE.\r\ngOOd lUCK.", "");
				this.canquit = true;
				base.Hide();
				MyProject.Forms.Game3.Show();
				base.Close();
			}
			if (Operators.ConditionalCompareObjectEqual(this.gamesec, 20, false) && !MyProject.Computer.FileSystem.FileExists(this.desktopPath + "\\MAJORAS.ben"))
			{
				this.GameTimer2.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\WinSoundEffect2.wav", AudioPlayMode.WaitToComplete);
				MessageBox.Show("thAt wAs eaSY.", "");
				Thread.Sleep(2000);
				MessageBox.Show("evEn, veRY EAsy...", "");
				Thread.Sleep(2000);
				MessageBox.Show("tHIs tIME YOu wiLL BE lUCKleSS.", "");
				Thread.Sleep(1000);
				MessageBox.Show("thERe'S aNOthER fiLE.\r\ngOOd lUCK.", "");
				this.canquit = true;
				base.Hide();
				MyProject.Forms.Game3.Show();
				base.Close();
			}
			if (Operators.ConditionalCompareObjectEqual(this.gamesec, 10, false) && !MyProject.Computer.FileSystem.FileExists(this.desktopPath + "\\MAJORAS.ben"))
			{
				this.GameTimer2.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\WinSoundEffect2.wav", AudioPlayMode.WaitToComplete);
				MessageBox.Show("thAt wAs eaSY.", "");
				Thread.Sleep(2000);
				MessageBox.Show("evEn, veRY EAsy...", "");
				Thread.Sleep(2000);
				MessageBox.Show("tHIs tIME YOu wiLL BE lUCKleSS.", "");
				Thread.Sleep(1000);
				MessageBox.Show("thERe'S aNOthER fiLE.\r\ngOOd lUCK.", "");
				this.canquit = true;
				base.Hide();
				MyProject.Forms.Game3.Show();
				base.Close();
			}
			if (Operators.ConditionalCompareObjectEqual(this.gamesec, 1, false) && !MyProject.Computer.FileSystem.FileExists(this.desktopPath + "\\MAJORAS.ben"))
			{
				this.GameTimer2.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\WinSoundEffect2.wav", AudioPlayMode.WaitToComplete);
				MessageBox.Show("thAt wAs eaSY.", "");
				Thread.Sleep(2000);
				MessageBox.Show("evEn, veRY EAsy...", "");
				Thread.Sleep(2000);
				MessageBox.Show("tHIs tIME YOu wiLL BE lUCKleSS.", "");
				Thread.Sleep(1000);
				MessageBox.Show("thERe'S aNOthER fiLE.\r\ngOOd lUCK.", "");
				this.canquit = true;
				base.Hide();
				MyProject.Forms.Game3.Show();
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
				this.GameTimer2.Stop();
				Cursor.Show();
				if (MyProject.Computer.FileSystem.FileExists(this.desktopPath + "\\MAJORAS.ben"))
				{
					try
					{
						MyProject.Computer.FileSystem.DeleteFile(this.desktopPath + "\\MAJORAS.ben");
					}
					catch (Exception ex2)
					{
					}
				}
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Hey!.wav", AudioPlayMode.Background);
				base.Activate();
				if (Interaction.MsgBox("Hey ! What are you doing ?\r\nYou should fight !", MsgBoxStyle.YesNo, "GA\u035c\u032e\u0347M\u0336\u0347\u0354\u0339\u032a\u035aE\u0353\u032f\u031d\u035a\u0347\u0316 \u033c\u0348O\u0336\u0349\u0320\u0320\u0325V\u0331\u0324\u032b\u0356\u032dE\u0358\u0319\u0356\u0317\u0331\u032dR\u0328\u0329\u031e\u032f\u0325\u0354\u0359") == MsgBoxResult.Yes)
				{
					MyProject.Computer.Audio.Play(this.appPath + "\\assets\\LiveSwipe.wav", AudioPlayMode.Background);
					Thread.Sleep(2000);
					this.gamesec = 120;
					MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Game2Music.wav", AudioPlayMode.Background);
					base.TransparencyKey = Color.Black;
					this.GameTimer2.Start();
					return;
				}
				MessageBox.Show("No ?", "...");
				if (Interaction.MsgBox("Are you giving up for real ?", MsgBoxStyle.YesNo, "FLESRUOYEVAS") == MsgBoxResult.Yes)
				{
					MessageBox.Show("I'm disappointed...");
					this.ChoiceDeathTimer2.Start();
					return;
				}
				MessageBox.Show("So go ahead !", "FLESRUOYEVASFLESRUOYEVASFLESRUOYEVAS");
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\LiveSwipe.wav", AudioPlayMode.Background);
				Thread.Sleep(2000);
				this.gamesec = 120;
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Game2Music.wav", AudioPlayMode.Background);
				base.TransparencyKey = Color.Black;
				this.GameTimer2.Start();
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x000092E8 File Offset: 0x000074E8
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void ChoiceDeathTimer2_Tick(object sender, EventArgs e)
		{
			this.deathsec = Operators.SubtractObject(this.deathsec, 1);
			if (Operators.ConditionalCompareObjectEqual(this.deathsec, 485, false))
			{
				this.ChoiceDeathTimer2.Stop();
				MessageBox.Show("tHE viCTorY wAs clOSE . . .");
				this.ChoiceDeathTimer2.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.deathsec, 475, false))
			{
				this.ChoiceDeathTimer2.Stop();
				MessageBox.Show("bUt rEMEMbeR ;");
				try
				{
					File.WriteAllText(this.appPath + "\\datas\\gamedataDeath1.dat", "diedGame2");
				}
				catch (Exception ex)
				{
				}
				this.PictureBox1.Image = Resources.MOSHED_2018_11_16_0_20_35;
				this.ChoiceDeathTimer2.Start();
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

		// Token: 0x060000BB RID: 187 RVA: 0x000099C0 File Offset: 0x00007BC0
		private void Game2_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!this.canquit)
			{
				e.Cancel = true;
			}
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000099D1 File Offset: 0x00007BD1
		private void PictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x04000048 RID: 72
		private bool canquit;

		// Token: 0x04000049 RID: 73
		private string appPath;

		// Token: 0x0400004A RID: 74
		private object gamesec;

		// Token: 0x0400004B RID: 75
		private object deathsec;

		// Token: 0x0400004C RID: 76
		private string desktopPath;
	}
}
