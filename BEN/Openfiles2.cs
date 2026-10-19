using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Media;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using BEN.My;
using BEN.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

namespace BEN
{
	// Token: 0x02000014 RID: 20
	[DesignerGenerated]
	public partial class Openfiles2 : Form
	{
		// Token: 0x06000106 RID: 262 RVA: 0x0000DBBC File Offset: 0x0000BDBC
		public Openfiles2()
		{
			base.Load += this.Openfiles2_Load;
			this.sec = 500;
			this.secSave = 10;
			this.son = new SoundPlayer(Resources._1);
			this.appPath = Application.StartupPath;
			this.InitializeComponent();
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000109 RID: 265 RVA: 0x0000DE28 File Offset: 0x0000C028
		// (set) Token: 0x0600010A RID: 266 RVA: 0x0000DE30 File Offset: 0x0000C030
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

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600010B RID: 267 RVA: 0x0000DE73 File Offset: 0x0000C073
		// (set) Token: 0x0600010C RID: 268 RVA: 0x0000DE7C File Offset: 0x0000C07C
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

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600010D RID: 269 RVA: 0x0000DEBF File Offset: 0x0000C0BF
		// (set) Token: 0x0600010E RID: 270 RVA: 0x0000DEC7 File Offset: 0x0000C0C7
		internal virtual PictureBox PictureBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0000DED0 File Offset: 0x0000C0D0
		private void Openfiles2_Load(object sender, EventArgs e)
		{
			base.KeyPreview = true;
			this.PictureBox1.Image = Image.FromFile(this.appPath + "\\assets\\gifs\\Glitch.gif");
			NewLateBinding.LateCall(this.son, null, "Play", new object[0], null, null, null, true);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0000DF20 File Offset: 0x0000C120
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.sec = Operators.SubtractObject(this.sec, 1);
			if (Operators.ConditionalCompareObjectEqual(this.sec, 499, false))
			{
				try
				{
					Process.Start(this.appPath + "\\datas\\others\\WHAT HAVE YOU DONE.txt");
				}
				catch (Exception ex)
				{
				}
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 496, false))
			{
				try
				{
					Process.Start(this.appPath + "\\datas\\others\\ENOD UOY EVAH TAHW.txt");
				}
				catch (Exception ex2)
				{
				}
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 493, false))
			{
				this.sec = 500;
			}
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0000E000 File Offset: 0x0000C200
		private void Timer2_Tick(object sender, EventArgs e)
		{
			this.secSave = Operators.SubtractObject(this.secSave, 1);
			if (Operators.ConditionalCompareObjectEqual(this.secSave, 5, false))
			{
				foreach (Process process in Process.GetProcessesByName("notepad"))
				{
					try
					{
						process.Kill();
					}
					catch (Exception ex)
					{
					}
				}
				NewLateBinding.LateCall(this.son, null, "Stop", new object[0], null, null, null, true);
				MyProject.Forms.Talking3.Show();
				base.Close();
			}
		}

		// Token: 0x0400007C RID: 124
		private object sec;

		// Token: 0x0400007D RID: 125
		private object secSave;

		// Token: 0x0400007E RID: 126
		private object son;

		// Token: 0x0400007F RID: 127
		private string appPath;
	}
}
