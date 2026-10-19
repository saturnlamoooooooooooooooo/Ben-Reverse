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
	// Token: 0x02000016 RID: 22
	[DesignerGenerated]
	public partial class Scream1 : Form
	{
		// Token: 0x0600011D RID: 285 RVA: 0x0000E50B File Offset: 0x0000C70B
		public Scream1()
		{
			base.Load += this.Scream1_Load;
			this.sec = 5;
			this.son = new SoundPlayer(Resources._7);
			this.InitializeComponent();
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000120 RID: 288 RVA: 0x0000E70E File Offset: 0x0000C90E
		// (set) Token: 0x06000121 RID: 289 RVA: 0x0000E716 File Offset: 0x0000C916
		internal virtual PictureBox PictureBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000122 RID: 290 RVA: 0x0000E71F File Offset: 0x0000C91F
		// (set) Token: 0x06000123 RID: 291 RVA: 0x0000E728 File Offset: 0x0000C928
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

		// Token: 0x06000124 RID: 292 RVA: 0x0000E76B File Offset: 0x0000C96B
		private void Scream1_Load(object sender, EventArgs e)
		{
			Cursor.Hide();
			NewLateBinding.LateCall(this.son, null, "Play", new object[0], null, null, null, true);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0000E790 File Offset: 0x0000C990
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.sec = Operators.SubtractObject(this.sec, 1);
			if (Operators.ConditionalCompareObjectEqual(this.sec, 4, false))
			{
				this.PictureBox1.Image = Resources.MOSHED_2018_11_16_0_22_24;
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 2, false))
			{
				NewLateBinding.LateCall(this.son, null, "stop", new object[0], null, null, null, true);
				Cursor.Show();
				MyProject.Forms.Openfiles2.Show();
				base.Close();
			}
		}

		// Token: 0x04000089 RID: 137
		private object sec;

		// Token: 0x0400008A RID: 138
		private object son;
	}
}
