using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using BEN.My;
using BEN.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace BEN
{
	// Token: 0x0200000D RID: 13
	[DesignerGenerated]
	public partial class Finalstep : Form
	{
		// Token: 0x0600008B RID: 139 RVA: 0x00004DA4 File Offset: 0x00002FA4
		public Finalstep()
		{
			base.Load += this.Finalstep_Load;
			base.FormClosing += this.Finalstep_FormClosing;
			this.appPath = Application.StartupPath;
			this.sec = 50;
			this.newSec = 1000;
			this.finalTimer = 100;
			this.gotYouSec = 100;
			this.taskbared = false;
			this.taskError = false;
			this.canQuit = false;
			this.InitializeComponent();
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00005055 File Offset: 0x00003255
		// (set) Token: 0x0600008F RID: 143 RVA: 0x0000505D File Offset: 0x0000325D
		internal virtual PictureBox PictureBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00005066 File Offset: 0x00003266
		// (set) Token: 0x06000091 RID: 145 RVA: 0x00005070 File Offset: 0x00003270
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

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000092 RID: 146 RVA: 0x000050B3 File Offset: 0x000032B3
		// (set) Token: 0x06000093 RID: 147 RVA: 0x000050BC File Offset: 0x000032BC
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

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000094 RID: 148 RVA: 0x000050FF File Offset: 0x000032FF
		// (set) Token: 0x06000095 RID: 149 RVA: 0x00005108 File Offset: 0x00003308
		internal virtual global::System.Windows.Forms.Timer Tasktimer
		{
			[CompilerGenerated]
			get
			{
				return this._Tasktimer;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Tasktimer_Tick);
				global::System.Windows.Forms.Timer timer = this._Tasktimer;
				if (timer != null)
				{
					timer.Tick -= eventHandler;
				}
				this._Tasktimer = value;
				timer = this._Tasktimer;
				if (timer != null)
				{
					timer.Tick += eventHandler;
				}
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000096 RID: 150 RVA: 0x0000514B File Offset: 0x0000334B
		// (set) Token: 0x06000097 RID: 151 RVA: 0x00005153 File Offset: 0x00003353
		internal virtual global::System.Windows.Forms.Timer GotyouTimer
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000515C File Offset: 0x0000335C
		private void Finalstep_Load(object sender, EventArgs e)
		{
			this.Timer1.Start();
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0000516C File Offset: 0x0000336C
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.sec = Operators.SubtractObject(this.sec, 1);
			if (Operators.ConditionalCompareObjectEqual(this.sec, 49, false))
			{
				this.Timer1.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Hey!.wav", AudioPlayMode.Background);
				MessageBox.Show("WHAT HAVE YOU DONE ?\r\nYOU WERE FREE !", "Navi :");
				this.Timer1.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 48, false))
			{
				this.PictureBox1.Image = Resources.MoshedShake1;
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Skullkid.wav", AudioPlayMode.Background);
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 44, false))
			{
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Trapped.wav", AudioPlayMode.Background);
				this.PictureBox1.Visible = true;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 42, false))
			{
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\WhatDidYouDo.wav", AudioPlayMode.BackgroundLoop);
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 41, false))
			{
				this.Timer1.Stop();
				MessageBox.Show("F\u031c\u034d\u0326R\u031d\u032a\u0359\u0323\u035a\u0316\u0355E\u0320\u031f\u0319\u032d\u033c\u0330E\u0315\u0349\u0330\u0332\u035a\u033a\u0348 \u0334\u0330\u0331\u0319\u034e\u0359?\u0328\u0317\u033a\u0324\u031e\u0349", "");
				this.Timer1.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 40, false))
			{
				this.Timer1.Stop();
				MessageBox.Show("I\u0327\u0331\u034d\u032d\u032d \u0327 \u035a\u0317\u0324\u031d\u0319\u0325\u031c \u031f\u031d\u0332\u0333\u032aD\u0356\u031c\u0331\u0354O\u0329\u0318\u0326\u0317\u0326N\u0317\u0359\u033c\u0355\u0353'\u0332\u033aT\u033a\u0317\u0353\u0331 \u0349\u0323 \u0489K\u033cN\u032b\u0324O\u0317\u0348\u0325\u0323\u032e\u0319\u0329W\u0349\u0332 \u0337\u033a\u0317\u0356 \u0330\u0329\u0318 \u034dTH\u031b\u031e\u0353\u0323\u0324\u0347\u0339\u0330A\u0359\u0332\u0317\u0347\u0323T\u035c\u0339\u031f\u0323\u032f\u0317\u0349 \u0345\u0353\u0354\u0353\u035a\u0345 \u031d\u031c\u0325\u0347\u0355\u0356 \u035e\u0323\u032a\u032b\u0349\u0355\u0349\u0355W\u0322\u0329\u0318\u0359\u0349\u0349\u034dO\u0322\u0320\u0318R\u0327\u031f\u0316D\u035c.\u0327\u031c\u034e\u0348\u0326\u031f\u033c", "");
				this.PictureBox1.Image = Image.FromFile(this.appPath + "\\assets\\gifs\\Youvemate.gif");
				this.Timer1.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 37, false))
			{
				this.Timer1.Stop();
				this.PictureBox1.Image = Resources.MoshedShake2;
				MessageBox.Show("YO\u0362\u0345\u033a\u0325\u0329U\u0359 \u0317\u032c\u0324\u032d \u031b\u032d\u0359\u0325\u0347\u0356\u0348\u033c \u0317\u0318\u0319\u032b\u032bTW\u0324\u0332O\u034d\u0320\u033c\u0319\u0356\u0320 \u032d\u0323 \u0330\u032a\u0319\u034d\u0323\u0339\u032c \u032d\u0325\u0317\u0332B\u0361\u0333\u032e\u0339E\u0326\u0332\u0325\u0330\u0331\u0347L\u032e\u0347\u0329\u0333\u0359\u0329O\u034d\u031d\u031dN\u035c\u0323\u0319\u032e\u031e\u0323\u0319\u0339G\u035c\u0356\u032e\u0339\u033a\u0323\u0319\u0332 \u0360\u0320\u031d \u035a\u0324\u0354\u034dT\u0348\u0316O\u0354\u031c\u0330 \u0336\u035a\u031e\u031e\u032e \u0333\u031c\u0339\u0318\u032c \u0361\u0323\u032c\u032c\u0325\u031c\u032b\u033bM\u0317E\u035c\u0330\u033a \u0338\u032c\u0359\u032a\u0332\u0345\u0354\u031e \u032b\u034e\u034d \u0326\u0324\u0348\u0332\u032bN\u0317\u0319\u0356\u0319\u0354\u0316OW\u0348\u0359\u032b.\u0321\u032a", "");
				this.Timer1.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 35, false))
			{
				this.Timer1.Stop();
				this.PictureBox1.Image = Resources.MoshedShake3;
				MessageBox.Show("A\u035e\u032d\u0323N\u0315\u0323\u0333\u0325\u0317D \u0349\u0349 \u0334\u0354\u0316\u0323\u034eY\u031b\u0319O\u0335\u035a\u0333\u0316U\u0333\u0347\u0323\u033c\u0319\u033c\u0329 \u0348\u0324\u0324 \u0334\u0353\u032f\u0326\u033c\u0354\u0323 \u032cC\u0321\u0324A\u035e\u032f\u0324\u032aN\u0334\u032b\u0316\u033a\u032d\u0318\u032c'\u031b\u031c\u032e\u0331\u0345T\u0328\u0353 \u0321\u0339\u0316\u0326\u0319\u0316\u0323\u0355 \u035c\u033c\u0332\u0348\u0333\u0318E\u0336\u0325\u0332\u0323\u032e\u033b\u0348SC\u0359A\u0324\u031e\u034e\u0333\u034eP\u0335\u0326E\u0338\u0319\u031c\u031e", "");
				this.PictureBox1.Visible = false;
				this.Timer1.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 33, false))
			{
				this.Timer1.Stop();
				this.PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
				MessageBox.Show("Y\u034eO\u0361\u0356\u032f\u031d\u031d\u0355\u031e\u032fU\u0326\u033a\u0330 \u0315 \u0360\u0330\u034e\u032a\u032e\u031cA\u033c\u0320\u0333\u0356\u0320R\u0359\u032e\u035aE\u0337\u031e\u033b\u0317\u0326\u035a \u0315 \u0337\u0353\u031c\u035a \u0334\u034d\u033b\u032e\u0331S\u0329\u0323\u033a\u032e\u0345\u0317T\u031e\u0348\u0359\u034dU\u0336\u0355\u031d\u0318\u0320\u0331\u0356\u034dCK\u0322\u0320\u031f\u032b\u0319E\u0335\u0320\u0354\u0354D\u0324\u032b\u0353\u0353\u033c \u0327\u033b\u0345\u033a\u0356\u034d \u0348\u0317\u0332 \u0337\u0320\u034d\u0345\u0348IN\u035e\u032e\u031d\u0345\u033b \u0489\u0349\u0333\u035a\u0348\u0316 \u031b\u0326\u0349\u032b\u0353\u031e\u032f \u0337\u031e\u031f\u031e\u034eT\u0353H\u0332\u0329\u032e\u0324\u032bE\u0316\u034e\u0319\u034d\u0320 \u035d\u0320\u031d\u0349\u031d \u035e\u0319\u0319\u033b \u034d\u031d\u0349\u033a\u034d\u0347D\u0349\u032c\u032dA\u035e\u031fR\u0353\u033aK\u031b\u0325\u0347\u031e\u031e\u0349\u032b\u032e", "");
				this.Timer1.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 31, false))
			{
				this.Timer1.Stop();
				this.PictureBox1.Image = Image.FromFile(this.appPath + "\\assets\\gifs\\Navi.gif");
				MessageBox.Show("F\u035e\u0315\u035c\u0331\u032c\u033b\u033b\u0339\u0333\u033a\u0333\u0345\u0319\u0356\u0319\u032d\u034e\u0326\u0330 \u0361\u0338\u0335\u0335\u0337\u034e\u033c\u034d\u032e\u0356\u0356\u035a\u0325\u032b\u033b\u0347\u032d\u033a\u033b\u0349\u0316 \u031b\u0361\u0336\u034f\u035f\u0359\u0331\u0345\u034d \u034f\u0322\u035f\u032b\u0325\u034d\u034eO\u0315\u034f\u0345\u0318\u0325\u0326\u035a\u0324\u0347\u0332\u0353\u032b\u0330\u032b\u0348\u034d\u034e \u0334\u0340\u034e\u0356\u032a\u031c\u032e\u033c \u035f\u034f\u035f\u0328\u0348\u032a\u032c\u0316\u032a\u0347\u0339\u0323\u033b \u0322\u034f\u0489\u035f\u031e\u031e\u0323\u0332\u031c\u0353\u032a\u0345R\u035c\u0355\u031e\u0331\u032d\u033b\u0330 \u0334\u035f\u034f\u032d\u0320\u033b\u0333\u0356\u031d\u035a \u0335\u034f\u0335\u035f\u035e\u0347\u0323\u0317\u033b\u0355\u0323\u0345\u0317\u033c\u033a\u0329\u032f\u0316\u0349 \u035d\u035f\u0362\u0322\u0317\u0316\u0354\u0323\u0323\u032c\u035a\u031c\u0347\u0349\u0330\u0316\u0324\u0318\u0332\u0339E\u0341\u0361\u034d\u032d\u031d\u0318 \u0489\u0338\u0321\u031c\u033c\u033c\u0355\u0333\u0332\u032e\u033a\u0349\u0318\u0354\u0354\u034e\u0349\u0333\u0318 \u0336\u0321\u0316\u0353\u034d\u032b\u0316\u033a\u033b\u033a\u0347\u0320\u0333\u032a\u0319\u0348\u0318\u034d\u0325\u031d \u0361\u0360\u0360\u0321\u033c\u0331\u0319\u0323\u034eV\u0340\u035d\u0320\u0326\u0330\u0331\u033b\u0355\u0325\u0323\u033b\u0332\u0323\u0333 \u0315\u0336\u035a\u0348\u031e\u031e\u035a\u032a\u032a\u031c \u0337\u0341\u0322\u031d\u032c\u0354\u033c\u0316\u033b\u0333\u032f\u032f\u032c\u0359\u034d\u033b\u0339\u0339\u032d\u034d \u0341\u0337\u0340\u0317\u0333\u0330\u0356\u031c\u031c\u033c\u034e\u0347\u031d\u0332\u034e\u0356\u031e\u032f\u031f\u031cE\u035e\u0340\u0316\u031f\u0339\u0319\u034e\u0317\u031d\u0318\u0348\u0333\u0317\u032a\u032a\u0354\u0326 \u0322\u0328\u0347\u0323\u0354\u0356 \u0358\u0328\u0349\u0356\u0356\u032b\u032c\u0345\u0332\u033b\u0354\u0359\u032c\u0326\u0332\u0330\u0329\u0320\u0354\u031c \u0334\u0325\u0324\u0332\u0355\u031e\u0354\u0324\u0355\u032bR\u0335\u0321\u0322\u0333\u0332\u0347\u0319\u0323", "");
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Skullkid.wav", AudioPlayMode.Background);
				this.Timer1.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 22, false))
			{
				this.Timer1.Stop();
				this.PictureBox1.Visible = true;
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\NaviFlyMini.wav", AudioPlayMode.Background);
				MessageBox.Show("...", "Navi :");
				this.Timer1.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 20, false))
			{
				this.Timer1.Stop();
				MessageBox.Show("we're alone...", "Navi :");
				this.Timer1.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 18, false))
			{
				this.Timer1.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\NaviFlydown.wav", AudioPlayMode.Background);
				MessageBox.Show("and stucked...", "Navi :");
				this.PictureBox1.Visible = false;
				this.Timer1.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 8, false))
			{
				this.Timer1.Stop();
				this.PictureBox1.Visible = true;
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Listen!.wav", AudioPlayMode.Background);
				MessageBox.Show("I have an idea !", "Navi :");
				this.Timer1.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 7, false))
			{
				this.Timer1.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Look!.wav", AudioPlayMode.Background);
				MessageBox.Show("First, I will try to get us out of the dark.", "Navi :");
				this.Timer1.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 6, false))
			{
				this.Timer1.Stop();
				MessageBox.Show("Then I'll tell you what to do.\r\nYou've to help me next !", "Navi :");
				this.Timer1.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 5, false))
			{
				this.Timer1.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\NaviFlydown.wav", AudioPlayMode.Background);
				MessageBox.Show("If you don't, we're done...", "Navi :");
				this.Timer1.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 3, false))
			{
				this.Timer1.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Watchout!.wav", AudioPlayMode.Background);
				MessageBox.Show("Alright, I'll use all of my strength to break the wall.\r\nWatch out !", "Navi :");
				this.PictureBox1.Visible = false;
				this.PictureBox1.Image = null;
				this.sec = 50;
				base.TransparencyKey = Color.FromArgb(235, 235, 235);
				this.Timer2.Start();
			}
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000579C File Offset: 0x0000399C
		private void Timer2_Tick(object sender, EventArgs e)
		{
			this.newSec = Operators.SubtractObject(this.newSec, 1);
			if (Operators.ConditionalCompareObjectEqual(this.newSec, 998, false))
			{
				this.PictureBox1.Visible = true;
			}
			if (Operators.ConditionalCompareObjectEqual(this.newSec, 995, false))
			{
				this.Timer2.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Break.wav", AudioPlayMode.Background);
				this.PictureBox1.Image = Image.FromFile(this.appPath + "\\assets\\pictures\\WB1.png");
				this.Timer2.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.newSec, 993, false))
			{
				this.Timer2.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Break.wav", AudioPlayMode.Background);
				this.PictureBox1.Image = Image.FromFile(this.appPath + "\\assets\\gifs\\WB2.gif");
				this.Timer2.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.newSec, 991, false))
			{
				this.Timer2.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Break.wav", AudioPlayMode.Background);
				this.PictureBox1.Image = Image.FromFile(this.appPath + "\\assets\\gifs\\WB3.gif");
				this.Timer2.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.newSec, 989, false))
			{
				this.Timer2.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Break.wav", AudioPlayMode.Background);
				this.PictureBox1.Image = Image.FromFile(this.appPath + "\\assets\\gifs\\WB4.gif");
				this.Timer2.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.newSec, 987, false))
			{
				this.Timer2.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Break.wav", AudioPlayMode.Background);
				this.PictureBox1.Image = Image.FromFile(this.appPath + "\\assets\\gifs\\WB5.gif");
				this.Timer2.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.newSec, 985, false))
			{
				this.Timer2.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\FinalHoursBroken.wav", AudioPlayMode.BackgroundLoop);
				this.PictureBox1.Visible = false;
				base.TransparencyKey = Color.Black;
				this.Timer2.Interval = 1000;
				this.Timer2.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.newSec, 980, false))
			{
				this.Timer2.Stop();
				this.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
				MessageBox.Show("I broke the wall...", "Navi :");
				this.Timer2.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.newSec, 977, false))
			{
				this.Timer2.Stop();
				MessageBox.Show("But... I'm... very weak now...", "Navi :");
				this.Timer2.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.newSec, 975, false))
			{
				this.Timer2.Stop();
				MessageBox.Show("I... can't... move...", "Navi :");
				this.Timer2.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.newSec, 973, false))
			{
				this.Timer2.Stop();
				MessageBox.Show("Please... save yourself...", "Navi :");
				this.Timer2.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.newSec, 971, false))
			{
				this.Timer2.Stop();
				MessageBox.Show("I'll find another way...", "Navi :");
				this.Timer2.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.newSec, 969, false))
			{
				this.Timer2.Stop();
				MessageBox.Show("Please... save your...I am sorry...", "Navi :");
				this.Timer2.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.newSec, 967, false))
			{
				this.Timer2.Stop();
				MessageBox.Show("I am so weak...", "Navi :");
				this.Timer2.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.newSec, 965, false))
			{
				this.Timer2.Stop();
				MessageBox.Show("Listen...", "Navi :");
				this.Timer2.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.newSec, 963, false))
			{
				this.Timer2.Stop();
				this.newSec = 1000;
				if (Interaction.MsgBox("You have to... right click on your taskbar... and click on \"Task Manager\"...\r\n\r\nCan you do it ... ?", MsgBoxStyle.YesNo, "Navi :") != MsgBoxResult.Yes)
				{
					MessageBox.Show("If you don't, we'll both die forever...\r\nI'll be fine... believe me...", "Navi :");
				}
				this.Tasktimer.Start();
			}
		}

		// Token: 0x0600009B RID: 155
		[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern bool ShowWindow(IntPtr hWnd, Finalstep.SHOW_WINDOW nCmdShow);

		// Token: 0x0600009C RID: 156 RVA: 0x00005CDC File Offset: 0x00003EDC
		private void MinimizeTaskmanager()
		{
			checked
			{
				try
				{
					Process[] processesByName = Process.GetProcessesByName("Taskmgr");
					for (int i = 0; i < processesByName.Length; i++)
					{
						Finalstep.ShowWindow(processesByName[i].MainWindowHandle, Finalstep.SHOW_WINDOW.SW_MINIMIZE);
					}
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00005D30 File Offset: 0x00003F30
		private void Tasktimer_Tick(object sender, EventArgs e)
		{
			this.finalTimer = Operators.SubtractObject(this.finalTimer, 1);
			Process[] processesByName = Process.GetProcessesByName("Taskmgr");
			if (Operators.ConditionalCompareObjectEqual(this.finalTimer, 98, false))
			{
				if (processesByName.Length == 0)
				{
					this.finalTimer = 100;
				}
				else
				{
					this.Tasktimer.Stop();
					Thread.Sleep(500);
					MyProject.Computer.Audio.Stop();
					foreach (Process process in processesByName)
					{
						try
						{
							process.Kill();
						}
						catch (Exception ex)
						{
							this.taskError = true;
						}
					}
					if (this.taskError)
					{
						this.MinimizeTaskmanager();
						this.Tasktimer.Start();
						MyProject.Computer.Audio.Play(this.appPath + "\\assets\\ReverseSkullkid.wav", AudioPlayMode.Background);
					}
					else
					{
						this.Tasktimer.Start();
						MyProject.Computer.Audio.Play(this.appPath + "\\assets\\ReverseSkullkid.wav", AudioPlayMode.Background);
					}
				}
			}
			if (Operators.ConditionalCompareObjectEqual(this.finalTimer, 95, false))
			{
				base.Activate();
				base.TransparencyKey = default(Color);
				this.PictureBox1.Image = Image.FromFile(this.appPath + "\\assets\\gifs\\BenWpGif.gif");
			}
			if (Operators.ConditionalCompareObjectEqual(this.finalTimer, 94, false))
			{
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\TrailerJumpscare.wav", AudioPlayMode.Background);
				this.PictureBox1.Visible = true;
			}
			if (Operators.ConditionalCompareObjectEqual(this.finalTimer, 91, false))
			{
				this.Tasktimer.Stop();
				MessageBox.Show("Y\u031a\u030c\u0305\u030b\u030a\u0344\u0302\u036c\u033d\u0350\u0363\u036b\u0306\u035b\u035c\u035d\u0358\u0340\u0341\u034d\u033c\u0329\u0354\u032a\u034d\u034d\u0323\u0330\u0318\u0319\u0325\u0318O\u0366\u0311\u0307\u035b\u0367\u030e\u0361\u0360\u0362\u0341\u0340\u0330\u032c\u0331\u031c\u0320U\u0357\u0300\u0352\u034a\u0365\u0351\u0344\u0301\u035f\u0327\u031d\u0317\u0359\u0325 \u0363\u0368\u031a\u0304\u033d\u0344\u0312\u030c\u0303\u0322\u0341\u0348\u032f\u0345\u0325\u0324\u0348\u034e\u0324\u0324\u034e\u033a\u0316\u0345\u0332\u032e\u0317\u031d\u031e\u0317 \u0343\u030a\u0368\u0308\u030f\u036f\u0304\u036e\u036e\u0314\u0367\u0351\u036c\u0338\u0336\u0348\u0324\u0316\u0331\u034e\u031c\u031f\u033b\u0355\u032c\u032d \u0314\u0314\u0305\u0310\u0315\u0361\u0337\u0329\u0316\u0339\u0359\u031d\u035aS\u0363H\u0351\u036e\u0311\u033e\u0351\u0309\u0308\u0363\u030a\u0311\u034c\u0368\u0368\u0357\u0357\u0343\u0360\u0315\u0338\u0361O\u0308\u0313\u034a\u034c\u0357\u0343\u030c\u0303\u0309\u0357\u031a\u035b\u0367\u034b\u0365\u0365\u030b\u0369\u0328\u035e\u0336\u0322\u0339\u0330\u0347\u0339\u0320\u032e\u031c\u031eU\u036a\u0309\u0301\u0308\u0366\u0342\u035b\u0305\u0300\u0357\u036e\u030e\u0306\u030e\u0334\u0340\u035e\u035c\u032b\u0317\u031d\u032b\u0320\u0316\u035a\u031f\u0359\u0318\u034d\u0355\u0320\u033c\u034e\u031e\u031c\u0332\u034eL\u0365\u030f\u034c\u030c\u030b\u0350\u0363\u0303\u035d\u0336\u0321\u031b\u032f\u0347\u0348\u0318\u0316\u0320\u035a\u0325\u0332\u0329D\u036c\u036d\u0302\u0307\u0314\u0369\u0306\u036e\u0367\u035b\u0304\u0310\u0343\u0358\u031b\u0334\u0362\u0339\u035a\u0353\u034d\u0329\u0356\u0347\u033c\u0356\u0318\u035a\u032d\u031f\u0319N\u0369\u033f\u036f\u0368\u0342\u030a\u036e\u0351\u0335\u0315\u0341\u0316\u0349\u0332\u031f\u0349\u0354'\u0343\u0300\u030a\u0342\u034c\u0351\u033d\u0368\u0303\u0361\u0315\u0489\u0335\u031f\u0349\u0354\u034e\u034e\u031e\u031f\u031e\u032b\u0332\u033a\u035aT\u0302\u0307\u0307\u0311\u036a\u030a\u0351\u0308\u036c\u0344\u0364\u033f\u0315\u035f\u0358\u0327\u0320\u0325\u0325\u0330\u0324 \u0344\u0300\u0302\u0302\u0352\u0362\u0334\u0336\u0322\u0348\u0330\u032a\u033a\u032d\u0320\u0348\u0326\u0348\u033b \u0367\u0357\u030c\u0344\u0305\u0351\u034f\u0325\u031f\u033a\u0353\u032c\u032c\u0339\u032f\u0345\u033b \u0307\u036b\u0367\u0344\u033f\u0360\u0335\u0358\u0361\u032b\u0345\u0329\u0325\u0347\u033b\u032dH\u0306\u036c\u0308\u0308\u0343\u0338\u0337A\u0314\u0368\u036d\u034c\u030e\u033e\u034a\u0350\u0342\u0307\u0301\u0305\u033f\u0303\u0346\u036a\u0310\u0351\u0321\u0361\u0336\u0341\u033a\u0317\u0319\u0353\u0324\u0317\u033a\u031f\u0326\u032e\u032a\u0339\u035a\u0318\u0331\u031c\u033bV\u0302\u0350\u0303\u035b\u0366\u036d\u0313\u034c\u036b\u0342\u0365\u0350\u0367\u0343\u0366E\u036f\u036c\u0351\u0352\u0351\u034a\u0346\u0336\u0315\u0355\u031e\u032d\u031f \u036a\u0363\u0369\u030e\u0312\u036f\u030e\u0304\u036e\u036a\u036f\u0314\u035b\u030a\u0304\u035b\u033d\u0314\u0321\u035c\u035f\u0323\u032e\u0317 \u0313\u030e\u0310\u0308\u033d\u0357\u0368\u036b\u030d\u030e\u036a\u031a\u0351\u033d\u0307\u0351\u0346\u0301\u030d\u0489\u0337\u0341\u032e\u034d\u0353\u032e\u0348\u0330\u0347\u032e\u0348\u0354\u0349\u035a \u0301\u0346\u0352\u0305\u030e\u030c\u0357\u0311\u0314\u030a\u036a\u0304\u030c\u033e\u030a\u0304\u030f\u0321\u0338\u0353\u0332\u0318\u0316\u0323\u032d\u032e\u0348D\u0350\u0369\u036f\u0344\u0368\u035f\u0321\u032b\u0318\u0329\u0332\u033a\u0353\u0317\u0356\u0332\u031c\u0333\u033b\u0359\u033b\u033c\u034e\u0317\u031eO\u0342\u031a\u0300\u033d\u0313\u0300\u0313\u036f\u0367\u034b\u0343\u0363\u035f\u0322N\u0343\u0342\u0363\u036b\u036aE\u0302\u036c\u033d\u0351\u0350\u030a\u0367\u035f\u0360\u0317\u0329\u032e\u032c\u0317\u032f\u0329\u0317\u032a \u0351\u033f\u036e\u0364\u0312\u034c\u0304\u036e\u030f\u0338\u035d\u0336\u035e\u0317\u0359\u0323\u0324\u0329\u0353 \u031a\u034c\u0351\u0313\u030c\u0369\u0301\u0312\u0306\u0351\u031a\u0368\u0336\u0358\u0335\u0329\u0320\u0324\u032c\u0347\u034d\u033b\u0353\u0356\u0333\u0326\u032b\u0353\u0329\u0319\u033b\u031f \u030c\u0351\u0302\u0306\u0314\u036e\u035e\u0355\u0331\u032d\u034e\u0318\u032a\u034e\u0359\u035a\u0333\u0349\u031f\u0355\u0332\u0345\u0349\u0324\u0319T\u0364\u0306\u0310\u0363\u0303\u0346\u0309\u034a\u0368\u033d\u0350\u033d\u0346\u0304\u036a\u033e\u0350\u0342H\u0305\u033d\u035b\u036e\u036a\u036f\u030f\u0306\u033f\u0310\u030a\u035b\u0309\u0303\u0336\u0334\u0316\u032b\u0331\u0356\u0348\u0319\u032f\u0359\u0323\u0320\u033b\u0331\u0348A\u031a\u031a\u0365\u0311\u0308\u0305\u0365\u0346\u033e\u0313\u0346\u0352\u035c\u0341\u0337\u031c\u034e\u0329\u0353\u0347\u031e\u0329\u0317\u033c\u0330\u033a\u033b\u0329\u031d\u0329\u0354\u0319\u0356\u033bT\u030e\u0305\u0314\u033f\u0310\u0309\u030c\u0300\u0350\u036e\u033e\u0312\u035b\u0309\u035d\u0328\u0355\u032c\u0332\u0325\u0325\u031f\u0319\u0320\u032f\u0320\u0345\u032b\u0349", "");
				this.Tasktimer.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.finalTimer, 90, false))
			{
				this.Tasktimer.Stop();
				MessageBox.Show("DI\u030d\u0311\u032f\u031d\u034e\u0320\u0329\u0324D\u0313\u0300\u0363\u030c\u034b\u0306\u0359\u0324\u033a\u0324 \u036c\u0346\u0315\u0356\u0353 \u033d\u0313\u0302\u0343\u0307\u033e\u035e\u0320\u035a\u031d\u0353\u032a \u036e\u0305\u0343\u031a\u0300\u030f\u0351\u034d\u0333\u0323\u0323Y\u0313\u0313\u0366\u030e\u0310O\u036f\u0303\u036b\u0351\u0309\u036d\u0360\u033c\u0320\u0329\u032b\u032fU\u030f\u0311\u036f\u0314\u034d\u033b \u0344\u030f\u034a\u030c\u0363\u0365\u0351\u0489\u033b\u0353\u0339\u032b\u032b \u0300\u035c\u032a\u035a\u034d \u030d\u030f\u030c\u0308\u034eT\u030c\u033fH\u033e\u0322\u0318\u0317\u033b\u032b\u035aI\u0350\u0305\u034b\u0303\u0322\u031e\u0331N\u030c\u0351\u0308\u0337\u032a\u0330\u0326\u0349\u034e\u0316\u0329K\u0302\u0301\u0346\u0303\u030f\u033f\u0307\u031b\u0359 \u036d\u0307\u0311\u036b\u0304\u0352\u0355 \u031a\u0300\u0310\u034d\u031c\u0326\u032d\u0354 \u035a\u032f\u0349\u033b\u034eY\u036b\u031a\u0363\u0360\u032f\u033a\u034d\u0348O\u0321\u0333\u031c\u0355\u0347\u0324\u0332\u0339U\u0346\u0342\u035b\u036f\u030d\u033d\u0317\u034e\u0325\u0359\u0317'\u0304\u034a\u036b\u036d\u030b\u0340\u034d\u0332\u031eD\u0344\u033c\u0332\u0333\u0318 \u033f\u0302\u032a \u0352\u030f\u030c\u0366\u035e \u036c\u030c\u0313\u034a\u030d\u033d\u0361\u0319\u032fE\u0327\u0353\u0331\u032c\u032b\u031dN\u0357\u0301\u0350\u036c\u0310\u0320\u0359\u0330\u032d\u0323D\u0344\u0361\u0325\u0326\u031d\u0318 \u033e\u036d\u0313\u035b\u032a\u0348\u0348\u0349\u0332\u0325\u0317 \u030e\u0304\u0301\u035b\u0302\u036f\u0326\u0333\u031d\u0359\u0333\u0329\u0348 \u0369\u0305\u036b\u0344\u0337\u0317\u0318\u0354\u0330U\u0300\u036a\u033f\u0302\u0351\u034b\u0357\u034d\u0355\u032a\u0326\u0323\u0330\u031eP\u0320\u0347\u0349\u0316\u0316\u0359\u0347 \u0344\u030d\u034c\u034b\u0301\u034b\u0327\u035a\u031f\u0353 \u0343\u0365\u0336\u0333\u0345\u0329\u0333\u0323\u0323 \u0310\u036c\u030d\u036f\u0303\u0366\u0340\u0324\u0355\u0320L\u031f\u0339I\u0311\u0321\u035a\u031c\u035a\u031cK\u030b\u0363\u0309\u0352\u0300\u0363\u035b\u035c\u031c\u0348\u032f\u031fE\u033d\u0325\u032b\u0331\u035a\u0347\u0356\u0354 \u032a\u0320\u0318\u0347\u032e \u0368\u0343\u034c\u0324\u0348\u035a\u0359 \u036f\u0359\u035a\u0348\u0319\u032aT\u033e\u0304\u0366\u0314\u0352H\u0313\u0343\u0357\u0352\u0346\u0347\u0349I\u0346\u0314\u0365\u034c\u030b\u0350\u0356S\u030e\u030c\u0342\u036e\u0300\u033d\u033a\u0345\u031f\u0324\u0317\u033b \u036a\u0350\u036f\u035b\u030d\u030c\u0314\u031b\u0348\u0355\u0353\u0356\u0330\u0354 \u0365\u030d\u036a\u0362\u0347\u0359 \u0300\u0301\u0307\u0367\u0300\u034a\u0328\u0333\u0324\u031e\u033b?\u0301\u0351\u0366\u0301\u0302\u035f\u0345\u033a\u0331\u0348\u0347\u032f", "");
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\WhatDidYouDo3.wav", AudioPlayMode.BackgroundLoop);
				this.Tasktimer.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.finalTimer, 88, false))
			{
				this.Tasktimer.Stop();
				MessageBox.Show("Y\u036c\u0366\u0314\u030d\u0313\u0307\u0349\u0316\u0325\u0355\u034d\u0326\u032bO\u034b\u0357\u0360\u0354\u0354U\u0304\u035b\u0301\u0369\u0367\u0341\u0320\u0318\u0347\u031e\u0330\u0329\u0319 \u0314\u0302\u0343\u0369\u034a\u033d\u0333\u031d \u034b\u0366\u0343\u0343\u030d\u0322\u031e \u030f\u0357\u0352\u030a\u0368\u030c\u032c\u0329\u034e\u0331\u0339AR\u0339\u0349\u0348\u031eE\u035b\u030c\u036c\u031e\u034e\u035a\u035a\u0323 \u034b\u0344\u031a\u036d\u0310\u0305\u0321\u0354\u032c\u031d\u0331 \u0312\u0301\u036e\u0331\u031e\u0316\u033b\u032c\u033c \u0351\u0358\u0320\u032f\u033c\u0317\u0356\u035aS\u030e\u0308\u032b\u031d\u0347T\u034c\u0368\u0364\u0342\u0363\u0357\u030dU\u0307\u036c\u0307\u0306\u035b\u0347\u033cC\u0344\u036a\u031bK\u036fED\u0368\u030d\u0334\u0339\u0331\u031f\u0353\u0323\u0326", "");
				this.Tasktimer.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.finalTimer, 86, false))
			{
				this.Tasktimer.Stop();
				MessageBox.Show("N\u0301\u0303\u0310\u030e\u0313\u033a\u0354\u0345\u0354\u0345\u032e\u033cO\u036f\u0352\u0346\u0328\u0353\u0339\u0354 \u030f\u0363\u036f\u030c\u030e\u031a\u0342\u034e\u0347\u033c\u034d\u0355\u0333\u0353 \u0356\u0347\u032e\u033a\u0319\u031f\u0331 \u0369\u0313\u034e\u0333\u032b\u032b\u032d\u0354\u034dO\u0309\u030b\u0358N\u0321\u033b\u034e\u034dE\u036a\u0351\u0314\u034a\u033c\u0330\u034d\u0331\u032b\u0332 \u0305\u0344\u030e\u0357\u0307\u0301\u0334 \u035d \u0314\u036e\u035d\u0330\u032a\u035a\u031dC\u0366\u036e\u0305\u0303\u0339A\u0307\u032eN\u0366\u0363\u033e\u0337\u0354 \u031b\u0347 \u0300\u0344\u0369\u0366\u034a\u031b\u0330\u032d\u034e\u0320\u0324 \u0363\u033d\u0315\u0320\u0329H\u0326\u031cE\u036a\u0368\u030c\u036e\u0361\u0359\u0319\u0356L\u033f\u0322\u0345\u0331P\u0346\u036a\u035b\u036d\u0346\u0314\u0351\u0333\u0333\u0348\u0316 \u0350\u0313\u030c\u0362\u032b\u032e\u031c\u032e\u0318 \u033f\u0369\u0300\u031a\u036d\u0315\u0320\u034d\u0331 \u0319\u032c\u031e\u033b\u0359Y\u0342\u0365\u0357\u036f\u0308\u030b\u0362\u0324\u0353\u035aO\u0350\u036b\u033d\u0314\u0307\u036c\u0350\u0328U\u033f\u034d\u0354", "");
				this.Tasktimer.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.finalTimer, 84, false))
			{
				this.Tasktimer.Stop();
				MessageBox.Show("N\u031a\u0357\u035b\u0334\u0355\u032a\u0325\u0347\u032cO\u035c\u0349\u032b\u0333 \u0310\u0347\u0331\u0354\u0320\u0330 \u030a\u0314\u0350\u0309\u030b\u0307\u036f\u032c\u031f\u0345\u032c \u0308\u0369\u0326\u034d\u031dO\u034b\u0305\u036d\u0311N\u033c\u0318\u0359\u031e\u0354\u033c\u0354E\u0313\u0314\u032d\u0333\u0355\u0353 \u0319\u0318\u0339 \u0350\u033f\u030e\u0364\u0304\u0353\u0318 \u0300\u0308\u0366\u0301\u033f\u034a\u0321\u0316\u0332C\u034b\u0363\u030d\u0367\u0308\u036f\u0319\u0345\u0317\u0348A\u0303\u0366\u0323\u0349\u0320\u0354N\u033f\u0354\u032e\u0323\u0355..", "");
				this.Tasktimer.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.finalTimer, 83, false))
			{
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Boom.wav", AudioPlayMode.Background);
				this.PictureBox1.Image = Resources.MoshedShake1;
			}
			if (Operators.ConditionalCompareObjectEqual(this.finalTimer, 81, false))
			{
				this.Tasktimer.Stop();
				MessageBox.Show("WH\u0301\u0314\u033f\u0352\u0306\u0314\u0300\u0337\u0325\u035a\u034eA\u036e\u034f\u0333\u033b\u033cT\u0310\u0308\u035b\u033f\u034a\u032e\u031e\u0359 \u0339\u031d\u0356?", "");
				this.Tasktimer.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.finalTimer, 80, false))
			{
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Boom.wav", AudioPlayMode.Background);
				this.PictureBox1.Image = Resources.MoshedShake2;
			}
			if (Operators.ConditionalCompareObjectEqual(this.finalTimer, 78, false))
			{
				this.Tasktimer.Stop();
				MessageBox.Show("I\u031a\u0366\u034b\u034a\u0304\u036c\u0327M\u0302\u0364\u0327\u0349\u0324\u033c\u0318PO\u030b\u0363\u036d\u0366\u036d\u034b\u030eS\u033dS\u0322\u0320\u032eI\u0311\u0331\u031c\u0318B\u030e\u035b\u0346\u035b\u0357\u036a\u0342\u032d\u0353\u0359\u033c\u0355\u0318\u0324L\u0365\u034c\u036d\u030b\u031b\u0359\u0349\u0347E\u0369\u0310\u0369\u036b\u0343\u030a\u036b\u0355\u0320", "");
				this.Tasktimer.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.finalTimer, 76, false))
			{
				this.Tasktimer.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Hey!.wav", AudioPlayMode.Background);
				MessageBox.Show("I went into the task manager when you opened it...!", "Navi :");
				MessageBox.Show("I killed the process, you'll be free ...", "Navi :");
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\ReverseStrangeMusic1Mini.wav", AudioPlayMode.BackgroundLoop);
				this.PictureBox1.Image = Resources.MoshedShake3;
				this.Tasktimer.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.finalTimer, 74, false))
			{
				this.Tasktimer.Stop();
				this.PictureBox1.Image = Resources.MoshedShake4;
				MessageBox.Show("T\u0367\u0350\u0342\u0352\u0330H\u0367\u0328\u0347A\u035d\u0324\u0347\u0345T\u030d\u0367\u0310\u0354\u0356\u0345'\u0305\u0364\u030e\u0307\u0350\u0365\u0327\u032cS\u034a\u0304\u0331\u0332\u033c \u0314\u036c\u030f\u0358\u0329\u0329\u034e\u032a\u0317\u0356 \u030d\u0313\u0367\u0310\u0312\u0331\u0347\u0356\u0333\u0339\u032f\u0330 \u030b\u030a\u036b\u0352\u0309\u030a\u033e\u0353\u031f\u032aR\u0308\u033f\u0305\u035f\u032a\u034d\u0333I\u0305\u034b\u033d\u0357\u0306\u0358\u0324\u0348\u034d\u0332\u034e\u031cG\u0350\u0309\u036c\u0363\u0368\u0352\u0326H\u036d\u0305\u036e\u0314\u0343\u036c\u0358\u031f\u0347\u032c\u033c\u0326\u0345T\u030c\u0368\u0312\u0335\u0339.\u0328\u032a\u0332\u031c\u034e\u0319", "");
				this.Tasktimer.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.finalTimer, 73, false))
			{
				this.Tasktimer.Stop();
				MessageBox.Show("Y\u0363\u0328\u032e\u034dO\u036a\u0305\u033fU\u0357\u036c\u0325\u032f\u035a\u0331\u034d\u031e\u034e'\u033e\u0343\u0314\u035b\u0312\u0302\u0336LL\u030d\u0335\u034d\u0320\u0324\u031f\u0349\u0339\u033c \u036f\u0351\u030f\u0302\u0313\u0338\u032a\u0329\u0316\u034e\u035a \u0350\u033e\u0338\u034d\u0317\u0319\u0345 \u033e\u0305\u0350\u036d\u034a\u035e\u032c\u033a\u0331B\u0364\u0304\u0320\u0319E\u036d\u0307\u0369\u0367\u0350\u030c\u0350\u0353\u0339\u034e \u0368\u036c\u030c\u030c\u0351\u0307\u0358\u0339\u0316\u035a\u0316\u0347 \u036f\u0306\u036f\u030a\u030f\u035a \u0343\u030b\u0315FR\u034a\u035d\u031cE\u0301\u0307\u0351\u0342\u0335\u031f\u032d\u0326\u032e\u0353\u032e\u032fE\u0351\u0343\u0350\u0306\u0362\u033a\u0329\u0359\u034e.\u0314\u0301\u030f\u034a\u0350\u0304\u0316", "");
				this.Tasktimer.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.finalTimer, 72, false))
			{
				this.Tasktimer.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\FinalHoursBroken.wav", AudioPlayMode.BackgroundLoop);
				MessageBox.Show("B\u0306\u0367\u0369\u0342\u0304\u0366\u0338U\u0354\u032a\u0325\u032b\u0355\u0330T\u031d\u0359\u031f\u0333\u033c\u0356 \u036b\u0350\u036a\u036f\u0307\u033d\u0322\u032c\u031c\u0348\u031d\u032f\u033b \u0363\u0341\u0331\u0349\u032a \u035e\u0324\u0353\u0325\u0329N\u0300\u0307\u0305\u0365\u0308\u0368\u0301\u033a\u031e\u0320\u0339O\u0343\u036fT\u0367\u0351\u0300\u0307\u030b\u0368\u0362 \u0343\u0308\u0342\u0337\u031e\u032c \u034a\u0367\u0352\u030c\u033e\u0317\u0355\u0359\u0355 \u0325Y\u0304\u0343\u035b\u030b\u0318\u0318\u031f\u0316\u033a\u032bO\u033e\u030b\u030f\u0303\u0350\u036e\u035e\u0326U\u030e\u034f\u032d\u0348\u0353\u032c\u031fR\u0310\u0305\u031a\u034c\u0369\u031a\u036d\u0358\u0323\u032a\u031d \u0323\u0347\u031f\u0356 \u036f\u036b\u0303\u0352\u0352\u0367\u033e\u0347\u035a\u0348\u031c\u0355\u033a \u0308\u0339F\u0306\u0365\u0306\u030d\u036c\u0344\u0342\u035e\u0316\u0332\u033c\u0354\u0319\u031dR\u030d\u0350\u030c\u035e\u035a\u0323\u0359\u0330\u033c\u0349\u0319I\u0311\u035a\u0330\u033c\u0339E\u0306\u0306\u0357\u030b\u0337\u031e\u0320N\u0365\u0336\u034d\u0320\u0348\u034e\u033bD\u0303\u0342\u030c\u0342\u0322\u031c\u0332\u031f\u0345", "");
				this.Tasktimer.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.finalTimer, 71, false))
			{
				this.Tasktimer.Stop();
				MessageBox.Show("S\u0369\u0306\u0344\u033e\u035b\u0364\u0307\u035dH\u034a\u036c\u0350E\u030f\u030a\u0300\u0310\u036a\u0315\u0333\u034e\u0319\u032b'\u030c\u0366\u034a\u033f\u0348\u0353\u035a\u032bL\u033e\u031a\u0306\u0362\u032b\u035a\u0316\u0324\u0355\u0325L \u0311\u034f\u032b\u0349\u0345 \u0302\u0350\u0365\u0306\u0364\u0364\u0349\u0359\u0356\u032d \u0366B\u0300\u0321\u033a\u0318\u031eE\u033f\u0342\u0327\u031e\u0353\u032d \u0311\u034e\u0355\u033b\u033b\u031e\u0348 \u033d\u0346\u0311\u0309\u0301\u0360\u0359\u0354\u032d\u0354\u033c \u0310\u030b\u0350\u032d\u0331\u034d\u034d\u032f\u032cS\u036e\u0306\u0343\u0307\u0311\u0322\u0349\u032a\u0325\u0319\u0326\u0317T\u032d\u0316\u0330\u033b\u0323\u0325\u034eU\u030b\u034b\u0357\u0349\u032d\u0316C\u036c\u036f\u0314\u034cK\u034b\u0314\u0302\u036c\u0342\u030b\u0317\u0320\u032cE\u0314\u0360\u0359D\u0303\u0315\u0316\u0325\u0330\u0318\u0320\u033c\u031c", "");
				this.Tasktimer.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.finalTimer, 70, false))
			{
				this.Tasktimer.Stop();
				MessageBox.Show("W\u0307\u034b\u030a\u0315\u0359\u031d\u031e\u0318\u031f\u031fI\u031e\u031eT\u0342\u0365\u036a\u030b\u0342\u030c\u031fH\u0300\u0366\u031d\u0359\u032b\u0349\u0324 \u036a\u030b\u036f\u0301\u0305\u0332 \u0307\u033d\u0365\u035b\u0307\u0303\u035e\u0339\u031c\u033a\u0317\u031c\u0333 \u0300\u0346\u0304\u0321\u031d\u0348\u0330\u032e\u0325\u034eM\u0365E\u0300\u0303\u0366\u036a\u034a\u0309\u034b\u0355\u0339\u032d\u0332,\u034b\u0365\u030b\u036e\u0368\u0342\u033d\u0335\u0339\u0320\u0339\u0326\u0318\u0319\u0320 \u0308\u0312\u0369\u0369\u036d\u0350\u0355\u0323\u0349\u032a \u0367\u0303\u036d\u0346\u0336\u031c\u0349 \u034c\u0345F\u0351\u0310\u0330\u035a\u0320\u032f\u032f\u033aO\u0335\u033a\u034e\u0356R\u0302\u034fE\u0352\u0303\u0306\u0304\u0350\u031f\u035a\u0329\u0348\u032f\u035a\u033aV\u0343\u0305\u0303\u0365\u031a\u0309\u0308\u0356\u0316\u0325\u031d\u0320\u0349\u0354E\u0369R\u0308\u030f\u0309\u033d\u030e\u031a\u0368\u0316\u033b\u033a", "");
				this.PictureBox1.Visible = false;
				this.Tasktimer.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.finalTimer, 69, false))
			{
				this.Tasktimer.Stop();
				MessageBox.Show("Don't worry, everything will be fine...", "Navi :");
				this.PictureBox1.Image = Image.FromFile(this.appPath + "\\assets\\gifs\\BenWpGif.gif");
				this.Tasktimer.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.finalTimer, 68, false))
			{
				this.Tasktimer.Stop();
				MessageBox.Show("You'll be free, isn't that nice ?", "Navi :");
				this.Tasktimer.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.finalTimer, 67, false))
			{
				this.Tasktimer.Stop();
				MessageBox.Show("But don't come back to save me...", "Navi :");
				this.Tasktimer.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.finalTimer, 65, false))
			{
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\MessageFromHell.wav", AudioPlayMode.Background);
				this.PictureBox1.Visible = true;
			}
			if (Operators.ConditionalCompareObjectEqual(this.finalTimer, 63, false))
			{
				this.Tasktimer.Stop();
				MessageBox.Show("I\u030c\u0369\u0309\u035b\u0314\u0312\u0322\u0332\u034d\u031c\u0324\u0339\u0323 \u0305\u036e\u0350\u030c\u0305\u0324\u0345\u031e\u0355\u0329 \u0300\u036f\u0312\u0363\u035f\u0347\u0320F\u0342\u035b\u030f\u0336\u0339\u034dOR\u0327\u033b\u0326\u0330\u031e\u0326\u0333G\u031c\u031d\u031c\u0323\u035a\u0317\u032cO\u0302\u031b\u031f\u031e\u031dT\u0311\u0335\u032a \u030f\u0354\u0331\u032f\u033a\u0316 \u0346\u0350\u031b\u035a\u031f \u0350\u0366\u0310\u0368\u031f\u0325\u032c\u0316\u0349T\u0300\u0309\u0342\u0364\u0331O\u0317\u034d\u0318\u0339\u0319\u0331\u0347 \u0365\u0351\u034f\u0320\u032f \u0342\u0314\u0322\u0320\u0320\u031e\u0330 \u0311\u0367\u033d\u030b\u034b\u036b\u0321\u0324\u0348\u0332\u033a\u0329\u0347T\u0343\u0335\u0355ELL \u0304\u0304\u035e\u031f\u0318\u0347 \u035b\u0346\u0357\u0309\u0311\u0329\u0317\u0348\u0345 \u0363\u034c\u036a\u0310\u0343\u032b\u0348\u0320\u031c\u032d\u0349\u0317YO\u033fU\u0369\u0308\u0308\u0352\u034c\u0300\u0331\u032f", "");
				this.Tasktimer.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.finalTimer, 62, false))
			{
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Free.wav", AudioPlayMode.Background);
				this.PictureBox1.Image = Image.FromFile(this.appPath + "\\assets\\gifs\\EvenFree.gif");
			}
			if (Operators.ConditionalCompareObjectEqual(this.finalTimer, 60, false))
			{
				this.PictureBox1.Image = Resources.MoshedShake5;
			}
			if (Operators.ConditionalCompareObjectEqual(this.finalTimer, 56, false))
			{
				this.PictureBox1.Image = Resources.MoshedCreepysmile;
				base.TopMost = false;
				MyProject.Forms.EndWhite.Show();
			}
			if (Operators.ConditionalCompareObjectEqual(this.finalTimer, 52, false))
			{
				this.canQuit = true;
			}
			if (Operators.ConditionalCompareObjectEqual(this.finalTimer, 50, false))
			{
				base.Close();
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00006564 File Offset: 0x00004764
		private void Finalstep_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!this.canQuit)
			{
				e.Cancel = true;
			}
		}

		// Token: 0x04000031 RID: 49
		private string appPath;

		// Token: 0x04000032 RID: 50
		private object sec;

		// Token: 0x04000033 RID: 51
		private object newSec;

		// Token: 0x04000034 RID: 52
		private object finalTimer;

		// Token: 0x04000035 RID: 53
		private object gotYouSec;

		// Token: 0x04000036 RID: 54
		private bool taskbared;

		// Token: 0x04000037 RID: 55
		private bool taskError;

		// Token: 0x04000038 RID: 56
		private bool canQuit;

		// Token: 0x02000021 RID: 33
		private enum SHOW_WINDOW
		{
			// Token: 0x04000193 RID: 403
			SW_HIDE,
			// Token: 0x04000194 RID: 404
			SW_SHOWNORMAL,
			// Token: 0x04000195 RID: 405
			SW_NORMAL = 1,
			// Token: 0x04000196 RID: 406
			SW_SHOWMINIMIZED,
			// Token: 0x04000197 RID: 407
			SW_SHOWMAXIMIZED,
			// Token: 0x04000198 RID: 408
			SW_MAXIMIZE = 3,
			// Token: 0x04000199 RID: 409
			SW_SHOWNOACTIVATE,
			// Token: 0x0400019A RID: 410
			SW_SHOW,
			// Token: 0x0400019B RID: 411
			SW_MINIMIZE,
			// Token: 0x0400019C RID: 412
			SW_SHOWMINNOACTIVE,
			// Token: 0x0400019D RID: 413
			SW_SHOWNA,
			// Token: 0x0400019E RID: 414
			SW_RESTORE,
			// Token: 0x0400019F RID: 415
			SW_SHOWDEFAULT,
			// Token: 0x040001A0 RID: 416
			SW_FORCEMINIMIZE,
			// Token: 0x040001A1 RID: 417
			SW_MAX = 11
		}
	}
}
