using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using BEN.My;
using BEN.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace BEN
{
	// Token: 0x02000012 RID: 18
	[DesignerGenerated]
	public partial class nextFirstGames : Form
	{
		// Token: 0x060000E8 RID: 232 RVA: 0x0000C358 File Offset: 0x0000A558
		public nextFirstGames()
		{
			base.Load += this.nextFirstGames_Load;
			base.FormClosing += this.nextFirstGames_FormClosing;
			this.sec = 1020;
			this.sec2 = 50;
			this.appPath = Application.StartupPath;
			this.canquit = false;
			this.InitializeComponent();
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060000EB RID: 235 RVA: 0x0000C5B8 File Offset: 0x0000A7B8
		// (set) Token: 0x060000EC RID: 236 RVA: 0x0000C5C0 File Offset: 0x0000A7C0
		internal virtual PictureBox PictureBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060000ED RID: 237 RVA: 0x0000C5C9 File Offset: 0x0000A7C9
		// (set) Token: 0x060000EE RID: 238 RVA: 0x0000C5D4 File Offset: 0x0000A7D4
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

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060000EF RID: 239 RVA: 0x0000C617 File Offset: 0x0000A817
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x0000C620 File Offset: 0x0000A820
		internal virtual Timer Timer2
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
				Timer timer = this._Timer2;
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

		// Token: 0x060000F1 RID: 241 RVA: 0x0000C664 File Offset: 0x0000A864
		private void nextFirstGames_Load(object sender, EventArgs e)
		{
			base.Activate();
			try
			{
				File.WriteAllText(this.appPath + "\\datas\\gamedataDeath1.dat", "gamepassed");
			}
			catch (Exception ex)
			{
			}
			this.Timer1.Start();
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0000C6BC File Offset: 0x0000A8BC
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.sec = Operators.SubtractObject(this.sec, 1);
			if (Operators.ConditionalCompareObjectEqual(this.sec, 995, false))
			{
				new SoundPlayer(Resources._6).Play();
				base.TransparencyKey = default(Color);
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 994, false))
			{
				this.BackColor = Color.White;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 993, false))
			{
				this.BackColor = Color.Black;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 992, false))
			{
				this.BackColor = Color.White;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 991, false))
			{
				this.BackColor = Color.Black;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 990, false))
			{
				this.BackColor = Color.White;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 989, false))
			{
				this.BackColor = Color.Black;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 988, false))
			{
				this.BackColor = Color.White;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 987, false))
			{
				this.BackColor = Color.Black;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 986, false))
			{
				this.BackColor = Color.White;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 985, false))
			{
				this.BackColor = Color.Black;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 984, false))
			{
				this.BackColor = Color.White;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 983, false))
			{
				this.BackColor = Color.Black;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 982, false))
			{
				this.BackColor = Color.White;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 981, false))
			{
				this.BackColor = Color.Black;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 980, false))
			{
				this.BackColor = Color.White;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 979, false))
			{
				this.BackColor = Color.Black;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 978, false))
			{
				this.BackColor = Color.White;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 977, false))
			{
				this.BackColor = Color.Black;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 976, false))
			{
				this.BackColor = Color.White;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 975, false))
			{
				this.BackColor = Color.Black;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 974, false))
			{
				this.BackColor = Color.White;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 973, false))
			{
				this.BackColor = Color.Black;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 972, false))
			{
				this.BackColor = Color.White;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 971, false))
			{
				this.BackColor = Color.Black;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 970, false))
			{
				this.BackColor = Color.White;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 969, false))
			{
				this.BackColor = Color.Black;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 968, false))
			{
				this.BackColor = Color.White;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 967, false))
			{
				this.BackColor = Color.Black;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 966, false))
			{
				this.BackColor = Color.White;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 965, false))
			{
				this.BackColor = Color.Black;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 964, false))
			{
				this.BackColor = Color.White;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 963, false))
			{
				this.BackColor = Color.Black;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 962, false))
			{
				this.BackColor = Color.White;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 961, false))
			{
				this.BackColor = Color.Black;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 960, false))
			{
				this.BackColor = Color.White;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 959, false))
			{
				this.BackColor = Color.Black;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 958, false))
			{
				this.BackColor = Color.White;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 957, false))
			{
				this.BackColor = Color.Black;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 956, false))
			{
				this.BackColor = Color.White;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 955, false))
			{
				this.BackColor = Color.Black;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 954, false))
			{
				this.BackColor = Color.White;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 953, false))
			{
				this.BackColor = Color.Black;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 952, false))
			{
				this.PictureBox1.Visible = true;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 951, false))
			{
				this.PictureBox1.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 950, false))
			{
				this.BackColor = Color.White;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 949, false))
			{
				this.BackColor = Color.Black;
				this.PictureBox1.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 948, false))
			{
				this.BackColor = Color.White;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 947, false))
			{
				this.BackColor = Color.Black;
				this.PictureBox1.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 946, false))
			{
				this.PictureBox1.Visible = true;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 945, false))
			{
				this.BackColor = Color.Black;
				this.PictureBox1.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 944, false))
			{
				this.BackColor = Color.White;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 943, false))
			{
				this.BackColor = Color.Black;
				this.PictureBox1.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 942, false))
			{
				this.PictureBox1.Visible = true;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 941, false))
			{
				this.BackColor = Color.Black;
				this.PictureBox1.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 940, false))
			{
				this.BackColor = Color.White;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 939, false))
			{
				this.BackColor = Color.Black;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 938, false))
			{
				this.BackColor = Color.White;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 937, false))
			{
				this.BackColor = Color.Black;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 936, false))
			{
				this.BackColor = Color.White;
				this.PictureBox1.Image = Resources.MOSHED_2018_11_16_0_18_57;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 935, false))
			{
				this.BackColor = Color.Black;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 934, false))
			{
				this.BackColor = Color.White;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 933, false))
			{
				this.BackColor = Color.Black;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 932, false))
			{
				this.BackColor = Color.White;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 931, false))
			{
				this.BackColor = Color.Black;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 930, false))
			{
				this.BackColor = Color.White;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 929, false))
			{
				this.BackColor = Color.Black;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 928, false))
			{
				this.BackColor = Color.White;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 927, false))
			{
				this.BackColor = Color.Black;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 926, false))
			{
				this.BackColor = Color.White;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 925, false))
			{
				new SoundPlayer(Resources._6).Stop();
				this.Timer1.Stop();
				this.sec = 1020;
				this.BackColor = Color.Black;
				this.PictureBox1.Visible = true;
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\BenMusic3.wav", AudioPlayMode.BackgroundLoop);
				this.Timer2.Start();
			}
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0000D15C File Offset: 0x0000B35C
		private void Timer2_Tick(object sender, EventArgs e)
		{
			this.sec2 = Operators.SubtractObject(this.sec2, 1);
			if (Operators.ConditionalCompareObjectEqual(this.sec2, 46, false))
			{
				this.Timer2.Stop();
				MessageBox.Show("D\u0361O\u0360N\u0337'T\u034f \u0338 \u0358 F\u0321OR\u035fGE\u0336T");
				this.Timer2.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec2, 44, false))
			{
				this.PictureBox1.Image = Image.FromFile(this.appPath + "\\assets\\gifs\\YOUARESTUCKED.gif");
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec2, 42, false))
			{
				this.PictureBox1.Image = Resources.MoshedFastdark;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec2, 41, false))
			{
				this.Timer2.Stop();
				MessageBox.Show("Di\u0322d\u031b y\u0358o\u0336u\u035f \u0322thi\u0360nk y\u0362ou'd g\u0337et\u0315 aw\u035da\u031by w\u031bi\u035dth it\u0328 ?\u031b");
				this.Timer2.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec2, 39, false))
			{
				this.Timer2.Stop();
				MyProject.Computer.Audio.Stop();
				this.PictureBox1.Visible = false;
				MessageBox.Show("F\u035d\u0338\u0322 \u035d\u0358\u0489U\u0341 \u0361N\u0327\u0358 \u0334\u0362N\u0341 Y\u0315\u0362 .", "");
				base.TransparencyKey = Color.Black;
				this.Timer2.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec2, 36, false))
			{
				this.Timer2.Stop();
				this.sec2 = 50;
				this.canquit = true;
				base.Hide();
				MyProject.Forms.SecondGame.Show();
				base.Close();
			}
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0000D2F6 File Offset: 0x0000B4F6
		private void nextFirstGames_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!this.canquit)
			{
				e.Cancel = true;
			}
		}

		// Token: 0x0400006A RID: 106
		private object sec;

		// Token: 0x0400006B RID: 107
		private object sec2;

		// Token: 0x0400006C RID: 108
		private string appPath;

		// Token: 0x0400006D RID: 109
		private bool canquit;
	}
}
