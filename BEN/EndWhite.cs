using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using BEN.My;
using Microsoft.VisualBasic.CompilerServices;

namespace BEN
{
	// Token: 0x0200000C RID: 12
	[DesignerGenerated]
	public partial class EndWhite : Form
	{
		// Token: 0x06000081 RID: 129 RVA: 0x00004970 File Offset: 0x00002B70
		public EndWhite()
		{
			base.Load += this.EndWhite_Load;
			base.Closing += this.EndWhite_Closing;
			this.sec = 50;
			this.appPath = Application.StartupPath;
			this.InitializeComponent();
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00004AD4 File Offset: 0x00002CD4
		// (set) Token: 0x06000085 RID: 133 RVA: 0x00004ADC File Offset: 0x00002CDC
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

		// Token: 0x06000086 RID: 134
		[DllImport("user32", CharSet = CharSet.Ansi, EntryPoint = "SystemParametersInfoA", ExactSpelling = true, SetLastError = true)]
		private static extern int SystemParametersInfo(int uAction, int uParam, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpvParam, int fuwinIni);

		// Token: 0x06000087 RID: 135 RVA: 0x00004B1F File Offset: 0x00002D1F
		private void EndWhite_Load(object sender, EventArgs e)
		{
			base.Activate();
			this.Fade(2500, "Show");
			this.Timer1.Start();
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00004B44 File Offset: 0x00002D44
		public void Fade(int Time, string Type)
		{
			if (Operators.CompareString(Type, "Show", false) == 0)
			{
				base.Opacity = 0.0;
				base.Show();
				int tickCount = MyProject.Computer.Clock.TickCount;
				int i;
				while (i < Time)
				{
					i = checked(MyProject.Computer.Clock.TickCount - tickCount);
					base.Opacity = (double)i / (double)Time;
					Application.DoEvents();
				}
				return;
			}
			if (Operators.CompareString(Type, "Hide", false) != 0)
			{
				return;
			}
			base.Opacity = 1.0;
			int tickCount2 = MyProject.Computer.Clock.TickCount;
			int j;
			while (j < Time)
			{
				j = checked(MyProject.Computer.Clock.TickCount - tickCount2);
				base.Opacity = 1.0 - 1.0 / ((double)Time / (double)j);
				Application.DoEvents();
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00004C1B File Offset: 0x00002E1B
		private void EndWhite_Closing(object sender, CancelEventArgs e)
		{
			e.Cancel = true;
			this.Fade(4500, "Hide");
			MyProject.Forms.Andcredits.Show();
			e.Cancel = false;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00004C4C File Offset: 0x00002E4C
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.sec = Operators.SubtractObject(this.sec, 1);
			if (Operators.ConditionalCompareObjectEqual(this.sec, 49, false))
			{
				this.imgLink = this.appPath + "\\assets\\pictures\\BenWpperOff.jpg";
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 45, false))
			{
				try
				{
					EndWhite.SystemParametersInfo(20, 0, ref this.imgLink, 1);
				}
				catch (Exception ex)
				{
				}
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 44, false))
			{
				try
				{
					File.WriteAllText(this.appPath + "\\datas\\game2ad.dat", "credits");
				}
				catch (Exception ex2)
				{
				}
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 43, false))
			{
				try
				{
					File.WriteAllText(this.appPath + "\\datas\\fnshd.dat", "yes");
				}
				catch (Exception ex3)
				{
				}
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 40, false))
			{
				this.Timer1.Stop();
				this.sec = 50;
				base.Close();
			}
		}

		// Token: 0x04000026 RID: 38
		private object sec;

		// Token: 0x04000027 RID: 39
		private string appPath;

		// Token: 0x04000028 RID: 40
		private string imgLink;

		// Token: 0x04000029 RID: 41
		private const int SETDESKWALL = 20;

		// Token: 0x0400002A RID: 42
		private const int UPDATEINIFILE = 1;
	}
}
