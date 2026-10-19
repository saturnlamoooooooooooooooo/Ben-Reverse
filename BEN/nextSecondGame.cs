using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using BEN.My;
using BEN.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace BEN
{
	// Token: 0x02000013 RID: 19
	[DesignerGenerated]
	public partial class nextSecondGame : Form
	{
		// Token: 0x060000F5 RID: 245 RVA: 0x0000D308 File Offset: 0x0000B508
		public nextSecondGame()
		{
			base.Load += this.nextSecondGame_Load;
			base.FormClosing += this.nextSecondGame_FormClosing;
			this.appPath = Application.StartupPath;
			this.sec = 50;
			this.yesSec = 50;
			this.noSec = 50;
			this.canQuit = false;
			this.InitializeComponent();
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x0000D583 File Offset: 0x0000B783
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x0000D58C File Offset: 0x0000B78C
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

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060000FA RID: 250 RVA: 0x0000D5CF File Offset: 0x0000B7CF
		// (set) Token: 0x060000FB RID: 251 RVA: 0x0000D5D8 File Offset: 0x0000B7D8
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

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060000FC RID: 252 RVA: 0x0000D61B File Offset: 0x0000B81B
		// (set) Token: 0x060000FD RID: 253 RVA: 0x0000D624 File Offset: 0x0000B824
		internal virtual Timer TimerYes
		{
			[CompilerGenerated]
			get
			{
				return this._TimerYes;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.TimerYes_Tick);
				Timer timer = this._TimerYes;
				if (timer != null)
				{
					timer.Tick -= eventHandler;
				}
				this._TimerYes = value;
				timer = this._TimerYes;
				if (timer != null)
				{
					timer.Tick += eventHandler;
				}
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060000FE RID: 254 RVA: 0x0000D667 File Offset: 0x0000B867
		// (set) Token: 0x060000FF RID: 255 RVA: 0x0000D670 File Offset: 0x0000B870
		internal virtual Timer TimerNo
		{
			[CompilerGenerated]
			get
			{
				return this._TimerNo;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.TimerNo_Tick);
				Timer timer = this._TimerNo;
				if (timer != null)
				{
					timer.Tick -= eventHandler;
				}
				this._TimerNo = value;
				timer = this._TimerNo;
				if (timer != null)
				{
					timer.Tick += eventHandler;
				}
			}
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0000D6B4 File Offset: 0x0000B8B4
		private void nextSecondGame_Load(object sender, EventArgs e)
		{
			base.Activate();
			this.PictureBox1.Image = Resources.Moshed3D1;
			this.PictureBox1.Visible = true;
			MyProject.Computer.Audio.Play(this.appPath + "\\assets\\ReverseStrangeMusic1Mini.wav", AudioPlayMode.BackgroundLoop);
			this.Timer1.Start();
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000D710 File Offset: 0x0000B910
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.sec = Operators.SubtractObject(this.sec, 1);
			if (Operators.ConditionalCompareObjectEqual(this.sec, 48, false))
			{
				this.Timer1.Stop();
				MessageBox.Show("dO yoU reGReT ?", "");
				this.Timer1.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 46, false))
			{
				this.Timer1.Stop();
				if (Interaction.MsgBox("fOR brINginG mE iN ?", MsgBoxStyle.YesNo, "") == MsgBoxResult.Yes)
				{
					this.TimerYes.Start();
					return;
				}
				this.TimerNo.Start();
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0000D7BC File Offset: 0x0000B9BC
		private void TimerYes_Tick(object sender, EventArgs e)
		{
			this.yesSec = Operators.SubtractObject(this.yesSec, 1);
			if (Operators.ConditionalCompareObjectEqual(this.yesSec, 48, false))
			{
				this.TimerYes.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Msg.wav", AudioPlayMode.Background);
				MessageBox.Show("oF coURSe.", "");
				Cursor.Hide();
				this.PictureBox1.Visible = false;
				this.PictureBox1.Image = Image.FromFile(this.appPath + "\\assets\\pictures\\BenSSJ.png");
				this.TimerYes.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.yesSec, 46, false))
			{
				this.PictureBox1.Visible = true;
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\TrailerJumpscare.wav", AudioPlayMode.Background);
			}
			if (Operators.ConditionalCompareObjectEqual(this.yesSec, 40, false))
			{
				this.TimerYes.Stop();
				Cursor.Show();
				this.PictureBox1.Image = Image.FromFile(this.appPath + "\\assets\\gifs\\BenSSJGif.gif");
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Bugging.wav", AudioPlayMode.BackgroundLoop);
				MessageBox.Show("y\u0350\u0352\u0301\u0312\u0362\u0335\u031c\u0349\u0331\u031f\u031c\u0355\u0347\u0339o\u0306\u0346\u0366\u0364\u0300\u0366\u036c\u0338\u0327\u0331\u0318\u0348\u0329\u0348\u0347u\u0310\u0363\u0369\u0303\u0300\u0357\u033d\u0338\u0328\u032e'\u0344\u0365\u030f\u0308\u036b\u034b\u0311\u0300\u0333\u0345\u035a\u031dv\u033d\u0369\u030f\u0343\u0352\u034a\u035e\u0489\u035c\u0318\u0353e\u030f\u0300\u0358\u0322\u031f\u0354 \u0343\u0300\u034a\u030c\u0311\u031a\u033e\u0361\u035c\u033a\u0320\u0347 \u036d\u033f\u036b\u035c\u0335\u032d\u032f\u034d \u035b\u0365\u030c\u0310\u0336\u034f\u0348\u0324\u0317\u032d\u031cm\u0357\u0344\u030e\u036a\u0365\u035b\u0301\u030e\u030c\u0321\u0318\u031e\u0326\u0345e\u0369\u0342\u034a\u0327\u035f\u032c\u031c\u032f\u0348t\u036c\u0351\u0300\u0342\u0357\u034b\u0365\u0337\u033a\u0355 \u034a\u0302\u034a\u030e\u0356\u032e \u034b\u036f\u0306\u030f\u0327\u035f\u032e\u0339\u0359\u0318\u0333\u0318 \u033e\u0367\u033f\u0363\u0306\u0348\u0320\u0330\u0320w\u036f\u0304\u033d\u0489\u035c\u0322\u031c\u0318\u0356\u0323\u0318\u033b\u0323\u0348\u0326i\u0312\u0304\u0308\u033d\u0300\u0306\u0337t\u036b\u036a\u0334\u0338\u032e\u0354h\u0351\u036d\u0301\u034a\u0314\u0364\u0360\u031b\u0336\u032a\u0317\u031f\u032c\u035a\u035a\u031f \u030c\u0365\u030f\u0312\u0315\u0321\u031d\u033a\u0319\u0359 \u0357\u030c\u030a\u0365\u0366\u0315\u0362\u0319\u031f \u030b\u036b\u034a\u030c\u036b\u0309\u034b\u0322\u0335\u0360\u0345\u031e\u0347\u0347\u031ca\u0366\u0368\u0322\u0341\u0328\u032c\u0330\u0354\u032c\u031d \u030f\u030b\u0368\u030a\u0301\u0311\u035f\u0320\u0317\u0320\u033b\u0331\u0324\u0324\u034e \u0310\u036e\u036b\u0307\u0328\u0335\u0360\u032d\u0347 \u0302\u030e\u0309\u0361\u0341\u0326\u033c\u031c\u031d\u0330\u0325t\u034c\u0364\u030a\u030a\u030f\u033f\u0311\u0313\u035c\u0328\u0322\u032f\u031e\u0356\u033ae\u036e\u0314\u0357\u0311\u0344\u0329\u032f\u0323\u031dr\u0343\u030c\u0344\u0307\u0342\u0351\u0336\u0320\u032er\u0367\u0302\u0312\u0369\u034b\u0366\u035e\u0354i\u0357\u0343\u033f\u0314\u033d\u0364\u0336\u035d\u0337\u032c\u0319\u0329\u031c\u0339\u0345\u0354b\u0311\u0365\u030e\u0369\u0305\u030a\u033d\u0305\u0361\u0338\u0359\u0333l\u0352\u030b\u036e\u036b\u0368\u0308\u0301\u0322\u035d\u0345\u0317\u033a\u0353\u0329\u0355\u031d\u0339e\u030e\u0307\u0351\u030e\u0351\u0344\u030b\u0305\u0338\u0341\u0330\u0353\u032e \u034b\u0306\u036b\u036f\u034c\u0308\u0314\u0363\u0334\u032b\u0329\u0345 \u0309\u0368\u0313\u0311\u036f\u031a\u0304\u0303\u0338\u031c\u0332\u0329\u0317\u0353\u0347\u0339\u0330\u031d \u0307\u0300\u036e\u033e\u030a\u0346\u033d\u0344\u035e\u035e\u032b\u031f\u0323\u033b\u0349\u0320\u032ff\u0344\u036d\u0307\u030f\u031c\u0349\u0332\u032c\u031e\u031f\u032aa\u0300\u0365\u030e\u0303\u031a\u0357\u035e\u0335\u0347\u033c\u031dt\u0303\u031a\u036a\u0363\u034b\u0314\u0369\u0310\u0336\u0320\u031f\u034d\u0348e\u0352\u035b\u0356,\u0300\u0309\u0310\u0361\u032f\u032b\u0319\u0329\u031c \u030a\u0306\u0365\u035b\u0306\u0349\u031f\u034d \u035b\u0344\u0352\u034c\u0308\u0346\u0302\u036d\u0340\u0334\u0489\u0345\u0355\u032a\u0329\u031f\u0319\u0319\u0354\u034d \u036f\u0369\u0314\u0363\u034a\u0313\u0313\u036a\u0327\u0319\u0339\u0347h\u0365\u0369\u036c\u0301\u0365\u031a\u034b\u033f\u035e\u0334\u035d\u0316\u0349\u031e\u0324\u0353\u033c\u034da\u0357\u0313\u0342\u0340\u0340\u0356\u0318\u0359\u0326\u0326\u034dv\u0307\u0303\u0342\u036c\u036d\u0310\u035f\u0348\u0324e\u030e\u034b\u0344\u0344\u0300\u0311\u035b\u0342\u0336\u0362\u0331\u0355\u0349\u032a\u0339\u0329\u033bn\u0314\u033d\u033d\u030d\u0314\u0300\u0306\u0321\u0361\u0348\u0339\u0317'\u036e\u036a\u034f\u031f\u0324\u0347\u0348\u031et\u036c\u0305\u0364\u0304\u030e\u0352\u0364\u034a\u035e\u0360\u0341\u0348\u035a\u0348\u034d\u0317\u0359\u0316 \u0312\u030e\u0334\u033b\u032f\u0354\u0325 \u0304\u030a\u0330\u0353\u0326\u0325 \u030f\u0303\u0304\u034a\u034a\u0300\u0321\u0338\u0339\u0333\u0332\u0325\u0317\u032d\u033b\u031ey\u0309\u0313\u0365\u0310\u030d\u0305\u036e\u035d\u0329\u033b\u031d\u032f\u0349\u031e\u0353o\u030f\u0366\u0369\u034b\u0352\u0335\u031b\u0326\u0326\u0329\u0339\u0319\u032c\u032c\u031c\u0319u\u0304\u0369\u0342\u0310\u0366\u0327\u031e\u0317 \u0363\u0346\u030d\u030c\u0301\u0303\u0304\u030d\u035e\u0362\u033b\u031f\u0324\u033c\u0324\u0323\u0316 \u0365\u0302\u0358\u0340\u031d\u0345 \u0366\u0346\u033d\u034f\u0341\u031c?\u036b\u034a\u0352\u036e\u0351\u0306\u036b\u030c\u0358\u0360\u033b\u0320\u0318\u032a\u0333", "");
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Skullkid.wav", AudioPlayMode.Background);
				this.PictureBox1.Visible = false;
				try
				{
					File.WriteAllText(this.appPath + "\\datas\\game2ad.dat", "thirdgame");
				}
				catch (Exception ex)
				{
				}
				this.TimerYes.Start();
				base.Hide();
			}
			if (Operators.ConditionalCompareObjectEqual(this.yesSec, 36, false))
			{
				this.TimerYes.Stop();
				this.yesSec = 50;
				MyProject.Computer.Audio.Stop();
				MyProject.Forms.ThirdGame.Show();
				base.Close();
			}
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0000D9EC File Offset: 0x0000BBEC
		private void TimerNo_Tick(object sender, EventArgs e)
		{
			this.noSec = Operators.SubtractObject(this.noSec, 1);
			if (Operators.ConditionalCompareObjectEqual(this.noSec, 48, false))
			{
				this.TimerNo.Stop();
				MessageBox.Show("rIgHT.", "");
				this.TimerNo.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.noSec, 46, false))
			{
				this.TimerNo.Stop();
				MessageBox.Show("sO i gUEsS...", "");
				this.TimerNo.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.noSec, 44, false))
			{
				this.TimerNo.Stop();
				MessageBox.Show("wE cAN gO. . .", "");
				try
				{
					File.WriteAllText(this.appPath + "\\datas\\game2ad.dat", "thirdgame");
				}
				catch (Exception ex)
				{
				}
				this.TimerNo.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.noSec, 42, false))
			{
				this.canQuit = true;
				this.TimerNo.Stop();
				this.noSec = 50;
				this.PictureBox1.Image = Resources.Moshed3D2;
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Laughing.wav", AudioPlayMode.BackgroundLoop);
				MessageBox.Show("TO  \u0321\u0328 \u035d \u0337\u0360TH\u0338\u035c\u0340E\u0340\u0328\u0489 \u035d \u0315 \u034fNE\u0315\u0334X\u0337T\u035e\u0336\u0341 \u0334\u034f \u034f\u0337 \u0362GA\u035cM\u0361\u031bE\u0358", "S\u0334\u0358\u0335A\u0335\u0338\u0341\u0361\u0315V\u0315\u0361E\u035f\u0340\u0361\u0338Y\u0322\u035f\u0322O\u034f\u035c\u0327\u0489U\u0334\u034f\u0489\u0338R\u0341\u0341\u0327S\u0334\u0327\u0362E\u0335\u0361\u0362L\u0336\u0328\u0360\u0362F\u0362\u031b\u0341\u031b");
				MyProject.Computer.Audio.Stop();
				this.PictureBox1.Visible = false;
				base.Hide();
				MyProject.Forms.ThirdGame.Show();
				base.Close();
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0000DBA8 File Offset: 0x0000BDA8
		private void nextSecondGame_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!this.canQuit)
			{
				e.Cancel = true;
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0000DBB9 File Offset: 0x0000BDB9
		private void PictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x04000073 RID: 115
		private string appPath;

		// Token: 0x04000074 RID: 116
		private object sec;

		// Token: 0x04000075 RID: 117
		private object yesSec;

		// Token: 0x04000076 RID: 118
		private object noSec;

		// Token: 0x04000077 RID: 119
		private bool canQuit;
	}
}
