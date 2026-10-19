using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace BEN.My
{
	// Token: 0x02000004 RID: 4
	[StandardModule]
	[HideModuleName]
	[GeneratedCode("MyTemplate", "11.0.0.0")]
	internal sealed class MyProject
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000006 RID: 6 RVA: 0x000020DA File Offset: 0x000002DA
		[HelpKeyword("My.Computer")]
		internal static MyComputer Computer
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_ComputerObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000007 RID: 7 RVA: 0x000020E6 File Offset: 0x000002E6
		[HelpKeyword("My.Application")]
		internal static MyApplication Application
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_AppObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000008 RID: 8 RVA: 0x000020F2 File Offset: 0x000002F2
		[HelpKeyword("My.User")]
		internal static User User
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_UserObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000009 RID: 9 RVA: 0x000020FE File Offset: 0x000002FE
		[HelpKeyword("My.Forms")]
		internal static MyProject.MyForms Forms
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_MyFormsObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000A RID: 10 RVA: 0x0000210A File Offset: 0x0000030A
		[HelpKeyword("My.WebServices")]
		internal static MyProject.MyWebServices WebServices
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_MyWebServicesObjectProvider.GetInstance;
			}
		}

		// Token: 0x04000001 RID: 1
		private static readonly MyProject.ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new MyProject.ThreadSafeObjectProvider<MyComputer>();

		// Token: 0x04000002 RID: 2
		private static readonly MyProject.ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new MyProject.ThreadSafeObjectProvider<MyApplication>();

		// Token: 0x04000003 RID: 3
		private static readonly MyProject.ThreadSafeObjectProvider<User> m_UserObjectProvider = new MyProject.ThreadSafeObjectProvider<User>();

		// Token: 0x04000004 RID: 4
		private static MyProject.ThreadSafeObjectProvider<MyProject.MyForms> m_MyFormsObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyForms>();

		// Token: 0x04000005 RID: 5
		private static readonly MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices> m_MyWebServicesObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices>();

		// Token: 0x0200001E RID: 30
		[EditorBrowsable(EditorBrowsableState.Never)]
		[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
		internal sealed class MyForms
		{
			// Token: 0x0600035A RID: 858 RVA: 0x00022274 File Offset: 0x00020474
			[DebuggerHidden]
			private static T Create__Instance__<T>(T Instance) where T : Form, new()
			{
				if (Instance == null || Instance.IsDisposed)
				{
					if (MyProject.MyForms.m_FormBeingCreated != null)
					{
						if (MyProject.MyForms.m_FormBeingCreated.ContainsKey(typeof(T)))
						{
							throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
						}
					}
					else
					{
						MyProject.MyForms.m_FormBeingCreated = new Hashtable();
					}
					MyProject.MyForms.m_FormBeingCreated.Add(typeof(T), null);
					try
					{
						return new T();
					}
					catch (TargetInvocationException ex) when (ex.InnerException != null)
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", new string[] { ex.InnerException.Message }), ex.InnerException);
					}
					finally
					{
						MyProject.MyForms.m_FormBeingCreated.Remove(typeof(T));
					}
				}
				return Instance;
			}

			// Token: 0x0600035B RID: 859 RVA: 0x00022378 File Offset: 0x00020578
			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance) where T : Form
			{
				instance.Dispose();
				instance = default(T);
			}

			// Token: 0x0600035C RID: 860 RVA: 0x0002238D File Offset: 0x0002058D
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public MyForms()
			{
			}

			// Token: 0x0600035D RID: 861 RVA: 0x00022395 File Offset: 0x00020595
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			// Token: 0x0600035E RID: 862 RVA: 0x000223A3 File Offset: 0x000205A3
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x0600035F RID: 863 RVA: 0x000223AB File Offset: 0x000205AB
			[EditorBrowsable(EditorBrowsableState.Never)]
			internal new Type GetType()
			{
				return typeof(MyProject.MyForms);
			}

			// Token: 0x06000360 RID: 864 RVA: 0x000223B7 File Offset: 0x000205B7
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override string ToString()
			{
				return base.ToString();
			}

			// Token: 0x1700013F RID: 319
			// (get) Token: 0x06000361 RID: 865 RVA: 0x000223BF File Offset: 0x000205BF
			// (set) Token: 0x06000377 RID: 887 RVA: 0x000225E5 File Offset: 0x000207E5
			public Andcredits Andcredits
			{
				get
				{
					this.m_Andcredits = MyProject.MyForms.Create__Instance__<Andcredits>(this.m_Andcredits);
					return this.m_Andcredits;
				}
				set
				{
					if (value != this.m_Andcredits)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Andcredits>(ref this.m_Andcredits);
					}
				}
			}

			// Token: 0x17000140 RID: 320
			// (get) Token: 0x06000362 RID: 866 RVA: 0x000223D8 File Offset: 0x000205D8
			// (set) Token: 0x06000378 RID: 888 RVA: 0x0002260A File Offset: 0x0002080A
			public Backnoiser Backnoiser
			{
				get
				{
					this.m_Backnoiser = MyProject.MyForms.Create__Instance__<Backnoiser>(this.m_Backnoiser);
					return this.m_Backnoiser;
				}
				set
				{
					if (value != this.m_Backnoiser)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Backnoiser>(ref this.m_Backnoiser);
					}
				}
			}

			// Token: 0x17000141 RID: 321
			// (get) Token: 0x06000363 RID: 867 RVA: 0x000223F1 File Offset: 0x000205F1
			// (set) Token: 0x06000379 RID: 889 RVA: 0x0002262F File Offset: 0x0002082F
			public checkPlay checkPlay
			{
				get
				{
					this.m_checkPlay = MyProject.MyForms.Create__Instance__<checkPlay>(this.m_checkPlay);
					return this.m_checkPlay;
				}
				set
				{
					if (value != this.m_checkPlay)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<checkPlay>(ref this.m_checkPlay);
					}
				}
			}

			// Token: 0x17000142 RID: 322
			// (get) Token: 0x06000364 RID: 868 RVA: 0x0002240A File Offset: 0x0002060A
			// (set) Token: 0x0600037A RID: 890 RVA: 0x00022654 File Offset: 0x00020854
			public Contactme Contactme
			{
				get
				{
					this.m_Contactme = MyProject.MyForms.Create__Instance__<Contactme>(this.m_Contactme);
					return this.m_Contactme;
				}
				set
				{
					if (value != this.m_Contactme)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Contactme>(ref this.m_Contactme);
					}
				}
			}

			// Token: 0x17000143 RID: 323
			// (get) Token: 0x06000365 RID: 869 RVA: 0x00022423 File Offset: 0x00020623
			// (set) Token: 0x0600037B RID: 891 RVA: 0x00022679 File Offset: 0x00020879
			public EndWhite EndWhite
			{
				get
				{
					this.m_EndWhite = MyProject.MyForms.Create__Instance__<EndWhite>(this.m_EndWhite);
					return this.m_EndWhite;
				}
				set
				{
					if (value != this.m_EndWhite)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<EndWhite>(ref this.m_EndWhite);
					}
				}
			}

			// Token: 0x17000144 RID: 324
			// (get) Token: 0x06000366 RID: 870 RVA: 0x0002243C File Offset: 0x0002063C
			// (set) Token: 0x0600037C RID: 892 RVA: 0x0002269E File Offset: 0x0002089E
			public Finalstep Finalstep
			{
				get
				{
					this.m_Finalstep = MyProject.MyForms.Create__Instance__<Finalstep>(this.m_Finalstep);
					return this.m_Finalstep;
				}
				set
				{
					if (value != this.m_Finalstep)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Finalstep>(ref this.m_Finalstep);
					}
				}
			}

			// Token: 0x17000145 RID: 325
			// (get) Token: 0x06000367 RID: 871 RVA: 0x00022455 File Offset: 0x00020655
			// (set) Token: 0x0600037D RID: 893 RVA: 0x000226C3 File Offset: 0x000208C3
			public Game1 Game1
			{
				get
				{
					this.m_Game1 = MyProject.MyForms.Create__Instance__<Game1>(this.m_Game1);
					return this.m_Game1;
				}
				set
				{
					if (value != this.m_Game1)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Game1>(ref this.m_Game1);
					}
				}
			}

			// Token: 0x17000146 RID: 326
			// (get) Token: 0x06000368 RID: 872 RVA: 0x0002246E File Offset: 0x0002066E
			// (set) Token: 0x0600037E RID: 894 RVA: 0x000226E8 File Offset: 0x000208E8
			public Game2 Game2
			{
				get
				{
					this.m_Game2 = MyProject.MyForms.Create__Instance__<Game2>(this.m_Game2);
					return this.m_Game2;
				}
				set
				{
					if (value != this.m_Game2)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Game2>(ref this.m_Game2);
					}
				}
			}

			// Token: 0x17000147 RID: 327
			// (get) Token: 0x06000369 RID: 873 RVA: 0x00022487 File Offset: 0x00020687
			// (set) Token: 0x0600037F RID: 895 RVA: 0x0002270D File Offset: 0x0002090D
			public Game3 Game3
			{
				get
				{
					this.m_Game3 = MyProject.MyForms.Create__Instance__<Game3>(this.m_Game3);
					return this.m_Game3;
				}
				set
				{
					if (value != this.m_Game3)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Game3>(ref this.m_Game3);
					}
				}
			}

			// Token: 0x17000148 RID: 328
			// (get) Token: 0x0600036A RID: 874 RVA: 0x000224A0 File Offset: 0x000206A0
			// (set) Token: 0x06000380 RID: 896 RVA: 0x00022732 File Offset: 0x00020932
			public InstallShield InstallShield
			{
				get
				{
					this.m_InstallShield = MyProject.MyForms.Create__Instance__<InstallShield>(this.m_InstallShield);
					return this.m_InstallShield;
				}
				set
				{
					if (value != this.m_InstallShield)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<InstallShield>(ref this.m_InstallShield);
					}
				}
			}

			// Token: 0x17000149 RID: 329
			// (get) Token: 0x0600036B RID: 875 RVA: 0x000224B9 File Offset: 0x000206B9
			// (set) Token: 0x06000381 RID: 897 RVA: 0x00022757 File Offset: 0x00020957
			public nextFirstGames nextFirstGames
			{
				get
				{
					this.m_nextFirstGames = MyProject.MyForms.Create__Instance__<nextFirstGames>(this.m_nextFirstGames);
					return this.m_nextFirstGames;
				}
				set
				{
					if (value != this.m_nextFirstGames)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<nextFirstGames>(ref this.m_nextFirstGames);
					}
				}
			}

			// Token: 0x1700014A RID: 330
			// (get) Token: 0x0600036C RID: 876 RVA: 0x000224D2 File Offset: 0x000206D2
			// (set) Token: 0x06000382 RID: 898 RVA: 0x0002277C File Offset: 0x0002097C
			public nextSecondGame nextSecondGame
			{
				get
				{
					this.m_nextSecondGame = MyProject.MyForms.Create__Instance__<nextSecondGame>(this.m_nextSecondGame);
					return this.m_nextSecondGame;
				}
				set
				{
					if (value != this.m_nextSecondGame)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<nextSecondGame>(ref this.m_nextSecondGame);
					}
				}
			}

			// Token: 0x1700014B RID: 331
			// (get) Token: 0x0600036D RID: 877 RVA: 0x000224EB File Offset: 0x000206EB
			// (set) Token: 0x06000383 RID: 899 RVA: 0x000227A1 File Offset: 0x000209A1
			public Openfiles2 Openfiles2
			{
				get
				{
					this.m_Openfiles2 = MyProject.MyForms.Create__Instance__<Openfiles2>(this.m_Openfiles2);
					return this.m_Openfiles2;
				}
				set
				{
					if (value != this.m_Openfiles2)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Openfiles2>(ref this.m_Openfiles2);
					}
				}
			}

			// Token: 0x1700014C RID: 332
			// (get) Token: 0x0600036E RID: 878 RVA: 0x00022504 File Offset: 0x00020704
			// (set) Token: 0x06000384 RID: 900 RVA: 0x000227C6 File Offset: 0x000209C6
			public S2GameLost S2GameLost
			{
				get
				{
					this.m_S2GameLost = MyProject.MyForms.Create__Instance__<S2GameLost>(this.m_S2GameLost);
					return this.m_S2GameLost;
				}
				set
				{
					if (value != this.m_S2GameLost)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<S2GameLost>(ref this.m_S2GameLost);
					}
				}
			}

			// Token: 0x1700014D RID: 333
			// (get) Token: 0x0600036F RID: 879 RVA: 0x0002251D File Offset: 0x0002071D
			// (set) Token: 0x06000385 RID: 901 RVA: 0x000227EB File Offset: 0x000209EB
			public Scream1 Scream1
			{
				get
				{
					this.m_Scream1 = MyProject.MyForms.Create__Instance__<Scream1>(this.m_Scream1);
					return this.m_Scream1;
				}
				set
				{
					if (value != this.m_Scream1)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Scream1>(ref this.m_Scream1);
					}
				}
			}

			// Token: 0x1700014E RID: 334
			// (get) Token: 0x06000370 RID: 880 RVA: 0x00022536 File Offset: 0x00020736
			// (set) Token: 0x06000386 RID: 902 RVA: 0x00022810 File Offset: 0x00020A10
			public Screamer2 Screamer2
			{
				get
				{
					this.m_Screamer2 = MyProject.MyForms.Create__Instance__<Screamer2>(this.m_Screamer2);
					return this.m_Screamer2;
				}
				set
				{
					if (value != this.m_Screamer2)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Screamer2>(ref this.m_Screamer2);
					}
				}
			}

			// Token: 0x1700014F RID: 335
			// (get) Token: 0x06000371 RID: 881 RVA: 0x0002254F File Offset: 0x0002074F
			// (set) Token: 0x06000387 RID: 903 RVA: 0x00022835 File Offset: 0x00020A35
			public Screamer3 Screamer3
			{
				get
				{
					this.m_Screamer3 = MyProject.MyForms.Create__Instance__<Screamer3>(this.m_Screamer3);
					return this.m_Screamer3;
				}
				set
				{
					if (value != this.m_Screamer3)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Screamer3>(ref this.m_Screamer3);
					}
				}
			}

			// Token: 0x17000150 RID: 336
			// (get) Token: 0x06000372 RID: 882 RVA: 0x00022568 File Offset: 0x00020768
			// (set) Token: 0x06000388 RID: 904 RVA: 0x0002285A File Offset: 0x00020A5A
			public Screamer4 Screamer4
			{
				get
				{
					this.m_Screamer4 = MyProject.MyForms.Create__Instance__<Screamer4>(this.m_Screamer4);
					return this.m_Screamer4;
				}
				set
				{
					if (value != this.m_Screamer4)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Screamer4>(ref this.m_Screamer4);
					}
				}
			}

			// Token: 0x17000151 RID: 337
			// (get) Token: 0x06000373 RID: 883 RVA: 0x00022581 File Offset: 0x00020781
			// (set) Token: 0x06000389 RID: 905 RVA: 0x0002287F File Offset: 0x00020A7F
			public Screamer5 Screamer5
			{
				get
				{
					this.m_Screamer5 = MyProject.MyForms.Create__Instance__<Screamer5>(this.m_Screamer5);
					return this.m_Screamer5;
				}
				set
				{
					if (value != this.m_Screamer5)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Screamer5>(ref this.m_Screamer5);
					}
				}
			}

			// Token: 0x17000152 RID: 338
			// (get) Token: 0x06000374 RID: 884 RVA: 0x0002259A File Offset: 0x0002079A
			// (set) Token: 0x0600038A RID: 906 RVA: 0x000228A4 File Offset: 0x00020AA4
			public SecondGame SecondGame
			{
				get
				{
					this.m_SecondGame = MyProject.MyForms.Create__Instance__<SecondGame>(this.m_SecondGame);
					return this.m_SecondGame;
				}
				set
				{
					if (value != this.m_SecondGame)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<SecondGame>(ref this.m_SecondGame);
					}
				}
			}

			// Token: 0x17000153 RID: 339
			// (get) Token: 0x06000375 RID: 885 RVA: 0x000225B3 File Offset: 0x000207B3
			// (set) Token: 0x0600038B RID: 907 RVA: 0x000228C9 File Offset: 0x00020AC9
			public Talking3 Talking3
			{
				get
				{
					this.m_Talking3 = MyProject.MyForms.Create__Instance__<Talking3>(this.m_Talking3);
					return this.m_Talking3;
				}
				set
				{
					if (value != this.m_Talking3)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Talking3>(ref this.m_Talking3);
					}
				}
			}

			// Token: 0x17000154 RID: 340
			// (get) Token: 0x06000376 RID: 886 RVA: 0x000225CC File Offset: 0x000207CC
			// (set) Token: 0x0600038C RID: 908 RVA: 0x000228EE File Offset: 0x00020AEE
			public ThirdGame ThirdGame
			{
				get
				{
					this.m_ThirdGame = MyProject.MyForms.Create__Instance__<ThirdGame>(this.m_ThirdGame);
					return this.m_ThirdGame;
				}
				set
				{
					if (value != this.m_ThirdGame)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<ThirdGame>(ref this.m_ThirdGame);
					}
				}
			}

			// Token: 0x0400017A RID: 378
			[ThreadStatic]
			private static Hashtable m_FormBeingCreated;

			// Token: 0x0400017B RID: 379
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Andcredits m_Andcredits;

			// Token: 0x0400017C RID: 380
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Backnoiser m_Backnoiser;

			// Token: 0x0400017D RID: 381
			[EditorBrowsable(EditorBrowsableState.Never)]
			public checkPlay m_checkPlay;

			// Token: 0x0400017E RID: 382
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Contactme m_Contactme;

			// Token: 0x0400017F RID: 383
			[EditorBrowsable(EditorBrowsableState.Never)]
			public EndWhite m_EndWhite;

			// Token: 0x04000180 RID: 384
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Finalstep m_Finalstep;

			// Token: 0x04000181 RID: 385
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Game1 m_Game1;

			// Token: 0x04000182 RID: 386
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Game2 m_Game2;

			// Token: 0x04000183 RID: 387
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Game3 m_Game3;

			// Token: 0x04000184 RID: 388
			[EditorBrowsable(EditorBrowsableState.Never)]
			public InstallShield m_InstallShield;

			// Token: 0x04000185 RID: 389
			[EditorBrowsable(EditorBrowsableState.Never)]
			public nextFirstGames m_nextFirstGames;

			// Token: 0x04000186 RID: 390
			[EditorBrowsable(EditorBrowsableState.Never)]
			public nextSecondGame m_nextSecondGame;

			// Token: 0x04000187 RID: 391
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Openfiles2 m_Openfiles2;

			// Token: 0x04000188 RID: 392
			[EditorBrowsable(EditorBrowsableState.Never)]
			public S2GameLost m_S2GameLost;

			// Token: 0x04000189 RID: 393
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Scream1 m_Scream1;

			// Token: 0x0400018A RID: 394
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Screamer2 m_Screamer2;

			// Token: 0x0400018B RID: 395
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Screamer3 m_Screamer3;

			// Token: 0x0400018C RID: 396
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Screamer4 m_Screamer4;

			// Token: 0x0400018D RID: 397
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Screamer5 m_Screamer5;

			// Token: 0x0400018E RID: 398
			[EditorBrowsable(EditorBrowsableState.Never)]
			public SecondGame m_SecondGame;

			// Token: 0x0400018F RID: 399
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Talking3 m_Talking3;

			// Token: 0x04000190 RID: 400
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ThirdGame m_ThirdGame;
		}

		// Token: 0x0200001F RID: 31
		[EditorBrowsable(EditorBrowsableState.Never)]
		[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
		internal sealed class MyWebServices
		{
			// Token: 0x0600038D RID: 909 RVA: 0x00022913 File Offset: 0x00020B13
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			// Token: 0x0600038E RID: 910 RVA: 0x00022921 File Offset: 0x00020B21
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x0600038F RID: 911 RVA: 0x00022929 File Offset: 0x00020B29
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			internal new Type GetType()
			{
				return typeof(MyProject.MyWebServices);
			}

			// Token: 0x06000390 RID: 912 RVA: 0x00022935 File Offset: 0x00020B35
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public override string ToString()
			{
				return base.ToString();
			}

			// Token: 0x06000391 RID: 913 RVA: 0x00022940 File Offset: 0x00020B40
			[DebuggerHidden]
			private static T Create__Instance__<T>(T instance) where T : new()
			{
				T t;
				if (instance == null)
				{
					t = new T();
				}
				else
				{
					t = instance;
				}
				return t;
			}

			// Token: 0x06000392 RID: 914 RVA: 0x00022960 File Offset: 0x00020B60
			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance)
			{
				instance = default(T);
			}

			// Token: 0x06000393 RID: 915 RVA: 0x00022969 File Offset: 0x00020B69
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public MyWebServices()
			{
			}
		}

		// Token: 0x02000020 RID: 32
		[EditorBrowsable(EditorBrowsableState.Never)]
		[ComVisible(false)]
		internal sealed class ThreadSafeObjectProvider<T> where T : new()
		{
			// Token: 0x17000155 RID: 341
			// (get) Token: 0x06000394 RID: 916 RVA: 0x00022971 File Offset: 0x00020B71
			internal T GetInstance
			{
				[DebuggerHidden]
				get
				{
					if (MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null)
					{
						MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue = new T();
					}
					return MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue;
				}
			}

			// Token: 0x06000395 RID: 917 RVA: 0x0002298E File Offset: 0x00020B8E
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ThreadSafeObjectProvider()
			{
			}

			// Token: 0x04000191 RID: 401
			[CompilerGenerated]
			[ThreadStatic]
			private static T m_ThreadStaticValue;
		}
	}
}
