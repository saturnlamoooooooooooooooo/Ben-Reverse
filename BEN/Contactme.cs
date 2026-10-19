using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace BEN
{
	// Token: 0x0200000B RID: 11
	[DesignerGenerated]
	public partial class Contactme : Form
	{
		// Token: 0x0600006F RID: 111 RVA: 0x0000432F File Offset: 0x0000252F
		public Contactme()
		{
			base.Load += this.Contactme_Load;
			base.Closing += this.Contactme_Closing;
			this.appPath = Application.StartupPath;
			this.InitializeComponent();
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000072 RID: 114 RVA: 0x000047A5 File Offset: 0x000029A5
		// (set) Token: 0x06000073 RID: 115 RVA: 0x000047B0 File Offset: 0x000029B0
		internal virtual PictureBox pbDiscord
		{
			[CompilerGenerated]
			get
			{
				return this._pbDiscord;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.pbDiscord_Click);
				PictureBox pictureBox = this._pbDiscord;
				if (pictureBox != null)
				{
					pictureBox.Click -= eventHandler;
				}
				this._pbDiscord = value;
				pictureBox = this._pbDiscord;
				if (pictureBox != null)
				{
					pictureBox.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000074 RID: 116 RVA: 0x000047F3 File Offset: 0x000029F3
		// (set) Token: 0x06000075 RID: 117 RVA: 0x000047FC File Offset: 0x000029FC
		internal virtual PictureBox pbYoutube
		{
			[CompilerGenerated]
			get
			{
				return this._pbYoutube;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.pbYoutube_Click);
				PictureBox pictureBox = this._pbYoutube;
				if (pictureBox != null)
				{
					pictureBox.Click -= eventHandler;
				}
				this._pbYoutube = value;
				pictureBox = this._pbYoutube;
				if (pictureBox != null)
				{
					pictureBox.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000076 RID: 118 RVA: 0x0000483F File Offset: 0x00002A3F
		// (set) Token: 0x06000077 RID: 119 RVA: 0x00004848 File Offset: 0x00002A48
		internal virtual PictureBox pbGamejolt
		{
			[CompilerGenerated]
			get
			{
				return this._pbGamejolt;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.pbGamejolt_Click);
				PictureBox pictureBox = this._pbGamejolt;
				if (pictureBox != null)
				{
					pictureBox.Click -= eventHandler;
				}
				this._pbGamejolt = value;
				pictureBox = this._pbGamejolt;
				if (pictureBox != null)
				{
					pictureBox.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000078 RID: 120 RVA: 0x0000488B File Offset: 0x00002A8B
		// (set) Token: 0x06000079 RID: 121 RVA: 0x00004893 File Offset: 0x00002A93
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600007A RID: 122 RVA: 0x0000489C File Offset: 0x00002A9C
		// (set) Token: 0x0600007B RID: 123 RVA: 0x000048A4 File Offset: 0x00002AA4
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000048B0 File Offset: 0x00002AB0
		private void Contactme_Load(object sender, EventArgs e)
		{
			this.pbDiscord.Image = Image.FromFile(this.appPath + "\\assets\\pictures\\contact\\discord.png");
			this.pbYoutube.Image = Image.FromFile(this.appPath + "\\assets\\pictures\\contact\\youtube.png");
			this.pbGamejolt.Image = Image.FromFile(this.appPath + "\\assets\\pictures\\contact\\gamejolt.png");
			this.pbDiscord.Visible = true;
			this.pbYoutube.Visible = true;
			this.pbGamejolt.Visible = true;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00004941 File Offset: 0x00002B41
		private void pbDiscord_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/sttjmY9PUB");
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000494E File Offset: 0x00002B4E
		private void pbYoutube_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/c/Jeremzed");
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000495B File Offset: 0x00002B5B
		private void pbGamejolt_Click(object sender, EventArgs e)
		{
			Process.Start("https://gamejolt.com/@NayTeeGame");
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00004968 File Offset: 0x00002B68
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void Contactme_Closing(object sender, CancelEventArgs e)
		{
			ProjectData.EndApp();
		}

		// Token: 0x04000023 RID: 35
		private string appPath;
	}
}
