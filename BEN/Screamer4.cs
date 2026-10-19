using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using BEN.My;
using BEN.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace BEN
{
	// Token: 0x02000019 RID: 25
	[DesignerGenerated]
	public partial class Screamer4 : Form
	{
		// Token: 0x0600013A RID: 314 RVA: 0x0000EE88 File Offset: 0x0000D088
		public Screamer4()
		{
			base.Load += this.Screamer4_Load;
			base.FormClosing += this.Screamer4_FormClosing;
			this.sec = 50;
			this.appPath = Application.StartupPath;
			this.InitializeComponent();
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600013D RID: 317 RVA: 0x0000F094 File Offset: 0x0000D294
		// (set) Token: 0x0600013E RID: 318 RVA: 0x0000F09C File Offset: 0x0000D29C
		internal virtual PictureBox PictureBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600013F RID: 319 RVA: 0x0000F0A5 File Offset: 0x0000D2A5
		// (set) Token: 0x06000140 RID: 320 RVA: 0x0000F0B0 File Offset: 0x0000D2B0
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

		// Token: 0x06000141 RID: 321 RVA: 0x0000F0F4 File Offset: 0x0000D2F4
		private void Screamer4_Load(object sender, EventArgs e)
		{
			Cursor.Hide();
			this.PictureBox1.Image = Resources.MoshedShake3;
			MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Mega10Loop.wav", AudioPlayMode.BackgroundLoop);
			this.PictureBox1.Visible = true;
			this.Timer1.Start();
		}

		// Token: 0x06000142 RID: 322 RVA: 0x0000F14D File Offset: 0x0000D34D
		private void Screamer4_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
		}

		// Token: 0x06000143 RID: 323 RVA: 0x0000F158 File Offset: 0x0000D358
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.sec = Operators.SubtractObject(this.sec, 1);
			if (Operators.ConditionalCompareObjectEqual(this.sec, 48, false))
			{
				this.Timer1.Stop();
				this.sec = 50;
				Cursor.Show();
				MessageBox.Show("C\u034b\u0310\u035b\u036c\u032f\u0320\u0359H\u0351\u0344\u0344\u035b\u0311\u0308\u036d\u033aE\u034a\u0313\u0358\u0318\u034d\u0348A\u0342\u030a\u030f\u0331\u0317\u0359\u0316\u033b\u033c\u034dT\u0342\u033f\u0367\u030a\u0310\u0357IN\u030f\u0325\u0359\u0355\u031eG\u030d\u030d\u0369\u0301\u0312\u033c\u031c\u0324\u0347 \u0365\u036b\u0321\u032d\u031e\u0326\u031f \u0363\u036c\u0310\u0353\u0323\u034d\u032a \u0366\u036e\u036f\u0306\u0369\u0302\u030f\u032fI\u0366\u033d\u0305\u036cS\u0312\u0304\u034d \u031a\u0367\u030f\u030c\u0309\u0310\u0340\u032d\u032f\u0330\u0348 \u0302\u0366\u036d\u0351\u034a\u0300\u0331\u032c\u0356 \u0350\u0344\u036b\u032c\u034eN\u030f\u0305\u030a\u034a\u035bO\u0359\u0325\u0353\u0325\u033aT\u0346\u033e\u0369\u0309\u033f\u0313\u031a\u0326\u032f\u032a\u0325\u033c\u0320\u033b \u0309\u0312\u036f\u0361 \u035b\u036e\u030f\u0305\u0306\u0334\u031c\u0353\u033c\u0330\u0348\u0331 \u0300\u033e\u0363\u0306\u030c\u0300\u030f\u0340\u032c\u0359\u0333\u0331\u034d\u0319A\u0343\u031f\u033c\u0345LL\u0308\u0350\u035d\u0349\u034dO\u0362W\u0369\u0301\u0366\u035a\u0345\u035a\u033b\u033b\u0355\u0345E\u0365\u030c\u0309\u0305\u033fD\u036a\u0352\u0351\u030d\u033f\u0322\u0329\u032d\u0348.", "");
				MyProject.Computer.Audio.Stop();
				base.Hide();
				MyProject.Forms.ThirdGame.Show();
				MyProject.Forms.ThirdGame.MoveToStart();
				MyProject.Forms.ThirdGame.reputMusic();
				base.Close();
			}
		}

		// Token: 0x04000098 RID: 152
		private object sec;

		// Token: 0x04000099 RID: 153
		private string appPath;
	}
}
