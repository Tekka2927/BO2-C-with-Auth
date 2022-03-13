namespace Auth.GG_Winform_Example
{
    public partial class Main : global::System.Windows.Forms.Form
    {
        protected override void Dispose(bool disposing)
        {
            bool flag = disposing && this.components != null;
            if (flag)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.Ammoinf = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.god = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.GR = new System.Windows.Forms.Label();
            this.expiry = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.BGWorker = new System.ComponentModel.BackgroundWorker();
            this.OneShot = new System.ComponentModel.BackgroundWorker();
            this.positionworker = new System.ComponentModel.BackgroundWorker();
            this.TeleportWorker = new System.ComponentModel.BackgroundWorker();
            this.TeleportWorker2 = new System.ComponentModel.BackgroundWorker();
            this.Plx = new System.Windows.Forms.Label();
            this.PlY = new System.Windows.Forms.Label();
            this.PlZ = new System.Windows.Forms.Label();
            this.setcoordWorker = new System.ComponentModel.BackgroundWorker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(10, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 27;
            this.label2.Text = "NAME";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(14, 52);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(513, 226);
            this.flowLayoutPanel1.TabIndex = 62;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(16)))));
            this.panel1.Controls.Add(this.checkBox5);
            this.panel1.Controls.Add(this.checkBox4);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.Ammoinf);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.god);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 220);
            this.panel1.TabIndex = 65;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.ForeColor = System.Drawing.Color.White;
            this.checkBox2.Location = new System.Drawing.Point(43, 7);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(71, 17);
            this.checkBox2.TabIndex = 65;
            this.checkBox2.Text = "Rapid Fire";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Ammoinf
            // 
            this.Ammoinf.AutoSize = true;
            this.Ammoinf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Ammoinf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ammoinf.ForeColor = System.Drawing.Color.White;
            this.Ammoinf.Location = new System.Drawing.Point(43, 76);
            this.Ammoinf.Name = "Ammoinf";
            this.Ammoinf.Size = new System.Drawing.Size(75, 17);
            this.Ammoinf.TabIndex = 59;
            this.Ammoinf.Text = "Infin Ammo";
            this.Ammoinf.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(43, 30);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 17);
            this.checkBox1.TabIndex = 58;
            this.checkBox1.Text = "Infin Money";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // god
            // 
            this.god.AutoSize = true;
            this.god.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.god.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.god.ForeColor = System.Drawing.Color.White;
            this.god.Location = new System.Drawing.Point(43, 53);
            this.god.Name = "god";
            this.god.Size = new System.Drawing.Size(69, 17);
            this.god.TabIndex = 66;
            this.god.Text = "Godmode";
            this.god.UseVisualStyleBackColor = true;
            this.god.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(16)))));
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(174, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(165, 220);
            this.panel3.TabIndex = 67;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(16)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "AK74u",
            "MP5",
            "Chicom CQB",
            "M14",
            "Colt M16A1",
            "SMR",
            "M8A1",
            "Type 25",
            "MTAR",
            "Remington",
            "Olympia",
            "S12",
            "M1216",
            "Galil",
            "FAL",
            "RPD",
            "HAMR",
            "DSR 50",
            "Barret M82A1",
            "M1911",
            "Python",
            "Executioner",
            "KAPR",
            "Fiveseven",
            "RPG",
            "War Machine",
            "Ballistic Knife",
            "RayGun"});
            this.comboBox1.Location = new System.Drawing.Point(24, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 63;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(25, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 64;
            this.button1.Text = "Give Weapon";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(16)))));
            this.panel4.Controls.Add(this.textBox3);
            this.panel4.Controls.Add(this.textBox2);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.PlZ);
            this.panel4.Controls.Add(this.PlY);
            this.panel4.Controls.Add(this.Plx);
            this.panel4.Location = new System.Drawing.Point(345, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(165, 220);
            this.panel4.TabIndex = 66;
            // 
            // GR
            // 
            this.GR.AutoSize = true;
            this.GR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GR.ForeColor = System.Drawing.Color.White;
            this.GR.Location = new System.Drawing.Point(14, 303);
            this.GR.Name = "GR";
            this.GR.Size = new System.Drawing.Size(45, 16);
            this.GR.TabIndex = 61;
            this.GR.Text = "label3";
            // 
            // expiry
            // 
            this.expiry.AutoSize = true;
            this.expiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiry.ForeColor = System.Drawing.Color.White;
            this.expiry.Location = new System.Drawing.Point(14, 319);
            this.expiry.Name = "expiry";
            this.expiry.Size = new System.Drawing.Size(45, 16);
            this.expiry.TabIndex = 60;
            this.expiry.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(19, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 58;
            this.label3.Text = "COMET.WTF";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(-8, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(615, 48);
            this.panel2.TabIndex = 59;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(508, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 22);
            this.button2.TabIndex = 63;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BGWorker
            // 
            this.BGWorker.WorkerReportsProgress = true;
            this.BGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWorker_DoWork_1);
            this.BGWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BGWorker_ProgressChanged_1);
            this.BGWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGWorker_RunWorkerCompleted_1);
            // 
            // OneShot
            // 
            this.OneShot.DoWork += new System.ComponentModel.DoWorkEventHandler(this.OneShot_DoWork);
            // 
            // positionworker
            // 
            this.positionworker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.positionworker_DoWork);
            // 
            // TeleportWorker
            // 
            this.TeleportWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.TeleportWorker_DoWork);
            // 
            // TeleportWorker2
            // 
            this.TeleportWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.TeleportWorker2_DoWork);
            // 
            // Plx
            // 
            this.Plx.AutoSize = true;
            this.Plx.ForeColor = System.Drawing.Color.White;
            this.Plx.Location = new System.Drawing.Point(15, 14);
            this.Plx.Name = "Plx";
            this.Plx.Size = new System.Drawing.Size(35, 13);
            this.Plx.TabIndex = 0;
            this.Plx.Text = "label4";
            // 
            // PlY
            // 
            this.PlY.AutoSize = true;
            this.PlY.ForeColor = System.Drawing.Color.White;
            this.PlY.Location = new System.Drawing.Point(15, 29);
            this.PlY.Name = "PlY";
            this.PlY.Size = new System.Drawing.Size(35, 13);
            this.PlY.TabIndex = 1;
            this.PlY.Text = "label4";
            // 
            // PlZ
            // 
            this.PlZ.AutoSize = true;
            this.PlZ.ForeColor = System.Drawing.Color.White;
            this.PlZ.Location = new System.Drawing.Point(15, 45);
            this.PlZ.Name = "PlZ";
            this.PlZ.Size = new System.Drawing.Size(35, 13);
            this.PlZ.TabIndex = 2;
            this.PlZ.Text = "label4";
            // 
            // setcoordWorker
            // 
            this.setcoordWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.setcoordWorker_DoWork);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Pos X";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(18, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Pos Y";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(18, 113);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "Pos Z";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox3.ForeColor = System.Drawing.Color.White;
            this.checkBox3.Location = new System.Drawing.Point(43, 99);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(105, 17);
            this.checkBox3.TabIndex = 67;
            this.checkBox3.Text = "Teleport Zombies";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged_1);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox4.ForeColor = System.Drawing.Color.White;
            this.checkBox4.Location = new System.Drawing.Point(43, 124);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(80, 17);
            this.checkBox4.TabIndex = 68;
            this.checkBox4.Text = "TP Zombies";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox5.ForeColor = System.Drawing.Color.White;
            this.checkBox5.Location = new System.Drawing.Point(43, 147);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(75, 17);
            this.checkBox5.TabIndex = 69;
            this.checkBox5.Text = "Set Coords";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(548, 344);
            this.Controls.Add(this.GR);
            this.Controls.Add(this.expiry);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "COMET.WTF";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.Main_Load);
            this.Shown += new System.EventHandler(this.Main_Shown_1);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private global::System.ComponentModel.IContainer components = null;


        // Token: 0x0400000A RID: 10
        private global::System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox Ammoinf;
        private System.Windows.Forms.Label GR;
        private System.Windows.Forms.Label expiry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.ComponentModel.BackgroundWorker BGWorker;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker OneShot;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox god;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.ComponentModel.BackgroundWorker positionworker;
        private System.ComponentModel.BackgroundWorker TeleportWorker;
        private System.ComponentModel.BackgroundWorker TeleportWorker2;
        private System.Windows.Forms.Label PlZ;
        private System.Windows.Forms.Label PlY;
        private System.Windows.Forms.Label Plx;
        private System.ComponentModel.BackgroundWorker setcoordWorker;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}