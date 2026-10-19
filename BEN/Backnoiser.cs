using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace BEN
{
	// Token: 0x02000009 RID: 9
	[DesignerGenerated]
	public partial class Backnoiser : Form
	{
		// Token: 0x0600005A RID: 90 RVA: 0x00003194 File Offset: 0x00001394
		public Backnoiser()
		{
			base.Load += this.Backnoiser_Load;
			this.appPath = Application.StartupPath;
			this.InitializeComponent();
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00003368 File Offset: 0x00001568
		// (set) Token: 0x0600005E RID: 94 RVA: 0x00003370 File Offset: 0x00001570
		internal virtual PictureBox PictureBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00003379 File Offset: 0x00001579
		private void Backnoiser_Load(object sender, EventArgs e)
		{
			Cursor.Hide();
			this.PictureBox1.Image = Image.FromFile(this.appPath + "\\assets\\gifs\\Glitch.gif");
			this.PictureBox1.Visible = true;
		}

		// Token: 0x04000013 RID: 19
		private string appPath;
	}
}
