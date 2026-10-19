using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Media;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using BEN.My;
using BEN.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace BEN
{
	// Token: 0x0200001C RID: 28
	[DesignerGenerated]
	public partial class Talking3 : Form
	{
		// Token: 0x060002AC RID: 684 RVA: 0x0001C0C0 File Offset: 0x0001A2C0
		public Talking3()
		{
			base.Load += this.Talking3_Load;
			base.FormClosing += this.Talking3_FormClosing;
			this.sec = 30;
			this.appPath = Application.StartupPath;
			this.canquit = false;
			this.InitializeComponent();
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060002AF RID: 687 RVA: 0x0001C2ED File Offset: 0x0001A4ED
		// (set) Token: 0x060002B0 RID: 688 RVA: 0x0001C2F8 File Offset: 0x0001A4F8
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

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060002B1 RID: 689 RVA: 0x0001C33B File Offset: 0x0001A53B
		// (set) Token: 0x060002B2 RID: 690 RVA: 0x0001C343 File Offset: 0x0001A543
		internal virtual PictureBox PictureBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x0001C34C File Offset: 0x0001A54C
		private void Talking3_Load(object sender, EventArgs e)
		{
			base.KeyPreview = true;
			Cursor.Hide();
			this.Timer1.Start();
			MyProject.Computer.Audio.Play(this.appPath + "\\assets\\BenMusic1.wav", AudioPlayMode.BackgroundLoop);
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0001C388 File Offset: 0x0001A588
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.sec = Operators.SubtractObject(this.sec, 1);
			if (Operators.ConditionalCompareObjectEqual(this.sec, 26, false))
			{
				this.Timer1.Stop();
				Cursor.Show();
				MessageBox.Show("h\u0336\u035d\u0310\u031c\u031d\u033ae\u0338\u031b\u0328\u0320\u0339l\u0336\u0341\u0302\u032a\u032dL\u0335\u035b\u0349\u032fO\u0336\u034b\u0307\u0319\u032e\u0345", "");
				this.Timer1.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 22, false))
			{
				this.Timer1.Stop();
				MessageBox.Show("t\u0337\u030a\u033d\u0347h\u0334\u031a\u032f\u032aa\u0338\u0307\u0328\u0348N\u0338\u034a\u0305\u0347\u0317K\u0335\u030a\u0320 \u0334\u0346\u0313\u0324\u0325 \u0334\u035d\u0301\u034e \u0335\u031b\u033e\u035cy\u0335\u0307\u0332\u0347O\u0338\u0314\u0315\u0326U\u0336\u0342\u0309\u032c \u0335\u034a\u0329\u0324 \u0338\u030a\u0319\u0324 \u0336\u033d\u0332\u0355v\u0336\u034a\u0358\u0339\u0317E\u0335\u0305\u0331\u035cr\u0337\u0309\u035d\u0319\u0339Y\u0336\u0352\u032f \u0338\u035d\u033e\u0339 \u0334\u033e\u033c \u0336\u031b\u0352\u0347 \u0334\u0313\u035b\u034dm\u0335\u0358\u035d\u032eu\u0337\u0314\u0323C\u0337\u0312\u0301\u0355H\u0337\u031b\u030e\u032f", "");
				this.Timer1.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 18, false))
			{
				this.Timer1.Stop();
				MessageBox.Show("b\u0335\u033f\u032d\u0339E\u0334\u0305\u0357\u0322\u0324C\u0336\u0340\u0358\u0331\u0331A\u0336\u035d\u0344\u0354\u035au\u0336\u0309\u035a\u0325S\u0334\u030f\u0354\u0317e\u0336\u031b\u032b", "");
				this.Timer1.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 14, false))
			{
				this.Timer1.Stop();
				MessageBox.Show("I \u0337\u030c\u0344\u0325 \u0335\u0314\u0355    \u0338\u0344\u0310\u032c \u0337\u0304\u034d\u035a \u0335\u0344\u0340\u0356a\u0337\u030d\u0349\u031eM\u0336\u030f\u0343\u032c \u0338\u0357\u030a\u032e\u031e \u0335\u0315\u032e    \u0337\u030d\u0340\u0356\u033c \u0338\u033e\u0304\u031c\u032f \u0335\u030a\u030f\u0348\u0356 f\u0337\u033e\u034a\u0320r\u0334\u0314\u031d\u0330E\u0338\u0307\u030c\u033cE\u0335\u0302\u0358\u0339", "");
				this.Timer1.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 10, false))
			{
				MyProject.Computer.Audio.Stop();
				this.PictureBox1.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 8, false))
			{
				this.Timer1.Stop();
				this.PictureBox1.Image = Image.FromFile(this.appPath + "\\assets\\gifs\\YOUARESTUCKED.gif");
				MessageBox.Show("b\u0338\u030b\u0358\u032a\u035cu\u0337\u0306\u035b\u035a\u0318T\u0334\u0344\u0331 \u0334\u034c\u0328 \u0338\u0342\u0317 \u0334\u0358\u0349\u0354 \u0335\u0342\u032d\u0332y\u0334\u0303\u0347\u033co\u0334\u0315\u032d\u0329U\u0334\u0350\u035d\u0345 .  . .", "");
				this.Timer1.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 5, false))
			{
				new SoundPlayer(Resources.mega1).Play();
				this.PictureBox1.Visible = true;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 4, false))
			{
				new SoundPlayer(Resources._9).Play();
				this.PictureBox1.Image = Resources.MOSHED_2018_11_16_0_22_24;
				this.PictureBox1.Visible = true;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 1, false))
			{
				new SoundPlayer(Resources._9).Stop();
				this.Timer1.Stop();
				this.sec = 30;
				this.canquit = true;
				this.PictureBox1.Dispose();
				this.PictureBox1.Visible = false;
				base.Hide();
				MyProject.Forms.Game1.Show();
				base.Close();
			}
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x0001C609 File Offset: 0x0001A809
		private void Talking3_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!this.canquit)
			{
				e.Cancel = true;
			}
		}

		// Token: 0x04000120 RID: 288
		private object sec;

		// Token: 0x04000121 RID: 289
		private string appPath;

		// Token: 0x04000122 RID: 290
		private bool canquit;
	}
}
