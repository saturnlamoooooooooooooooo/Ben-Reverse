using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using BEN.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace BEN
{
	// Token: 0x0200001B RID: 27
	[DesignerGenerated]
	public partial class SecondGame : Form
	{
		// Token: 0x0600014F RID: 335 RVA: 0x0000F5A4 File Offset: 0x0000D7A4
		public SecondGame()
		{
			base.Load += this.SecondGame_Load;
			base.FormClosing += this.SecondGame_FormClosing;
			base.TextChanged += this.SecondGame_TextChanged;
			this.manycases = 0;
			this.manyerrors = 12;
			this.trytoquit = 0;
			this.appPath = Application.StartupPath;
			this.gametimePassed = false;
			this.noquitLosing = false;
			this.sec = 50;
			this.secrestantes = 60;
			this.InitializeComponent();
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000152 RID: 338 RVA: 0x00015FD9 File Offset: 0x000141D9
		// (set) Token: 0x06000153 RID: 339 RVA: 0x00015FE4 File Offset: 0x000141E4
		internal virtual Button Button54
		{
			[CompilerGenerated]
			get
			{
				return this._Button54;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button54_Click);
				Button button = this._Button54;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button54 = value;
				button = this._Button54;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000154 RID: 340 RVA: 0x00016027 File Offset: 0x00014227
		// (set) Token: 0x06000155 RID: 341 RVA: 0x00016030 File Offset: 0x00014230
		internal virtual Button Button63
		{
			[CompilerGenerated]
			get
			{
				return this._Button63;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button63_Click);
				Button button = this._Button63;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button63 = value;
				button = this._Button63;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000156 RID: 342 RVA: 0x00016073 File Offset: 0x00014273
		// (set) Token: 0x06000157 RID: 343 RVA: 0x0001607C File Offset: 0x0001427C
		internal virtual Button Button45
		{
			[CompilerGenerated]
			get
			{
				return this._Button45;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button45_Click);
				Button button = this._Button45;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button45 = value;
				button = this._Button45;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000158 RID: 344 RVA: 0x000160BF File Offset: 0x000142BF
		// (set) Token: 0x06000159 RID: 345 RVA: 0x000160C8 File Offset: 0x000142C8
		internal virtual Button Button1
		{
			[CompilerGenerated]
			get
			{
				return this._Button1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button1_Click);
				Button button = this._Button1;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button1 = value;
				button = this._Button1;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600015A RID: 346 RVA: 0x0001610B File Offset: 0x0001430B
		// (set) Token: 0x0600015B RID: 347 RVA: 0x00016114 File Offset: 0x00014314
		internal virtual Button Button2
		{
			[CompilerGenerated]
			get
			{
				return this._Button2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button2_Click);
				Button button = this._Button2;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button2 = value;
				button = this._Button2;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600015C RID: 348 RVA: 0x00016157 File Offset: 0x00014357
		// (set) Token: 0x0600015D RID: 349 RVA: 0x00016160 File Offset: 0x00014360
		internal virtual Button Button3
		{
			[CompilerGenerated]
			get
			{
				return this._Button3;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button3_Click);
				Button button = this._Button3;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button3 = value;
				button = this._Button3;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600015E RID: 350 RVA: 0x000161A3 File Offset: 0x000143A3
		// (set) Token: 0x0600015F RID: 351 RVA: 0x000161AC File Offset: 0x000143AC
		internal virtual Button Button4
		{
			[CompilerGenerated]
			get
			{
				return this._Button4;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button4_Click);
				Button button = this._Button4;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button4 = value;
				button = this._Button4;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000160 RID: 352 RVA: 0x000161EF File Offset: 0x000143EF
		// (set) Token: 0x06000161 RID: 353 RVA: 0x000161F8 File Offset: 0x000143F8
		internal virtual Button Button5
		{
			[CompilerGenerated]
			get
			{
				return this._Button5;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button5_Click);
				Button button = this._Button5;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button5 = value;
				button = this._Button5;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000162 RID: 354 RVA: 0x0001623B File Offset: 0x0001443B
		// (set) Token: 0x06000163 RID: 355 RVA: 0x00016244 File Offset: 0x00014444
		internal virtual Button Button7
		{
			[CompilerGenerated]
			get
			{
				return this._Button7;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button7_Click);
				Button button = this._Button7;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button7 = value;
				button = this._Button7;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000164 RID: 356 RVA: 0x00016287 File Offset: 0x00014487
		// (set) Token: 0x06000165 RID: 357 RVA: 0x00016290 File Offset: 0x00014490
		internal virtual Button Button6
		{
			[CompilerGenerated]
			get
			{
				return this._Button6;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button6_Click);
				Button button = this._Button6;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button6 = value;
				button = this._Button6;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000166 RID: 358 RVA: 0x000162D3 File Offset: 0x000144D3
		// (set) Token: 0x06000167 RID: 359 RVA: 0x000162DC File Offset: 0x000144DC
		internal virtual Button Button8
		{
			[CompilerGenerated]
			get
			{
				return this._Button8;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button8_Click);
				Button button = this._Button8;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button8 = value;
				button = this._Button8;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000168 RID: 360 RVA: 0x0001631F File Offset: 0x0001451F
		// (set) Token: 0x06000169 RID: 361 RVA: 0x00016328 File Offset: 0x00014528
		internal virtual Button Button9
		{
			[CompilerGenerated]
			get
			{
				return this._Button9;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button9_Click);
				Button button = this._Button9;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button9 = value;
				button = this._Button9;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600016A RID: 362 RVA: 0x0001636B File Offset: 0x0001456B
		// (set) Token: 0x0600016B RID: 363 RVA: 0x00016374 File Offset: 0x00014574
		internal virtual Button Button10
		{
			[CompilerGenerated]
			get
			{
				return this._Button10;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button10_Click);
				Button button = this._Button10;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button10 = value;
				button = this._Button10;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600016C RID: 364 RVA: 0x000163B7 File Offset: 0x000145B7
		// (set) Token: 0x0600016D RID: 365 RVA: 0x000163C0 File Offset: 0x000145C0
		internal virtual Button Button11
		{
			[CompilerGenerated]
			get
			{
				return this._Button11;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button11_Click);
				Button button = this._Button11;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button11 = value;
				button = this._Button11;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600016E RID: 366 RVA: 0x00016403 File Offset: 0x00014603
		// (set) Token: 0x0600016F RID: 367 RVA: 0x0001640C File Offset: 0x0001460C
		internal virtual Button Button12
		{
			[CompilerGenerated]
			get
			{
				return this._Button12;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button12_Click);
				Button button = this._Button12;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button12 = value;
				button = this._Button12;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000170 RID: 368 RVA: 0x0001644F File Offset: 0x0001464F
		// (set) Token: 0x06000171 RID: 369 RVA: 0x00016458 File Offset: 0x00014658
		internal virtual Button Button13
		{
			[CompilerGenerated]
			get
			{
				return this._Button13;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button13_Click);
				Button button = this._Button13;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button13 = value;
				button = this._Button13;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000172 RID: 370 RVA: 0x0001649B File Offset: 0x0001469B
		// (set) Token: 0x06000173 RID: 371 RVA: 0x000164A4 File Offset: 0x000146A4
		internal virtual Button Button14
		{
			[CompilerGenerated]
			get
			{
				return this._Button14;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button14_Click);
				Button button = this._Button14;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button14 = value;
				button = this._Button14;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000174 RID: 372 RVA: 0x000164E7 File Offset: 0x000146E7
		// (set) Token: 0x06000175 RID: 373 RVA: 0x000164F0 File Offset: 0x000146F0
		internal virtual Button Button16
		{
			[CompilerGenerated]
			get
			{
				return this._Button16;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button16_Click);
				Button button = this._Button16;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button16 = value;
				button = this._Button16;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000176 RID: 374 RVA: 0x00016533 File Offset: 0x00014733
		// (set) Token: 0x06000177 RID: 375 RVA: 0x0001653C File Offset: 0x0001473C
		internal virtual Button Button15
		{
			[CompilerGenerated]
			get
			{
				return this._Button15;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button15_Click);
				Button button = this._Button15;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button15 = value;
				button = this._Button15;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000178 RID: 376 RVA: 0x0001657F File Offset: 0x0001477F
		// (set) Token: 0x06000179 RID: 377 RVA: 0x00016588 File Offset: 0x00014788
		internal virtual Button Button17
		{
			[CompilerGenerated]
			get
			{
				return this._Button17;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button17_Click);
				Button button = this._Button17;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button17 = value;
				button = this._Button17;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600017A RID: 378 RVA: 0x000165CB File Offset: 0x000147CB
		// (set) Token: 0x0600017B RID: 379 RVA: 0x000165D4 File Offset: 0x000147D4
		internal virtual Button Button18
		{
			[CompilerGenerated]
			get
			{
				return this._Button18;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button18_Click);
				Button button = this._Button18;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button18 = value;
				button = this._Button18;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600017C RID: 380 RVA: 0x00016617 File Offset: 0x00014817
		// (set) Token: 0x0600017D RID: 381 RVA: 0x00016620 File Offset: 0x00014820
		internal virtual Button Button19
		{
			[CompilerGenerated]
			get
			{
				return this._Button19;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button19_Click);
				Button button = this._Button19;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button19 = value;
				button = this._Button19;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600017E RID: 382 RVA: 0x00016663 File Offset: 0x00014863
		// (set) Token: 0x0600017F RID: 383 RVA: 0x0001666C File Offset: 0x0001486C
		internal virtual Button Button20
		{
			[CompilerGenerated]
			get
			{
				return this._Button20;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button20_Click);
				Button button = this._Button20;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button20 = value;
				button = this._Button20;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000180 RID: 384 RVA: 0x000166AF File Offset: 0x000148AF
		// (set) Token: 0x06000181 RID: 385 RVA: 0x000166B8 File Offset: 0x000148B8
		internal virtual Button Button21
		{
			[CompilerGenerated]
			get
			{
				return this._Button21;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button21_Click);
				Button button = this._Button21;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button21 = value;
				button = this._Button21;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000182 RID: 386 RVA: 0x000166FB File Offset: 0x000148FB
		// (set) Token: 0x06000183 RID: 387 RVA: 0x00016704 File Offset: 0x00014904
		internal virtual Button Button22
		{
			[CompilerGenerated]
			get
			{
				return this._Button22;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button22_Click);
				Button button = this._Button22;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button22 = value;
				button = this._Button22;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000184 RID: 388 RVA: 0x00016747 File Offset: 0x00014947
		// (set) Token: 0x06000185 RID: 389 RVA: 0x00016750 File Offset: 0x00014950
		internal virtual Button Button23
		{
			[CompilerGenerated]
			get
			{
				return this._Button23;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button23_Click);
				Button button = this._Button23;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button23 = value;
				button = this._Button23;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000186 RID: 390 RVA: 0x00016793 File Offset: 0x00014993
		// (set) Token: 0x06000187 RID: 391 RVA: 0x0001679C File Offset: 0x0001499C
		internal virtual Button Button25
		{
			[CompilerGenerated]
			get
			{
				return this._Button25;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button25_Click);
				Button button = this._Button25;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button25 = value;
				button = this._Button25;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000188 RID: 392 RVA: 0x000167DF File Offset: 0x000149DF
		// (set) Token: 0x06000189 RID: 393 RVA: 0x000167E8 File Offset: 0x000149E8
		internal virtual Button Button26
		{
			[CompilerGenerated]
			get
			{
				return this._Button26;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button26_Click);
				Button button = this._Button26;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button26 = value;
				button = this._Button26;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600018A RID: 394 RVA: 0x0001682B File Offset: 0x00014A2B
		// (set) Token: 0x0600018B RID: 395 RVA: 0x00016834 File Offset: 0x00014A34
		internal virtual Button Button27
		{
			[CompilerGenerated]
			get
			{
				return this._Button27;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button27_Click);
				Button button = this._Button27;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button27 = value;
				button = this._Button27;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600018C RID: 396 RVA: 0x00016877 File Offset: 0x00014A77
		// (set) Token: 0x0600018D RID: 397 RVA: 0x00016880 File Offset: 0x00014A80
		internal virtual Button Button29
		{
			[CompilerGenerated]
			get
			{
				return this._Button29;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button29_Click);
				Button button = this._Button29;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button29 = value;
				button = this._Button29;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600018E RID: 398 RVA: 0x000168C3 File Offset: 0x00014AC3
		// (set) Token: 0x0600018F RID: 399 RVA: 0x000168CC File Offset: 0x00014ACC
		internal virtual Button Button28
		{
			[CompilerGenerated]
			get
			{
				return this._Button28;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button28_Click);
				Button button = this._Button28;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button28 = value;
				button = this._Button28;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000190 RID: 400 RVA: 0x0001690F File Offset: 0x00014B0F
		// (set) Token: 0x06000191 RID: 401 RVA: 0x00016918 File Offset: 0x00014B18
		internal virtual Button Button30
		{
			[CompilerGenerated]
			get
			{
				return this._Button30;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button30_Click);
				Button button = this._Button30;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button30 = value;
				button = this._Button30;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000192 RID: 402 RVA: 0x0001695B File Offset: 0x00014B5B
		// (set) Token: 0x06000193 RID: 403 RVA: 0x00016964 File Offset: 0x00014B64
		internal virtual Button Button31
		{
			[CompilerGenerated]
			get
			{
				return this._Button31;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button31_Click);
				Button button = this._Button31;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button31 = value;
				button = this._Button31;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000194 RID: 404 RVA: 0x000169A7 File Offset: 0x00014BA7
		// (set) Token: 0x06000195 RID: 405 RVA: 0x000169B0 File Offset: 0x00014BB0
		internal virtual Button Button32
		{
			[CompilerGenerated]
			get
			{
				return this._Button32;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button32_Click);
				Button button = this._Button32;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button32 = value;
				button = this._Button32;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000196 RID: 406 RVA: 0x000169F3 File Offset: 0x00014BF3
		// (set) Token: 0x06000197 RID: 407 RVA: 0x000169FC File Offset: 0x00014BFC
		internal virtual Button Button33
		{
			[CompilerGenerated]
			get
			{
				return this._Button33;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button33_Click);
				Button button = this._Button33;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button33 = value;
				button = this._Button33;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000198 RID: 408 RVA: 0x00016A3F File Offset: 0x00014C3F
		// (set) Token: 0x06000199 RID: 409 RVA: 0x00016A48 File Offset: 0x00014C48
		internal virtual Button Button34
		{
			[CompilerGenerated]
			get
			{
				return this._Button34;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button34_Click);
				Button button = this._Button34;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button34 = value;
				button = this._Button34;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600019A RID: 410 RVA: 0x00016A8B File Offset: 0x00014C8B
		// (set) Token: 0x0600019B RID: 411 RVA: 0x00016A94 File Offset: 0x00014C94
		internal virtual Button Button35
		{
			[CompilerGenerated]
			get
			{
				return this._Button35;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button35_Click);
				Button button = this._Button35;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button35 = value;
				button = this._Button35;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600019C RID: 412 RVA: 0x00016AD7 File Offset: 0x00014CD7
		// (set) Token: 0x0600019D RID: 413 RVA: 0x00016AE0 File Offset: 0x00014CE0
		internal virtual Button Button37
		{
			[CompilerGenerated]
			get
			{
				return this._Button37;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button37_Click);
				Button button = this._Button37;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button37 = value;
				button = this._Button37;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600019E RID: 414 RVA: 0x00016B23 File Offset: 0x00014D23
		// (set) Token: 0x0600019F RID: 415 RVA: 0x00016B2C File Offset: 0x00014D2C
		internal virtual Button Button38
		{
			[CompilerGenerated]
			get
			{
				return this._Button38;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button38_Click);
				Button button = this._Button38;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button38 = value;
				button = this._Button38;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x00016B6F File Offset: 0x00014D6F
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x00016B78 File Offset: 0x00014D78
		internal virtual Button Button36
		{
			[CompilerGenerated]
			get
			{
				return this._Button36;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button36_Click);
				Button button = this._Button36;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button36 = value;
				button = this._Button36;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x00016BBB File Offset: 0x00014DBB
		// (set) Token: 0x060001A3 RID: 419 RVA: 0x00016BC4 File Offset: 0x00014DC4
		internal virtual Button Button39
		{
			[CompilerGenerated]
			get
			{
				return this._Button39;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button39_Click);
				Button button = this._Button39;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button39 = value;
				button = this._Button39;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x00016C07 File Offset: 0x00014E07
		// (set) Token: 0x060001A5 RID: 421 RVA: 0x00016C10 File Offset: 0x00014E10
		internal virtual Button Button40
		{
			[CompilerGenerated]
			get
			{
				return this._Button40;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button40_Click);
				Button button = this._Button40;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button40 = value;
				button = this._Button40;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x00016C53 File Offset: 0x00014E53
		// (set) Token: 0x060001A7 RID: 423 RVA: 0x00016C5C File Offset: 0x00014E5C
		internal virtual Button Button42
		{
			[CompilerGenerated]
			get
			{
				return this._Button42;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button42_Click);
				Button button = this._Button42;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button42 = value;
				button = this._Button42;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x00016C9F File Offset: 0x00014E9F
		// (set) Token: 0x060001A9 RID: 425 RVA: 0x00016CA8 File Offset: 0x00014EA8
		internal virtual Button Button43
		{
			[CompilerGenerated]
			get
			{
				return this._Button43;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button43_Click);
				Button button = this._Button43;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button43 = value;
				button = this._Button43;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060001AA RID: 426 RVA: 0x00016CEB File Offset: 0x00014EEB
		// (set) Token: 0x060001AB RID: 427 RVA: 0x00016CF4 File Offset: 0x00014EF4
		internal virtual Button Button41
		{
			[CompilerGenerated]
			get
			{
				return this._Button41;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button41_Click);
				Button button = this._Button41;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button41 = value;
				button = this._Button41;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060001AC RID: 428 RVA: 0x00016D37 File Offset: 0x00014F37
		// (set) Token: 0x060001AD RID: 429 RVA: 0x00016D40 File Offset: 0x00014F40
		internal virtual Button Button44
		{
			[CompilerGenerated]
			get
			{
				return this._Button44;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button44_Click);
				Button button = this._Button44;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button44 = value;
				button = this._Button44;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060001AE RID: 430 RVA: 0x00016D83 File Offset: 0x00014F83
		// (set) Token: 0x060001AF RID: 431 RVA: 0x00016D8C File Offset: 0x00014F8C
		internal virtual Button Button46
		{
			[CompilerGenerated]
			get
			{
				return this._Button46;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button46_Click);
				Button button = this._Button46;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button46 = value;
				button = this._Button46;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x00016DCF File Offset: 0x00014FCF
		// (set) Token: 0x060001B1 RID: 433 RVA: 0x00016DD8 File Offset: 0x00014FD8
		internal virtual Button Button47
		{
			[CompilerGenerated]
			get
			{
				return this._Button47;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button47_Click);
				Button button = this._Button47;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button47 = value;
				button = this._Button47;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x00016E1B File Offset: 0x0001501B
		// (set) Token: 0x060001B3 RID: 435 RVA: 0x00016E24 File Offset: 0x00015024
		internal virtual Button Button48
		{
			[CompilerGenerated]
			get
			{
				return this._Button48;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button48_Click);
				Button button = this._Button48;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button48 = value;
				button = this._Button48;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x00016E67 File Offset: 0x00015067
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x00016E70 File Offset: 0x00015070
		internal virtual Button Button49
		{
			[CompilerGenerated]
			get
			{
				return this._Button49;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button49_Click);
				Button button = this._Button49;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button49 = value;
				button = this._Button49;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x00016EB3 File Offset: 0x000150B3
		// (set) Token: 0x060001B7 RID: 439 RVA: 0x00016EBC File Offset: 0x000150BC
		internal virtual Button Button24
		{
			[CompilerGenerated]
			get
			{
				return this._Button24;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button24_Click);
				Button button = this._Button24;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button24 = value;
				button = this._Button24;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x00016EFF File Offset: 0x000150FF
		// (set) Token: 0x060001B9 RID: 441 RVA: 0x00016F08 File Offset: 0x00015108
		internal virtual Button Button50
		{
			[CompilerGenerated]
			get
			{
				return this._Button50;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button50_Click);
				Button button = this._Button50;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button50 = value;
				button = this._Button50;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060001BA RID: 442 RVA: 0x00016F4B File Offset: 0x0001514B
		// (set) Token: 0x060001BB RID: 443 RVA: 0x00016F54 File Offset: 0x00015154
		internal virtual Button Button51
		{
			[CompilerGenerated]
			get
			{
				return this._Button51;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button51_Click);
				Button button = this._Button51;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button51 = value;
				button = this._Button51;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060001BC RID: 444 RVA: 0x00016F97 File Offset: 0x00015197
		// (set) Token: 0x060001BD RID: 445 RVA: 0x00016FA0 File Offset: 0x000151A0
		internal virtual Button Button52
		{
			[CompilerGenerated]
			get
			{
				return this._Button52;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button52_Click);
				Button button = this._Button52;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button52 = value;
				button = this._Button52;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060001BE RID: 446 RVA: 0x00016FE3 File Offset: 0x000151E3
		// (set) Token: 0x060001BF RID: 447 RVA: 0x00016FEC File Offset: 0x000151EC
		internal virtual Button Button53
		{
			[CompilerGenerated]
			get
			{
				return this._Button53;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button53_Click);
				Button button = this._Button53;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button53 = value;
				button = this._Button53;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x0001702F File Offset: 0x0001522F
		// (set) Token: 0x060001C1 RID: 449 RVA: 0x00017038 File Offset: 0x00015238
		internal virtual Button Button55
		{
			[CompilerGenerated]
			get
			{
				return this._Button55;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button55_Click);
				Button button = this._Button55;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button55 = value;
				button = this._Button55;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x0001707B File Offset: 0x0001527B
		// (set) Token: 0x060001C3 RID: 451 RVA: 0x00017084 File Offset: 0x00015284
		internal virtual Button Button56
		{
			[CompilerGenerated]
			get
			{
				return this._Button56;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button56_Click);
				Button button = this._Button56;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button56 = value;
				button = this._Button56;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x000170C7 File Offset: 0x000152C7
		// (set) Token: 0x060001C5 RID: 453 RVA: 0x000170D0 File Offset: 0x000152D0
		internal virtual Button Button57
		{
			[CompilerGenerated]
			get
			{
				return this._Button57;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button57_Click);
				Button button = this._Button57;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button57 = value;
				button = this._Button57;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x00017113 File Offset: 0x00015313
		// (set) Token: 0x060001C7 RID: 455 RVA: 0x0001711C File Offset: 0x0001531C
		internal virtual Button Button58
		{
			[CompilerGenerated]
			get
			{
				return this._Button58;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button58_Click);
				Button button = this._Button58;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button58 = value;
				button = this._Button58;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x0001715F File Offset: 0x0001535F
		// (set) Token: 0x060001C9 RID: 457 RVA: 0x00017168 File Offset: 0x00015368
		internal virtual Button Button59
		{
			[CompilerGenerated]
			get
			{
				return this._Button59;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button59_Click);
				Button button = this._Button59;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button59 = value;
				button = this._Button59;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060001CA RID: 458 RVA: 0x000171AB File Offset: 0x000153AB
		// (set) Token: 0x060001CB RID: 459 RVA: 0x000171B4 File Offset: 0x000153B4
		internal virtual Button Button60
		{
			[CompilerGenerated]
			get
			{
				return this._Button60;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button60_Click);
				Button button = this._Button60;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button60 = value;
				button = this._Button60;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060001CC RID: 460 RVA: 0x000171F7 File Offset: 0x000153F7
		// (set) Token: 0x060001CD RID: 461 RVA: 0x00017200 File Offset: 0x00015400
		internal virtual Button Button61
		{
			[CompilerGenerated]
			get
			{
				return this._Button61;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button61_Click);
				Button button = this._Button61;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button61 = value;
				button = this._Button61;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060001CE RID: 462 RVA: 0x00017243 File Offset: 0x00015443
		// (set) Token: 0x060001CF RID: 463 RVA: 0x0001724C File Offset: 0x0001544C
		internal virtual Button Button62
		{
			[CompilerGenerated]
			get
			{
				return this._Button62;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button62_Click);
				Button button = this._Button62;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button62 = value;
				button = this._Button62;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x0001728F File Offset: 0x0001548F
		// (set) Token: 0x060001D1 RID: 465 RVA: 0x00017298 File Offset: 0x00015498
		internal virtual Button Button64
		{
			[CompilerGenerated]
			get
			{
				return this._Button64;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button64_Click);
				Button button = this._Button64;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button64 = value;
				button = this._Button64;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x000172DB File Offset: 0x000154DB
		// (set) Token: 0x060001D3 RID: 467 RVA: 0x000172E4 File Offset: 0x000154E4
		internal virtual Button Button65
		{
			[CompilerGenerated]
			get
			{
				return this._Button65;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button65_Click);
				Button button = this._Button65;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button65 = value;
				button = this._Button65;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x00017327 File Offset: 0x00015527
		// (set) Token: 0x060001D5 RID: 469 RVA: 0x00017330 File Offset: 0x00015530
		internal virtual Button Button66
		{
			[CompilerGenerated]
			get
			{
				return this._Button66;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button66_Click);
				Button button = this._Button66;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button66 = value;
				button = this._Button66;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x00017373 File Offset: 0x00015573
		// (set) Token: 0x060001D7 RID: 471 RVA: 0x0001737C File Offset: 0x0001557C
		internal virtual Button Button67
		{
			[CompilerGenerated]
			get
			{
				return this._Button67;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button67_Click);
				Button button = this._Button67;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button67 = value;
				button = this._Button67;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x000173BF File Offset: 0x000155BF
		// (set) Token: 0x060001D9 RID: 473 RVA: 0x000173C8 File Offset: 0x000155C8
		internal virtual Button Button68
		{
			[CompilerGenerated]
			get
			{
				return this._Button68;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button68_Click);
				Button button = this._Button68;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button68 = value;
				button = this._Button68;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060001DA RID: 474 RVA: 0x0001740B File Offset: 0x0001560B
		// (set) Token: 0x060001DB RID: 475 RVA: 0x00017414 File Offset: 0x00015614
		internal virtual Button Button69
		{
			[CompilerGenerated]
			get
			{
				return this._Button69;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button69_Click);
				Button button = this._Button69;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button69 = value;
				button = this._Button69;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060001DC RID: 476 RVA: 0x00017457 File Offset: 0x00015657
		// (set) Token: 0x060001DD RID: 477 RVA: 0x00017460 File Offset: 0x00015660
		internal virtual Button Button70
		{
			[CompilerGenerated]
			get
			{
				return this._Button70;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button70_Click);
				Button button = this._Button70;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button70 = value;
				button = this._Button70;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060001DE RID: 478 RVA: 0x000174A3 File Offset: 0x000156A3
		// (set) Token: 0x060001DF RID: 479 RVA: 0x000174AC File Offset: 0x000156AC
		internal virtual Button Button71
		{
			[CompilerGenerated]
			get
			{
				return this._Button71;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button71_Click);
				Button button = this._Button71;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button71 = value;
				button = this._Button71;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x000174EF File Offset: 0x000156EF
		// (set) Token: 0x060001E1 RID: 481 RVA: 0x000174F8 File Offset: 0x000156F8
		internal virtual Button Button72
		{
			[CompilerGenerated]
			get
			{
				return this._Button72;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button72_Click);
				Button button = this._Button72;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button72 = value;
				button = this._Button72;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x0001753B File Offset: 0x0001573B
		// (set) Token: 0x060001E3 RID: 483 RVA: 0x00017544 File Offset: 0x00015744
		internal virtual Button Button73
		{
			[CompilerGenerated]
			get
			{
				return this._Button73;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button73_Click);
				Button button = this._Button73;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button73 = value;
				button = this._Button73;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x00017587 File Offset: 0x00015787
		// (set) Token: 0x060001E5 RID: 485 RVA: 0x00017590 File Offset: 0x00015790
		internal virtual Button Button74
		{
			[CompilerGenerated]
			get
			{
				return this._Button74;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button74_Click);
				Button button = this._Button74;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button74 = value;
				button = this._Button74;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x000175D3 File Offset: 0x000157D3
		// (set) Token: 0x060001E7 RID: 487 RVA: 0x000175DC File Offset: 0x000157DC
		internal virtual Button Button75
		{
			[CompilerGenerated]
			get
			{
				return this._Button75;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button75_Click);
				Button button = this._Button75;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button75 = value;
				button = this._Button75;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x0001761F File Offset: 0x0001581F
		// (set) Token: 0x060001E9 RID: 489 RVA: 0x00017628 File Offset: 0x00015828
		internal virtual Button Button76
		{
			[CompilerGenerated]
			get
			{
				return this._Button76;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button76_Click);
				Button button = this._Button76;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button76 = value;
				button = this._Button76;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060001EA RID: 490 RVA: 0x0001766B File Offset: 0x0001586B
		// (set) Token: 0x060001EB RID: 491 RVA: 0x00017674 File Offset: 0x00015874
		internal virtual Button Button77
		{
			[CompilerGenerated]
			get
			{
				return this._Button77;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button77_Click);
				Button button = this._Button77;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button77 = value;
				button = this._Button77;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060001EC RID: 492 RVA: 0x000176B7 File Offset: 0x000158B7
		// (set) Token: 0x060001ED RID: 493 RVA: 0x000176C0 File Offset: 0x000158C0
		internal virtual Button Button78
		{
			[CompilerGenerated]
			get
			{
				return this._Button78;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button78_Click);
				Button button = this._Button78;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button78 = value;
				button = this._Button78;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060001EE RID: 494 RVA: 0x00017703 File Offset: 0x00015903
		// (set) Token: 0x060001EF RID: 495 RVA: 0x0001770C File Offset: 0x0001590C
		internal virtual Button Button79
		{
			[CompilerGenerated]
			get
			{
				return this._Button79;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button79_Click);
				Button button = this._Button79;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button79 = value;
				button = this._Button79;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x0001774F File Offset: 0x0001594F
		// (set) Token: 0x060001F1 RID: 497 RVA: 0x00017758 File Offset: 0x00015958
		internal virtual Button Button80
		{
			[CompilerGenerated]
			get
			{
				return this._Button80;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button80_Click);
				Button button = this._Button80;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button80 = value;
				button = this._Button80;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x0001779B File Offset: 0x0001599B
		// (set) Token: 0x060001F3 RID: 499 RVA: 0x000177A4 File Offset: 0x000159A4
		internal virtual Button Button81
		{
			[CompilerGenerated]
			get
			{
				return this._Button81;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button81_Click);
				Button button = this._Button81;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button81 = value;
				button = this._Button81;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x000177E7 File Offset: 0x000159E7
		// (set) Token: 0x060001F5 RID: 501 RVA: 0x000177F0 File Offset: 0x000159F0
		internal virtual Button Button82
		{
			[CompilerGenerated]
			get
			{
				return this._Button82;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button82_Click);
				Button button = this._Button82;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button82 = value;
				button = this._Button82;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x00017833 File Offset: 0x00015A33
		// (set) Token: 0x060001F7 RID: 503 RVA: 0x0001783C File Offset: 0x00015A3C
		internal virtual Button Button83
		{
			[CompilerGenerated]
			get
			{
				return this._Button83;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button83_Click);
				Button button = this._Button83;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button83 = value;
				button = this._Button83;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x0001787F File Offset: 0x00015A7F
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x00017888 File Offset: 0x00015A88
		internal virtual Button Button84
		{
			[CompilerGenerated]
			get
			{
				return this._Button84;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button84_Click);
				Button button = this._Button84;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button84 = value;
				button = this._Button84;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060001FA RID: 506 RVA: 0x000178CB File Offset: 0x00015ACB
		// (set) Token: 0x060001FB RID: 507 RVA: 0x000178D4 File Offset: 0x00015AD4
		internal virtual Button Button85
		{
			[CompilerGenerated]
			get
			{
				return this._Button85;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button85_Click);
				Button button = this._Button85;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button85 = value;
				button = this._Button85;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060001FC RID: 508 RVA: 0x00017917 File Offset: 0x00015B17
		// (set) Token: 0x060001FD RID: 509 RVA: 0x00017920 File Offset: 0x00015B20
		internal virtual Button Button86
		{
			[CompilerGenerated]
			get
			{
				return this._Button86;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button86_Click);
				Button button = this._Button86;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button86 = value;
				button = this._Button86;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060001FE RID: 510 RVA: 0x00017963 File Offset: 0x00015B63
		// (set) Token: 0x060001FF RID: 511 RVA: 0x0001796C File Offset: 0x00015B6C
		internal virtual Button Button87
		{
			[CompilerGenerated]
			get
			{
				return this._Button87;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button87_Click);
				Button button = this._Button87;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button87 = value;
				button = this._Button87;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000200 RID: 512 RVA: 0x000179AF File Offset: 0x00015BAF
		// (set) Token: 0x06000201 RID: 513 RVA: 0x000179B8 File Offset: 0x00015BB8
		internal virtual Button Button88
		{
			[CompilerGenerated]
			get
			{
				return this._Button88;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button88_Click);
				Button button = this._Button88;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button88 = value;
				button = this._Button88;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000202 RID: 514 RVA: 0x000179FB File Offset: 0x00015BFB
		// (set) Token: 0x06000203 RID: 515 RVA: 0x00017A04 File Offset: 0x00015C04
		internal virtual Button Button89
		{
			[CompilerGenerated]
			get
			{
				return this._Button89;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button89_Click);
				Button button = this._Button89;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button89 = value;
				button = this._Button89;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000204 RID: 516 RVA: 0x00017A47 File Offset: 0x00015C47
		// (set) Token: 0x06000205 RID: 517 RVA: 0x00017A50 File Offset: 0x00015C50
		internal virtual Button Button90
		{
			[CompilerGenerated]
			get
			{
				return this._Button90;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button90_Click);
				Button button = this._Button90;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button90 = value;
				button = this._Button90;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000206 RID: 518 RVA: 0x00017A93 File Offset: 0x00015C93
		// (set) Token: 0x06000207 RID: 519 RVA: 0x00017A9C File Offset: 0x00015C9C
		internal virtual Button Button91
		{
			[CompilerGenerated]
			get
			{
				return this._Button91;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button91_Click);
				Button button = this._Button91;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button91 = value;
				button = this._Button91;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000208 RID: 520 RVA: 0x00017ADF File Offset: 0x00015CDF
		// (set) Token: 0x06000209 RID: 521 RVA: 0x00017AE8 File Offset: 0x00015CE8
		internal virtual Button Button92
		{
			[CompilerGenerated]
			get
			{
				return this._Button92;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button92_Click);
				Button button = this._Button92;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button92 = value;
				button = this._Button92;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x0600020A RID: 522 RVA: 0x00017B2B File Offset: 0x00015D2B
		// (set) Token: 0x0600020B RID: 523 RVA: 0x00017B34 File Offset: 0x00015D34
		internal virtual Button Button93
		{
			[CompilerGenerated]
			get
			{
				return this._Button93;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button93_Click);
				Button button = this._Button93;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button93 = value;
				button = this._Button93;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x0600020C RID: 524 RVA: 0x00017B77 File Offset: 0x00015D77
		// (set) Token: 0x0600020D RID: 525 RVA: 0x00017B80 File Offset: 0x00015D80
		internal virtual Button Button94
		{
			[CompilerGenerated]
			get
			{
				return this._Button94;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button94_Click);
				Button button = this._Button94;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button94 = value;
				button = this._Button94;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600020E RID: 526 RVA: 0x00017BC3 File Offset: 0x00015DC3
		// (set) Token: 0x0600020F RID: 527 RVA: 0x00017BCC File Offset: 0x00015DCC
		internal virtual Button Button95
		{
			[CompilerGenerated]
			get
			{
				return this._Button95;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button95_Click);
				Button button = this._Button95;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button95 = value;
				button = this._Button95;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000210 RID: 528 RVA: 0x00017C0F File Offset: 0x00015E0F
		// (set) Token: 0x06000211 RID: 529 RVA: 0x00017C18 File Offset: 0x00015E18
		internal virtual Button Button96
		{
			[CompilerGenerated]
			get
			{
				return this._Button96;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button96_Click);
				Button button = this._Button96;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button96 = value;
				button = this._Button96;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000212 RID: 530 RVA: 0x00017C5B File Offset: 0x00015E5B
		// (set) Token: 0x06000213 RID: 531 RVA: 0x00017C64 File Offset: 0x00015E64
		internal virtual Button Button97
		{
			[CompilerGenerated]
			get
			{
				return this._Button97;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button97_Click);
				Button button = this._Button97;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button97 = value;
				button = this._Button97;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000214 RID: 532 RVA: 0x00017CA7 File Offset: 0x00015EA7
		// (set) Token: 0x06000215 RID: 533 RVA: 0x00017CB0 File Offset: 0x00015EB0
		internal virtual Button Button98
		{
			[CompilerGenerated]
			get
			{
				return this._Button98;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button98_Click);
				Button button = this._Button98;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button98 = value;
				button = this._Button98;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000216 RID: 534 RVA: 0x00017CF3 File Offset: 0x00015EF3
		// (set) Token: 0x06000217 RID: 535 RVA: 0x00017CFC File Offset: 0x00015EFC
		internal virtual Button Button99
		{
			[CompilerGenerated]
			get
			{
				return this._Button99;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button99_Click);
				Button button = this._Button99;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button99 = value;
				button = this._Button99;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000218 RID: 536 RVA: 0x00017D3F File Offset: 0x00015F3F
		// (set) Token: 0x06000219 RID: 537 RVA: 0x00017D48 File Offset: 0x00015F48
		internal virtual Button Button100
		{
			[CompilerGenerated]
			get
			{
				return this._Button100;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button100_Click);
				Button button = this._Button100;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button100 = value;
				button = this._Button100;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x0600021A RID: 538 RVA: 0x00017D8B File Offset: 0x00015F8B
		// (set) Token: 0x0600021B RID: 539 RVA: 0x00017D94 File Offset: 0x00015F94
		internal virtual Button Button101
		{
			[CompilerGenerated]
			get
			{
				return this._Button101;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button101_Click);
				Button button = this._Button101;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button101 = value;
				button = this._Button101;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x0600021C RID: 540 RVA: 0x00017DD7 File Offset: 0x00015FD7
		// (set) Token: 0x0600021D RID: 541 RVA: 0x00017DE0 File Offset: 0x00015FE0
		internal virtual Button Button102
		{
			[CompilerGenerated]
			get
			{
				return this._Button102;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button102_Click);
				Button button = this._Button102;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button102 = value;
				button = this._Button102;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x0600021E RID: 542 RVA: 0x00017E23 File Offset: 0x00016023
		// (set) Token: 0x0600021F RID: 543 RVA: 0x00017E2C File Offset: 0x0001602C
		internal virtual Button Button103
		{
			[CompilerGenerated]
			get
			{
				return this._Button103;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button103_Click);
				Button button = this._Button103;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button103 = value;
				button = this._Button103;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000220 RID: 544 RVA: 0x00017E6F File Offset: 0x0001606F
		// (set) Token: 0x06000221 RID: 545 RVA: 0x00017E78 File Offset: 0x00016078
		internal virtual Button Button104
		{
			[CompilerGenerated]
			get
			{
				return this._Button104;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button104_Click);
				Button button = this._Button104;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button104 = value;
				button = this._Button104;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000222 RID: 546 RVA: 0x00017EBB File Offset: 0x000160BB
		// (set) Token: 0x06000223 RID: 547 RVA: 0x00017EC4 File Offset: 0x000160C4
		internal virtual Button Button105
		{
			[CompilerGenerated]
			get
			{
				return this._Button105;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button105_Click);
				Button button = this._Button105;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button105 = value;
				button = this._Button105;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000224 RID: 548 RVA: 0x00017F07 File Offset: 0x00016107
		// (set) Token: 0x06000225 RID: 549 RVA: 0x00017F10 File Offset: 0x00016110
		internal virtual Button Button106
		{
			[CompilerGenerated]
			get
			{
				return this._Button106;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button106_Click);
				Button button = this._Button106;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button106 = value;
				button = this._Button106;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000226 RID: 550 RVA: 0x00017F53 File Offset: 0x00016153
		// (set) Token: 0x06000227 RID: 551 RVA: 0x00017F5C File Offset: 0x0001615C
		internal virtual Button Button107
		{
			[CompilerGenerated]
			get
			{
				return this._Button107;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button107_Click);
				Button button = this._Button107;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button107 = value;
				button = this._Button107;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000228 RID: 552 RVA: 0x00017F9F File Offset: 0x0001619F
		// (set) Token: 0x06000229 RID: 553 RVA: 0x00017FA8 File Offset: 0x000161A8
		internal virtual Button Button108
		{
			[CompilerGenerated]
			get
			{
				return this._Button108;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button108_Click);
				Button button = this._Button108;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button108 = value;
				button = this._Button108;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600022A RID: 554 RVA: 0x00017FEB File Offset: 0x000161EB
		// (set) Token: 0x0600022B RID: 555 RVA: 0x00017FF4 File Offset: 0x000161F4
		internal virtual Button Button109
		{
			[CompilerGenerated]
			get
			{
				return this._Button109;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button109_Click);
				Button button = this._Button109;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button109 = value;
				button = this._Button109;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x0600022C RID: 556 RVA: 0x00018037 File Offset: 0x00016237
		// (set) Token: 0x0600022D RID: 557 RVA: 0x00018040 File Offset: 0x00016240
		internal virtual Button Button110
		{
			[CompilerGenerated]
			get
			{
				return this._Button110;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button110_Click);
				Button button = this._Button110;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button110 = value;
				button = this._Button110;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x0600022E RID: 558 RVA: 0x00018083 File Offset: 0x00016283
		// (set) Token: 0x0600022F RID: 559 RVA: 0x0001808C File Offset: 0x0001628C
		internal virtual Button Button111
		{
			[CompilerGenerated]
			get
			{
				return this._Button111;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button111_Click);
				Button button = this._Button111;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button111 = value;
				button = this._Button111;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000230 RID: 560 RVA: 0x000180CF File Offset: 0x000162CF
		// (set) Token: 0x06000231 RID: 561 RVA: 0x000180D8 File Offset: 0x000162D8
		internal virtual Button Button112
		{
			[CompilerGenerated]
			get
			{
				return this._Button112;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button112_Click);
				Button button = this._Button112;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button112 = value;
				button = this._Button112;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000232 RID: 562 RVA: 0x0001811B File Offset: 0x0001631B
		// (set) Token: 0x06000233 RID: 563 RVA: 0x00018124 File Offset: 0x00016324
		internal virtual global::System.Windows.Forms.Timer TimerVerifieur
		{
			[CompilerGenerated]
			get
			{
				return this._TimerVerifieur;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.TimerVerifieur_Tick);
				global::System.Windows.Forms.Timer timer = this._TimerVerifieur;
				if (timer != null)
				{
					timer.Tick -= eventHandler;
				}
				this._TimerVerifieur = value;
				timer = this._TimerVerifieur;
				if (timer != null)
				{
					timer.Tick += eventHandler;
				}
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000234 RID: 564 RVA: 0x00018167 File Offset: 0x00016367
		// (set) Token: 0x06000235 RID: 565 RVA: 0x00018170 File Offset: 0x00016370
		internal virtual global::System.Windows.Forms.Timer LeMinuteur
		{
			[CompilerGenerated]
			get
			{
				return this._LeMinuteur;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.LeMinuteur_Tick);
				global::System.Windows.Forms.Timer timer = this._LeMinuteur;
				if (timer != null)
				{
					timer.Tick -= eventHandler;
				}
				this._LeMinuteur = value;
				timer = this._LeMinuteur;
				if (timer != null)
				{
					timer.Tick += eventHandler;
				}
			}
		}

		// Token: 0x06000236 RID: 566 RVA: 0x000181B4 File Offset: 0x000163B4
		private void SecondGame_Load(object sender, EventArgs e)
		{
			Cursor.Show();
			this.manycases = 0;
			this.manyerrors = 12;
			this.trytoquit = 0;
			this.gametimePassed = false;
			this.secrestantes = 60;
			this.noquitLosing = false;
			string text = MyProject.Computer.FileSystem.ReadAllText(this.appPath + "\\datas\\game2ad.dat");
			if (text.Contains("yes"))
			{
				this.alreadyDead = true;
			}
			else if (text.Contains("no"))
			{
				this.alreadyDead = false;
			}
			this.TimerVerifieur.Start();
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0001824C File Offset: 0x0001644C
		private void SecondGame_FormClosing(object sender, FormClosingEventArgs e)
		{
			checked
			{
				if (!this.noquitLosing)
				{
					e.Cancel = true;
					this.trytoquit++;
					if (this.trytoquit == 1)
					{
						MessageBox.Show("WhAT'S THe poInt oF eScaPINg...", "");
					}
					if (this.trytoquit == 2)
					{
						MessageBox.Show("yOu ARe sTUCKeD.", "");
					}
					if (this.trytoquit == 3)
					{
						MessageBox.Show("dO YOu unDERsTAND ?", "");
					}
					if (this.trytoquit == 4)
					{
						MessageBox.Show("nO...", "");
					}
					if (this.trytoquit == 5)
					{
						MessageBox.Show("no yOU dOn'T...", "");
					}
					if (this.trytoquit == 6)
					{
						MessageBox.Show("I ThOUGht yoU'D GEt uSEd tO iT", "");
					}
					if (this.trytoquit == 7)
					{
						MessageBox.Show("yOu SUrRenDED To mE", "");
					}
					if (this.trytoquit == 8)
					{
						MyProject.Forms.Screamer2.PictureBox1.Visible = true;
						MessageBox.Show("yOU SHOuLD StOP.", "");
					}
					if (this.trytoquit == 9)
					{
						MyProject.Computer.Audio.Stop();
						base.TopMost = false;
						MyProject.Forms.Screamer2.Show();
					}
					int num = this.trytoquit;
					return;
				}
				if (this.noquitLosing)
				{
					e.Cancel = false;
				}
			}
		}

		// Token: 0x06000238 RID: 568 RVA: 0x0001839F File Offset: 0x0001659F
		public void remetMusique()
		{
			MyProject.Computer.Audio.Play(this.appPath + "\\assets\\BenMusic2.wav", AudioPlayMode.BackgroundLoop);
		}

		// Token: 0x06000239 RID: 569 RVA: 0x000183C4 File Offset: 0x000165C4
		private void Button3_Click(object sender, EventArgs e)
		{
			this.Button3.BackColor = Color.FromArgb(0, 192, 0);
			this.Button3.Enabled = false;
			this.Button3.Text = "";
			checked
			{
				this.manycases++;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00018440 File Offset: 0x00016640
		private void Button50_Click(object sender, EventArgs e)
		{
			this.Button50.BackColor = Color.FromArgb(192, 0, 0);
			this.Button50.Enabled = false;
			this.Button50.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x0600023B RID: 571 RVA: 0x000184BC File Offset: 0x000166BC
		private void SecondGame_TextChanged(object sender, EventArgs e)
		{
			if (this.Text.Contains(" 1 ERRORS"))
			{
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERROR LEFT";
			}
			if (this.manycases == 51)
			{
				MyProject.Computer.Audio.Stop();
				base.Hide();
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Game2End.wav", AudioPlayMode.WaitToComplete);
				if (this.gametimePassed)
				{
					try
					{
						File.WriteAllText(this.appPath + "\\datas\\game2ad.dat", "yes");
					}
					catch (Exception ex)
					{
					}
					MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Msg.wav", AudioPlayMode.Background);
					MessageBox.Show("yOU'rE qUItE goOd.. .", "");
					Thread.Sleep(2000);
					MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Msg.wav", AudioPlayMode.Background);
					MessageBox.Show("yES..yEs.. .", "");
					Thread.Sleep(2000);
					MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Msg.wav", AudioPlayMode.Background);
					MessageBox.Show("bUT I foRGOt oNe rULe aBoUT tHis lITTlE gAME :", "");
					Thread.Sleep(2000);
					MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Laughing.wav", AudioPlayMode.BackgroundLoop);
					MessageBox.Show("Y\u0334O\u0334U\u0489 \u035c \u0321O\u0334NL\u0315Y HAD \u0338 \u0341 ONE \u0334 \u0327M\u0315I\u034fN\u035fUT\u035eE\u035c \u0340 \u035d \u0328TO \u0362PL\u0360A\u0337Y", "");
					base.Hide();
					MyProject.Forms.Screamer3.Show();
				}
				else if (!this.gametimePassed)
				{
					try
					{
						File.WriteAllText(this.appPath + "\\datas\\game2ad.dat", "game2passed");
					}
					catch (Exception ex2)
					{
					}
					MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Msg.wav", AudioPlayMode.Background);
					MessageBox.Show("finAlLy.", "");
					Thread.Sleep(2000);
					MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Msg.wav", AudioPlayMode.Background);
					MessageBox.Show("I WAs gETtiNg bORed.", "");
					Thread.Sleep(2000);
					MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Msg.wav", AudioPlayMode.Background);
					MessageBox.Show("ANywaY . . .", "");
					Thread.Sleep(2000);
					MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Laughing.wav", AudioPlayMode.BackgroundLoop);
					MessageBox.Show("W\u0335\u0337E\u035c\u0361'\u035e\u0327RE\u035e \u0334\u0361\u035d \u0338\u0489 N\u0340O\u0489\u0322\u0321T\u035f\u0328 \u0321 \u0338 D\u0327\u035f\u0362O\u031bN\u0360\u0361E\u0321 \u0337 \u0340\u035eP\u0358\u035c\u0315L\u0328AY\u035e\u035fI\u0327\u0327N\u0321\u0334\u031bG\u0489\u035f \u035f\u035d \u035d\u0360 \u031bY\u034f\u0322E\u0335\u0361T", "");
					this.noquitLosing = true;
					MyProject.Computer.Audio.Stop();
					base.Hide();
					MyProject.Forms.nextSecondGame.Show();
					base.Close();
					return;
				}
			}
			if (this.Text.Contains(" 0 ERROR"))
			{
				this.Text = "";
				try
				{
					File.WriteAllText(this.appPath + "\\datas\\game2ad.dat", "yes");
				}
				catch (Exception ex3)
				{
				}
				MyProject.Computer.Audio.Stop();
				this.manycases = 0;
				this.manyerrors = 12;
				this.trytoquit = 0;
				this.gametimePassed = false;
				this.secrestantes = 60;
				this.noquitLosing = true;
				this.LeMinuteur.Stop();
				base.Hide();
				MyProject.Forms.S2GameLost.Show();
				base.Close();
			}
		}

		// Token: 0x0600023C RID: 572 RVA: 0x0001888C File Offset: 0x00016A8C
		private void Button2_Click(object sender, EventArgs e)
		{
			this.Button2.BackColor = Color.FromArgb(0, 192, 0);
			this.Button2.Enabled = false;
			this.Button2.Text = "";
			checked
			{
				this.manycases++;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00018908 File Offset: 0x00016B08
		private void Button1_Click(object sender, EventArgs e)
		{
			this.Button1.BackColor = Color.FromArgb(0, 192, 0);
			this.Button1.Enabled = false;
			this.Button1.Text = "";
			checked
			{
				this.manycases++;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00018984 File Offset: 0x00016B84
		private void Button45_Click(object sender, EventArgs e)
		{
			this.Button45.BackColor = Color.FromArgb(0, 192, 0);
			this.Button45.Enabled = false;
			this.Button45.Text = "";
			checked
			{
				this.manycases++;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00018A00 File Offset: 0x00016C00
		private void Button54_Click(object sender, EventArgs e)
		{
			this.Button54.BackColor = Color.FromArgb(0, 192, 0);
			this.Button54.Enabled = false;
			this.Button54.Text = "";
			checked
			{
				this.manycases++;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00018A7C File Offset: 0x00016C7C
		private void Button63_Click(object sender, EventArgs e)
		{
			this.Button63.BackColor = Color.FromArgb(0, 192, 0);
			this.Button63.Enabled = false;
			this.Button63.Text = "";
			checked
			{
				this.manycases++;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00018AF8 File Offset: 0x00016CF8
		private void Button12_Click(object sender, EventArgs e)
		{
			this.Button12.BackColor = Color.FromArgb(0, 192, 0);
			this.Button12.Enabled = false;
			this.Button12.Text = "";
			checked
			{
				this.manycases++;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00018B74 File Offset: 0x00016D74
		private void Button8_Click(object sender, EventArgs e)
		{
			this.Button8.BackColor = Color.FromArgb(0, 192, 0);
			this.Button8.Enabled = false;
			this.Button8.Text = "";
			checked
			{
				this.manycases++;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00018BF0 File Offset: 0x00016DF0
		private void Button9_Click(object sender, EventArgs e)
		{
			this.Button9.BackColor = Color.FromArgb(0, 192, 0);
			this.Button9.Enabled = false;
			this.Button9.Text = "";
			checked
			{
				this.manycases++;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00018C6C File Offset: 0x00016E6C
		private void Button13_Click(object sender, EventArgs e)
		{
			this.Button13.BackColor = Color.FromArgb(0, 192, 0);
			this.Button13.Enabled = false;
			this.Button13.Text = "";
			checked
			{
				this.manycases++;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00018CE8 File Offset: 0x00016EE8
		private void Button14_Click(object sender, EventArgs e)
		{
			this.Button14.BackColor = Color.FromArgb(0, 192, 0);
			this.Button14.Enabled = false;
			this.Button14.Text = "";
			checked
			{
				this.manycases++;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00018D64 File Offset: 0x00016F64
		private void Button11_Click(object sender, EventArgs e)
		{
			this.Button11.BackColor = Color.FromArgb(0, 192, 0);
			this.Button11.Enabled = false;
			this.Button11.Text = "";
			checked
			{
				this.manycases++;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00018DE0 File Offset: 0x00016FE0
		private void Button10_Click(object sender, EventArgs e)
		{
			this.Button10.BackColor = Color.FromArgb(0, 192, 0);
			this.Button10.Enabled = false;
			this.Button10.Text = "";
			checked
			{
				this.manycases++;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00018E5C File Offset: 0x0001705C
		private void Button6_Click(object sender, EventArgs e)
		{
			this.Button6.BackColor = Color.FromArgb(0, 192, 0);
			this.Button6.Enabled = false;
			this.Button6.Text = "";
			checked
			{
				this.manycases++;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00018ED8 File Offset: 0x000170D8
		private void Button7_Click(object sender, EventArgs e)
		{
			this.Button7.BackColor = Color.FromArgb(0, 192, 0);
			this.Button7.Enabled = false;
			this.Button7.Text = "";
			checked
			{
				this.manycases++;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00018F54 File Offset: 0x00017154
		private void Button5_Click(object sender, EventArgs e)
		{
			this.Button5.BackColor = Color.FromArgb(0, 192, 0);
			this.Button5.Enabled = false;
			this.Button5.Text = "";
			checked
			{
				this.manycases++;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00018FD0 File Offset: 0x000171D0
		private void Button4_Click(object sender, EventArgs e)
		{
			this.Button4.BackColor = Color.FromArgb(0, 192, 0);
			this.Button4.Enabled = false;
			this.Button4.Text = "";
			checked
			{
				this.manycases++;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x0600024C RID: 588 RVA: 0x0001904C File Offset: 0x0001724C
		private void Button17_Click(object sender, EventArgs e)
		{
			this.Button17.BackColor = Color.FromArgb(0, 192, 0);
			this.Button17.Enabled = false;
			this.Button17.Text = "";
			checked
			{
				this.manycases++;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x0600024D RID: 589 RVA: 0x000190C8 File Offset: 0x000172C8
		private void Button18_Click(object sender, EventArgs e)
		{
			this.Button18.BackColor = Color.FromArgb(0, 192, 0);
			this.Button18.Enabled = false;
			this.Button18.Text = "";
			checked
			{
				this.manycases++;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00019144 File Offset: 0x00017344
		private void Button19_Click(object sender, EventArgs e)
		{
			this.Button19.BackColor = Color.FromArgb(0, 192, 0);
			this.Button19.Enabled = false;
			this.Button19.Text = "";
			checked
			{
				this.manycases++;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x0600024F RID: 591 RVA: 0x000191C0 File Offset: 0x000173C0
		private void Button20_Click(object sender, EventArgs e)
		{
			this.Button20.BackColor = Color.FromArgb(0, 192, 0);
			this.Button20.Enabled = false;
			this.Button20.Text = "";
			checked
			{
				this.manycases++;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000250 RID: 592 RVA: 0x0001923C File Offset: 0x0001743C
		private void Button21_Click(object sender, EventArgs e)
		{
			this.Button21.BackColor = Color.FromArgb(0, 192, 0);
			this.Button21.Enabled = false;
			this.Button21.Text = "";
			checked
			{
				this.manycases++;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000251 RID: 593 RVA: 0x000192B8 File Offset: 0x000174B8
		private void Button16_Click(object sender, EventArgs e)
		{
			this.Button16.BackColor = Color.FromArgb(0, 192, 0);
			this.Button16.Enabled = false;
			this.Button16.Text = "";
			checked
			{
				this.manycases++;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00019334 File Offset: 0x00017534
		private void Button15_Click(object sender, EventArgs e)
		{
			this.Button15.BackColor = Color.FromArgb(0, 192, 0);
			this.Button15.Enabled = false;
			this.Button15.Text = "";
			checked
			{
				this.manycases++;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000253 RID: 595 RVA: 0x000193B0 File Offset: 0x000175B0
		private void Button27_Click(object sender, EventArgs e)
		{
			this.Button27.BackColor = Color.FromArgb(0, 192, 0);
			this.Button27.Enabled = false;
			this.Button27.Text = "";
			checked
			{
				this.manycases++;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000254 RID: 596 RVA: 0x0001942C File Offset: 0x0001762C
		private void Button26_Click(object sender, EventArgs e)
		{
			this.Button26.BackColor = Color.FromArgb(0, 192, 0);
			this.Button26.Enabled = false;
			this.Button26.Text = "";
			checked
			{
				this.manycases++;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000255 RID: 597 RVA: 0x000194A8 File Offset: 0x000176A8
		private void Button25_Click(object sender, EventArgs e)
		{
			this.Button25.BackColor = Color.FromArgb(0, 192, 0);
			this.Button25.Enabled = false;
			this.Button25.Text = "";
			checked
			{
				this.manycases++;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00019524 File Offset: 0x00017724
		private void Button24_Click(object sender, EventArgs e)
		{
			this.Button24.BackColor = Color.FromArgb(0, 192, 0);
			this.Button24.Enabled = false;
			this.Button24.Text = "";
			checked
			{
				this.manycases++;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000257 RID: 599 RVA: 0x000195A0 File Offset: 0x000177A0
		private void Button23_Click(object sender, EventArgs e)
		{
			this.Button23.BackColor = Color.FromArgb(0, 192, 0);
			this.Button23.Enabled = false;
			this.Button23.Text = "";
			checked
			{
				this.manycases++;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0001961C File Offset: 0x0001781C
		private void Button22_Click(object sender, EventArgs e)
		{
			this.Button22.BackColor = Color.FromArgb(0, 192, 0);
			this.Button22.Enabled = false;
			this.Button22.Text = "";
			checked
			{
				this.manycases++;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00019698 File Offset: 0x00017898
		private void Button32_Click(object sender, EventArgs e)
		{
			this.Button32.BackColor = Color.FromArgb(0, 192, 0);
			this.Button32.Enabled = false;
			this.Button32.Text = "";
			checked
			{
				this.manycases++;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00019714 File Offset: 0x00017914
		private void Button34_Click(object sender, EventArgs e)
		{
			this.Button34.BackColor = Color.FromArgb(0, 192, 0);
			this.Button34.Enabled = false;
			this.Button34.Text = "";
			checked
			{
				this.manycases++;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00019790 File Offset: 0x00017990
		private void Button33_Click(object sender, EventArgs e)
		{
			this.Button33.BackColor = Color.FromArgb(0, 192, 0);
			this.Button33.Enabled = false;
			this.Button33.Text = "";
			checked
			{
				this.manycases++;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0001980C File Offset: 0x00017A0C
		private void Button29_Click(object sender, EventArgs e)
		{
			this.Button29.BackColor = Color.FromArgb(0, 192, 0);
			this.Button29.Enabled = false;
			this.Button29.Text = "";
			checked
			{
				this.manycases++;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00019888 File Offset: 0x00017A88
		private void Button28_Click(object sender, EventArgs e)
		{
			this.Button28.BackColor = Color.FromArgb(0, 192, 0);
			this.Button28.Enabled = false;
			this.Button28.Text = "";
			checked
			{
				this.manycases++;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00019904 File Offset: 0x00017B04
		private void Button31_Click(object sender, EventArgs e)
		{
			this.Button31.BackColor = Color.FromArgb(0, 192, 0);
			this.Button31.Enabled = false;
			this.Button31.Text = "";
			checked
			{
				this.manycases++;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00019980 File Offset: 0x00017B80
		private void Button30_Click(object sender, EventArgs e)
		{
			this.Button30.BackColor = Color.FromArgb(0, 192, 0);
			this.Button30.Enabled = false;
			this.Button30.Text = "";
			checked
			{
				this.manycases++;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000260 RID: 608 RVA: 0x000199FC File Offset: 0x00017BFC
		private void Button35_Click(object sender, EventArgs e)
		{
			this.Button35.BackColor = Color.FromArgb(0, 192, 0);
			this.Button35.Enabled = false;
			this.Button35.Text = "";
			checked
			{
				this.manycases++;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00019A78 File Offset: 0x00017C78
		private void Button37_Click(object sender, EventArgs e)
		{
			this.Button37.BackColor = Color.FromArgb(0, 192, 0);
			this.Button37.Enabled = false;
			this.Button37.Text = "";
			checked
			{
				this.manycases++;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00019AF4 File Offset: 0x00017CF4
		private void Button38_Click(object sender, EventArgs e)
		{
			this.Button38.BackColor = Color.FromArgb(0, 192, 0);
			this.Button38.Enabled = false;
			this.Button38.Text = "";
			checked
			{
				this.manycases++;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00019B70 File Offset: 0x00017D70
		private void Button36_Click(object sender, EventArgs e)
		{
			this.Button36.BackColor = Color.FromArgb(0, 192, 0);
			this.Button36.Enabled = false;
			this.Button36.Text = "";
			checked
			{
				this.manycases++;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00019BEC File Offset: 0x00017DEC
		private void Button39_Click(object sender, EventArgs e)
		{
			this.Button39.BackColor = Color.FromArgb(0, 192, 0);
			this.Button39.Enabled = false;
			this.Button39.Text = "";
			checked
			{
				this.manycases++;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00019C68 File Offset: 0x00017E68
		private void Button40_Click(object sender, EventArgs e)
		{
			this.Button40.BackColor = Color.FromArgb(0, 192, 0);
			this.Button40.Enabled = false;
			this.Button40.Text = "";
			checked
			{
				this.manycases++;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00019CE4 File Offset: 0x00017EE4
		private void Button42_Click(object sender, EventArgs e)
		{
			this.Button42.BackColor = Color.FromArgb(0, 192, 0);
			this.Button42.Enabled = false;
			this.Button42.Text = "";
			checked
			{
				this.manycases++;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00019D60 File Offset: 0x00017F60
		private void Button49_Click(object sender, EventArgs e)
		{
			this.Button49.BackColor = Color.FromArgb(0, 192, 0);
			this.Button49.Enabled = false;
			this.Button49.Text = "";
			checked
			{
				this.manycases++;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00019DDC File Offset: 0x00017FDC
		private void Button43_Click(object sender, EventArgs e)
		{
			this.Button43.BackColor = Color.FromArgb(0, 192, 0);
			this.Button43.Enabled = false;
			this.Button43.Text = "";
			checked
			{
				this.manycases++;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00019E58 File Offset: 0x00018058
		private void Button41_Click(object sender, EventArgs e)
		{
			this.Button41.BackColor = Color.FromArgb(0, 192, 0);
			this.Button41.Enabled = false;
			this.Button41.Text = "";
			checked
			{
				this.manycases++;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00019ED4 File Offset: 0x000180D4
		private void Button44_Click(object sender, EventArgs e)
		{
			this.Button44.BackColor = Color.FromArgb(0, 192, 0);
			this.Button44.Enabled = false;
			this.Button44.Text = "";
			checked
			{
				this.manycases++;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00019F50 File Offset: 0x00018150
		private void Button46_Click(object sender, EventArgs e)
		{
			this.Button46.BackColor = Color.FromArgb(0, 192, 0);
			this.Button46.Enabled = false;
			this.Button46.Text = "";
			checked
			{
				this.manycases++;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00019FCC File Offset: 0x000181CC
		private void Button47_Click(object sender, EventArgs e)
		{
			this.Button47.BackColor = Color.FromArgb(0, 192, 0);
			this.Button47.Enabled = false;
			this.Button47.Text = "";
			checked
			{
				this.manycases++;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0001A048 File Offset: 0x00018248
		private void Button48_Click(object sender, EventArgs e)
		{
			this.Button48.BackColor = Color.FromArgb(0, 192, 0);
			this.Button48.Enabled = false;
			this.Button48.Text = "";
			checked
			{
				this.manycases++;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0001A0C4 File Offset: 0x000182C4
		private void Button51_Click(object sender, EventArgs e)
		{
			this.Button51.BackColor = Color.FromArgb(192, 0, 0);
			this.Button51.Enabled = false;
			this.Button51.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x0600026F RID: 623 RVA: 0x0001A140 File Offset: 0x00018340
		private void Button52_Click(object sender, EventArgs e)
		{
			this.Button52.BackColor = Color.FromArgb(192, 0, 0);
			this.Button52.Enabled = false;
			this.Button52.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000270 RID: 624 RVA: 0x0001A1BC File Offset: 0x000183BC
		private void Button53_Click(object sender, EventArgs e)
		{
			this.Button53.BackColor = Color.FromArgb(192, 0, 0);
			this.Button53.Enabled = false;
			this.Button53.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0001A238 File Offset: 0x00018438
		private void Button55_Click(object sender, EventArgs e)
		{
			this.Button55.BackColor = Color.FromArgb(192, 0, 0);
			this.Button55.Enabled = false;
			this.Button55.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000272 RID: 626 RVA: 0x0001A2B4 File Offset: 0x000184B4
		private void Button57_Click(object sender, EventArgs e)
		{
			this.Button57.BackColor = Color.FromArgb(192, 0, 0);
			this.Button57.Enabled = false;
			this.Button57.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000273 RID: 627 RVA: 0x0001A330 File Offset: 0x00018530
		private void Button56_Click(object sender, EventArgs e)
		{
			this.Button56.BackColor = Color.FromArgb(192, 0, 0);
			this.Button56.Enabled = false;
			this.Button56.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0001A3AC File Offset: 0x000185AC
		private void Button64_Click(object sender, EventArgs e)
		{
			this.Button64.BackColor = Color.FromArgb(192, 0, 0);
			this.Button64.Enabled = false;
			this.Button64.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000275 RID: 629 RVA: 0x0001A428 File Offset: 0x00018628
		private void Button70_Click(object sender, EventArgs e)
		{
			this.Button70.BackColor = Color.FromArgb(192, 0, 0);
			this.Button70.Enabled = false;
			this.Button70.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0001A4A4 File Offset: 0x000186A4
		private void Button69_Click(object sender, EventArgs e)
		{
			this.Button69.BackColor = Color.FromArgb(192, 0, 0);
			this.Button69.Enabled = false;
			this.Button69.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0001A520 File Offset: 0x00018720
		private void Button68_Click(object sender, EventArgs e)
		{
			this.Button68.BackColor = Color.FromArgb(192, 0, 0);
			this.Button68.Enabled = false;
			this.Button68.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0001A59C File Offset: 0x0001879C
		private void Button67_Click(object sender, EventArgs e)
		{
			this.Button67.BackColor = Color.FromArgb(192, 0, 0);
			this.Button67.Enabled = false;
			this.Button67.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0001A618 File Offset: 0x00018818
		private void Button66_Click(object sender, EventArgs e)
		{
			this.Button66.BackColor = Color.FromArgb(192, 0, 0);
			this.Button66.Enabled = false;
			this.Button66.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x0600027A RID: 634 RVA: 0x0001A694 File Offset: 0x00018894
		private void Button65_Click(object sender, EventArgs e)
		{
			this.Button65.BackColor = Color.FromArgb(192, 0, 0);
			this.Button65.Enabled = false;
			this.Button65.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0001A710 File Offset: 0x00018910
		private void Button61_Click(object sender, EventArgs e)
		{
			this.Button61.BackColor = Color.FromArgb(192, 0, 0);
			this.Button61.Enabled = false;
			this.Button61.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x0600027C RID: 636 RVA: 0x0001A78C File Offset: 0x0001898C
		private void Button62_Click(object sender, EventArgs e)
		{
			this.Button62.BackColor = Color.FromArgb(192, 0, 0);
			this.Button62.Enabled = false;
			this.Button62.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0001A808 File Offset: 0x00018A08
		private void Button75_Click(object sender, EventArgs e)
		{
			this.Button75.BackColor = Color.FromArgb(192, 0, 0);
			this.Button75.Enabled = false;
			this.Button75.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0001A884 File Offset: 0x00018A84
		private void Button74_Click(object sender, EventArgs e)
		{
			this.Button74.BackColor = Color.FromArgb(192, 0, 0);
			this.Button74.Enabled = false;
			this.Button74.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0001A900 File Offset: 0x00018B00
		private void Button73_Click(object sender, EventArgs e)
		{
			this.Button73.BackColor = Color.FromArgb(192, 0, 0);
			this.Button73.Enabled = false;
			this.Button73.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0001A97C File Offset: 0x00018B7C
		private void Button72_Click(object sender, EventArgs e)
		{
			this.Button72.BackColor = Color.FromArgb(192, 0, 0);
			this.Button72.Enabled = false;
			this.Button72.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0001A9F8 File Offset: 0x00018BF8
		private void Button71_Click(object sender, EventArgs e)
		{
			this.Button71.BackColor = Color.FromArgb(192, 0, 0);
			this.Button71.Enabled = false;
			this.Button71.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000282 RID: 642 RVA: 0x0001AA74 File Offset: 0x00018C74
		private void Button109_Click(object sender, EventArgs e)
		{
			this.Button109.BackColor = Color.FromArgb(192, 0, 0);
			this.Button109.Enabled = false;
			this.Button109.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0001AAF0 File Offset: 0x00018CF0
		private void Button110_Click(object sender, EventArgs e)
		{
			this.Button110.BackColor = Color.FromArgb(192, 0, 0);
			this.Button110.Enabled = false;
			this.Button110.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0001AB6C File Offset: 0x00018D6C
		private void Button76_Click(object sender, EventArgs e)
		{
			this.Button76.BackColor = Color.FromArgb(192, 0, 0);
			this.Button76.Enabled = false;
			this.Button76.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000285 RID: 645 RVA: 0x0001ABE8 File Offset: 0x00018DE8
		private void Button77_Click(object sender, EventArgs e)
		{
			this.Button77.BackColor = Color.FromArgb(192, 0, 0);
			this.Button77.Enabled = false;
			this.Button77.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000286 RID: 646 RVA: 0x0001AC64 File Offset: 0x00018E64
		private void Button78_Click(object sender, EventArgs e)
		{
			this.Button78.BackColor = Color.FromArgb(192, 0, 0);
			this.Button78.Enabled = false;
			this.Button78.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0001ACE0 File Offset: 0x00018EE0
		private void Button79_Click(object sender, EventArgs e)
		{
			this.Button79.BackColor = Color.FromArgb(192, 0, 0);
			this.Button79.Enabled = false;
			this.Button79.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0001AD5C File Offset: 0x00018F5C
		private void Button80_Click(object sender, EventArgs e)
		{
			this.Button80.BackColor = Color.FromArgb(192, 0, 0);
			this.Button80.Enabled = false;
			this.Button80.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0001ADD8 File Offset: 0x00018FD8
		private void Button60_Click(object sender, EventArgs e)
		{
			this.Button60.BackColor = Color.FromArgb(192, 0, 0);
			this.Button60.Enabled = false;
			this.Button60.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0001AE54 File Offset: 0x00019054
		private void Button85_Click(object sender, EventArgs e)
		{
			this.Button85.BackColor = Color.FromArgb(192, 0, 0);
			this.Button85.Enabled = false;
			this.Button85.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0001AED0 File Offset: 0x000190D0
		private void Button84_Click(object sender, EventArgs e)
		{
			this.Button84.BackColor = Color.FromArgb(192, 0, 0);
			this.Button84.Enabled = false;
			this.Button84.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0001AF4C File Offset: 0x0001914C
		private void Button83_Click(object sender, EventArgs e)
		{
			this.Button83.BackColor = Color.FromArgb(192, 0, 0);
			this.Button83.Enabled = false;
			this.Button83.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0001AFC8 File Offset: 0x000191C8
		private void Button82_Click(object sender, EventArgs e)
		{
			this.Button82.BackColor = Color.FromArgb(192, 0, 0);
			this.Button82.Enabled = false;
			this.Button82.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0001B044 File Offset: 0x00019244
		private void Button81_Click(object sender, EventArgs e)
		{
			this.Button81.BackColor = Color.FromArgb(192, 0, 0);
			this.Button81.Enabled = false;
			this.Button81.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0001B0C0 File Offset: 0x000192C0
		private void Button111_Click(object sender, EventArgs e)
		{
			this.Button111.BackColor = Color.FromArgb(192, 0, 0);
			this.Button111.Enabled = false;
			this.Button111.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0001B13C File Offset: 0x0001933C
		private void Button100_Click(object sender, EventArgs e)
		{
			this.Button100.BackColor = Color.FromArgb(192, 0, 0);
			this.Button100.Enabled = false;
			this.Button100.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0001B1B8 File Offset: 0x000193B8
		private void Button99_Click(object sender, EventArgs e)
		{
			this.Button99.BackColor = Color.FromArgb(192, 0, 0);
			this.Button99.Enabled = false;
			this.Button99.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000292 RID: 658 RVA: 0x0001B234 File Offset: 0x00019434
		private void Button104_Click(object sender, EventArgs e)
		{
			this.Button104.BackColor = Color.FromArgb(192, 0, 0);
			this.Button104.Enabled = false;
			this.Button104.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0001B2B0 File Offset: 0x000194B0
		private void Button103_Click(object sender, EventArgs e)
		{
			this.Button103.BackColor = Color.FromArgb(192, 0, 0);
			this.Button103.Enabled = false;
			this.Button103.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0001B32C File Offset: 0x0001952C
		private void Button102_Click(object sender, EventArgs e)
		{
			this.Button102.BackColor = Color.FromArgb(192, 0, 0);
			this.Button102.Enabled = false;
			this.Button102.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000295 RID: 661 RVA: 0x0001B3A8 File Offset: 0x000195A8
		private void Button101_Click(object sender, EventArgs e)
		{
			this.Button101.BackColor = Color.FromArgb(192, 0, 0);
			this.Button101.Enabled = false;
			this.Button101.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0001B424 File Offset: 0x00019624
		private void Button106_Click(object sender, EventArgs e)
		{
			this.Button106.BackColor = Color.FromArgb(192, 0, 0);
			this.Button106.Enabled = false;
			this.Button106.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0001B4A0 File Offset: 0x000196A0
		private void Button105_Click(object sender, EventArgs e)
		{
			this.Button105.BackColor = Color.FromArgb(192, 0, 0);
			this.Button105.Enabled = false;
			this.Button105.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000298 RID: 664 RVA: 0x0001B51C File Offset: 0x0001971C
		private void Button59_Click(object sender, EventArgs e)
		{
			this.Button59.BackColor = Color.FromArgb(192, 0, 0);
			this.Button59.Enabled = false;
			this.Button59.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0001B598 File Offset: 0x00019798
		private void Button58_Click(object sender, EventArgs e)
		{
			this.Button58.BackColor = Color.FromArgb(192, 0, 0);
			this.Button58.Enabled = false;
			this.Button58.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0001B614 File Offset: 0x00019814
		private void Button90_Click(object sender, EventArgs e)
		{
			this.Button90.BackColor = Color.FromArgb(192, 0, 0);
			this.Button90.Enabled = false;
			this.Button90.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0001B690 File Offset: 0x00019890
		private void Button89_Click(object sender, EventArgs e)
		{
			this.Button89.BackColor = Color.FromArgb(192, 0, 0);
			this.Button89.Enabled = false;
			this.Button89.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0001B70C File Offset: 0x0001990C
		private void Button88_Click(object sender, EventArgs e)
		{
			this.Button88.BackColor = Color.FromArgb(192, 0, 0);
			this.Button88.Enabled = false;
			this.Button88.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0001B788 File Offset: 0x00019988
		private void Button112_Click(object sender, EventArgs e)
		{
			this.Button112.BackColor = Color.FromArgb(192, 0, 0);
			this.Button112.Enabled = false;
			this.Button112.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0001B804 File Offset: 0x00019A04
		private void Button87_Click(object sender, EventArgs e)
		{
			this.Button87.BackColor = Color.FromArgb(192, 0, 0);
			this.Button87.Enabled = false;
			this.Button87.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0001B880 File Offset: 0x00019A80
		private void Button86_Click(object sender, EventArgs e)
		{
			this.Button86.BackColor = Color.FromArgb(192, 0, 0);
			this.Button86.Enabled = false;
			this.Button86.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0001B8FC File Offset: 0x00019AFC
		private void Button107_Click(object sender, EventArgs e)
		{
			this.Button107.BackColor = Color.FromArgb(192, 0, 0);
			this.Button107.Enabled = false;
			this.Button107.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0001B978 File Offset: 0x00019B78
		private void Button108_Click(object sender, EventArgs e)
		{
			this.Button108.BackColor = Color.FromArgb(192, 0, 0);
			this.Button108.Enabled = false;
			this.Button108.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x0001B9F4 File Offset: 0x00019BF4
		private void Button94_Click(object sender, EventArgs e)
		{
			this.Button94.BackColor = Color.FromArgb(192, 0, 0);
			this.Button94.Enabled = false;
			this.Button94.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0001BA70 File Offset: 0x00019C70
		private void Button93_Click(object sender, EventArgs e)
		{
			this.Button93.BackColor = Color.FromArgb(192, 0, 0);
			this.Button93.Enabled = false;
			this.Button93.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x0001BAEC File Offset: 0x00019CEC
		private void Button96_Click(object sender, EventArgs e)
		{
			this.Button96.BackColor = Color.FromArgb(192, 0, 0);
			this.Button96.Enabled = false;
			this.Button96.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0001BB68 File Offset: 0x00019D68
		private void Button95_Click(object sender, EventArgs e)
		{
			this.Button95.BackColor = Color.FromArgb(192, 0, 0);
			this.Button95.Enabled = false;
			this.Button95.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0001BBE4 File Offset: 0x00019DE4
		private void Button92_Click(object sender, EventArgs e)
		{
			this.Button92.BackColor = Color.FromArgb(192, 0, 0);
			this.Button92.Enabled = false;
			this.Button92.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x0001BC60 File Offset: 0x00019E60
		private void Button91_Click(object sender, EventArgs e)
		{
			this.Button91.BackColor = Color.FromArgb(192, 0, 0);
			this.Button91.Enabled = false;
			this.Button91.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x0001BCDC File Offset: 0x00019EDC
		private void Button98_Click(object sender, EventArgs e)
		{
			this.Button98.BackColor = Color.FromArgb(192, 0, 0);
			this.Button98.Enabled = false;
			this.Button98.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x0001BD58 File Offset: 0x00019F58
		private void Button97_Click(object sender, EventArgs e)
		{
			this.Button97.BackColor = Color.FromArgb(192, 0, 0);
			this.Button97.Enabled = false;
			this.Button97.Text = "";
			checked
			{
				this.manyerrors--;
				this.Text = Conversions.ToString(this.manycases) + "/51 - " + Conversions.ToString(this.manyerrors) + " ERRORS LEFT";
			}
		}

		// Token: 0x060002AA RID: 682 RVA: 0x0001BDD4 File Offset: 0x00019FD4
		private void TimerVerifieur_Tick(object sender, EventArgs e)
		{
			this.sec = Operators.SubtractObject(this.sec, 1);
			if (Operators.ConditionalCompareObjectEqual(this.sec, 49, false))
			{
				if (!this.alreadyDead)
				{
					this.TimerVerifieur.Stop();
					this.sec = 50;
					MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Msg.wav", AudioPlayMode.Background);
					MessageBox.Show("thESe aRE 112 cAsEs", "");
					Thread.Sleep(1000);
					MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Msg.wav", AudioPlayMode.Background);
					MessageBox.Show("bUt onLY 51 Of theM aRe sAFe", "");
					Thread.Sleep(1000);
					MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Msg.wav", AudioPlayMode.Background);
					MessageBox.Show("wITh yOUr cUrsOR, you hAVe to fInD aNd prEsS tHEm tO wIN", "");
					Thread.Sleep(2000);
					MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Msg.wav", AudioPlayMode.Background);
					MessageBox.Show("hoWEVer . . .", "");
					Thread.Sleep(1000);
					MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Msg.wav", AudioPlayMode.Background);
					MessageBox.Show("yOU onLy HAve 12 aTTemPts . . .", "");
					Thread.Sleep(1000);
					MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Msg.wav", AudioPlayMode.Background);
					MessageBox.Show("iF YOu eXCEeD thIS tHResHOlD,", "");
					Thread.Sleep(1000);
					MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Msg.wav", AudioPlayMode.Background);
					MessageBox.Show("YoU'lL bE sTuCK foREVer, wiTH mE", "");
					MyProject.Computer.Audio.Play(this.appPath + "\\assets\\BenMusic2.wav", AudioPlayMode.BackgroundLoop);
					this.LeMinuteur.Start();
					return;
				}
				if (this.alreadyDead)
				{
					this.TimerVerifieur.Stop();
					this.sec = 50;
					MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Msg.wav", AudioPlayMode.Background);
					MessageBox.Show("yoU alrEAdy kNOw wHaT to dO...", " ");
					MyProject.Computer.Audio.Play(this.appPath + "\\assets\\BenMusic2.wav", AudioPlayMode.BackgroundLoop);
					this.LeMinuteur.Start();
				}
			}
		}

		// Token: 0x060002AB RID: 683 RVA: 0x0001C068 File Offset: 0x0001A268
		private void LeMinuteur_Tick(object sender, EventArgs e)
		{
			this.secrestantes = Operators.SubtractObject(this.secrestantes, 1);
			if (Operators.ConditionalCompareObjectEqual(this.secrestantes, 0, false))
			{
				this.LeMinuteur.Stop();
				this.secrestantes = 0;
				this.gametimePassed = true;
			}
		}

		// Token: 0x04000113 RID: 275
		private int manycases;

		// Token: 0x04000114 RID: 276
		private int manyerrors;

		// Token: 0x04000115 RID: 277
		private int trytoquit;

		// Token: 0x04000116 RID: 278
		private string appPath;

		// Token: 0x04000117 RID: 279
		public bool alreadyDead;

		// Token: 0x04000118 RID: 280
		public bool gameIsPassed;

		// Token: 0x04000119 RID: 281
		public bool gametimePassed;

		// Token: 0x0400011A RID: 282
		public bool noquitLosing;

		// Token: 0x0400011B RID: 283
		private object sec;

		// Token: 0x0400011C RID: 284
		private object secrestantes;
	}
}
