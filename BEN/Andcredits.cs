using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using BEN.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace BEN
{
	// Token: 0x02000008 RID: 8
	[DesignerGenerated]
	public partial class Andcredits : Form
	{
		// Token: 0x06000050 RID: 80 RVA: 0x000028C4 File Offset: 0x00000AC4
		public Andcredits()
		{
			base.Load += this.Andcredits_Load;
			base.FormClosing += this.Andcredits_FormClosing;
			this.appPath = Application.StartupPath;
			this.canQuit = false;
			this.sec = 50;
			this.InitializeComponent();
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00002AC8 File Offset: 0x00000CC8
		// (set) Token: 0x06000054 RID: 84 RVA: 0x00002AD0 File Offset: 0x00000CD0
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

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00002B13 File Offset: 0x00000D13
		// (set) Token: 0x06000056 RID: 86 RVA: 0x00002B1B File Offset: 0x00000D1B
		internal virtual PictureBox PictureBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002B24 File Offset: 0x00000D24
		private void Andcredits_Load(object sender, EventArgs e)
		{
			MyProject.Computer.Audio.Play(this.appPath + "\\assets\\EndingSong.wav", AudioPlayMode.Background);
			this.Timer1.Start();
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002B51 File Offset: 0x00000D51
		private void Andcredits_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!this.canQuit)
			{
				e.Cancel = true;
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002B64 File Offset: 0x00000D64
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.sec = Operators.SubtractObject(this.sec, 1);
			if (Operators.ConditionalCompareObjectEqual(this.sec, 49, false))
			{
				this.PictureBox1.Visible = true;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 48, false))
			{
				this.PictureBox1.Image = Image.FromFile(this.appPath + "\\assets\\gifs\\Noise.gif");
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 47, false))
			{
				this.PictureBox1.Image = Image.FromFile(this.appPath + "\\assets\\pictures\\credits\\C1.jpg");
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 45, false))
			{
				this.PictureBox1.Image = Image.FromFile(this.appPath + "\\assets\\gifs\\Noise.gif");
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 44, false))
			{
				this.PictureBox1.Image = Image.FromFile(this.appPath + "\\assets\\pictures\\credits\\C2.jpg");
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 41, false))
			{
				this.PictureBox1.Image = Image.FromFile(this.appPath + "\\assets\\gifs\\Noise.gif");
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 40, false))
			{
				this.PictureBox1.Image = Image.FromFile(this.appPath + "\\assets\\pictures\\credits\\C3.jpg");
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 37, false))
			{
				this.PictureBox1.Image = Image.FromFile(this.appPath + "\\assets\\gifs\\Noise.gif");
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 36, false))
			{
				this.PictureBox1.Image = Image.FromFile(this.appPath + "\\assets\\pictures\\credits\\C4.jpg");
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 33, false))
			{
				this.PictureBox1.Image = Image.FromFile(this.appPath + "\\assets\\gifs\\Noise.gif");
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 32, false))
			{
				this.PictureBox1.Image = Image.FromFile(this.appPath + "\\assets\\pictures\\credits\\C5.jpg");
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 29, false))
			{
				this.PictureBox1.Image = Image.FromFile(this.appPath + "\\assets\\gifs\\Noise.gif");
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 28, false))
			{
				this.PictureBox1.Image = Image.FromFile(this.appPath + "\\assets\\pictures\\credits\\C6.jpg");
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 25, false))
			{
				this.PictureBox1.Image = Image.FromFile(this.appPath + "\\assets\\gifs\\Noise.gif");
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 24, false))
			{
				this.PictureBox1.Image = Image.FromFile(this.appPath + "\\assets\\pictures\\credits\\C7.jpg");
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 21, false))
			{
				this.PictureBox1.Image = Image.FromFile(this.appPath + "\\assets\\gifs\\Noise.gif");
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 20, false))
			{
				this.PictureBox1.Image = Image.FromFile(this.appPath + "\\assets\\pictures\\credits\\C8.jpg");
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 17, false))
			{
				this.PictureBox1.Image = Image.FromFile(this.appPath + "\\assets\\gifs\\Noise.gif");
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 16, false))
			{
				this.PictureBox1.Image = Image.FromFile(this.appPath + "\\assets\\pictures\\credits\\C9.jpg");
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 13, false))
			{
				this.PictureBox1.Image = Image.FromFile(this.appPath + "\\assets\\gifs\\Noise.gif");
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 12, false))
			{
				this.PictureBox1.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 11, false))
			{
				try
				{
					File.WriteAllText(this.appPath + "\\datas\\game2ad.dat", "no");
				}
				catch (Exception ex)
				{
				}
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 10, false))
			{
				try
				{
					File.WriteAllText(this.appPath + "\\datas\\gamedataDeath1.dat", "");
				}
				catch (Exception ex2)
				{
				}
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 7, false))
			{
				this.PictureBox1.Visible = true;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 6, false))
			{
				this.PictureBox1.Image = Image.FromFile(this.appPath + "\\assets\\pictures\\credits\\TBC1.jpg");
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 3, false))
			{
				this.PictureBox1.Image = Image.FromFile(this.appPath + "\\assets\\gifs\\Noise.gif");
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 2, false))
			{
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Skullkid.wav", AudioPlayMode.Background);
				this.PictureBox1.Image = Image.FromFile(this.appPath + "\\assets\\gifs\\credits\\TBC2.gif");
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, -1, false))
			{
				this.PictureBox1.Visible = false;
				this.canQuit = true;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, -3, false))
			{
				this.Timer1.Stop();
				this.sec = 50;
				MyProject.Forms.Contactme.Show();
				base.Close();
			}
		}

		// Token: 0x0400000E RID: 14
		private string appPath;

		// Token: 0x0400000F RID: 15
		private bool canQuit;

		// Token: 0x04000010 RID: 16
		private object sec;
	}
}
