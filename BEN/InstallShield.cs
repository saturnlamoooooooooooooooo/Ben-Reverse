using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using BEN.My;
using BEN.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace BEN
{
	// Token: 0x02000011 RID: 17
	[DesignerGenerated]
	public partial class InstallShield : Form
	{
		// Token: 0x060000CA RID: 202 RVA: 0x0000B124 File Offset: 0x00009324
		public InstallShield()
		{
			base.Load += this.InstallShield_Load;
			base.FormClosing += this.InstallShield_FormClosing;
			this.installEtape = 1;
			this.appPath = Application.StartupPath;
			this.sec = 50;
			this.contentEnd = MyProject.Computer.FileSystem.ReadAllText(this.appPath + "\\datas\\fnshd.dat");
			this.canQuit = false;
			this.InitializeComponent();
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0000B1AC File Offset: 0x000093AC
		private void InstallShield_Load(object sender, EventArgs e)
		{
			base.Activate();
			base.KeyPreview = true;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0000B1BC File Offset: 0x000093BC
		private void Button2_Click(object sender, EventArgs e)
		{
			if (this.installEtape == 1)
			{
				this.installEtape = 2;
				this.RichTextBox1.Text = "Preparing to Install...";
				this.RichTextBox2.Text = "InstallShield Setup is preparing TLOZ : Majora's Mask,\r\nwhich will guide you through the program setup process.\r\nPlease wait.";
				this.ProgressBar1.Visible = true;
				this.Label1.Text = "Extracting files...";
				this.Label1.Visible = true;
				this.Timer1.Interval = 50;
				this.Timer1.Start();
				this.Button2.Enabled = false;
				this.Button3.Enabled = true;
				return;
			}
			if (this.installEtape == 2)
			{
				this.Button3.Enabled = false;
				this.Button2.Enabled = false;
				this.Button1.Enabled = false;
				this.installEtape = 3;
				this.RichTextBox1.Text = "Installing TLOZ : Majora's Mask...";
				this.RichTextBox2.Text = "InstallShield Setup is installing TLOZ : Majora's Mask,\r\nplease wait until the installation.";
				this.Label1.Text = "Installing maps...";
				this.Timer1.Interval = 100;
				this.ProgressBar1.Value = 0;
				this.Timer1.Start();
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000B2E0 File Offset: 0x000094E0
		private void Timer1_Tick(object sender, EventArgs e)
		{
			checked
			{
				if (this.installEtape == 2)
				{
					if (this.ProgressBar1.Value <= this.ProgressBar1.Maximum - 1)
					{
						ProgressBar progressBar;
						(progressBar = this.ProgressBar1).Value = progressBar.Value + 1;
					}
					if (this.ProgressBar1.Value == 25)
					{
						this.Label1.Text = "Extracting sounds...";
					}
					if (this.ProgressBar1.Value == 45)
					{
						this.Label1.Text = "Extracting maps...";
					}
					if (this.ProgressBar1.Value == 65)
					{
						this.Label1.Text = "Extracting structures...";
					}
					if (this.ProgressBar1.Value == 85)
					{
						this.Label1.Text = "Extracting meshes...";
					}
					if (this.ProgressBar1.Value == 100)
					{
						this.Timer1.Stop();
						this.Label1.Text = "Extraction done";
						this.Button2.Enabled = true;
					}
				}
				if (this.installEtape == 3)
				{
					if (this.ProgressBar1.Value <= this.ProgressBar1.Maximum - 1)
					{
						ProgressBar progressBar;
						(progressBar = this.ProgressBar1).Value = progressBar.Value + 1;
					}
					if (this.ProgressBar1.Value == 10)
					{
						this.Label1.Text = "Installing meshes...";
						try
						{
							File.WriteAllText(this.appPath + "\\datas\\others\\WHAT HAVE YOU DONE.txt", Resources.WHAT_HAVE_YOU_DONE);
						}
						catch (Exception ex)
						{
						}
					}
					if (this.ProgressBar1.Value == 20)
					{
						this.Label1.Text = "Installing assets...";
						try
						{
							File.WriteAllText(this.appPath + "\\datas\\others\\ENOD UOY EVAH TAHW.txt", Resources.ENOD_UOY_EVAH_TAHW);
						}
						catch (Exception ex2)
						{
						}
					}
					if (this.ProgressBar1.Value == 30)
					{
						this.Label1.Text = "Installing characters...";
						if (!MyProject.Computer.FileSystem.FileExists(this.appPath + "\\datas\\gamedataDeath1.dat") && !MyProject.Computer.FileSystem.FileExists(this.appPath + "\\datas\\gamedataDeath1.dat"))
						{
							try
							{
								File.Create(this.appPath + "\\datas\\gamedataDeath1.dat").Close();
							}
							catch (Exception ex3)
							{
							}
						}
					}
					if (this.ProgressBar1.Value == 40)
					{
						this.Label1.Text = "Installing licenses...";
						if (!MyProject.Computer.FileSystem.FileExists(this.appPath + "\\datas\\game2.dat") && !MyProject.Computer.FileSystem.FileExists(this.appPath + "\\datas\\game2.dat"))
						{
							try
							{
								File.Create(this.appPath + "\\datas\\game2.dat").Close();
							}
							catch (Exception ex4)
							{
							}
						}
					}
					if (this.ProgressBar1.Value == 50)
					{
						this.Label1.Text = "Installing worlds...";
						if (!MyProject.Computer.FileSystem.FileExists(this.appPath + "\\datas\\game2ad.dat") && !MyProject.Computer.FileSystem.FileExists(this.appPath + "\\datas\\game2ad.dat"))
						{
							try
							{
								File.Create(this.appPath + "\\datas\\game2ad.dat").Close();
							}
							catch (Exception ex5)
							{
							}
						}
					}
					if (this.ProgressBar1.Value == 60)
					{
						this.Label1.Text = "Installing dialogs...";
						if (!MyProject.Computer.FileSystem.FileExists(this.appPath + "\\datas\\fnshd.dat") && !MyProject.Computer.FileSystem.FileExists(this.appPath + "\\datas\\fnshd.dat"))
						{
							try
							{
								File.Create(this.appPath + "\\datas\\fnshd.dat").Close();
							}
							catch (Exception ex6)
							{
							}
						}
					}
					if (this.ProgressBar1.Value == 70)
					{
						this.Label1.Text = "Installing languages...";
						try
						{
							File.WriteAllText(this.appPath + "\\datas\\fnshd.dat", "");
						}
						catch (Exception ex7)
						{
						}
					}
					if (this.ProgressBar1.Value == 80)
					{
						this.Text = "T\u0307\u030e\u030c\u034a\u0367\u031e\u0326\u031d\u0353\u032aL\u0350\u0356\u031f\u0359\u035a\u0354\u0347O\u0344\u032aZ\u0342\u0305\u0343\u0321\u033c\u035a\u0332\u0317 \u031a\u030f\u036c\u033f\u0360:\u0346\u034b\u0305\u034a\u0352\u0346\u0308\u0489\u032d\u032b\u0329\u0326\u0333\u031f\u0359 \u033e\u031a\u0361\u0330\u0353\u033c\u0325\u031e\u031d\u0320M\u0310\u0307\u033d\u0307\u0334\u032ca\u036a\u0351\u035f\u0317\u0345\u032b\u032e\u0325\u0348\u0325j\u0302\u036e\u0367\u035b\u034f\u032a\u032f\u034e\u033c\u033b\u031do\u033f\u036b\u0312\u0368\u0346\u0343\u0352r\u0328\u0330\u033c\u0331a\u0317\u033b\u0329'\u035b\u030b\u0340\u0319\u0353\u0332s\u0352\u0302\u0302\u0352\u035c\u034e\u032d\u0356\u032d \u034c\u031b\u033c\u0345\u035a\u0347\u0348M\u0363\u033d\u036a\u036c\u0308\u0342\u030b\u0360\u0353\u033b\u0329a\u035b\u0314\u030d\u0306\u0310\u0325\u032c\u0317\u034es\u0350\u034b\u033f\u034f\u0317\u0332\u0354k\u0322\u0349\u031d \u036d\u0300\u0313\u0300\u0361\u0330\u0320 \u036d\u0350\u0301\u034c\u034b\u0301\u030c\u0349\u0325\u032b\u0349\u0323\u0355\u0325-\u030e\u036b\u030b\u0352\u031a\u036e\u0343\u0334\u0355\u0354\u0355\u0319 \u0368\u0365\u030c\u030d\u030f\u030e\u0336\u034d\u034e\u033cI\u0342\u0313\u0336\u0353\u031f\u035an\u0350\u031a\u0300\u030c\u036e\u0302\u034d\u032a\u0347\u0333\u031c\u031c\u035as\u030b\u031b\u034e\u031e\u0318\u0323t\u030d\u030f\u0368\u0361\u032b\u0353a\u0304\u0369\u0308\u034c\u0489\u031c\u0348\u034e\u0329l\u0308\u0342\u036c\u0364\u0350\u0322\u032a\u0359l\u036a\u033d\u0311\u0310\u0301\u034b\u036c\u033c\u0330\u0345\u032fS\u033f\u034c\u036b\u0312\u0310\u032bh\u0326\u0354\u0326\u0349i\u0342\u0305\u034c\u032f\u034e\u0359\u034e\u0330\u0331\u033be\u030c\u0365\u030f\u0306\u0365\u0309\u033d\u0489\u0330\u0320\u0323\u0356\u0324\u0331l\u036e\u0360\u0318\u0316\u032f\u0325\u033ad\u033d\u033f\u030a\u035c\u0339 \u0367\u031f\u033b\u0355\u0354\u0345\u0319\u032fW\u0350\u030c\u0305\u0324\u031e\u035ai\u034c\u0321\u032c\u0345\u0348\u031dz\u0308\u0306\u030e\u034a\u0333\u0317\u0330\u0355a\u036d\u036d\u0303\u034c\u036d\u0365\u035b\u0327r\u036f\u0314\u034b\u0331\u032a\u0325\u032f\u0353\u0320\u031dd\u0304\u034c\u0355\u033c\u0329\u0359";
						this.RichTextBox1.Text = "I\u0365\u0311\u0309\u036a\u0306\u034b\u0314\u0357\u0300\u034b\u0336\u035d\u0362\u035e\u0347\u033b\u0348\u0353\u032e\u0349\u031d\u0330\u031cn\u0310\u036e\u031a\u0312\u0306\u034b\u0307\u0343\u0311\u0312\u0309\u036b\u0312\u0336\u0335\u032c\u031f\u035a\u031f\u0333\u034d\u032b\u0332\u0319\u0332\u0348\u031f\u032e\u032b\u0316\u0339\u0359\u0339\u035as\u0311\u036a\u0305\u0302\u0302\u0314\u0309\u0489\u031b\u0338\u0334\u0330\u035a\u0316\u032at\u030c\u0365\u036b\u036c\u0351\u0301\u0311\u0342\u0343\u0344\u0309\u0352\u030a\u0366\u0314\u030e\u0350\u036b\u0360\u034f\u0489\u035e\u0358\u032e\u032e\u0359\u031e\u0325\u0329\u034e\u0359\u0323a\u0357\u036c\u0305\u034c\u036e\u0314\u030b\u035b\u0304\u030e\u0337\u0358\u0334\u0336\u035d\u0354\u0325\u0353\u0318\u0323\u034d\u0320\u032d\u0356\u033bl\u0364\u0314\u0369\u0342\u0367\u0363\u0365\u034f\u035f\u0338\u0358\u0335\u0332\u0349\u034d\u0319\u034el\u0350\u0351\u030c\u0346\u0305\u0368\u0336\u0362\u0318\u031d\u033b\u032b\u0319\u031d\u031d\u031f\u0359\u0355\u0319\u0319\u0320\u0331\u032ei\u030c\u036a\u0343\u0307\u0344\u0358\u0489\u032c\u0319\u032f\u0333\u0359\u0319\u0323\u0318\u0353\u0323\u032f\u032f\u0320\u0333\u0345\u0316\u0347n\u0305\u030a\u0309\u0302\u034f\u035c\u0328\u0333\u0329\u0323\u035a\u032b\u0333\u032b\u0325\u0324\u035a\u0353\u0345\u0316\u033a\u0355\u0323\u034e\u0354g\u0310\u030d\u033f\u0368\u030d\u0342\u0342\u035b\u0300\u0313\u034f\u0327\u0327\u0489\u032e\u0349\u032c\u0324\u0331 \u0310\u030a\u0300\u0314\u035b\u0305\u031a\u0343\u0304\u033d\u030b\u0352\u0357\u0365\u0363\u033e\u031a\u031b\u0338\u034f\u0321\u031d\u032b\u0319\u031e\u033c\u0316\u0326\u0332\u031f\u0347\u0349\u034d\u032a\u031d\u032fT\u0311\u0364\u0346\u031a\u0346\u030b\u033e\u034c\u0304\u0365\u0305\u0303\u0366\u030b\u0307\u0368\u0342\u0367\u0313\u035c\u035d\u0337\u0336\u035f\u0320\u0339\u0359\u0331\u0319\u031e\u034d\u0320\u034e\u0355\u0318\u035a\u0331L\u0302\u034b\u0310\u030e\u0352\u034a\u036d\u034b\u0350\u033f\u0338\u0321\u0356\u0355\u0359\u0325\u032f\u0324\u0325O\u034a\u0311\u030a\u0366\u0342\u0305\u0302\u033f\u030e\u0368\u0310\u0342\u0312\u0343\u0343\u033d\u034b\u0350\u035c\u0321\u0322\u0337\u035c\u032b\u032d\u0339\u032f\u0356\u0330\u0333\u031d\u0316Z\u0368\u034b\u033f\u036f\u0346\u0312\u030b\u0368\u033d\u034c\u0351\u030f\u034a\u031b\u0341\u035e\u0489\u0326\u0345\u0319\u0353\u0333\u0333\u032a \u031a\u0342\u034a\u0311\u0343\u0312\u0342\u0369\u0369\u036c\u0304\u036f\u0304\u0303\u035b\u0340\u0359\u032c\u034e\u033b:\u0364\u033d\u0343\u036a\u036a\u0366\u0300\u033d\u030e\u0334\u0334\u032e\u032f\u031f\u0347\u0323\u032c\u0325\u0345\u031f\u0355\u034d\u0320 \u030a\u034a\u0352\u0311\u034b\u0303\u0351\u034a\u036d\u0340\u0360\u0328\u031e\u032f\u0333\u032f\u0317\u032b\u0317\u032e\u035a\u031f\u0331\u0359\u0353M\u0313\u030c\u0307\u0363\u033f\u0346\u035e\u035e\u0338\u035d\u033c\u034e\u031c\u034d\u0317\u0354\u0324a\u0301\u0300\u0357\u0346\u034c\u036f\u0367\u033d\u0364\u030f\u030f\u034b\u0310\u030e\u036b\u0489\u035e\u0358\u035c\u0336\u032d\u031e\u033c\u0318\u0323j\u0308\u0366\u0310\u0367\u0300\u0340\u0322\u0361\u0362\u0354\u031d\u032c\u0316\u0359o\u0357\u0302\u0365\u0315\u0340\u0489\u035d\u031c\u0329\u0317\u033a\u0354r\u0365\u034c\u0300\u0314\u0368\u033f\u0365\u033d\u036b\u036b\u0303\u0305\u0305\u0305\u036f\u0312\u036d\u0307\u0336\u035e\u0340\u0321\u032d\u0325\u031e\u0325\u0319\u031d\u0326\u031f\u031f\u032d\u0329\u0325\u033ba\u030d\u034b\u030f\u0346\u0344\u0306\u030b\u0366\u0305\u0312\u030d\u0309\u033e\u030e\u034c\u0346\u034a\u0306\u0350\u0362\u0348\u0349\u0325\u0320\u0317'\u036c\u0305\u036a\u0302\u0310\u033d\u030b\u030d\u0342\u0344\u0303\u031b\u0327\u0340\u0334\u0318\u031e\u0333\u033a\u032b\u0333\u0326\u033a\u032a\u0347\u034d\u0331\u0326\u0318\u0319s\u034c\u0300\u0367\u036a\u033d\u0344\u0357\u0346\u0351\u0351\u034a\u0309\u034c\u0309\u0369\u0344\u030f\u0303\u0321\u0321\u0323\u034e\u0339\u032a\u034e\u0353\u0320\u0356\u0320\u0345\u034d\u033a\u034e \u0306\u0369\u036a\u0306\u030f\u0302\u033e\u0357\u0312\u0351\u0365\u0335\u0327\u031f\u0347\u0345\u0339\u0339\u0316\u034d\u034d\u032e\u0348\u031d\u031cM\u033d\u031a\u030d\u0351\u033f\u034f\u0336\u0489\u034f\u0331\u0331\u032a\u0355\u031f\u033c\u0318\u032e\u034da\u0302\u0367\u0305\u0310\u0306\u0303\u031a\u0301\u0305\u0366\u0343\u036d\u0352\u035f\u0327\u0341\u035d\u0335\u0349\u031e\u0329\u0329\u0329s\u030f\u0314\u0310\u034b\u0346\u030b\u030c\u034a\u036c\u0313\u0321\u0489\u035d\u0327\u0358\u0345\u032f\u0333\u0331\u035a\u0330\u031c\u031f\u0355\u0317\u031ck\u0368\u0302\u0369\u0352\u0304\u034c\u036c\u0342\u0321\u0341\u0338\u031c\u0329\u0333\u0329\u032b\u0339\u032e\u031f\u034e\u032c\u032b\u0329\u0355.\u030f\u0351\u0351\u036e\u0312\u0363\u0346\u0307\u0344\u030e\u0306\u033d\u0363\u030a\u036f\u0351\u0368\u0342\u0307\u0489\u0360\u0358\u031b\u032d\u0320\u032a\u032f.\u0369\u036e\u030c\u033f\u030f\u0307\u0306\u034b\u036b\u030b\u0311\u0489\u0341\u0322\u0328\u0341\u0316\u035a\u0356\u0354.\u0307\u0368\u0305\u0346\u0357\u0303\u0315\u0358\u035d\u0361\u0358\u0332\u0359\u0329";
						this.RichTextBox2.Text = "I\u0364\u0311\u0313\u035b\u033d\u0368\u0369\u030d\u0327\u0328\u0322\u0322\u035e\u0353\u0339\u0326\u0316\u033c\u034d\u0320\u032d\u031f\u0326\u0323\u0319\u0323\u034e\u032e\u032c\u032f\u031e\u031en\u030c\u0308\u0308\u0365\u030d\u0364\u0311\u030f\u036b\u035b\u0351\u035d\u0321\u034f\u032c\u033b\u0354\u0330\u033c\u032a\u034d\u0355\u031ds\u0303\u0314\u0306\u0350\u0301\u0308\u036b\u0314\u0369\u0303\u033f\u0300\u0308\u0300\u0368\u0360\u0338\u0362\u0355\u0339\u0323\u0331\u031e\u0359\u0353\u0355\u032a\u033c\u0320\u031ft\u030a\u030e\u0343\u0308\u0314\u0300\u033e\u0302\u0313\u033f\u0303\u034a\u036d\u0336\u0336\u0339\u0348\u032e\u0359\u0332\u0325\u032fa\u030d\u0357\u0343\u030d\u035c\u0315\u0361\u0339\u0332\u032b\u033c\u033a\u0329\u0333\u0354\u0333\u0339\u034d\u0345\u0329\u031e\u0316\u033cl\u033e\u0365\u036c\u0344\u0303\u034c\u030c\u033f\u0310\u0306\u0312\u0363\u0363\u030f\u0363\u030b\u0302\u030c\u034f\u0362\u0322\u0356\u0332\u0329\u032e\u0354\u033b\u031f\u033c\u032f\u032b\u0316\u0316\u033a\u031e\u0353\u033al\u0350\u0307\u036c\u0314\u030b\u0351\u0313\u0360\u0327\u0318\u032f\u0353\u032d\u032f\u0348\u033b\u032c\u031c\u0348\u0354\u032f\u034e\u0347\u0325\u034d\u033a\u0320\u0319S\u0307\u031a\u0305\u036a\u034a\u0364\u036a\u0351\u0352\u0342\u0343\u0357\u034b\u036f\u0367\u034b\u0344\u0367\u0350\u0321\u0340\u0362\u0489\u0327\u033a\u034e\u031d\u032b\u032e\u031f\u032c\u035a\u0332\u033c\u0316\u0326\u0329\u0354\u0349\u0353\u031ch\u0351\u034b\u0351\u033e\u036f\u0367\u030d\u036c\u0343\u0310\u0311\u0311\u030f\u0307\u0311\u0310\u0301\u0336\u035d\u0353\u0329\u0359\u032d\u0320\u0324\u031c\u0353\u0355\u0349\u0326\u034e\u0323\u0359\u0330\u0359\u0353\u0345i\u0351\u0350\u034b\u0310\u036a\u0352\u0311\u0365\u0368\u0341\u035e\u0489\u033c\u0318\u0345\u032c\u032b\u0333\u0347e\u0366\u030c\u0301\u0306\u0306\u0306\u0342\u0309\u0365\u030f\u036d\u0302\u0358\u0337\u0361\u035f\u0316\u0323\u031d\u032f\u031f\u0320l\u030f\u0344\u030b\u0304\u036c\u034a\u0310\u0307\u030d\u0303\u035b\u030e\u0334\u0337\u0340\u035a\u0326\u0359\u0356\u031d\u031d\u0359\u034d\u0355\u0317\u0349\u0349\u032d\u0349\u0349d\u0308\u0306\u0363\u0311\u0369\u0311\u030d\u0362\u0335\u0326\u033b\u0324\u0324\u031c\u0329\u0316\u032a \u0351\u0313\u030f\u0369\u0369\u0351\u0344\u0311\u0314\u0343\u0350\u0312\u036e\u0342\u036d\u0327\u0340\u0321\u0338\u0337\u0332\u0359\u0325S\u034a\u0342\u030b\u0367\u034a\u0306\u0365\u0367\u0351\u0302\u0310\u036e\u034b\u030a\u036c\u0357\u0338\u0335\u035e\u035d\u034f\u0356\u031f\u032b\u0325\u0331\u0332\u0325\u0325\u0316\u0320\u032b\u031c\u033be\u0352\u0302\u036d\u0342\u0357\u035c\u0328\u035d\u0336\u0360\u0353\u034d\u0316\u032b\u032c\u0339\u031c\u0330\u0355\u034d\u0324\u0353\u0333\u0353t\u036d\u036f\u0346\u0313\u0313\u0307\u0365\u0302\u030c\u033e\u0350\u0314\u0344\u0314\u0307\u030b\u0322\u0358\u032a\u032d\u0330\u0331u\u033e\u0304\u0352\u034c\u033e\u036a\u0352\u030f\u0364\u0314\u036b\u036c\u036e\u0312\u030f\u0334\u0336\u0334\u0316\u0324\u034e\u031c\u0316p\u0351\u030a\u0305\u030e\u0307\u0302\u0300\u0357\u0307\u033e\u0367\u0304\u030c\u0304\u031a\u0300\u0328\u035f\u0358\u0347\u0316\u034e\u033a\u032a\u0345\u0353\u0332 \u035b\u0368\u0309\u030a\u0305\u0357\u0300\u030f\u034a\u036d\u0342\u0350\u036b\u0307\u036d\u0350\u0309\u0311\u0300\u0362\u0336\u031c\u0323\u032c\u0319\u0318\u0348\u0329\u032c\u0330\u0316\u0317i\u0313\u033e\u0342\u036e\u0351\u0368\u0366\u031b\u0356\u0349\u0332\u0324s\u030b\u036d\u033e\u0310\u0344\u034a\u033f\u0307\u0367\u0343\u034b\u0362\u0337\u0322\u0489\u0489\u033c\u0355\u032b\u032f\u0331\u0355\u0325\u032b\u0353 \u0369\u033f\u030c\u0366\u034a\u0306\u0310\u0346\u036e\u0363\u0351\u0363\u030f\u0334\u0360\u0322\u0335\u0355\u0323\u0355\u0324\u033b\u033c\u031f\u032f\u0316\u034e\u032d\u0329\u0320\u0333\u0318\u033a\u0339\u034d\u033ai\u034b\u034a\u033d\u030f\u035b\u0368\u0351\u033f\u036f\u036a\u030a\u0309\u0307\u034a\u0351\u0369\u0341\u035c\u035d\u0338\u033a\u0348\u0348\u032c\u0323\u0330\u0331\u032c\u0324\u0356\u0326\u033b\u032b\u032a\u0359\u031d\u034e\u0354n\u033e\u033f\u033f\u030e\u034c\u0366\u0350\u0300\u0366\u0306\u0358\u0328\u031b\u0327\u032f\u0317\u031f\u0348\u0330\u0329\u032b\u0356\u032b\u032ds\u030c\u0312\u0352\u034b\u030a\u0308\u036a\u0366\u035b\u0344\u034a\u030b\u0352\u036f\u035d\u0358\u0489\u0319\u031d\u034e\u0317\u0319\u0353\u031d\u0325\u0355\u0359\u032c\u031f\u0345\u0355\u0349\u034e\u031e\u034et\u0344\u0301\u033e\u034b\u0350\u0366\u030c\u030e\u0357\u033e\u0303\u0344\u0352\u033d\u034b\u036a\u0360\u0335\u034d\u031d\u0316\u034e\u0330\u0332\u035a\u0356\u0325\u032d\u0348\u0326\u032d\u032a\u0324a\u0310\u036b\u0365\u0342\u0308\u0364\u0308\u033d\u031a\u036c\u0346\u0346\u030e\u0310\u0361\u031b\u0334\u0328\u0347\u035a\u0331\u0316\u0317\u0325\u0324l\u0368\u030b\u0352\u0364\u0311\u0315\u031b\u035e\u0358\u0360\u035a\u0316\u032e\u034e\u0318\u0330l\u0343\u0352\u030d\u0367\u036d\u036b\u0301\u0350\u0312\u0352\u031a\u034b\u035b\u0307\u0307\u036b\u0350\u036d\u036d\u0334\u0335\u0328\u032a\u0359\u0330\u0339\u0354\u032e\u031e\u0329\u0333\u0316\u0333\u032d\u031d\u0347i\u0302\u030e\u0310\u0309\u0362\u0341\u0358\u031b\u0321\u0317\u0345\u0318\u0330n\u035b\u0344\u0314\u034a\u0309\u0344\u030e\u0312\u034c\u0367\u0366\u0311\u030d\u0334\u0334\u0322\u031b\u035f\u0326\u033b\u0354\u032b\u0323\u0317\u033c\u0345\u032e\u032d\u0356\u0329\u0345\u0348\u0349\u035a\u0330g\u0357\u0308\u0352\u0303\u033f\u0306\u0360\u032c\u035a\u0324\u032c\u0339\u032a\u032f \u0346\u034c\u036f\u0302\u0369\u036e\u0344\u033e\u0366\u0363\u0342\u0366\u0338\u0337\u0322\u035f\u0332\u033b\u0332\u0332\u0355\u034d\u031e\u0347\u034dT\u035b\u036f\u0314\u0312\u030f\u035b\u036f\u036f\u0303\u034b\u0367\u036a\u0363\u036e\u031a\u0338\u0489\u0489\u0360\u0362\u032e\u0348\u031f\u035a\u032f\u031e\u0331\u0355\u0323\u0324\u0320L\u0307\u0304\u0367\u0366\u0300\u036f\u033d\u030d\u0315\u035c\u031b\u031b\u031e\u032a\u032e\u0349\u035a\u034e\u0349\u0325\u034d\u0316\u032c\u0323\u031d\u0353\u0353O\u0304\u0350\u036b\u030c\u031a\u036d\u0305\u035b\u030b\u033f\u0357\u036d\u033e\u033d\u0308\u030b\u0342\u031b\u0338\u035d\u0320\u0356\u0324\u0318\u0353\u0345\u032a\u0331\u0329Z\u030f\u0304\u0342\u0367\u030e\u033d\u0365\u0363\u035c\u0361\u032b\u0347\u0318\u031e\u035a\u0348\u032d\u034e\u0330\u0339\u0320\u0317\u033c\u0347 \u034a\u0367\u0306\u033f\u0301\u0302\u0307\u031a\u030d\u034a\u0300\u0366\u0301\u0303\u0304\u0365\u034c\u033e\u036a\u0360\u035c\u0341\u032f\u033a\u035a\u0348\u0355\u032d:\u0352\u0364\u0369\u0307\u034b\u0344\u0352\u0306\u033f\u030c\u0300\u035c\u0341\u0337\u034d\u0355\u032f\u0354\u032e\u0359\u0339\u0323\u035a\u034e\u032e\u0330 \u033d\u0352\u036c\u0306\u033e\u033d\u0314\u0302\u0303\u0368\u030b\u0357\u0313\u0304\u0310\u033e\u0301\u033f\u034a\u0337\u0322\u0340\u035f\u032e\u031c\u0332\u0329\u0326\u032f\u0348\u0319M\u0302\u030a\u0364\u0302\u030d\u0313\u0312\u0346\u0309\u036c\u030e\u0334\u035e\u034e\u031d\u0318\u032c\u0319\u032c\u032f\u0354\u0316\u0333\u032d\u0326\u0348\u034d\u0359\u034d\u034ea\u0368\u034b\u0343\u0368\u0300\u0365\u036f\u0312\u0308\u034a\u036c\u0305\u0303\u0366\u0336\u0340\u0362\u0328\u0318\u032f\u032b\u0324\u034d\u032e\u032b\u031d\u031e\u0347\u0355\u032a\u0326\u032c\u0349\u032a\u0325\u034e\u0326j\u0309\u0363\u036a\u030a\u0344\u0352\u0351\u033d\u0305\u034f\u0335\u0348\u0356\u032e\u0316\u031c\u0318\u0345\u0356\u0324\u0355\u034do\u0357\u033d\u036f\u0313\u034c\u0306\u0350\u0310\u030b\u036f\u0352\u0302\u0314\u0368\u0350\u036a\u0346\u0352\u0338\u0337\u0341\u0315\u0356\u0320\u0355\u035a\u0355r\u0364\u0307\u0314\u035f\u0341\u0356\u031d\u032d\u0345\u0325\u0355\u0324\u031f\u033a\u0323\u032e\u032e\u031ea\u030d\u0343\u0306\u0346\u033d\u0352\u0311\u034c\u0363\u0365\u0306\u034a\u030a\u0344\u0368\u0346\u0366\u0307\u0321\u0328\u0319\u0354\u032e\u0349'\u0351\u0357\u0342\u030e\u031a\u033e\u030c\u036c\u0365\u0306\u030b\u0350\u0314\u035d\u0360\u0335\u031e\u0319\u0348\u033c\u0319\u032b\u0348\u032d\u0353\u035a\u033b\u032e\u0331\u034es\u0365\u035b\u0311\u0351\u0352\u036d\u0300\u030d\u0346\u0312\u0300\u0304\u0346\u0328\u0321\u035f\u0322\u033a\u0349\u0355\u0333\u0359 \u033d\u0310\u0300\u036b\u0313\u0367\u0352\u036f\u0300\u0307\u033d\u0309\u036e\u0350\u0311\u0312\u0307\u0360\u0340\u0336\u0321\u0353\u0330\u0349\u0325\u032a\u0318\u0349\u0319\u0331\u0326\u0359\u032dM\u030b\u0364\u036f\u0344\u0344\u036a\u030d\u0366\u0311\u036b\u0301\u030b\u033f\u0300\u030b\u035b\u030c\u0361\u0361\u0347\u0316\u035a\u032d\u0353\u031d\u0347\u031e\u032a\u0345\u0331a\u0369\u033d\u030b\u0343\u0363\u0357\u0351\u036e\u0351\u030c\u033d\u0311\u030a\u036d\u033d\u030b\u0365\u0361\u0338\u0323\u034e\u0326\u0323\u034d\u0349\u032a\u032c\u0325\u032b\u031f\u0330\u0348\u0356\u033cs\u0300\u0306\u0304\u0304\u036c\u036b\u033d\u0301\u0352\u0303\u0302\u0315\u0328\u034f\u0323\u032d\u032f\u0331\u0359k\u033d\u036f\u0313\u0368\u0368\u030d\u036a\u030c\u0350\u0352\u0357\u0313\u035b\u0361\u035e\u035f\u0358\u0355\u033b\u0354\u033a\u0329\u031e\u032c\u0354\u033a\u0348\u0333\u0354\u0339\u032e\u0359,\u0303\u0302\u0300\u0363\u0352\u0307\u0328\u035d\u0358\u031c\u0345\u033a\u0331\u032e\u0354\u0356\u033c\u0347\u032f\u0329\u0339\u0329\u0353\u0320\u031d\u033a\r\np\u0351\u0308\u0364\u036b\u0306\u0307\u0342\u030e\u0350\u030b\u036a\u0341\u0340\u0341\u035e\u0355\u0333\u031e\u0319\u0323l\u0310\u0346\u034a\u0334\u0361\u0329\u0333\u032f\u0356\u0339\u0325e\u0344\u0310\u036c\u035b\u031b\u0362\u0338\u0362\u0334\u0333\u034e\u0333\u0319\u032a\u0345\u0339\u034d\u032f\u032c\u0330\u0354\u031f\u0323a\u031a\u0367\u0311\u0357\u0366\u0351\u0362\u0339\u032a\u0354\u0353\u034e\u0317s\u035b\u030b\u030f\u0342\u033e\u036f\u0315\u035d\u0341\u0338\u034e\u0345\u0320\u0355\u0332e\u036e\u0314\u0351\u030d\u0303\u0309\u0352\u030d\u0366\u036a\u0327\u0321\u035e\u0341\u0356\u035a\u035a\u033b\u033c\u032e\u0318\u0354\u0331\u031d\u0354\u0348\u0323 \u030e\u030c\u0343\u0306\u0315\u0337\u0489\u0336\u0332\u033c\u0332\u0324\u0356\u0329\u031e\u0347\u033b\u0355\u035a\u0339\u031e\u0331\u032f\u034e\u033a\u0355w\u0369\u030e\u0357\u0344\u030e\u036b\u030e\u0352\u034f\u0327\u0339\u0359\u034e\u0323\u0339\u0320\u0353\u0323\u0356\u0349\u0331a\u036c\u0314\u0306\u0302\u030c\u0346\u0300\u035b\u035e\u0337\u033b\u0353\u0356\u032b\u0329\u032e\u0318\u0332i\u036a\u0314\u0351\u0314\u0311\u033e\u0300\u0366\u036c\u0302\u0357\u0346\u0310\u0304\u035f\u031b\u031b\u0328\u0327\u0323\u0331\u0333\u0326\u0319\u031f\u0329\u034d\u0317\u0347\u033c\u0349\u0353t\u035b\u0346\u0302\u0312\u0350\u036a\u035b\u030f\u0368\u0312\u035b\u030b\u0311\u0303\u030f\u0342\u0361\u0362\u035f\u0328\u035f\u033b\u031d\u032c\u033c \u0350\u036f\u0351\u0367\u0311\u035c\u0329\u0356\u031c\u0323\u0330\u031c\u0316u\u0343\u0310\u034b\u0368\u0352\u0304\u0357\u0344\u030b\u030d\u0315\u0334\u034e\u0348\u033a\u0320\u0353\u031d\u032b\u035a\u033b\u0316\u032a\u0323\u031f\u031e\u0329\u0354\u0333\u0332n\u0350\u036d\u033f\u0364\u035c\u031b\u0361\u031b\u0333\u0320\u0332\u0318\u0333\u0347\u031c\u0316\u0325\u0320\u0347\u0332t\u0350\u030f\u0367\u031a\u0309\u030e\u034c\u030e\u0327\u0322\u035e\u0321\u0338\u0330\u034d\u032d\u0345\u0331\u0345\u0331i\u036f\u033e\u036b\u036f\u036a\u0312\u0309\u0364\u0365\u0346\u036d\u034a\u0304\u0367\u0307\u0322\u035d\u034f\u0328\u0334\u035a\u0330\u032f\u032bl\u036c\u036f\u033f\u0300\u0363\u0309\u030c\u0306\u0335\u0321\u0330\u0318\u0330\u032a\u0319\u031f\u0324\u034d\u034d\u0329\u0325\u0349\u034d\u0317\u0349 \u0314\u030a\u0344\u0305\u036b\u0309\u0365\u035b\u036c\u033d\u0305\u0357\u034b\u036f\u030d\u030c\u0340\u031b\u0336\u0349\u034d\u0345\u0319\u035a\u0347\u0324\u0320\u0359\u033c\u035at\u030a\u036d\u0344\u0365\u0363\u0311\u0366\u036d\u034a\u035e\u0328\u035e\u0338\u0331\u031d\u0349\u031c\u033c\u032b\u0347\u035a\u0324\u031f\u0324\u0316\u0324h\u034c\u030a\u033d\u0304\u0341\u034f\u0341\u0356\u0326\u0333\u0329\u0331\u0356\u0349\u032d\u0333\u032c\u032c\u0349\u0316\u0316\u032fe\u0357\u034a\u0304\u0363\u033d\u0352\u031a\u033f\u036a\u0300\u034c\u035b\u0342\u0346\u035b\u035c\u0361\u0328\u031e\u031d\u0349\u031c\u0323\u0323\u0345\u0347\u0325\u0349\u0318\u0318\u0324\u0316 \u0309\u0314\u036e\u0309\u0346\u0367\u030f\u033e\u030f\u0309\u0344\u030c\u0352\u0369\u0300\u036c\u0321\u0328\u0358\u0332\u0354\u0317\u0331\u0326\u0317\u0326\u0329\u032e\u032c\u034e\u031c\u0326\u031e\u0317\u0325i\u0312\u030e\u030d\u0366\u0309\u0311\u0306\u030c\u0307\u0305\u033e\u033d\u0309\u035e\u0328\u0338\u0347\u0317\u033a\u0345\u0331\u0353n\u0302\u036a\u0366\u0364\u0351\u0301\u0303\u0366\u0315\u0335\u035f\u0316\u0356\u0345\u0319\u0359\u0355\u0330\u0318\u0329\u032e\u0339\u0331\u0339\u0347\u0359\u034d\u031f\u034ds\u033d\u036f\u0357\u036e\u0309\u030b\u0350\u0363\u0304\u034b\u0342\u034a\u036a\u0343\u0336\u0335\u0319\u0326\u032f\u034e\u0333\u0345t\u036b\u0309\u030f\u0307\u036a\u036e\u0308\u036c\u036f\u036b\u0363\u036f\u0309\u0338\u0361\u0335\u0315\u031b\u0347\u0354\u031e\u0318\u0317\u0339\u0333\u0316\u0330\u0353\u0345\u0331\u032e\u0359\u032ca\u030d\u0304\u0312\u030d\u036c\u031a\u036f\u031a\u0369\u0362\u0340\u0328\u0489\u033a\u0326\u032d\u032b\u0317l\u0305\u0304\u034a\u030c\u0313\u030d\u0303\u0301\u035e\u0334\u0349\u0347\u031e\u0323\u0331\u0331\u031e\u0355\u0329\u0330\u0317\u0348\u035a\u034dl\u0309\u0369\u036e\u0351\u030d\u0364\u0307\u0346\u031a\u0367\u0336\u0360\u0315\u0328\u032f\u0345\u0359\u0330\u031c\u032f\u0332\u0349\u033b\u032b\u034e\u034d\u031e\u033c\u0330\u0347\u0354\u032da\u0363\u0344\u0313\u0310\u0343\u034a\u0307\u0311\u033e\u0365\u0344\u0309\u030c\u036d\u036e\u0310\u0366\u0366\u0360\u0334\u0362\u0332\u0325\u0348\u0354\u0333t\u030c\u0311\u0314\u036e\u0306\u030f\u036a\u035d\u0337\u031b\u0324\u0323\u0326\u0347\u0347\u031f\u032f\u0326\u0316\u034ei\u0302\u0301\u034a\u0368\u0306\u0302\u0309\u0361\u0358\u0361\u0348\u034d\u031e\u031e\u032a\u033a\u0349\u032c\u0359\u0319\u032b\u031c\u031f\u0347o\u036f\u0350\u034c\u0306\u0301\u034c\u036f\u030c\u033e\u0367\u0303\u0364\u0301\u0367\u0366\u0363\u0328\u0353\u032e\u032c\u0324\u0355\u033c\u035a\u0317\u0318\u0349\u033a\u0317\u0326\u0320\u0318\u0356\u033an\u030f\u0343\u0313\u035f\u0489\u035a\u0345\u033c\u0330\u0353\u0347\u033a\u0320\u0356\u033a\u032d\u035a\u0356\u031f\u0331.\u0306\u036a\u0351\u034a\u0369\u036b\u033d\u036a\u030b\u0342\u0342\u0368\u0368\u0363\u0308\u0306\u0321\u035d\u034e\u0318\u0345\u0333\u0323\u0347\u0339\u0349";
						this.Label1.Text = "Installing B\u036f\u0311\u0314\u0304\u0302\u0306\u0342\u0313\u0341\u0336\u0328\u0329\u0348\u0347\u0330\u0349\u0316\u0326\u034dE\u0307\u030f\u0367\u0369\u0314\u0363\u030d\u0302\u0363\u0307\u030d\u033e\u0369\u0342\u034a\u0340\u0358\u031b\u035d\u0353\u0349\u0355\u032a\u032fN\u0367\u0304\u0313\u0346\u033e\u0313\u030d\u0301\u035f\u0327\u0320\u033a\u0326\u0333\u0345\u0326\u032f\u0329\u032e\u034e...";
					}
					if (this.ProgressBar1.Value == 87)
					{
						this.canQuit = true;
						this.Timer1.Stop();
						base.Hide();
						MyProject.Forms.Scream1.Show();
						base.Close();
					}
				}
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0000B7EC File Offset: 0x000099EC
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void Button1_Click(object sender, EventArgs e)
		{
			if (this.installEtape == 2)
			{
				this.Timer1.Stop();
				int num = (int)MessageBox.Show("Are you sure to cancel the installation ?", "InstallShield Wizard", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (num == 6)
				{
					if (Conversions.ToBoolean(NewLateBinding.LateGet(this.contentEnd, null, "Contains", new object[] { "yes" }, null, null, null)))
					{
						base.Hide();
						this.TimerEA.Start();
						return;
					}
					ProjectData.EndApp();
					return;
				}
				else if (num == 7)
				{
					this.Timer1.Start();
					return;
				}
			}
			else if (MessageBox.Show("Are you sure to cancel the installation ?", "InstallShield Wizard", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if (Conversions.ToBoolean(NewLateBinding.LateGet(this.contentEnd, null, "Contains", new object[] { "yes" }, null, null, null)))
				{
					base.Hide();
					this.TimerEA.Start();
					return;
				}
				ProjectData.EndApp();
			}
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000B8CC File Offset: 0x00009ACC
		private void Button3_Click(object sender, EventArgs e)
		{
			if (this.installEtape == 1)
			{
				this.Button3.Enabled = false;
				return;
			}
			if (this.installEtape == 2)
			{
				this.installEtape = 1;
				this.Timer1.Stop();
				this.Button3.Enabled = false;
				this.Label1.Visible = false;
				this.Label1.Text = "---";
				this.Timer1.Interval = 50;
				this.ProgressBar1.Visible = false;
				this.ProgressBar1.Value = 0;
				this.RichTextBox1.Text = "Welcome to the InstallShield Wizard for\r\nThe Legend of Zelda : Majora's Mask";
				this.RichTextBox2.Text = "The InstallShield Wizard will install The Legend of Zelda : Majora's Mask on your computer. To continue,\r\nclick Next.\r\n\r\n\r\n\r\n\r\nWARNING: This program is protected by copyright law and\r\ninternational treaties.";
				this.Button2.Enabled = true;
			}
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0000B988 File Offset: 0x00009B88
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void TimerEA_Tick(object sender, EventArgs e)
		{
			this.sec = Operators.SubtractObject(this.sec, 1);
			if (Operators.ConditionalCompareObjectEqual(this.sec, 45, false))
			{
				this.TimerEA.Stop();
				MessageBox.Show("S\u035cO\u0341 YOU\u0328'\u0341RE \u035e \u0335LI\u0321KE \u035eTHIS.", "");
				this.TimerEA.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 43, false))
			{
				this.TimerEA.Stop();
				MessageBox.Show("YOU \u0340 K\u035dNOW \u0322 \u035eY\u035fO\u031bUR\u0328 FR\u0362IEN\u035dD\u0341 \u0315 I\u035fS\u0328 \u0321 \u0335 ST\u0338U\u0358CK\u0358,", "");
				this.TimerEA.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 41, false))
			{
				this.TimerEA.Stop();
				MessageBox.Show("BUT\u0327 \u0321 YO\u0322U'D\u0315 \u0362 R\u035cA\u0362TH\u0336ER \u0489 L\u0328EAVE \u0315 \u035dT\u0362H\u0328A\u0362N \u0334 \u035c GO\u031b \u035d \u0327S\u0358A\u0362VE\u0321 \u0362 \u0341 HIM\u0340", "");
				this.TimerEA.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 39, false))
			{
				this.TimerEA.Stop();
				try
				{
					File.WriteAllText(this.appPath + "\\datas\\fnshd.dat", "");
				}
				catch (Exception ex)
				{
				}
				MessageBox.Show("P\u035eA\u0335T\u0327H\u0321E\u0327TIC.\u0341", "");
				this.TimerEA.Start();
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 37, false))
			{
				MyProject.Computer.Audio.Play(this.appPath + "\\assets\\Skullkid.wav", AudioPlayMode.Background);
			}
			if (Operators.ConditionalCompareObjectEqual(this.sec, 32, false))
			{
				ProjectData.EndApp();
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0000BB20 File Offset: 0x00009D20
		private void InstallShield_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!this.canQuit)
			{
				e.Cancel = true;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x0000C185 File Offset: 0x0000A385
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x0000C18D File Offset: 0x0000A38D
		internal virtual PictureBox PictureBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x0000C196 File Offset: 0x0000A396
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x0000C19E File Offset: 0x0000A39E
		internal virtual RichTextBox RichTextBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x0000C1A7 File Offset: 0x0000A3A7
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x0000C1AF File Offset: 0x0000A3AF
		internal virtual RichTextBox RichTextBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060000DA RID: 218 RVA: 0x0000C1B8 File Offset: 0x0000A3B8
		// (set) Token: 0x060000DB RID: 219 RVA: 0x0000C1C0 File Offset: 0x0000A3C0
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

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060000DC RID: 220 RVA: 0x0000C203 File Offset: 0x0000A403
		// (set) Token: 0x060000DD RID: 221 RVA: 0x0000C20C File Offset: 0x0000A40C
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

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060000DE RID: 222 RVA: 0x0000C24F File Offset: 0x0000A44F
		// (set) Token: 0x060000DF RID: 223 RVA: 0x0000C258 File Offset: 0x0000A458
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

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x0000C29B File Offset: 0x0000A49B
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x0000C2A3 File Offset: 0x0000A4A3
		internal virtual ProgressBar ProgressBar1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x0000C2AC File Offset: 0x0000A4AC
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x0000C2B4 File Offset: 0x0000A4B4
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x0000C2BD File Offset: 0x0000A4BD
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x0000C2C8 File Offset: 0x0000A4C8
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

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x0000C30B File Offset: 0x0000A50B
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x0000C314 File Offset: 0x0000A514
		internal virtual Timer TimerEA
		{
			[CompilerGenerated]
			get
			{
				return this._TimerEA;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.TimerEA_Tick);
				Timer timer = this._TimerEA;
				if (timer != null)
				{
					timer.Tick -= eventHandler;
				}
				this._TimerEA = value;
				timer = this._TimerEA;
				if (timer != null)
				{
					timer.Tick += eventHandler;
				}
			}
		}

		// Token: 0x04000056 RID: 86
		private int installEtape;

		// Token: 0x04000057 RID: 87
		private string appPath;

		// Token: 0x04000058 RID: 88
		private object sec;

		// Token: 0x04000059 RID: 89
		private object contentEnd;

		// Token: 0x0400005A RID: 90
		private bool canQuit;
	}
}
