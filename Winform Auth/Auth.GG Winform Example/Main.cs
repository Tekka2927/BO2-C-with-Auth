using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace Auth.GG_Winform_Example
{
    public partial class Main : Form
    {
        public Mem m = new Mem();

        public Main()
        {
            InitializeComponent();
        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            expiry.Text = "Expiry: " + User.Expiry;
        }

        bool ProcOpen = false;

        private void hwid_Click(object sender, EventArgs e)
        {

        }

        private void welcome_Click(object sender, EventArgs e)
        {

        }

        private void siticonePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BGWorker_DoWork_1(object sender, DoWorkEventArgs e)
        {
            ProcOpen = m.OpenProcess("t6zm");
            if (!m.OpenProcess("t6zm"))
            {
                GR.Text = "Game Closed";
                Thread.Sleep(1000);
                return;
            }


            Thread.Sleep(1000);
            BGWorker.ReportProgress(0);
        }

        private void BGWorker_ProgressChanged_1(object sender, ProgressChangedEventArgs e)
        {
            if (checkBox1.Checked)
            {
                m.WriteMemory("base+1F4C068", "int", "999999");
            }

            if (Ammoinf.Checked)
            {
                m.WriteMemory("base+1F46ECC", "int", "999");
                m.WriteMemory("base+1F46ED4", "int", "999");
            }

            GR.Text = "Game Found";
        }

        private void BGWorker_RunWorkerCompleted_1(object sender, RunWorkerCompletedEventArgs e)
        {
            BGWorker.RunWorkerAsync();
        }

        private void Main_Shown_1(object sender, EventArgs e)
        {
            BGWorker.RunWorkerAsync();//Start the BGWorker_DoWork
			positionworker.RunWorkerAsync();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
			if (this.comboBox1.Text == "Default Weapon")
			{
				this.m.WriteMemory("0x0218C590,29C", "int", "1", "", null);
			}
			if (this.comboBox1.Text == "AK74u")
			{
				this.m.WriteMemory("0x0218C590,29C", "int", "5", "", null);
			}
			if (this.comboBox1.Text == "MP5")
			{
				this.m.WriteMemory("0x0218C590,29C", "int", "6", "", null);
			}
			if (this.comboBox1.Text == "Chicom CQB")
			{
				this.m.WriteMemory("0x0218C590,29C", "int", "7", "", null);
			}
			if (this.comboBox1.Text == "M14")
			{
				this.m.WriteMemory("0x0218C590,29C", "int", "15", "", null);
			}
			if (this.comboBox1.Text == "Colt M16A1")
			{
				this.m.WriteMemory("0x0218C590,29C", "int", "16", "", null);
			}
			if (this.comboBox1.Text == "SMR")
			{
				this.m.WriteMemory("0x0218C590,29C", "int", "18", "", null);
			}
			if (this.comboBox1.Text == "M8A1")
			{
				this.m.WriteMemory("0x0218C590,29C", "int", "20", "", null);
			}
			if (this.comboBox1.Text == "Type 25")
			{
				this.m.WriteMemory("0x0218C590,29C", "int", "22", "", null);
			}
			if (this.comboBox1.Text == "MTAR")
			{
				this.m.WriteMemory("0x0218C590,29C", "int", "24", "", null);
			}
			if (this.comboBox1.Text == "Remington")
			{
				this.m.WriteMemory("0x0218C590,29C", "int", "26", "", null);
			}
			if (this.comboBox1.Text == "Olympia")
			{
				this.m.WriteMemory("0x0218C590,29C", "int", "31", "", null);
			}
			if (this.comboBox1.Text == "S12")
			{
				this.m.WriteMemory("0x0218C590,29C", "int", "32", "", null);
			}
			if (this.comboBox1.Text == "M1216")
			{
				this.m.WriteMemory("0x0218C590,29C", "int", "33", "", null);
			}
			if (this.comboBox1.Text == "Galil")
			{
				this.m.WriteMemory("0x0218C590,29C", "int", "38", "", null);
			}
			if (this.comboBox1.Text == "FAL")
			{
				this.m.WriteMemory("0x0218C590,29C", "int", "39", "", null);
			}
			if (this.comboBox1.Text == "RPD")
			{
				this.m.WriteMemory("0x0218C590,29C", "int", "40", "", null);
			}
			if (this.comboBox1.Text == "HAMR")
			{
				this.m.WriteMemory("0x0218C590,29C", "int", "41", "", null);
			}
			if (this.comboBox1.Text == "DSR 50")
			{
				this.m.WriteMemory("0x0218C590,29C", "int", "44", "", null);
			}
			if (this.comboBox1.Text == "Barret M82A1")
			{
				this.m.WriteMemory("0x0218C590,29C", "int", "45", "", null);
			}
			if (this.comboBox1.Text == "M1911")
			{
				this.m.WriteMemory("0x0218C590,29C", "int", "55", "", null);
			}
			if (this.comboBox1.Text == "Python")
			{
				this.m.WriteMemory("0x0218C590,29C", "int", "57", "", null);
			}
			if (this.comboBox1.Text == "Executioner")
			{
				this.m.WriteMemory("0x0218C590,29C", "int", "58", "", null);
			}
			if (this.comboBox1.Text == "KAPR")
			{
				this.m.WriteMemory("0x0218C590,29C", "int", "59", "", null);
			}
			if (this.comboBox1.Text == "Fiveseven")
			{
				this.m.WriteMemory("0x0218C590,29C", "int", "60", "", null);
			}
			if (this.comboBox1.Text == "RPG")
			{
				this.m.WriteMemory("0x0218C590,29C", "int", "66", "", null);
			}
			if (this.comboBox1.Text == "War Machine")
			{
				this.m.WriteMemory("0x0218C590,29C", "int", "67", "", null);
			}
			if (this.comboBox1.Text == "Ballistic Knife")
			{
				this.m.WriteMemory("0x0218C590,29C", "int", "73", "", null);
			}
			if (this.comboBox1.Text == "RayGun")
			{
				this.m.WriteMemory("0x0218C590,29C", "int", "78", "", null);
			}
		}



        private void OneShot_DoWork(object sender, DoWorkEventArgs e)
        {
            while (!this.OneShot.CancellationPending)
            {
				string value = "0x8C";
				string text = "0x1A8";
				string text2 = "0x023346E4";
				for(int i = 0; i < 25; i++)
                {
					m.WriteMemory(string.Concat(new string[]
					{
						text2,
						"x",
						(i * Convert.ToInt32(value, 16)).ToString("X"),
						",",
						text
					}), "int", "1", "", null);
                }
			}
			e.Cancel = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
			if (this.checkBox2.Checked)
			{
				m.FreezeValue("t6zm.exe+01D8C590,4C", "int", "0", "");
				return;
			}
			this.m.UnfreezeValue("t6zm.exe+01D8C590,4C");
		}

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
			if (this.god.Checked)
			{
				m.WriteMemory("base+1DC5868", "int", "100");
			}
		}

        private void positionworker_DoWork(object sender, DoWorkEventArgs e)
        {
			for (; ; )
			{
				float cX = this.m.ReadFloat("02346AC8", "", true);
				string.Format("{0:N3}", cX);
				float cY = this.m.ReadFloat("02346ACC", "", true);
				string.Format("{0:N3}", cY);
				float cZ = this.m.ReadFloat("02346AD0", "", true);
				string.Format("{0:N3}", cZ);
				base.Invoke(new MethodInvoker(delegate ()
				{
					this.Plx.Text = "Player X : " + cX.ToString();
					this.PlY.Text = "Player Y : " + cY.ToString();
					this.PlZ.Text = "Player Z : " + cZ.ToString();
				}));
			}
		}

        private void TeleportWorker_DoWork(object sender, DoWorkEventArgs e)
        {
			while (!this.TeleportWorker.CancellationPending)
			{
				string value = "0x8C";
				string text = "0x134";
				string text2 = "0x138";
				string text3 = "0x13C";
				string text4 = "0x023346E4";
				for (int i = 0; i < 10000; i++)
				{
					this.m.WriteMemory(string.Concat(new string[]
					{
						text4,
						"+",
						(i * Convert.ToInt32(value, 16)).ToString("X"),
						",",
						text
					}), "float", "1211.25", "", null);
					this.m.WriteMemory(string.Concat(new string[]
					{
						text4,
						"+",
						(i * Convert.ToInt32(value, 16)).ToString("X"),
						",",
						text2
					}), "float", "-574.65", "", null);
					this.m.WriteMemory(string.Concat(new string[]
					{
						text4,
						"+",
						(i * Convert.ToInt32(value, 16)).ToString("X"),
						",",
						text3
					}), "float", "-61.875", "", null);
				}
			}
			e.Cancel = true;
		}

        private void TeleportWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
			if (this.TeleportWorker2.CancellationPending)
			{
				return;
			}
			float num = this.m.ReadFloat("02346AC8", "", true);
			float num2 = this.m.ReadFloat("02346ACC", "", true);
			float num3 = this.m.ReadFloat("02346AD0", "", true);
			string value = "0x8C";
			string text = "0x134";
			string text2 = "0x138";
			string text3 = "0x13C";
			string text4 = "0x023346E4";
			for (int i = 0; i < 10000; i++)
			{
				this.m.FreezeValue(string.Concat(new string[]
				{
					text4,
					"+",
					(i * Convert.ToInt32(value, 16)).ToString("X"),
					",",
					text
				}), "float", num.ToString(), "");
				this.m.FreezeValue(string.Concat(new string[]
				{
					text4,
					"+",
					(i * Convert.ToInt32(value, 16)).ToString("X"),
					",",
					text2
				}), "float", num2.ToString(), "");
				this.m.FreezeValue(string.Concat(new string[]
				{
					text4,
					"+",
					(i * Convert.ToInt32(value, 16)).ToString("X"),
					",",
					text3
				}), "float", num3.ToString(), "");
			}
			e.Cancel = true;
		}

        private void setcoordWorker_DoWork(object sender, DoWorkEventArgs e)
        {
			if (this.setcoordWorker.CancellationPending)
			{
				return;
			}
			string text = this.textBox1.Text;
			string text2 = this.textBox2.Text;
			string text3 = this.textBox3.Text;
			string value = "0x8C";
			string text4 = "0x134";
			string text5 = "0x138";
			string text6 = "0x13C";
			string text7 = "0x023346E4";
			for (int i = 0; i < 10000; i++)
			{
				this.m.FreezeValue(string.Concat(new string[]
				{
					text7,
					"+",
					(i * Convert.ToInt32(value, 16)).ToString("X"),
					",",
					text4
				}), "float", text, "");
				this.m.FreezeValue(string.Concat(new string[]
				{
					text7,
					"+",
					(i * Convert.ToInt32(value, 16)).ToString("X"),
					",",
					text5
				}), "float", text2, "");
				this.m.FreezeValue(string.Concat(new string[]
				{
					text7,
					"+",
					(i * Convert.ToInt32(value, 16)).ToString("X"),
					",",
					text6
				}), "float", text3, "");
			}
			e.Cancel = true;
		}

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
			if (this.checkBox5.Checked)
			{
				this.setcoordWorker.RunWorkerAsync();
			}
		}

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
			if (this.checkBox4.Checked)
			{
				this.TeleportWorker2.RunWorkerAsync();
			}
		}

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
			if (this.checkBox3.Checked)
			{
				this.TeleportWorker.RunWorkerAsync();
			}
			
		}
    }
}
