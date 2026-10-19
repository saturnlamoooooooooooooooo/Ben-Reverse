using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Media;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using BEN.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

namespace BEN
{
	// Token: 0x02000018 RID: 24
	[DesignerGenerated]
	public partial class Screamer3 : Form
	{
		// Token: 0x06000130 RID: 304 RVA: 0x0000EB98 File Offset: 0x0000CD98
		public Screamer3()
		{
			base.Load += this.Screamer3_Load;
			base.FormClosing += this.Screamer3_FormClosing;
			this.appPath = Application.StartupPath;
			this.sec = 5;
			this.InitializeComponent();
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000133 RID: 307 RVA: 0x0000ED97 File Offset: 0x0000CF97
		// (set) Token: 0x06000134 RID: 308 RVA: 0x0000EDA0 File Offset: 0x0000CFA0
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

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000135 RID: 309 RVA: 0x0000EDE3 File Offset: 0x0000CFE3
		// (set) Token: 0x06000136 RID: 310 RVA: 0x0000EDEB File Offset: 0x0000CFEB
		internal virtual PictureBox PictureBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x0000EDF4 File Offset: 0x0000CFF4
		private void Screamer3_Load(object sender, EventArgs e)
		{
			Cursor.Hide();
			this.PictureBox1.Image = Image.FromFile(this.appPath + "\\assets\\gifs\\MoshedBenblackRoll.gif");
			new SoundPlayer(Resources.mega6).Play();
			this.PictureBox1.Visible = true;
			this.Timer1.Start();
		}

		// Token: 0x06000138 RID: 312 RVA: 0x0000EE4C File Offset: 0x0000D04C
		private void Screamer3_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x0000EE55 File Offset: 0x0000D055
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.sec = Operators.SubtractObject(this.sec, 1);
			if (Operators.ConditionalCompareObjectEqual(this.sec, 3, false))
			{
				ProjectData.EndApp();
			}
		}

		// Token: 0x04000093 RID: 147
		private string appPath;

		// Token: 0x04000094 RID: 148
		private object sec;
	}
}
