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
	// Token: 0x02000010 RID: 16
	[DesignerGenerated]
	public partial class Game3 : Form
	{
		// Token: 0x060000BD RID: 189 RVA: 0x000099D4 File Offset: 0x00007BD4
		public Game3()
		{
			base.Load += this.Game3_Load;
			base.FormClosing += this.Game3_FormClosing;
			this.appPath = Application.StartupPath;
			this.gamesec = 120;
			this.deathsec = 500;
			this.musicPath = MyProject.Computer.FileSystem.SpecialDirectories.MyMusic;
			this.canquit = false;
			this.InitializeComponent();
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x00009C4A File Offset: 0x00007E4A
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x00009C54 File Offset: 0x00007E54
		internal virtual global::System.Windows.Forms.Timer GameTimer3
		{
			[CompilerGenerated]
			get
			{
				return this._GameTimer3;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.GameTimer3_Tick);
				global::System.Windows.Forms.Timer timer = this._GameTimer3;
				if (timer != null)
				{
					timer.Tick -= eventHandler;
				}
				this._GameTimer3 = value;
				timer = this._GameTimer3;
				if (timer != null)
				{
					timer.Tick += eventHandler;
				}
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x00009C97 File Offset: 0x00007E97
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x00009CA0 File Offset: 0x00007EA0
		internal virtual global::System.Windows.Forms.Timer ChoiceDeathTimer3
		{
			[CompilerGenerated]
			get
			{
				return this._ChoiceDeathTimer3;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ChoiceDeathTimer3_Tick);
				global::System.Windows.Forms.Timer timer = this._ChoiceDeathTimer3;
				if (timer != null)
				{
					timer.Tick -= eventHandler;
				}
				this._ChoiceDeathTimer3 = value;
				timer = this._ChoiceDeathTimer3;
				if (timer != null)
				{
					timer.Tick += eventHandler;
				}
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00009CE3 File Offset: 0x00007EE3
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x00009CEB File Offset: 0x00007EEB
		internal virtual PictureBox PictureBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00009CF4 File Offset: 0x00007EF4
		private void Game3_Load(object sender, EventArgs e)
		{
			base.Activate();
			base.KeyPreview = true;
			MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Game5Music.wav", AudioPlayMode.Background);
			this.GameTimer3.Start();
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00009D30 File Offset: 0x00007F30
		private void GameTimer3_Tick(object sender, EventArgs e)
		{
			this.gamesec = Operators.SubtractObject(this.gamesec, 1);
			if (Operators.ConditionalCompareObjectEqual(this.gamesec, 119, false))
			{
				try
				{
					if (MyProject.Computer.FileSystem.FileExists(this.musicPath + "\\SAVEYOURSELF.ben"))
					{
						MyProject.Computer.FileSystem.DeleteFile(this.musicPath + "\\SAVEYOURSELF.ben");
						File.WriteAllText(this.musicPath + "\\SAVEYOURSELF.ben", Resources.SAVEYOURSELF);
					}
					else if (!MyProject.Computer.FileSystem.FileExists(this.musicPath + "\\SAVEYOURSELF.ben"))
					{
						File.WriteAllText(this.musicPath + "\\SAVEYOURSELF.ben", Resources.SAVEYOURSELF);
					}
				}
				catch (Exception ex)
				{
				}
			}
			if (Operators.ConditionalCompareObjectEqual(this.gamesec, 110, false) && !MyProject.Computer.FileSystem.FileExists(this.musicPath + "\\SAVEYOURSELF.ben"))
			{
				this.GameTimer3.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\WinSoundEffect3.wav", AudioPlayMode.WaitToComplete);
				MessageBox.Show("WElL, wElL, weLL.", "");
				Thread.Sleep(2000);
				MessageBox.Show("lOOkS liKE yOu sOLvEd evEryThiNg.", "");
				Thread.Sleep(2000);
				MessageBox.Show("P\u034fATH\u0315E\u0328TIC.", "");
				this.canquit = true;
				base.Hide();
				MyProject.Forms.nextFirstGames.Show();
				base.Close();
			}
			if (Operators.ConditionalCompareObjectEqual(this.gamesec, 100, false) && !MyProject.Computer.FileSystem.FileExists(this.musicPath + "\\SAVEYOURSELF.ben"))
			{
				this.GameTimer3.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\WinSoundEffect3.wav", AudioPlayMode.WaitToComplete);
				MessageBox.Show("WElL, wElL, weLL.", "");
				Thread.Sleep(2000);
				MessageBox.Show("lOOkS liKE yOu sOLvEd evEryThiNg.", "");
				Thread.Sleep(2000);
				MessageBox.Show("P\u034fATH\u0315E\u0328TIC.", "");
				this.canquit = true;
				base.Hide();
				MyProject.Forms.nextFirstGames.Show();
				base.Close();
			}
			if (Operators.ConditionalCompareObjectEqual(this.gamesec, 90, false) && !MyProject.Computer.FileSystem.FileExists(this.musicPath + "\\SAVEYOURSELF.ben"))
			{
				this.GameTimer3.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\WinSoundEffect3.wav", AudioPlayMode.WaitToComplete);
				MessageBox.Show("WElL, wElL, weLL.", "");
				Thread.Sleep(2000);
				MessageBox.Show("lOOkS liKE yOu sOLvEd evEryThiNg.", "");
				Thread.Sleep(2000);
				MessageBox.Show("P\u034fATH\u0315E\u0328TIC.", "");
				this.canquit = true;
				base.Hide();
				MyProject.Forms.nextFirstGames.Show();
				base.Close();
			}
			if (Operators.ConditionalCompareObjectEqual(this.gamesec, 80, false) && !MyProject.Computer.FileSystem.FileExists(this.musicPath + "\\SAVEYOURSELF.ben"))
			{
				this.GameTimer3.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\WinSoundEffect3.wav", AudioPlayMode.WaitToComplete);
				MessageBox.Show("WElL, wElL, weLL.", "");
				Thread.Sleep(2000);
				MessageBox.Show("lOOkS liKE yOu sOLvEd evEryThiNg.", "");
				Thread.Sleep(2000);
				MessageBox.Show("P\u034fATH\u0315E\u0328TIC.", "");
				this.canquit = true;
				base.Hide();
				MyProject.Forms.nextFirstGames.Show();
				base.Close();
			}
			if (Operators.ConditionalCompareObjectEqual(this.gamesec, 70, false) && !MyProject.Computer.FileSystem.FileExists(this.musicPath + "\\SAVEYOURSELF.ben"))
			{
				this.GameTimer3.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\WinSoundEffect3.wav", AudioPlayMode.WaitToComplete);
				MessageBox.Show("WElL, wElL, weLL.", "");
				Thread.Sleep(2000);
				MessageBox.Show("lOOkS liKE yOu sOLvEd evEryThiNg.", "");
				Thread.Sleep(2000);
				MessageBox.Show("P\u034fATH\u0315E\u0328TIC.", "");
				this.canquit = true;
				base.Hide();
				MyProject.Forms.nextFirstGames.Show();
				base.Close();
			}
			if (Operators.ConditionalCompareObjectEqual(this.gamesec, 60, false) && !MyProject.Computer.FileSystem.FileExists(this.musicPath + "\\SAVEYOURSELF.ben"))
			{
				this.GameTimer3.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\WinSoundEffect3.wav", AudioPlayMode.WaitToComplete);
				MessageBox.Show("WElL, wElL, weLL.", "");
				Thread.Sleep(2000);
				MessageBox.Show("lOOkS liKE yOu sOLvEd evEryThiNg.", "");
				Thread.Sleep(2000);
				MessageBox.Show("P\u034fATH\u0315E\u0328TIC.", "");
				this.canquit = true;
				base.Hide();
				MyProject.Forms.nextFirstGames.Show();
				base.Close();
			}
			if (Operators.ConditionalCompareObjectEqual(this.gamesec, 50, false) && !MyProject.Computer.FileSystem.FileExists(this.musicPath + "\\SAVEYOURSELF.ben"))
			{
				this.GameTimer3.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\WinSoundEffect3.wav", AudioPlayMode.WaitToComplete);
				MessageBox.Show("WElL, wElL, weLL.", "");
				Thread.Sleep(2000);
				MessageBox.Show("lOOkS liKE yOu sOLvEd evEryThiNg.", "");
				Thread.Sleep(2000);
				MessageBox.Show("P\u034fATH\u0315E\u0328TIC.", "");
				this.canquit = true;
				base.Hide();
				MyProject.Forms.nextFirstGames.Show();
				base.Close();
			}
			if (Operators.ConditionalCompareObjectEqual(this.gamesec, 40, false) && !MyProject.Computer.FileSystem.FileExists(this.musicPath + "\\SAVEYOURSELF.ben"))
			{
				this.GameTimer3.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\WinSoundEffect3.wav", AudioPlayMode.WaitToComplete);
				MessageBox.Show("WElL, wElL, weLL.", "");
				Thread.Sleep(2000);
				MessageBox.Show("lOOkS liKE yOu sOLvEd evEryThiNg.", "");
				Thread.Sleep(2000);
				MessageBox.Show("P\u034fATH\u0315E\u0328TIC.", "");
				this.canquit = true;
				base.Hide();
				MyProject.Forms.nextFirstGames.Show();
				base.Close();
			}
			if (Operators.ConditionalCompareObjectEqual(this.gamesec, 30, false) && !MyProject.Computer.FileSystem.FileExists(this.musicPath + "\\SAVEYOURSELF.ben"))
			{
				this.GameTimer3.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\WinSoundEffect3.wav", AudioPlayMode.WaitToComplete);
				MessageBox.Show("WElL, wElL, weLL.", "");
				Thread.Sleep(2000);
				MessageBox.Show("lOOkS liKE yOu sOLvEd evEryThiNg.", "");
				Thread.Sleep(2000);
				MessageBox.Show("P\u034fATH\u0315E\u0328TIC.", "");
				this.canquit = true;
				base.Hide();
				MyProject.Forms.nextFirstGames.Show();
				base.Close();
			}
			if (Operators.ConditionalCompareObjectEqual(this.gamesec, 20, false) && !MyProject.Computer.FileSystem.FileExists(this.musicPath + "\\SAVEYOURSELF.ben"))
			{
				this.GameTimer3.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\WinSoundEffect3.wav", AudioPlayMode.WaitToComplete);
				MessageBox.Show("WElL, wElL, weLL.", "");
				Thread.Sleep(2000);
				MessageBox.Show("lOOkS liKE yOu sOLvEd evEryThiNg.", "");
				Thread.Sleep(2000);
				MessageBox.Show("P\u034fATH\u0315E\u0328TIC.", "");
				this.canquit = true;
				base.Hide();
				MyProject.Forms.nextFirstGames.Show();
				base.Close();
			}
			if (Operators.ConditionalCompareObjectEqual(this.gamesec, 10, false) && !MyProject.Computer.FileSystem.FileExists(this.musicPath + "\\SAVEYOURSELF.ben"))
			{
				this.GameTimer3.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\WinSoundEffect3.wav", AudioPlayMode.WaitToComplete);
				MessageBox.Show("WElL, wElL, weLL.", "");
				Thread.Sleep(2000);
				MessageBox.Show("lOOkS liKE yOu sOLvEd evEryThiNg.", "");
				Thread.Sleep(2000);
				MessageBox.Show("P\u034fATH\u0315E\u0328TIC.", "");
				this.canquit = true;
				base.Hide();
				MyProject.Forms.nextFirstGames.Show();
				base.Close();
			}
			if (Operators.ConditionalCompareObjectEqual(this.gamesec, 1, false) && !MyProject.Computer.FileSystem.FileExists(this.musicPath + "\\SAVEYOURSELF.ben"))
			{
				this.GameTimer3.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\WinSoundEffect3.wav", AudioPlayMode.WaitToComplete);
				MessageBox.Show("WElL, wElL, weLL.", "");
				Thread.Sleep(2000);
				MessageBox.Show("lOOkS liKE yOu sOLvEd evEryThiNg.", "");
				Thread.Sleep(2000);
				MessageBox.Show("P\u034fATH\u0315E\u0328TIC.", "");
				this.canquit = true;
				base.Hide();
				MyProject.Forms.nextFirstGames.Show();
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
				this.GameTimer3.Stop();
				Cursor.Show();
				if (MyProject.Computer.FileSystem.FileExists(this.musicPath + "\\SAVEYOURSELF.ben"))
				{
					try
					{
						MyProject.Computer.FileSystem.DeleteFile(this.musicPath + "\\SAVEYOURSELF.ben");
					}
					catch (Exception ex2)
					{
					}
				}
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Hey!.wav", AudioPlayMode.Background);
				base.Activate();
				if (Interaction.MsgBox("Hey ! You were so close.\r\nCome on !", MsgBoxStyle.YesNo, "GA\u035c\u032e\u0347M\u0336\u0347\u0354\u0339\u032a\u035aE\u0353\u032f\u031d\u035a\u0347\u0316 \u033c\u0348O\u0336\u0349\u0320\u0320\u0325V\u0331\u0324\u032b\u0356\u032dE\u0358\u0319\u0356\u0317\u0331\u032dR\u0328\u0329\u031e\u032f\u0325\u0354\u0359") == MsgBoxResult.Yes)
				{
					MyProject.Computer.Audio.Play(this.appPath + "\\assets\\LiveSwipe.wav", AudioPlayMode.Background);
					Thread.Sleep(2000);
					this.gamesec = 120;
					MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Game5Music.wav", AudioPlayMode.Background);
					base.TransparencyKey = Color.Black;
					this.GameTimer3.Start();
					return;
				}
				MessageBox.Show("No ?", "...");
				if (Interaction.MsgBox("You want to stop ?", MsgBoxStyle.YesNo, "FLESRUOYEVAS") == MsgBoxResult.Yes)
				{
					MessageBox.Show("Ahah...");
					this.ChoiceDeathTimer3.Start();
					return;
				}
				MessageBox.Show("Go for it !", "FLESRUOYEVASFLESRUOYEVASFLESRUOYEVAS");
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\LiveSwipe.wav", AudioPlayMode.Background);
				Thread.Sleep(2000);
				this.gamesec = 120;
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Game5Music.wav", AudioPlayMode.Background);
				base.TransparencyKey = Color.Black;
				this.GameTimer3.Start();
			}
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0000AA38 File Offset: 0x00008C38
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void ChoiceDeathTimer3_Tick(object sender, EventArgs e)
		{
			this.deathsec = Operators.SubtractObject(this.deathsec, 1);
			if (Operators.ConditionalCompareObjectEqual(this.deathsec, 485, false))
			{
				this.ChoiceDeathTimer3.Stop();
				MessageBox.Show("yOU caN QUit...");
				this.ChoiceDeathTimer3.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.deathsec, 475, false))
			{
				this.ChoiceDeathTimer3.Stop();
				MessageBox.Show("bUT yOU KnoW,");
				try
				{
					File.WriteAllText(this.appPath + "\\datas\\gamedataDeath1.dat", "diedGame3");
				}
				catch (Exception ex)
				{
				}
				this.PictureBox1.Image = Resources.MOSHED_2018_11_16_0_20_35;
				this.ChoiceDeathTimer3.Start();
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

		// Token: 0x060000C9 RID: 201 RVA: 0x0000B110 File Offset: 0x00009310
		private void Game3_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!this.canquit)
			{
				e.Cancel = true;
			}
		}

		// Token: 0x04000051 RID: 81
		private string appPath;

		// Token: 0x04000052 RID: 82
		private object gamesec;

		// Token: 0x04000053 RID: 83
		private object deathsec;

		// Token: 0x04000054 RID: 84
		private string musicPath;

		// Token: 0x04000055 RID: 85
		private bool canquit;
	}
}
