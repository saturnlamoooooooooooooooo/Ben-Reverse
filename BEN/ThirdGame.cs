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
	// Token: 0x0200001D RID: 29
	[DesignerGenerated]
	public partial class ThirdGame : Form
	{
		// Token: 0x060002B6 RID: 694 RVA: 0x0001C61C File Offset: 0x0001A81C
		public ThirdGame()
		{
			base.Load += this.ThirdGame_Load;
			base.FormClosing += this.ThirdGame_FormClosing;
			this.appPath = Application.StartupPath;
			this.tsec = 5;
			this.sec = 51;
			this.cheatsec = 50;
			this.legitsec = 50;
			this.decompo = 93;
			this.youCanGo = false;
			this.cheatingCount = 0;
			this.ShakeCount = 0;
			this.alreadyGetScreamer = false;
			this.InitializeComponent();
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060002B9 RID: 697 RVA: 0x0001F3A2 File Offset: 0x0001D5A2
		// (set) Token: 0x060002BA RID: 698 RVA: 0x0001F3AC File Offset: 0x0001D5AC
		internal virtual Panel Panel2
		{
			[CompilerGenerated]
			get
			{
				return this._Panel2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Panel panel = this._Panel2;
				if (panel != null)
				{
					panel.MouseEnter -= eventHandler;
				}
				this._Panel2 = value;
				panel = this._Panel2;
				if (panel != null)
				{
					panel.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060002BB RID: 699 RVA: 0x0001F3EF File Offset: 0x0001D5EF
		// (set) Token: 0x060002BC RID: 700 RVA: 0x0001F3F8 File Offset: 0x0001D5F8
		internal virtual Panel Panel1
		{
			[CompilerGenerated]
			get
			{
				return this._Panel1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Panel panel = this._Panel1;
				if (panel != null)
				{
					panel.MouseEnter -= eventHandler;
				}
				this._Panel1 = value;
				panel = this._Panel1;
				if (panel != null)
				{
					panel.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060002BD RID: 701 RVA: 0x0001F43B File Offset: 0x0001D63B
		// (set) Token: 0x060002BE RID: 702 RVA: 0x0001F444 File Offset: 0x0001D644
		internal virtual Panel Panel4
		{
			[CompilerGenerated]
			get
			{
				return this._Panel4;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Panel panel = this._Panel4;
				if (panel != null)
				{
					panel.MouseEnter -= eventHandler;
				}
				this._Panel4 = value;
				panel = this._Panel4;
				if (panel != null)
				{
					panel.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060002BF RID: 703 RVA: 0x0001F487 File Offset: 0x0001D687
		// (set) Token: 0x060002C0 RID: 704 RVA: 0x0001F48F File Offset: 0x0001D68F
		internal virtual Panel pointDepart
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060002C1 RID: 705 RVA: 0x0001F498 File Offset: 0x0001D698
		// (set) Token: 0x060002C2 RID: 706 RVA: 0x0001F4A0 File Offset: 0x0001D6A0
		internal virtual Label Label1
		{
			[CompilerGenerated]
			get
			{
				return this._Label1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._Label1;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._Label1 = value;
				label = this._Label1;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x0001F4E3 File Offset: 0x0001D6E3
		// (set) Token: 0x060002C4 RID: 708 RVA: 0x0001F4EC File Offset: 0x0001D6EC
		internal virtual Label Label2
		{
			[CompilerGenerated]
			get
			{
				return this._Label2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._Label2;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._Label2 = value;
				label = this._Label2;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060002C5 RID: 709 RVA: 0x0001F52F File Offset: 0x0001D72F
		// (set) Token: 0x060002C6 RID: 710 RVA: 0x0001F538 File Offset: 0x0001D738
		internal virtual Label Label3
		{
			[CompilerGenerated]
			get
			{
				return this._Label3;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._Label3;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._Label3 = value;
				label = this._Label3;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060002C7 RID: 711 RVA: 0x0001F57B File Offset: 0x0001D77B
		// (set) Token: 0x060002C8 RID: 712 RVA: 0x0001F584 File Offset: 0x0001D784
		internal virtual Label Label4
		{
			[CompilerGenerated]
			get
			{
				return this._Label4;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._Label4;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._Label4 = value;
				label = this._Label4;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060002C9 RID: 713 RVA: 0x0001F5C7 File Offset: 0x0001D7C7
		// (set) Token: 0x060002CA RID: 714 RVA: 0x0001F5D0 File Offset: 0x0001D7D0
		internal virtual Label Label5
		{
			[CompilerGenerated]
			get
			{
				return this._Label5;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._Label5;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._Label5 = value;
				label = this._Label5;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060002CB RID: 715 RVA: 0x0001F613 File Offset: 0x0001D813
		// (set) Token: 0x060002CC RID: 716 RVA: 0x0001F61C File Offset: 0x0001D81C
		internal virtual Label Label6
		{
			[CompilerGenerated]
			get
			{
				return this._Label6;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._Label6;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._Label6 = value;
				label = this._Label6;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060002CD RID: 717 RVA: 0x0001F65F File Offset: 0x0001D85F
		// (set) Token: 0x060002CE RID: 718 RVA: 0x0001F668 File Offset: 0x0001D868
		internal virtual PictureBox fakeWin
		{
			[CompilerGenerated]
			get
			{
				return this._fakeWin;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.fakeWin_MouseEnter);
				PictureBox pictureBox = this._fakeWin;
				if (pictureBox != null)
				{
					pictureBox.MouseEnter -= eventHandler;
				}
				this._fakeWin = value;
				pictureBox = this._fakeWin;
				if (pictureBox != null)
				{
					pictureBox.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060002CF RID: 719 RVA: 0x0001F6AB File Offset: 0x0001D8AB
		// (set) Token: 0x060002D0 RID: 720 RVA: 0x0001F6B4 File Offset: 0x0001D8B4
		internal virtual Label Label7
		{
			[CompilerGenerated]
			get
			{
				return this._Label7;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._Label7;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._Label7 = value;
				label = this._Label7;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060002D1 RID: 721 RVA: 0x0001F6F7 File Offset: 0x0001D8F7
		// (set) Token: 0x060002D2 RID: 722 RVA: 0x0001F700 File Offset: 0x0001D900
		internal virtual Label Label8
		{
			[CompilerGenerated]
			get
			{
				return this._Label8;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._Label8;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._Label8 = value;
				label = this._Label8;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060002D3 RID: 723 RVA: 0x0001F743 File Offset: 0x0001D943
		// (set) Token: 0x060002D4 RID: 724 RVA: 0x0001F74C File Offset: 0x0001D94C
		internal virtual Label Label9
		{
			[CompilerGenerated]
			get
			{
				return this._Label9;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._Label9;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._Label9 = value;
				label = this._Label9;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060002D5 RID: 725 RVA: 0x0001F78F File Offset: 0x0001D98F
		// (set) Token: 0x060002D6 RID: 726 RVA: 0x0001F798 File Offset: 0x0001D998
		internal virtual Label Label10
		{
			[CompilerGenerated]
			get
			{
				return this._Label10;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._Label10;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._Label10 = value;
				label = this._Label10;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060002D7 RID: 727 RVA: 0x0001F7DB File Offset: 0x0001D9DB
		// (set) Token: 0x060002D8 RID: 728 RVA: 0x0001F7E4 File Offset: 0x0001D9E4
		internal virtual Panel Panel3
		{
			[CompilerGenerated]
			get
			{
				return this._Panel3;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Panel panel = this._Panel3;
				if (panel != null)
				{
					panel.MouseEnter -= eventHandler;
				}
				this._Panel3 = value;
				panel = this._Panel3;
				if (panel != null)
				{
					panel.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060002D9 RID: 729 RVA: 0x0001F827 File Offset: 0x0001DA27
		// (set) Token: 0x060002DA RID: 730 RVA: 0x0001F830 File Offset: 0x0001DA30
		internal virtual Label Label11
		{
			[CompilerGenerated]
			get
			{
				return this._Label11;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._Label11;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._Label11 = value;
				label = this._Label11;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060002DB RID: 731 RVA: 0x0001F873 File Offset: 0x0001DA73
		// (set) Token: 0x060002DC RID: 732 RVA: 0x0001F87C File Offset: 0x0001DA7C
		internal virtual Label Label12
		{
			[CompilerGenerated]
			get
			{
				return this._Label12;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._Label12;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._Label12 = value;
				label = this._Label12;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060002DD RID: 733 RVA: 0x0001F8BF File Offset: 0x0001DABF
		// (set) Token: 0x060002DE RID: 734 RVA: 0x0001F8C8 File Offset: 0x0001DAC8
		internal virtual Label Label13
		{
			[CompilerGenerated]
			get
			{
				return this._Label13;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._Label13;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._Label13 = value;
				label = this._Label13;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060002DF RID: 735 RVA: 0x0001F90B File Offset: 0x0001DB0B
		// (set) Token: 0x060002E0 RID: 736 RVA: 0x0001F914 File Offset: 0x0001DB14
		internal virtual Label Label14
		{
			[CompilerGenerated]
			get
			{
				return this._Label14;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._Label14;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._Label14 = value;
				label = this._Label14;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x0001F957 File Offset: 0x0001DB57
		// (set) Token: 0x060002E2 RID: 738 RVA: 0x0001F960 File Offset: 0x0001DB60
		internal virtual Label Label15
		{
			[CompilerGenerated]
			get
			{
				return this._Label15;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._Label15;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._Label15 = value;
				label = this._Label15;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x0001F9A3 File Offset: 0x0001DBA3
		// (set) Token: 0x060002E4 RID: 740 RVA: 0x0001F9AC File Offset: 0x0001DBAC
		internal virtual Label Label16
		{
			[CompilerGenerated]
			get
			{
				return this._Label16;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._Label16;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._Label16 = value;
				label = this._Label16;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x0001F9EF File Offset: 0x0001DBEF
		// (set) Token: 0x060002E6 RID: 742 RVA: 0x0001F9F8 File Offset: 0x0001DBF8
		internal virtual Label Label17
		{
			[CompilerGenerated]
			get
			{
				return this._Label17;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._Label17;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._Label17 = value;
				label = this._Label17;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x0001FA3B File Offset: 0x0001DC3B
		// (set) Token: 0x060002E8 RID: 744 RVA: 0x0001FA44 File Offset: 0x0001DC44
		internal virtual Label Label18
		{
			[CompilerGenerated]
			get
			{
				return this._Label18;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._Label18;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._Label18 = value;
				label = this._Label18;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060002E9 RID: 745 RVA: 0x0001FA87 File Offset: 0x0001DC87
		// (set) Token: 0x060002EA RID: 746 RVA: 0x0001FA90 File Offset: 0x0001DC90
		internal virtual Label Label19
		{
			[CompilerGenerated]
			get
			{
				return this._Label19;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._Label19;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._Label19 = value;
				label = this._Label19;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060002EB RID: 747 RVA: 0x0001FAD3 File Offset: 0x0001DCD3
		// (set) Token: 0x060002EC RID: 748 RVA: 0x0001FADC File Offset: 0x0001DCDC
		internal virtual Label Label20
		{
			[CompilerGenerated]
			get
			{
				return this._Label20;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._Label20;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._Label20 = value;
				label = this._Label20;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060002ED RID: 749 RVA: 0x0001FB1F File Offset: 0x0001DD1F
		// (set) Token: 0x060002EE RID: 750 RVA: 0x0001FB28 File Offset: 0x0001DD28
		internal virtual Label Label21
		{
			[CompilerGenerated]
			get
			{
				return this._Label21;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._Label21;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._Label21 = value;
				label = this._Label21;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060002EF RID: 751 RVA: 0x0001FB6B File Offset: 0x0001DD6B
		// (set) Token: 0x060002F0 RID: 752 RVA: 0x0001FB74 File Offset: 0x0001DD74
		internal virtual Label Label22
		{
			[CompilerGenerated]
			get
			{
				return this._Label22;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._Label22;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._Label22 = value;
				label = this._Label22;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060002F1 RID: 753 RVA: 0x0001FBB7 File Offset: 0x0001DDB7
		// (set) Token: 0x060002F2 RID: 754 RVA: 0x0001FBC0 File Offset: 0x0001DDC0
		internal virtual Label Label23
		{
			[CompilerGenerated]
			get
			{
				return this._Label23;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._Label23;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._Label23 = value;
				label = this._Label23;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060002F3 RID: 755 RVA: 0x0001FC03 File Offset: 0x0001DE03
		// (set) Token: 0x060002F4 RID: 756 RVA: 0x0001FC0C File Offset: 0x0001DE0C
		internal virtual Label Label24
		{
			[CompilerGenerated]
			get
			{
				return this._Label24;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._Label24;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._Label24 = value;
				label = this._Label24;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x0001FC4F File Offset: 0x0001DE4F
		// (set) Token: 0x060002F6 RID: 758 RVA: 0x0001FC58 File Offset: 0x0001DE58
		internal virtual Label Label25
		{
			[CompilerGenerated]
			get
			{
				return this._Label25;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._Label25;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._Label25 = value;
				label = this._Label25;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060002F7 RID: 759 RVA: 0x0001FC9B File Offset: 0x0001DE9B
		// (set) Token: 0x060002F8 RID: 760 RVA: 0x0001FCA4 File Offset: 0x0001DEA4
		internal virtual Label Label26
		{
			[CompilerGenerated]
			get
			{
				return this._Label26;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._Label26;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._Label26 = value;
				label = this._Label26;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060002F9 RID: 761 RVA: 0x0001FCE7 File Offset: 0x0001DEE7
		// (set) Token: 0x060002FA RID: 762 RVA: 0x0001FCF0 File Offset: 0x0001DEF0
		internal virtual Label Label28
		{
			[CompilerGenerated]
			get
			{
				return this._Label28;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._Label28;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._Label28 = value;
				label = this._Label28;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060002FB RID: 763 RVA: 0x0001FD33 File Offset: 0x0001DF33
		// (set) Token: 0x060002FC RID: 764 RVA: 0x0001FD3C File Offset: 0x0001DF3C
		internal virtual Label Label29
		{
			[CompilerGenerated]
			get
			{
				return this._Label29;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._Label29;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._Label29 = value;
				label = this._Label29;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060002FD RID: 765 RVA: 0x0001FD7F File Offset: 0x0001DF7F
		// (set) Token: 0x060002FE RID: 766 RVA: 0x0001FD88 File Offset: 0x0001DF88
		internal virtual Label Label30
		{
			[CompilerGenerated]
			get
			{
				return this._Label30;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._Label30;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._Label30 = value;
				label = this._Label30;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060002FF RID: 767 RVA: 0x0001FDCB File Offset: 0x0001DFCB
		// (set) Token: 0x06000300 RID: 768 RVA: 0x0001FDD4 File Offset: 0x0001DFD4
		internal virtual Label Label31
		{
			[CompilerGenerated]
			get
			{
				return this._Label31;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._Label31;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._Label31 = value;
				label = this._Label31;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000301 RID: 769 RVA: 0x0001FE17 File Offset: 0x0001E017
		// (set) Token: 0x06000302 RID: 770 RVA: 0x0001FE20 File Offset: 0x0001E020
		internal virtual Label Label32
		{
			[CompilerGenerated]
			get
			{
				return this._Label32;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._Label32;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._Label32 = value;
				label = this._Label32;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000303 RID: 771 RVA: 0x0001FE63 File Offset: 0x0001E063
		// (set) Token: 0x06000304 RID: 772 RVA: 0x0001FE6C File Offset: 0x0001E06C
		internal virtual Label Label33
		{
			[CompilerGenerated]
			get
			{
				return this._Label33;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._Label33;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._Label33 = value;
				label = this._Label33;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000305 RID: 773 RVA: 0x0001FEAF File Offset: 0x0001E0AF
		// (set) Token: 0x06000306 RID: 774 RVA: 0x0001FEB8 File Offset: 0x0001E0B8
		internal virtual Label Label34
		{
			[CompilerGenerated]
			get
			{
				return this._Label34;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._Label34;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._Label34 = value;
				label = this._Label34;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000307 RID: 775 RVA: 0x0001FEFB File Offset: 0x0001E0FB
		// (set) Token: 0x06000308 RID: 776 RVA: 0x0001FF04 File Offset: 0x0001E104
		internal virtual Label triggerCheater
		{
			[CompilerGenerated]
			get
			{
				return this._triggerCheater;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.triggerCheater_MouseEnter);
				EventHandler eventHandler2 = new EventHandler(this.triggerCheater_Click);
				Label label = this._triggerCheater;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
					label.Click -= eventHandler2;
				}
				this._triggerCheater = value;
				label = this._triggerCheater;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
					label.Click += eventHandler2;
				}
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000309 RID: 777 RVA: 0x0001FF62 File Offset: 0x0001E162
		// (set) Token: 0x0600030A RID: 778 RVA: 0x0001FF6C File Offset: 0x0001E16C
		internal virtual Label Label35
		{
			[CompilerGenerated]
			get
			{
				return this._Label35;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._Label35;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._Label35 = value;
				label = this._Label35;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600030B RID: 779 RVA: 0x0001FFAF File Offset: 0x0001E1AF
		// (set) Token: 0x0600030C RID: 780 RVA: 0x0001FFB8 File Offset: 0x0001E1B8
		internal virtual Label triggerTrap
		{
			[CompilerGenerated]
			get
			{
				return this._triggerTrap;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.triggerTrap_MouseEnter);
				Label label = this._triggerTrap;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._triggerTrap = value;
				label = this._triggerTrap;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600030D RID: 781 RVA: 0x0001FFFB File Offset: 0x0001E1FB
		// (set) Token: 0x0600030E RID: 782 RVA: 0x00020004 File Offset: 0x0001E204
		internal virtual Label Label36
		{
			[CompilerGenerated]
			get
			{
				return this._Label36;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._Label36;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._Label36 = value;
				label = this._Label36;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600030F RID: 783 RVA: 0x00020047 File Offset: 0x0001E247
		// (set) Token: 0x06000310 RID: 784 RVA: 0x00020050 File Offset: 0x0001E250
		internal virtual Label Label37
		{
			[CompilerGenerated]
			get
			{
				return this._Label37;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._Label37;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._Label37 = value;
				label = this._Label37;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000311 RID: 785 RVA: 0x00020093 File Offset: 0x0001E293
		// (set) Token: 0x06000312 RID: 786 RVA: 0x0002009C File Offset: 0x0001E29C
		internal virtual Label Label38
		{
			[CompilerGenerated]
			get
			{
				return this._Label38;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._Label38;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._Label38 = value;
				label = this._Label38;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000313 RID: 787 RVA: 0x000200DF File Offset: 0x0001E2DF
		// (set) Token: 0x06000314 RID: 788 RVA: 0x000200E8 File Offset: 0x0001E2E8
		internal virtual Label Label39
		{
			[CompilerGenerated]
			get
			{
				return this._Label39;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._Label39;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._Label39 = value;
				label = this._Label39;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000315 RID: 789 RVA: 0x0002012B File Offset: 0x0001E32B
		// (set) Token: 0x06000316 RID: 790 RVA: 0x00020134 File Offset: 0x0001E334
		internal virtual Label Label40
		{
			[CompilerGenerated]
			get
			{
				return this._Label40;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._Label40;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._Label40 = value;
				label = this._Label40;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000317 RID: 791 RVA: 0x00020177 File Offset: 0x0001E377
		// (set) Token: 0x06000318 RID: 792 RVA: 0x00020180 File Offset: 0x0001E380
		internal virtual Label Label41
		{
			[CompilerGenerated]
			get
			{
				return this._Label41;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._Label41;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._Label41 = value;
				label = this._Label41;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000319 RID: 793 RVA: 0x000201C3 File Offset: 0x0001E3C3
		// (set) Token: 0x0600031A RID: 794 RVA: 0x000201CC File Offset: 0x0001E3CC
		internal virtual Label Label42
		{
			[CompilerGenerated]
			get
			{
				return this._Label42;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._Label42;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._Label42 = value;
				label = this._Label42;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600031B RID: 795 RVA: 0x0002020F File Offset: 0x0001E40F
		// (set) Token: 0x0600031C RID: 796 RVA: 0x00020218 File Offset: 0x0001E418
		internal virtual Label Label43
		{
			[CompilerGenerated]
			get
			{
				return this._Label43;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._Label43;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._Label43 = value;
				label = this._Label43;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x0600031D RID: 797 RVA: 0x0002025B File Offset: 0x0001E45B
		// (set) Token: 0x0600031E RID: 798 RVA: 0x00020264 File Offset: 0x0001E464
		internal virtual Label Label44
		{
			[CompilerGenerated]
			get
			{
				return this._Label44;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._Label44;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._Label44 = value;
				label = this._Label44;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x0600031F RID: 799 RVA: 0x000202A7 File Offset: 0x0001E4A7
		// (set) Token: 0x06000320 RID: 800 RVA: 0x000202B0 File Offset: 0x0001E4B0
		internal virtual Label Label45
		{
			[CompilerGenerated]
			get
			{
				return this._Label45;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._Label45;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._Label45 = value;
				label = this._Label45;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000321 RID: 801 RVA: 0x000202F3 File Offset: 0x0001E4F3
		// (set) Token: 0x06000322 RID: 802 RVA: 0x000202FC File Offset: 0x0001E4FC
		internal virtual Label Label46
		{
			[CompilerGenerated]
			get
			{
				return this._Label46;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._Label46;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._Label46 = value;
				label = this._Label46;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000323 RID: 803 RVA: 0x0002033F File Offset: 0x0001E53F
		// (set) Token: 0x06000324 RID: 804 RVA: 0x00020348 File Offset: 0x0001E548
		internal virtual Label Label47
		{
			[CompilerGenerated]
			get
			{
				return this._Label47;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._Label47;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._Label47 = value;
				label = this._Label47;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000325 RID: 805 RVA: 0x0002038B File Offset: 0x0001E58B
		// (set) Token: 0x06000326 RID: 806 RVA: 0x00020394 File Offset: 0x0001E594
		internal virtual Label Label48
		{
			[CompilerGenerated]
			get
			{
				return this._Label48;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._Label48;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._Label48 = value;
				label = this._Label48;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000327 RID: 807 RVA: 0x000203D7 File Offset: 0x0001E5D7
		// (set) Token: 0x06000328 RID: 808 RVA: 0x000203E0 File Offset: 0x0001E5E0
		internal virtual Label Label49
		{
			[CompilerGenerated]
			get
			{
				return this._Label49;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._Label49;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._Label49 = value;
				label = this._Label49;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000329 RID: 809 RVA: 0x00020423 File Offset: 0x0001E623
		// (set) Token: 0x0600032A RID: 810 RVA: 0x0002042C File Offset: 0x0001E62C
		internal virtual Label Label50
		{
			[CompilerGenerated]
			get
			{
				return this._Label50;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._Label50;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._Label50 = value;
				label = this._Label50;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x0600032B RID: 811 RVA: 0x0002046F File Offset: 0x0001E66F
		// (set) Token: 0x0600032C RID: 812 RVA: 0x00020478 File Offset: 0x0001E678
		internal virtual Label Label51
		{
			[CompilerGenerated]
			get
			{
				return this._Label51;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._Label51;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._Label51 = value;
				label = this._Label51;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x0600032D RID: 813 RVA: 0x000204BB File Offset: 0x0001E6BB
		// (set) Token: 0x0600032E RID: 814 RVA: 0x000204C4 File Offset: 0x0001E6C4
		internal virtual Label Label52
		{
			[CompilerGenerated]
			get
			{
				return this._Label52;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._Label52;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._Label52 = value;
				label = this._Label52;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600032F RID: 815 RVA: 0x00020507 File Offset: 0x0001E707
		// (set) Token: 0x06000330 RID: 816 RVA: 0x00020510 File Offset: 0x0001E710
		internal virtual Label Label53
		{
			[CompilerGenerated]
			get
			{
				return this._Label53;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._Label53;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._Label53 = value;
				label = this._Label53;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000331 RID: 817 RVA: 0x00020553 File Offset: 0x0001E753
		// (set) Token: 0x06000332 RID: 818 RVA: 0x0002055C File Offset: 0x0001E75C
		internal virtual Label Label54
		{
			[CompilerGenerated]
			get
			{
				return this._Label54;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._Label54;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._Label54 = value;
				label = this._Label54;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000333 RID: 819 RVA: 0x0002059F File Offset: 0x0001E79F
		// (set) Token: 0x06000334 RID: 820 RVA: 0x000205A8 File Offset: 0x0001E7A8
		internal virtual Label Label55
		{
			[CompilerGenerated]
			get
			{
				return this._Label55;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._Label55;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._Label55 = value;
				label = this._Label55;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000335 RID: 821 RVA: 0x000205EB File Offset: 0x0001E7EB
		// (set) Token: 0x06000336 RID: 822 RVA: 0x000205F4 File Offset: 0x0001E7F4
		internal virtual Label Label56
		{
			[CompilerGenerated]
			get
			{
				return this._Label56;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._Label56;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._Label56 = value;
				label = this._Label56;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000337 RID: 823 RVA: 0x00020637 File Offset: 0x0001E837
		// (set) Token: 0x06000338 RID: 824 RVA: 0x00020640 File Offset: 0x0001E840
		internal virtual Label trap1
		{
			[CompilerGenerated]
			get
			{
				return this._trap1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._trap1;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._trap1 = value;
				label = this._trap1;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000339 RID: 825 RVA: 0x00020683 File Offset: 0x0001E883
		// (set) Token: 0x0600033A RID: 826 RVA: 0x0002068C File Offset: 0x0001E88C
		internal virtual Label trap2
		{
			[CompilerGenerated]
			get
			{
				return this._trap2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Wall_MouseEnter);
				Label label = this._trap2;
				if (label != null)
				{
					label.MouseEnter -= eventHandler;
				}
				this._trap2 = value;
				label = this._trap2;
				if (label != null)
				{
					label.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x0600033B RID: 827 RVA: 0x000206CF File Offset: 0x0001E8CF
		// (set) Token: 0x0600033C RID: 828 RVA: 0x000206D8 File Offset: 0x0001E8D8
		internal virtual Timer TimerTrap
		{
			[CompilerGenerated]
			get
			{
				return this._TimerTrap;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.TimerTrap_Tick);
				Timer timer = this._TimerTrap;
				if (timer != null)
				{
					timer.Tick -= eventHandler;
				}
				this._TimerTrap = value;
				timer = this._TimerTrap;
				if (timer != null)
				{
					timer.Tick += eventHandler;
				}
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x0600033D RID: 829 RVA: 0x0002071B File Offset: 0x0001E91B
		// (set) Token: 0x0600033E RID: 830 RVA: 0x00020724 File Offset: 0x0001E924
		internal virtual Panel anticheat
		{
			[CompilerGenerated]
			get
			{
				return this._anticheat;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.anticheat_MouseEnter);
				Panel panel = this._anticheat;
				if (panel != null)
				{
					panel.MouseEnter -= eventHandler;
				}
				this._anticheat = value;
				panel = this._anticheat;
				if (panel != null)
				{
					panel.MouseEnter += eventHandler;
				}
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x0600033F RID: 831 RVA: 0x00020767 File Offset: 0x0001E967
		// (set) Token: 0x06000340 RID: 832 RVA: 0x00020770 File Offset: 0x0001E970
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

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000341 RID: 833 RVA: 0x000207B3 File Offset: 0x0001E9B3
		// (set) Token: 0x06000342 RID: 834 RVA: 0x000207BC File Offset: 0x0001E9BC
		internal virtual Timer TimerLegit
		{
			[CompilerGenerated]
			get
			{
				return this._TimerLegit;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.TimerLegit_Tick);
				Timer timer = this._TimerLegit;
				if (timer != null)
				{
					timer.Tick -= eventHandler;
				}
				this._TimerLegit = value;
				timer = this._TimerLegit;
				if (timer != null)
				{
					timer.Tick += eventHandler;
				}
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000343 RID: 835 RVA: 0x000207FF File Offset: 0x0001E9FF
		// (set) Token: 0x06000344 RID: 836 RVA: 0x00020808 File Offset: 0x0001EA08
		internal virtual Timer TimerCheat
		{
			[CompilerGenerated]
			get
			{
				return this._TimerCheat;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.TimerCheat_Tick);
				Timer timer = this._TimerCheat;
				if (timer != null)
				{
					timer.Tick -= eventHandler;
				}
				this._TimerCheat = value;
				timer = this._TimerCheat;
				if (timer != null)
				{
					timer.Tick += eventHandler;
				}
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000345 RID: 837 RVA: 0x0002084B File Offset: 0x0001EA4B
		// (set) Token: 0x06000346 RID: 838 RVA: 0x00020854 File Offset: 0x0001EA54
		internal virtual Timer TimerDecompo
		{
			[CompilerGenerated]
			get
			{
				return this._TimerDecompo;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.TimerDecompo_Tick);
				Timer timer = this._TimerDecompo;
				if (timer != null)
				{
					timer.Tick -= eventHandler;
				}
				this._TimerDecompo = value;
				timer = this._TimerDecompo;
				if (timer != null)
				{
					timer.Tick += eventHandler;
				}
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000347 RID: 839 RVA: 0x00020897 File Offset: 0x0001EA97
		// (set) Token: 0x06000348 RID: 840 RVA: 0x0002089F File Offset: 0x0001EA9F
		internal virtual PictureBox PictureBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06000349 RID: 841 RVA: 0x000208A8 File Offset: 0x0001EAA8
		private void ThirdGame_Load(object sender, EventArgs e)
		{
			Cursor.Show();
			this.bougeCursor = true;
			this.getTrapped = false;
			this.isCheated = true;
			this.Timer1.Start();
		}

		// Token: 0x0600034A RID: 842 RVA: 0x000208CF File Offset: 0x0001EACF
		private void ThirdGame_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			if (this.youCanGo)
			{
				MessageBox.Show("N\u0346\u034c\u0365\u030a\u030f\u030e\u035b\u0365\u0326\u033c\u0339\u033c\u0331\u0320\u0324\u035aO\u034c\u0335\u0339\u0330\u0325\u0319\u0348", "");
				this.MoveToStart();
			}
		}

		// Token: 0x0600034B RID: 843 RVA: 0x000208F8 File Offset: 0x0001EAF8
		private void fakeWin_MouseEnter(object sender, EventArgs e)
		{
			if (this.youCanGo)
			{
				this.fakeWin.Visible = false;
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Ghost.wav", AudioPlayMode.Background);
				this.youCanGo = false;
				if (this.isCheated)
				{
					this.TimerCheat.Start();
					return;
				}
				if (!this.isCheated)
				{
					this.TimerLegit.Start();
				}
			}
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00020968 File Offset: 0x0001EB68
		public void MoveToStart()
		{
			if (this.bougeCursor)
			{
				Point location = this.pointDepart.Location;
				location.Offset(10, 10);
				Cursor.Position = base.PointToScreen(location);
			}
		}

		// Token: 0x0600034D RID: 845 RVA: 0x000209A0 File Offset: 0x0001EBA0
		private void Wall_MouseEnter(object sender, EventArgs e)
		{
			if (this.youCanGo)
			{
				this.MoveToStart();
				this.isCheated = true;
			}
		}

		// Token: 0x0600034E RID: 846 RVA: 0x000209B8 File Offset: 0x0001EBB8
		private void triggerCheater_MouseEnter(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectEqual(this.alreadyGetScreamer, false, false))
			{
				if (this.youCanGo)
				{
					this.alreadyGetScreamer = true;
					this.MoveToStart();
					base.Hide();
					this.triggerCheater.Text = "s\u0302\u030a\u033d\u0348\u0349\u0339\u033b\u0316\u034e\u0348a\u0366\u0301\u0365\u0347\u0324\u0347\u0319\u032a\u0349v\u034c\u031a\u030f\u030d\u0305\u0304\u034a\u0338\u032e\u034d";
					MyProject.Forms.Screamer4.Show();
					return;
				}
			}
			else
			{
				this.MoveToStart();
			}
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00020A20 File Offset: 0x0001EC20
		private void triggerTrap_MouseEnter(object sender, EventArgs e)
		{
			if (this.youCanGo && !this.getTrapped)
			{
				this.getTrapped = true;
				this.trap1.Visible = true;
				this.trap2.Visible = true;
				this.trap1.Enabled = true;
				this.trap2.Enabled = true;
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Trapped.wav", AudioPlayMode.Background);
				this.TimerTrap.Start();
			}
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00020AA0 File Offset: 0x0001ECA0
		private void TimerTrap_Tick(object sender, EventArgs e)
		{
			this.tsec = Operators.SubtractObject(this.tsec, 1);
			if (Operators.ConditionalCompareObjectEqual(this.tsec, 2, false))
			{
				this.TimerTrap.Stop();
				this.tsec = 5;
				MessageBox.Show("Y\u0306\u030bO\u0311\u033f\u030a\u0367\u033e\u033d\u0355\u031f\u0333\u0320\u031d\u032bU\u0359\u0317\u0323\u0353\u0316\u033b \u035b\u0368\u036f\u0340\u032e\u0347\u0345\u0316\u0347\u0359\u033a \u031a\u0308\u034b \u035b\u0340\u0318\u0347\u0333A\u030a\u0346\u030b\u0303\u0302\u035e\u031e\u034d\u031f\u0349\u0347\u031cR\u0311\u030a\u0343\u033f\u0352\u0367E\u0344\u036b\u036d\u035d \u0366\u0363\u0367\u0317\u0326\u0318\u032d\u032d \u0310\u0307\u030b\u0346\u030d\u030c\u030d\u0349\u0332\u0319 \u036f\u034c\u0300\u0313\u0352\u031d\u0339\u032e\u032d\u0355\u0349S\u0343\u031a\u030e\u0357\u030d\u0300TU\u030c\u033f\u034b\u0322\u0324\u032e\u0326\u0353C\u0303\u036e\u033f\u0314\u0351\u030b\u034cK\u0342\u0303\u034a\u030e\u030c\u036fE\u0313\u0363\u035b\u0356\u0325\u0317D\u0311\u0365\u030f\u0329 \u0366\u031a\u0342\u0339 \u0304\u0300\u0337\u0317\u0347 \u0309\u0305\u0343\u0308\u0303\u035f\u033a\u032c\u0326\u0317\u0345A\u030aG\u033e\u0367\u0307\u0346\u033d\u035b\u035c\u032f\u031e\u0330A\u034b\u0305\u0322\u032f\u032f\u0316\u0332\u0325\u0333\u0348I\u030d\u0301\u035b\u0335\u0354\u034e\u0317\u0359\u0354\u033cN\u0343\u036e\u032c\u0316\u0356\u033c \u0302\u0305\u030d\u034b\u033e\u036e\u034b\u0331\u0319\u032b\u031e\u032a\u0316 \u0309\u0366\u0313\u0311\u0363\u0344\u0361 \u030d\u036c\u0312\u031c\u0326\u0318\u0329\u0333A\u034a\u0302\u0310\u036b\u030b\u0308\u0320\u0319\u0354\u033bN\u030e\u0301\u0364\u0352\u0305\u0335\u0326\u033cD\u034c\u0310\u0305\u0368\u0344\u0310\u030d\u031f \u0306\u0366\u0308\u030f\u0308\u030e\u030e\u0316\u0355 \u0304\u0301\u0308\u0310\u035b\u036b \u0311\u0343\u0351\u0306\u0359\u0317\u031e\u033a\u033c\u0354\u033aA\u0367\u030b\u0344\u0363\u0336G\u0357\u0302\u0344\u030b\u0303\u030c\u0363\u032aA\u0342\u0302\u0366\u0303\u030e\u0350\u0332\u0319\u031d\u0356\u035aI\u030f\u0311\u0369\u0367\u036bN\u0357\u0314\u0309\u0312\u0351\u0357\u033d\u033b\u034e\u033a\u034d\u032e\u0318\u034e", "");
				this.MoveToStart();
				this.reputMusic();
			}
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00020B0B File Offset: 0x0001ED0B
		public void reputMusic()
		{
			MyProject.Computer.Audio.Play(this.appPath + "\\assets\\ReverseStrangeMusic1.wav", AudioPlayMode.BackgroundLoop);
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00020B2D File Offset: 0x0001ED2D
		private void anticheat_MouseEnter(object sender, EventArgs e)
		{
			if (this.youCanGo)
			{
				this.isCheated = false;
			}
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00020B40 File Offset: 0x0001ED40
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.sec = Operators.SubtractObject(this.sec, 1);
			if (Operators.ConditionalCompareObjectEqual(this.sec, 49, false))
			{
				this.Timer1.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Msg.wav", AudioPlayMode.Background);
				this.fakeWin.Image = Image.FromFile(this.appPath + "\\assets\\gifs\\Navi.gif");
				MessageBox.Show("yoU alREady kNow wHAt thAt Is", "");
				this.Timer1.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 48, false))
			{
				this.Timer1.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Msg.wav", AudioPlayMode.Background);
				MessageBox.Show("exACTlY, iT's A fuNNy gAME, aGAIN", "");
				this.Timer1.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 47, false))
			{
				this.Timer1.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Msg.wav", AudioPlayMode.Background);
				this.fakeWin.Visible = true;
				MessageBox.Show("yOUr frIEND wILL lEAD yOu tO thE eNd", "");
				this.Timer1.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 46, false))
			{
				this.Timer1.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Msg.wav", AudioPlayMode.Background);
				MessageBox.Show("jOIn hIM wiTH yOUR cuRsor", "");
				this.Timer1.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 45, false))
			{
				this.Timer1.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Msg.wav", AudioPlayMode.Background);
				MessageBox.Show("avOid toUcHIng bLOoDy teXtS", "");
				this.Timer1.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 44, false))
			{
				this.Timer1.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Msg.wav", AudioPlayMode.Background);
				MessageBox.Show("othERwiSe yOU WIll bE sTuCk", "");
				this.Timer1.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 43, false))
			{
				this.Timer1.Stop();
				this.sec = 51;
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Msg.wav", AudioPlayMode.Background);
				MessageBox.Show("F\u0342\u0338\u0322\u0347\u032c\u0332\u035a\u032c\u032c\u032f\u0331O\u030a\u0366\u0333\u0333\u035a\u0325\u033c\u0348\u0359\u032f\u0319R\u035b\u033f\u0343\u0308E\u0306V\u0343\u0307\u0335\u035e\u0319\u0356\u0332\u0325E\u0346\u0307\u0366\u034a\u0344\u030c\u0311\u031b\u0319\u032c\u0359R\u0303\u036c\u0368\u0300\u0328\u0316\u032e\u0318\u0339\u033c\u034d\u035a", "");
				this.youCanGo = true;
				this.reputMusic();
				this.MoveToStart();
			}
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00020E24 File Offset: 0x0001F024
		private void TimerCheat_Tick(object sender, EventArgs e)
		{
			this.cheatsec = Operators.SubtractObject(this.cheatsec, 1);
			checked
			{
				if (this.cheatingCount == 0)
				{
					if (Operators.ConditionalCompareObjectEqual(this.cheatsec, 46, false))
					{
						this.TimerCheat.Stop();
						MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Msg.wav", AudioPlayMode.Background);
						MessageBox.Show("i caN'T beLieVe iT. ..", "");
						this.TimerCheat.Start();
					}
					if (Operators.ConditionalCompareObjectEqual(this.cheatsec, 45, false))
					{
						this.TimerCheat.Stop();
						MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Msg.wav", AudioPlayMode.Background);
						MessageBox.Show("yOU'vE wON my laST gaME.. .", "");
						this.TimerCheat.Start();
					}
					if (Operators.ConditionalCompareObjectEqual(this.cheatsec, 44, false))
					{
						this.TimerCheat.Stop();
						MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Msg.wav", AudioPlayMode.Background);
						MessageBox.Show("i suPpoSe thIS Is tHE ENd . . . ?", "");
						this.TimerCheat.Start();
					}
					if (Operators.ConditionalCompareObjectEqual(this.cheatsec, 42, false))
					{
						MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Skullkid.wav", AudioPlayMode.Background);
					}
					if (Operators.ConditionalCompareObjectEqual(this.cheatsec, 38, false))
					{
						this.TimerCheat.Stop();
						MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Msg.wav", AudioPlayMode.Background);
						MessageBox.Show("aS A frIEnd onCe sAid", "");
						this.TimerCheat.Start();
					}
					if (Operators.ConditionalCompareObjectEqual(this.cheatsec, 37, false))
					{
						this.TimerCheat.Stop();
						this.cheatsec = 50;
						MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Laughing.wav", AudioPlayMode.BackgroundLoop);
						this.cheatingCount++;
						MessageBox.Show("Y\u034a\u0352\u030a\u030e\u0327\u0320\u0325\u033c\u0319\u0349\u0316\u033c\u033aO\u0364\u0310\u036a\u0366\u0352\u0307\u0342\u0303\u036b\u035e\u0336\u0349\u0329\u0353\u032e\u0324\u0325\u031d\u0349U\u034c\u0310\u0304\u036e\u0368\u030e\u0305\u0306\u0300\u0358\u031d'\u0301\u034a\u0368\u0327\u0337\u0349\u031dR\u0300\u034b\u033e\u0335\u031b\u035a\u0333\u031d\u0320\u0329\u034e\u0317\u0354E\u036c\u030f\u036e\u0301\u0306\u0305\u0339\u0320\u0347 \u030d\u0342\u0337\u0337\u0358\u0356\u0317\u0339 \u035b\u0357\u0312\u0342\u0306\u0364\u0364\u030b\u030d\u0361\u0341\u033b \u0306\u0344\u0308\u0350\u035e\u033b\u0359\u034e\u0330A\u0307\u033d\u031a\u0357\u0364\u0344\u033d\u033e\u0328\u0340\u031d\u032c\u0317\u031c \u0364\u0363\u030b\u0364\u0368\u0314\u0302\u0367\u0361\u0362\u0323\u032f\u0316\u0349\u033c \u034c\u0305\u033d\u0367\u0303\u030d\u0334\u0334\u0324\u035a\u032e\u0356\u031d\u0323\u0326\u031e \u034b\u0350\u0369\u0334\u0337\u0328\u031c\u0354D\u0367\u0350\u0365I\u033e\u0319\u0347R\u0369\u036e\u0366\u0357\u0327\u0331\u0318\u0316\u031e\u0325\u0331\u0333T\u0346\u0311\u0363\u033c\u0333\u0339\u0317\u0317\u0318Y\u033f\u0367\u033f\u036d\u030c\u036f\u0337\u0340\u0355\u0348\u0318\u0332\u033b \u033d\u0340\u0340\u031b\u032e\u0359\u0324\u031f\u033b\u0348 \u0343\u0307\u0342\u0310\u030e\u0335\u035d\u0332\u0353\u031c\u032b\u033a\u0318 \u0301\u0303\u0307\u036e\u034c\u033e\u0311\u031e\u0330H\u0364\u0309\u0351\u0346A\u030c\u033f\u0346\u0351\u0328\u031b\u031f\u0349\u0330\u034d\u034e\u0353\u0332C\u0309\u0369\u034e\u0355K\u0369\u0364\u030f\u0308\u036f\u0343\u033c\u032e\u032c\u0331E\u0307\u0335\u0354\u0347\u0355\u0356R\u0357\u0351\u036b\u0313\u030a\u0351\u0350\u0313\u034c\u0334\u034f\u035c\u0354\u033c\u0349\u0317\u0354\u0331\u0323,\u0304\u0308\u0301\u033f\u033e\u033e\u036a\u0327\u0320\u031e\u031c\u031c\u0345\u0345\u035a \u0368\u0367\u0314\u0310\u030c\u036b\u034f\u032a\u0316 \u030a\u036e\u0366\u0328\u0327\u031c\u0329\u031f\u032c\u032b \u0302\u030c\u0369\u036c\u032f\u0347H\u0368\u031a\u0363\u0358\u0330\u0333\u031e\u0356\u031d\u031dA\u0352\u0368\u0366\u0357\u035f\u032b\u0316\u0317\u0339V\u036b\u0350\u030f\u036f\u035f\u0335\u033a\u033b\u0326\u034e\u032c\u032f\u0325E\u0301\u036c\u036e\u0305\u034a\u0310\u034c\u0307\u0322\u0316\u032d\u0353N\u030a\u0314\u036a\u033a\u031e\u0316'\u031a\u0366\u036e\u0326\u0359\u0323\u033a\u0339\u0331T\u0307\u030e\u0343\u0304\u036d\u0343\u036f\u030d\u035c\u0340\u0362\u031d\u0347\u0324\u0316\u031c\u0329 \u0352\u0365\u0367\u0305\u034b\u0310\u0334\u0489\u0325\u0319\u0348\u0354\u0319\u032b\u031f\u0347 \u0342\u0369\u036e\u0303\u0313\u0357\u031a\u036a\u0360\u035c\u035c\u032c\u0356\u031e\u0333\u0330\u0349\u035a\u0353 \u0302\u0344\u0314\u0489\u035f\u0328\u034e\u032a\u0331\u0359\u0316\u0317\u0339Y\u0344\u0367\u0303\u0344\u0352\u035d\u0331\u032bO\u033f\u036b\u0305\u0368\u0367\u0313\u0352\u0335\u0334\u0359\u0339\u0329\u0359\u0330U\u034b\u0301\u0314\u036a\u032d\u0333\u032d\u0329\u0347\u0339\u0331\u0319\u0324 \u036a\u0303\u0314\u0342\u034c\u033f\u035e\u0355\u0349\u032a\u033b\u0317\u0316\u0345 \u030a\u030c\u0308\u033d\u0301\u0369\u036f\u036e\u0328\u035e\u0320\u0332\u0317\u0319\u0354\u0324\u0359 \u0357\u030e\u0306\u0364\u0309\u0346\u0361\u0341\u0333\u032a\u033a\u032f\u0320\u0332\u0355\u0359?\u036a\u0368\u0304\u0346\u0303\u034f\u0356\u032b\u0316\u0349\u0355\u032a\u033b\u0325", "");
						this.fakeWin.Visible = true;
						this.reputMusic();
						this.MoveToStart();
						this.youCanGo = true;
						return;
					}
				}
				else if (this.cheatingCount == 1)
				{
					if (Operators.ConditionalCompareObjectEqual(this.cheatsec, 46, false))
					{
						this.TimerCheat.Stop();
						MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Msg.wav", AudioPlayMode.Background);
						MessageBox.Show("i caN'T beLieVe iT. ..", "");
						this.TimerCheat.Start();
					}
					if (Operators.ConditionalCompareObjectEqual(this.cheatsec, 45, false))
					{
						this.TimerCheat.Stop();
						MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Msg.wav", AudioPlayMode.Background);
						MessageBox.Show(". . .", "");
						this.TimerCheat.Start();
					}
					if (Operators.ConditionalCompareObjectEqual(this.cheatsec, 44, false))
					{
						this.TimerCheat.Stop();
						this.cheatsec = 50;
						MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Laughing.wav", AudioPlayMode.BackgroundLoop);
						this.cheatingCount++;
						MessageBox.Show("Y\u034a\u0352\u030a\u030e\u0327\u0320\u0325\u033c\u0319\u0349\u0316\u033c\u033aO\u0364\u0310\u036a\u0366\u0352\u0307\u0342\u0303\u036b\u035e\u0336\u0349\u0329\u0353\u032e\u0324\u0325\u031d\u0349U\u034c\u0310\u0304\u036e\u0368\u030e\u0305\u0306\u0300\u0358\u031d'\u0301\u034a\u0368\u0327\u0337\u0349\u031dR\u0300\u034b\u033e\u0335\u031b\u035a\u0333\u031d\u0320\u0329\u034e\u0317\u0354E\u036c\u030f\u036e\u0301\u0306\u0305\u0339\u0320\u0347 \u030d\u0342\u0337\u0337\u0358\u0356\u0317\u0339 \u035b\u0357\u0312\u0342\u0306\u0364\u0364\u030b\u030d\u0361\u0341\u033b \u0306\u0344\u0308\u0350\u035e\u033b\u0359\u034e\u0330A\u0307\u033d\u031a\u0357\u0364\u0344\u033d\u033e\u0328\u0340\u031d\u032c\u0317\u031c \u0364\u0363\u030b\u0364\u0368\u0314\u0302\u0367\u0361\u0362\u0323\u032f\u0316\u0349\u033c \u034c\u0305\u033d\u0367\u0303\u030d\u0334\u0334\u0324\u035a\u032e\u0356\u031d\u0323\u0326\u031e \u034b\u0350\u0369\u0334\u0337\u0328\u031c\u0354D\u0367\u0350\u0365I\u033e\u0319\u0347R\u0369\u036e\u0366\u0357\u0327\u0331\u0318\u0316\u031e\u0325\u0331\u0333T\u0346\u0311\u0363\u033c\u0333\u0339\u0317\u0317\u0318Y\u033f\u0367\u033f\u036d\u030c\u036f\u0337\u0340\u0355\u0348\u0318\u0332\u033b \u033d\u0340\u0340\u031b\u032e\u0359\u0324\u031f\u033b\u0348 \u0343\u0307\u0342\u0310\u030e\u0335\u035d\u0332\u0353\u031c\u032b\u033a\u0318 \u0301\u0303\u0307\u036e\u034c\u033e\u0311\u031e\u0330H\u0364\u0309\u0351\u0346A\u030c\u033f\u0346\u0351\u0328\u031b\u031f\u0349\u0330\u034d\u034e\u0353\u0332C\u0309\u0369\u034e\u0355K\u0369\u0364\u030f\u0308\u036f\u0343\u033c\u032e\u032c\u0331E\u0307\u0335\u0354\u0347\u0355\u0356R\u0357\u0351\u036b\u0313\u030a\u0351\u0350\u0313\u034c\u0334\u034f\u035c\u0354\u033c\u0349\u0317\u0354\u0331\u0323,\u0304\u0308\u0301\u033f\u033e\u033e\u036a\u0327\u0320\u031e\u031c\u031c\u0345\u0345\u035a \u0368\u0367\u0314\u0310\u030c\u036b\u034f\u032a\u0316 \u030a\u036e\u0366\u0328\u0327\u031c\u0329\u031f\u032c\u032b \u0302\u030c\u0369\u036c\u032f\u0347H\u0368\u031a\u0363\u0358\u0330\u0333\u031e\u0356\u031d\u031dA\u0352\u0368\u0366\u0357\u035f\u032b\u0316\u0317\u0339V\u036b\u0350\u030f\u036f\u035f\u0335\u033a\u033b\u0326\u034e\u032c\u032f\u0325E\u0301\u036c\u036e\u0305\u034a\u0310\u034c\u0307\u0322\u0316\u032d\u0353N\u030a\u0314\u036a\u033a\u031e\u0316'\u031a\u0366\u036e\u0326\u0359\u0323\u033a\u0339\u0331T\u0307\u030e\u0343\u0304\u036d\u0343\u036f\u030d\u035c\u0340\u0362\u031d\u0347\u0324\u0316\u031c\u0329 \u0352\u0365\u0367\u0305\u034b\u0310\u0334\u0489\u0325\u0319\u0348\u0354\u0319\u032b\u031f\u0347 \u0342\u0369\u036e\u0303\u0313\u0357\u031a\u036a\u0360\u035c\u035c\u032c\u0356\u031e\u0333\u0330\u0349\u035a\u0353 \u0302\u0344\u0314\u0489\u035f\u0328\u034e\u032a\u0331\u0359\u0316\u0317\u0339Y\u0344\u0367\u0303\u0344\u0352\u035d\u0331\u032bO\u033f\u036b\u0305\u0368\u0367\u0313\u0352\u0335\u0334\u0359\u0339\u0329\u0359\u0330U\u034b\u0301\u0314\u036a\u032d\u0333\u032d\u0329\u0347\u0339\u0331\u0319\u0324 \u036a\u0303\u0314\u0342\u034c\u033f\u035e\u0355\u0349\u032a\u033b\u0317\u0316\u0345 \u030a\u030c\u0308\u033d\u0301\u0369\u036f\u036e\u0328\u035e\u0320\u0332\u0317\u0319\u0354\u0324\u0359 \u0357\u030e\u0306\u0364\u0309\u0346\u0361\u0341\u0333\u032a\u033a\u032f\u0320\u0332\u0355\u0359?\u036a\u0368\u0304\u0346\u0303\u034f\u0356\u032b\u0316\u0349\u0355\u032a\u033b\u0325", "");
						this.fakeWin.Visible = true;
						this.reputMusic();
						this.MoveToStart();
						this.youCanGo = true;
						return;
					}
				}
				else if (this.cheatingCount == 2)
				{
					if (Operators.ConditionalCompareObjectEqual(this.cheatsec, 46, false))
					{
						this.TimerCheat.Stop();
						MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Msg.wav", AudioPlayMode.Background);
						MessageBox.Show("i caN'T beLieVe iT. ..", "");
						this.TimerCheat.Start();
					}
					if (Operators.ConditionalCompareObjectEqual(this.cheatsec, 45, false))
					{
						this.TimerCheat.Stop();
						MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Msg.wav", AudioPlayMode.Background);
						MessageBox.Show("yOu'RE trYIng agAIN ?", "");
						this.TimerCheat.Start();
					}
					if (Operators.ConditionalCompareObjectEqual(this.cheatsec, 44, false))
					{
						this.TimerCheat.Stop();
						this.cheatsec = 50;
						MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Laughing.wav", AudioPlayMode.BackgroundLoop);
						this.cheatingCount++;
						MessageBox.Show("H\u0302\u0363\u031a\u0342\u0344\u036c\u036c\u0360O\u035d\u0323\u0332\u031c\u033cW\u0319\u031f\u0324\u033a\u0317\u031d\u0320 \u0318\u0318 \u0312\u036b\u034b\u0304\u0357\u0357\u0309\u0348\u033c\u0317\u0317\u0359 \u0328\u034d\u0317\u032a\u0345\u033aS\u036b\u0361\u0323\u0347\u032d\u032e\u0316T\u034c\u0305\u030d\u036f\u036d\u0366\u030eU\u034c\u032e\u032b\u0354PI\u0328\u0347\u031c\u0345\u0319\u0317\u031eD\u0361\u0339\u034e\u0323 \u034b\u034c\u0307\u0302\u0363\u033b\u0359\u0348 \u0308\u0305\u030d\u034c\u033d\u034f\u032b\u034d\u0318\u0353\u033c \u0369\u0311\u0308\u036d\u034c\u030d\u0335\u033bY\u0366\u0360\u0316\u033a\u0329\u032fO\u035b\u0367\u0368\u036d\u0306\u030d\u0337\u0353\u0316\u031e\u0324U\u0328\u0355\u0329\u033c\u0359\u032f \u033e\u034a\u0328\u031d\u0339\u032d\u0348\u0323\u0326 \u036f\u0343\u030f\u0369\u0302\u034c\u032e\u033c\u033b\u0326 \u0300\u0303\u0304\u030b\u0342\u0369\u0343\u032bA\u0313\u0300\u0352R\u0301\u0350\u031a\u0339\u032aE\u0364\u031a\u0364\u0338\u032a\u0330\u0349\u0318\u033a.\u0342\u0364\u0364\u0307\u036d\u0303\u0365\u0489\u0320\u0333", "");
						this.fakeWin.Visible = true;
						this.reputMusic();
						this.MoveToStart();
						this.youCanGo = true;
						return;
					}
				}
				else if (this.cheatingCount == 3)
				{
					if (Operators.ConditionalCompareObjectEqual(this.cheatsec, 46, false))
					{
						this.TimerCheat.Stop();
						this.cheatsec = 50;
						MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Laughing.wav", AudioPlayMode.BackgroundLoop);
						this.cheatingCount++;
						MessageBox.Show("Y\u0342\u036a\u0303\u034c\u0364\u0366\u035d\u032c\u0333\u0323\u034d\u0355O\u031a\u0344\u0310\u033e\u034b\u0356\u033a\u032b\u0349U\u0302\u0352\u034a\u033f\u036d\u0322\u0345\u0325\u035a \u0305\u0351\u0365\u0306\u0336\u0324\u0332\u0354\u031f\u0316\u032b\u0331 \u0306\u0300\u0314\u0307\u0300\u0347\u033b\u035a\u032b\u0319 \u034a\u0310\u0314\u0303\u0359\u0324\u0326\u0345\u0324C\u036c\u0303\u0354\u0326\u0326\u032fA\u0301\u030d\u0310\u034e\u0345\u031c\u0318\u0356N\u0357\u0369\u030d\u036f\u0303\u030f\u0324\u0353'\u0346\u0316\u0354\u034e\u0347\u0348T\u030a\u036f\u0364\u035f\u0339\u031e\u0316\u032b\u032f\u032a \u0311\u0332\u0359 \u0305\u0311\u033f\u0301\u0303\u031f\u0330\u033a\u0353\u0326 \u034c\u0315\u032eP\u0364L\u0302\u0300\u0304\u0369\u0324\u0345A\u0342\u036f\u0350\u031a\u0325\u0330\u032b\u0326Y\u0308\u030e\u0322\u031c\u033a\u0354\u034d\u0325 \u0307\u034b\u0345\u0355 \u0366\u0346\u033f\u030d\u0350\u0303\u0368\u0325\u0349\u033c \u0309\u0310\u0310\u031a\u0343\u0367\u0317\u0326\u0324L\u0364\u0305\u0362\u0349\u0331\u032e\u0329I\u031d\u0331\u0318\u032aK\u034b\u030a\u031d\u035a\u031cE\u034c\u030d\u034a\u035b\u0309\u036b\u030b\u0340\u035a\u033b\u0356\u0320\u0326\u032d \u032a\u0359\u0359\u033b \u0302\u0300\u0359 \u0351\u0312\u0331\u0320\u0318\u0356\u0354\u032aT\u0369\u0351\u0310\u035b\u0366\u0310H\u0313\u0367\u031b\u0347\u0331\u0326\u033a\u032f\u0320I\u030c\u0309\u0363\u030d\u033d\u0328\u0356\u034e\u033b\u033a\u032c\u0333S\u0300\u033e\u030b\u0343\u034a\u034a\u0304\u0317.\u0346\u0302\u0305\u030b\u036d\u030b\u034b\u0323\u0347\u0316\u0359\u0329", "");
						this.fakeWin.Visible = true;
						this.reputMusic();
						this.MoveToStart();
						this.youCanGo = true;
						return;
					}
				}
				else if (this.cheatingCount == 4)
				{
					if (Operators.ConditionalCompareObjectEqual(this.cheatsec, 46, false))
					{
						this.TimerCheat.Stop();
						this.cheatsec = 50;
						MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Laughing.wav", AudioPlayMode.BackgroundLoop);
						this.cheatingCount++;
						MessageBox.Show("S\u0304\u0352\u0346T\u0367\u0311\u0352\u030c\u0358\u032cO\u0364\u036f\u034b\u035b\u036c\u0368\u0363\u0362\u0330\u0347\u0332\u0318\u032fP\u0357\u0350\u0357\u035f\u0330\u0331\u0325 \u0312\u0365\u0353\u032a\u033a\u0348 \u0344\u036f\u0300\u0357\u030f\u034a\u0322\u0347 \u0365\u030a\u0312\u036b\u0313\u0332\u0316\u031e\u0333\u0317\u0325\u031fI\u0344\u030d\u0309\u0301\u0321\u0323T\u0366\u036d\u0341\u032c\u0355\u0330", "");
						this.fakeWin.Visible = true;
						this.reputMusic();
						this.MoveToStart();
						this.youCanGo = true;
						return;
					}
				}
				else if (this.cheatingCount == 5)
				{
					if (Operators.ConditionalCompareObjectEqual(this.cheatsec, 46, false))
					{
						this.TimerCheat.Stop();
						this.cheatsec = 50;
						MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Laughing.wav", AudioPlayMode.BackgroundLoop);
						this.cheatingCount++;
						MessageBox.Show("S\u0311\u0306\u0305\u0321\u035f\u0324\u034d\u035a\u0323\u033b\u0332\u0324T\u0313\u0305\u0364\u030e\u0305\u036d\u033f\u0346\u030d\u0336\u0326\u0332\u031f\u032d\u033b\u0359\u0318\u031d\u035aO\u0367\u0350\u0315\u0334\u0321\u0354\u033b\u0318\u0354\u032c\u0348P\u033f\u0350\u033d\u034a\u0364\u035e\u0334\u0338\u0323\u0324\u0317\u0339\u0347\u031c \u0302\u0309\u033e\u0363\u035b\u0303\u0358\u0327\u0328\u032d\u0319 \u036b\u0362\u0328\u034e\u034d\u035a \u036d\u0306\u031b\u0335\u034d\u0356\u0339\u032f\u032e\u0348\u0325\u0347I\u030a\u030a\u0366\u036b\u030d\u0313\u0362\u0327\u035c\u0329\u0332\u0320\u034e\u033b\u032aT\u0367\u030c\u0310\u0344\u035f\u0354\u0345", "");
						this.fakeWin.Visible = true;
						this.reputMusic();
						this.MoveToStart();
						this.youCanGo = true;
						return;
					}
				}
				else if (this.cheatingCount == 6 && Operators.ConditionalCompareObjectEqual(this.cheatsec, 46, false))
				{
					this.TimerCheat.Stop();
					this.cheatsec = 50;
					MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Laughing.wav", AudioPlayMode.BackgroundLoop);
					MessageBox.Show("S\u036f\u0368\u0342\u030a\u034b\u034a\u0363\u0367\u0308\u0300\u0314\u0338\u0358\u0355\u0332\u0347\u033b\u032d\u032f\u0353\u0329\u0333\u0356\u0347\u0339\u0319\u0355\u0356T\u0314\u034b\u036d\u030b\u0351\u0305\u0350\u030a\u0302\u030e\u0350\u0342\u0304\u034c\u035c\u035f\u0323\u031f\u032f\u032e\u032a\u0359\u031f\u0345O\u0343\u0302\u036a\u0307\u034b\u0365\u0364\u0302\u0363\u030c\u0363\u031a\u0305\u0304\u0311\u034c\u030f\u034b\u0360\u0361\u0358\u0322\u031f\u0320\u0353\u031c\u0331P\u0367\u030f\u0369\u0350\u0352\u0364\u036e\u0336\u0335\u0321\u032f\u0323\u0354\u035a\u0323\u034e\u032b\u031c\u031f \u030d\u036e\u036a\u0364\u0352\u0310\u0352\u0357\u030f\u0351\u030f\u0369\u030e\u033e\u0366\u0350\u0314\u0358\u0324\u031e\u032c\u0326\u0318\u0320\u031c\u0325\u033c\u0332\u0318\u0356\u0345\u0354 \u0304\u0300\u0344\u034a\u0361\u034f\u0360\u0338\u033c\u033a\u031f\u0323\u0331\u032e\u032d\u0325\u035a\u0348\u033b\u032a\u033a\u034d\u0353\u0320\u0332\u0348 \u0368\u030e\u036b\u0343\u0366\u0367\u030d\u0369\u0304\u035b\u0309\u0369\u0338\u0337\u034f\u0330\u0355\u0349\u0330\u031eI\u033d\u0350\u0357\u0364\u030a\u030b\u036b\u030d\u0306\u0327\u0361\u031e\u0333\u0332\u032e\u034e\u0359\u0329\u0345T\u0304\u0343\u034a\u0343\u0301\u0351\u034f\u0358\u0322\u0325\u0353\u0317\u0323\u0318\u031f\u031d\u031d\u0323\u032c\u0353\u0318\u031c\u0353\u0359\u0353\u032a", "");
					this.fakeWin.Visible = true;
					this.reputMusic();
					this.MoveToStart();
					this.youCanGo = true;
				}
			}
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00021578 File Offset: 0x0001F778
		private void TimerLegit_Tick(object sender, EventArgs e)
		{
			this.legitsec = Operators.SubtractObject(this.legitsec, 1);
			if (Operators.ConditionalCompareObjectEqual(this.legitsec, 46, false))
			{
				this.TimerLegit.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Msg.wav", AudioPlayMode.Background);
				MessageBox.Show("sO yOU dId iT.", "");
				this.TimerLegit.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.legitsec, 45, false))
			{
				this.TimerLegit.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Msg.wav", AudioPlayMode.Background);
				MessageBox.Show("hOW DO yOu fEEL ?", "");
				this.TimerLegit.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.legitsec, 44, false))
			{
				this.TimerLegit.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Msg.wav", AudioPlayMode.Background);
				MessageBox.Show("S\u036c\u036b\u0300\u031a\u0334T\u030d\u0306\u0301\u0305\u0364\u035f\u033b\u035a\u0330\u031e\u0355\u0329U\u035b\u0300\u0300\u0327\u0347\u0318\u035aCK\u0363\u0367\u030f\u0301\u030b\u0327\u032a\u0348\u033bE\u0321\u0319\u0355D\u0344\u0350\u033d\u0323\u0326 \u0351\u030c\u0311\u0311\u0363\u036b\u0320\u032c\u032c\u0333\u0332?\u0300\u033e\u0300\u030a\u0338\u0320\u0330\u0326\u032e\u031e\u033a\u0349", "");
				this.TimerLegit.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.legitsec, 43, false))
			{
				this.TimerLegit.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Msg.wav", AudioPlayMode.Background);
				MessageBox.Show("exACTlY.", "");
				this.TimerLegit.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.legitsec, 42, false))
			{
				this.TimerLegit.Stop();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Msg.wav", AudioPlayMode.Background);
				MessageBox.Show("yOU hAve tO KNow oNE thING", "");
				this.TimerLegit.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.legitsec, 41, false))
			{
				this.TimerLegit.Stop();
				this.legitsec = 50;
				MyProject.Forms.Screamer5.Show();
			}
		}

		// Token: 0x06000356 RID: 854 RVA: 0x0002179F File Offset: 0x0001F99F
		public void GlitchingVoid()
		{
			MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Bugging.wav", AudioPlayMode.Background);
		}

		// Token: 0x06000357 RID: 855 RVA: 0x000217C4 File Offset: 0x0001F9C4
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void TimerDecompo_Tick(object sender, EventArgs e)
		{
			this.decompo = Operators.SubtractObject(this.decompo, 1);
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 91, false))
			{
				base.TopMost = true;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 90, false))
			{
				this.GlitchingVoid();
				this.Label1.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 89, false))
			{
				this.GlitchingVoid();
				this.Label2.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 88, false))
			{
				this.GlitchingVoid();
				this.Label3.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 87, false))
			{
				this.GlitchingVoid();
				this.Label4.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 86, false))
			{
				this.GlitchingVoid();
				this.Label5.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 85, false))
			{
				this.GlitchingVoid();
				this.Label6.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 84, false))
			{
				this.GlitchingVoid();
				this.Label7.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 83, false))
			{
				this.GlitchingVoid();
				this.Label8.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 82, false))
			{
				this.GlitchingVoid();
				this.Label9.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 81, false))
			{
				this.GlitchingVoid();
				this.Label10.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 80, false))
			{
				this.GlitchingVoid();
				this.Label11.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 79, false))
			{
				this.GlitchingVoid();
				this.Label12.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 78, false))
			{
				this.GlitchingVoid();
				this.Label13.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 77, false))
			{
				this.GlitchingVoid();
				this.Label14.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 76, false))
			{
				this.GlitchingVoid();
				this.Label15.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 75, false))
			{
				this.GlitchingVoid();
				this.Label16.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 74, false))
			{
				this.GlitchingVoid();
				this.Label17.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 73, false))
			{
				this.GlitchingVoid();
				this.Label18.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 72, false))
			{
				this.GlitchingVoid();
				this.Label19.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 71, false))
			{
				this.GlitchingVoid();
				this.Label20.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 70, false))
			{
				this.GlitchingVoid();
				this.Label21.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 69, false))
			{
				this.GlitchingVoid();
				this.Label22.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 68, false))
			{
				this.GlitchingVoid();
				this.Label23.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 67, false))
			{
				this.GlitchingVoid();
				this.Label24.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 66, false))
			{
				this.GlitchingVoid();
				this.Label25.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 65, false))
			{
				this.GlitchingVoid();
				this.Label26.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 64, false))
			{
				this.GlitchingVoid();
				this.Label28.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 63, false))
			{
				this.GlitchingVoid();
				this.Label29.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 62, false))
			{
				this.GlitchingVoid();
				this.Label30.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 61, false))
			{
				this.GlitchingVoid();
				this.Label31.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 60, false))
			{
				this.GlitchingVoid();
				this.Label32.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 59, false))
			{
				this.GlitchingVoid();
				this.Label33.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 58, false))
			{
				this.GlitchingVoid();
				this.Label34.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 57, false))
			{
				this.GlitchingVoid();
				this.Label35.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 56, false))
			{
				this.GlitchingVoid();
				this.Label36.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 55, false))
			{
				this.GlitchingVoid();
				this.Label37.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 54, false))
			{
				this.GlitchingVoid();
				this.Label38.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 53, false))
			{
				this.GlitchingVoid();
				this.Label39.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 52, false))
			{
				this.GlitchingVoid();
				this.Label40.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 51, false))
			{
				this.GlitchingVoid();
				this.Label41.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 50, false))
			{
				this.GlitchingVoid();
				this.Label42.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 49, false))
			{
				this.GlitchingVoid();
				this.Label43.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 48, false))
			{
				this.GlitchingVoid();
				this.Label44.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 47, false))
			{
				this.GlitchingVoid();
				this.Label45.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 46, false))
			{
				this.GlitchingVoid();
				this.Label46.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 45, false))
			{
				this.GlitchingVoid();
				this.Label47.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 44, false))
			{
				this.GlitchingVoid();
				this.Label48.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 43, false))
			{
				this.GlitchingVoid();
				this.Label49.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 42, false))
			{
				this.GlitchingVoid();
				this.Label50.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 41, false))
			{
				this.GlitchingVoid();
				this.Label51.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 40, false))
			{
				this.GlitchingVoid();
				this.Label52.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 39, false))
			{
				this.GlitchingVoid();
				this.Label53.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 38, false))
			{
				this.GlitchingVoid();
				this.Label54.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 37, false))
			{
				this.GlitchingVoid();
				this.Label55.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 36, false))
			{
				this.GlitchingVoid();
				this.Label56.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 35, false))
			{
				MyProject.Computer.Audio.Stop();
				this.PictureBox1.Image = Image.FromFile(this.appPath + "\\assets\\gifs\\BenWpGifContrast.gif");
				try
				{
					File.WriteAllText(this.appPath + "\\datas\\game2ad.dat", "finalroute");
				}
				catch (Exception ex)
				{
				}
				this.trap1.Visible = false;
				this.trap2.Visible = false;
				this.triggerCheater.Visible = false;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 26, false))
			{
				Cursor.Hide();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\NoiseScreamer.wav", AudioPlayMode.Background);
				MyProject.Forms.Backnoiser.Show();
				this.PictureBox1.Visible = true;
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 25, false))
			{
				this.Shakering();
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 22, false))
			{
				this.Shakering();
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 19, false))
			{
				this.Shakering();
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 17, false))
			{
				this.Shakering();
			}
			if (Operators.ConditionalCompareObjectEqual(this.decompo, 15, false))
			{
				this.TimerDecompo.Stop();
				this.decompo = 93;
				ProjectData.EndApp();
			}
		}

		// Token: 0x06000358 RID: 856 RVA: 0x000221F8 File Offset: 0x000203F8
		public void Shakering()
		{
			if (this.ShakeCount >= 300)
			{
				this.ShakeCount = 0;
			}
			checked
			{
				while (this.ShakeCount != 300)
				{
					base.Left -= 30;
					base.Top -= 30;
					base.Top += 30;
					base.Left += 30;
					this.ShakeCount++;
				}
			}
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00022272 File Offset: 0x00020472
		private void triggerCheater_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0400016C RID: 364
		private string appPath;

		// Token: 0x0400016D RID: 365
		private bool bougeCursor;

		// Token: 0x0400016E RID: 366
		private bool isCheated;

		// Token: 0x0400016F RID: 367
		public bool getTrapped;

		// Token: 0x04000170 RID: 368
		private object tsec;

		// Token: 0x04000171 RID: 369
		private object sec;

		// Token: 0x04000172 RID: 370
		private object cheatsec;

		// Token: 0x04000173 RID: 371
		private object legitsec;

		// Token: 0x04000174 RID: 372
		private object decompo;

		// Token: 0x04000175 RID: 373
		private bool youCanGo;

		// Token: 0x04000176 RID: 374
		public bool getScreamed;

		// Token: 0x04000177 RID: 375
		private int cheatingCount;

		// Token: 0x04000178 RID: 376
		private int ShakeCount;

		// Token: 0x04000179 RID: 377
		private object alreadyGetScreamer;
	}
}
