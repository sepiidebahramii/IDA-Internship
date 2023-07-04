using System;
using System.Windows.Forms;

namespace INI
{
    internal partial class Master
    {
        public string Mod;

        public Button confirm_btn;

        public Label sample_period_s_lbl;
        public Label master_port_lbl;
        public Label master_addr_lbl;
        public Label clients_num_lbl;
        public Label debug_mode_lbl;
        public Label debug_mode2_lbl;
        public Label no_watchdog_lbl;
        public Label database_utime_lbl;
        public Label refresh_reg_lbl;
        public Label request_delay_lbl;
        public Label db_delay_lbl;

        public TextBox sample_period_s_txt;
        public TextBox master_port_txt;
        public TextBox master_addr_txt;
        public TextBox clients_num_txt;
        public TextBox debug_mode_txt;
        public TextBox debug_mode2_txt;
        public TextBox no_watchdog_txt;
        public TextBox database_utime_txt;
        public TextBox refresh_reg_txt;
        public TextBox request_delay_txt;
        public TextBox db_delay_txt;

        public Form create_f;
        public Form modify_f;

        #region
        public void InitializeComponent()
        {
            this.confirm_btn = new System.Windows.Forms.Button();
            this.sample_period_s_lbl = new System.Windows.Forms.Label();
            this.master_port_lbl = new System.Windows.Forms.Label();
            this.master_addr_lbl = new System.Windows.Forms.Label();
            this.clients_num_lbl = new System.Windows.Forms.Label();
            this.debug_mode_lbl = new System.Windows.Forms.Label();
            this.debug_mode2_lbl = new System.Windows.Forms.Label();
            this.no_watchdog_lbl = new System.Windows.Forms.Label();
            this.database_utime_lbl = new System.Windows.Forms.Label();
            this.refresh_reg_lbl = new System.Windows.Forms.Label();
            this.request_delay_lbl = new System.Windows.Forms.Label();
            this.db_delay_lbl = new System.Windows.Forms.Label();
            this.sample_period_s_txt = new System.Windows.Forms.TextBox();
            this.master_port_txt = new System.Windows.Forms.TextBox();
            this.master_addr_txt = new System.Windows.Forms.TextBox();
            this.clients_num_txt = new System.Windows.Forms.TextBox();
            this.debug_mode_txt = new System.Windows.Forms.TextBox();
            this.debug_mode2_txt = new System.Windows.Forms.TextBox();
            this.no_watchdog_txt = new System.Windows.Forms.TextBox();
            this.database_utime_txt = new System.Windows.Forms.TextBox();
            this.refresh_reg_txt = new System.Windows.Forms.TextBox();
            this.request_delay_txt = new System.Windows.Forms.TextBox();
            this.db_delay_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // confirm_btn
            // 
            this.confirm_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_btn.Location = new System.Drawing.Point(607, 395);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(181, 43);
            this.confirm_btn.Text = "Confirm";
            this.confirm_btn.UseVisualStyleBackColor = true;
            this.confirm_btn.Click += new System.EventHandler(this.buttonMasterConfirm_Click);
            // 
            // sample_period_s_lbl
            // 
            this.sample_period_s_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sample_period_s_lbl.Location = new System.Drawing.Point(37, 45);
            this.sample_period_s_lbl.Name = "sample_period_s_lbl";
            this.sample_period_s_lbl.Size = new System.Drawing.Size(165, 40);
            this.sample_period_s_lbl.Text = "sample period s";
            this.sample_period_s_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // master_port_lbl
            // 
            this.master_port_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.master_port_lbl.Location = new System.Drawing.Point(37, 105);
            this.master_port_lbl.Name = "master_port_lbl";
            this.master_port_lbl.Size = new System.Drawing.Size(165, 40);
            this.master_port_lbl.Text = "master port";
            this.master_port_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // master_addr_lbl
            // 
            this.master_addr_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.master_addr_lbl.Location = new System.Drawing.Point(37, 165);
            this.master_addr_lbl.Name = "master_addr_lbl";
            this.master_addr_lbl.Size = new System.Drawing.Size(165, 40);
            this.master_addr_lbl.Text = "master address";
            this.master_addr_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // clients_num_lbl
            // 
            this.clients_num_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clients_num_lbl.Location = new System.Drawing.Point(37, 225);
            this.clients_num_lbl.Name = "clients_num_lbl";
            this.clients_num_lbl.Size = new System.Drawing.Size(165, 40);
            this.clients_num_lbl.Text = "clients number";
            this.clients_num_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // debug_mode_lbl
            // 
            this.debug_mode_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debug_mode_lbl.Location = new System.Drawing.Point(37, 285);
            this.debug_mode_lbl.Name = "debug_mode_lbl";
            this.debug_mode_lbl.Size = new System.Drawing.Size(165, 40);
            this.debug_mode_lbl.Text = "debug mode";
            this.debug_mode_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // debug_mode2_lbl
            // 
            this.debug_mode2_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debug_mode2_lbl.Location = new System.Drawing.Point(37, 347);
            this.debug_mode2_lbl.Name = "debug_mode2_lbl";
            this.debug_mode2_lbl.Size = new System.Drawing.Size(165, 40);
            this.debug_mode2_lbl.Text = "debug mode2";
            this.debug_mode2_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // no_watchdog_lbl
            // 
            this.no_watchdog_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_watchdog_lbl.Location = new System.Drawing.Point(314, 45);
            this.no_watchdog_lbl.Name = "no_watchdog_lbl";
            this.no_watchdog_lbl.Size = new System.Drawing.Size(165, 40);
            this.no_watchdog_lbl.Text = "no watchdog";
            this.no_watchdog_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // database_utime_lbl
            // 
            this.database_utime_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.database_utime_lbl.Location = new System.Drawing.Point(314, 105);
            this.database_utime_lbl.Name = "database_utime_lbl";
            this.database_utime_lbl.Size = new System.Drawing.Size(165, 40);
            this.database_utime_lbl.Text = "database utime";
            this.database_utime_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // refresh_reg_lbl
            // 
            this.refresh_reg_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_reg_lbl.Location = new System.Drawing.Point(314, 165);
            this.refresh_reg_lbl.Name = "refresh_reg_lbl";
            this.refresh_reg_lbl.Size = new System.Drawing.Size(165, 40);
            this.refresh_reg_lbl.Text = "refresh reg";
            this.refresh_reg_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // request_delay_lbl
            // 
            this.request_delay_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.request_delay_lbl.Location = new System.Drawing.Point(314, 225);
            this.request_delay_lbl.Name = "request_delay_lbl";
            this.request_delay_lbl.Size = new System.Drawing.Size(165, 40);
            this.request_delay_lbl.Text = "request delay";
            this.request_delay_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // db_delay_lbl
            // 
            this.db_delay_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db_delay_lbl.Location = new System.Drawing.Point(314, 285);
            this.db_delay_lbl.Name = "db_delay_lbl";
            this.db_delay_lbl.Size = new System.Drawing.Size(165, 40);
            this.db_delay_lbl.Text = "db delay";
            this.db_delay_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sample_period_s_txt
            // 
            this.sample_period_s_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sample_period_s_txt.Location = new System.Drawing.Point(208, 57);
            this.sample_period_s_txt.Name = "sample_period_s_txt";
            this.sample_period_s_txt.Size = new System.Drawing.Size(100, 26);
            this.sample_period_s_txt.TabIndex = 0;
            // 
            // master_port_txt
            // 
            this.master_port_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.master_port_txt.Location = new System.Drawing.Point(208, 117);
            this.master_port_txt.Name = "master_port_txt";
            this.master_port_txt.Size = new System.Drawing.Size(100, 26);
            this.master_port_txt.TabIndex = 1;
            // 
            // master_addr_txt
            // 
            this.master_addr_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.master_addr_txt.Location = new System.Drawing.Point(208, 177);
            this.master_addr_txt.Name = "master_addr_txt";
            this.master_addr_txt.Size = new System.Drawing.Size(100, 26);
            this.master_addr_txt.TabIndex = 2;
            // 
            // clients_num_txt
            // 
            this.clients_num_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clients_num_txt.Location = new System.Drawing.Point(208, 237);
            this.clients_num_txt.Name = "clients_num_txt";
            this.clients_num_txt.Size = new System.Drawing.Size(100, 26);
            this.clients_num_txt.TabIndex = 3;
            // 
            // debug_mode_txt
            // 
            this.debug_mode_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debug_mode_txt.Location = new System.Drawing.Point(208, 297);
            this.debug_mode_txt.Name = "debug_mode_txt";
            this.debug_mode_txt.Size = new System.Drawing.Size(100, 26);
            this.debug_mode_txt.TabIndex = 4;
            // 
            // debug_mode2_txt
            // 
            this.debug_mode2_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debug_mode2_txt.Location = new System.Drawing.Point(208, 359);
            this.debug_mode2_txt.Name = "debug_mode2_txt";
            this.debug_mode2_txt.Size = new System.Drawing.Size(100, 26);
            this.debug_mode2_txt.TabIndex = 5;
            // 
            // no_watchdog_txt
            // 
            this.no_watchdog_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_watchdog_txt.Location = new System.Drawing.Point(485, 57);
            this.no_watchdog_txt.Name = "no_watchdog_txt";
            this.no_watchdog_txt.Size = new System.Drawing.Size(100, 26);
            this.no_watchdog_txt.TabIndex = 6;
            // 
            // database_utime_txt
            // 
            this.database_utime_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.database_utime_txt.Location = new System.Drawing.Point(485, 117);
            this.database_utime_txt.Name = "database_utime_txt";
            this.database_utime_txt.Size = new System.Drawing.Size(100, 26);
            this.database_utime_txt.TabIndex = 7;
            // 
            // refresh_reg_txt
            // 
            this.refresh_reg_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_reg_txt.Location = new System.Drawing.Point(485, 177);
            this.refresh_reg_txt.Name = "refresh_reg_txt";
            this.refresh_reg_txt.Size = new System.Drawing.Size(100, 26);
            this.refresh_reg_txt.TabIndex = 8;
            // 
            // request_delay_txt
            // 
            this.request_delay_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.request_delay_txt.Location = new System.Drawing.Point(485, 237);
            this.request_delay_txt.Name = "request_delay_txt";
            this.request_delay_txt.Size = new System.Drawing.Size(100, 26);
            this.request_delay_txt.TabIndex = 9;
            // 
            // db_delay_txt
            // 
            this.db_delay_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db_delay_txt.Location = new System.Drawing.Point(485, 297);
            this.db_delay_txt.Name = "db_delay_txt";
            this.db_delay_txt.Size = new System.Drawing.Size(100, 26);
            this.db_delay_txt.TabIndex = 10;
            //
            // reading from file
            //
            if (this.Mod == "m")
            {
                this.sample_period_s_txt.Text = Program.F.Read("sample_period_s", "MasterConfig");
                this.sample_period_s_txt.Text = Program.F.Read("sample_period_s", "MasterConfig");
                this.master_port_txt.Text = Program.F.Read("master_port", "MasterConfig");
                this.master_addr_txt.Text = Program.F.Read("master_addr", "MasterConfig");
                this.clients_num_txt.Text = Program.F.Read("clients_num", "MasterConfig");
                this.debug_mode_txt.Text = Program.F.Read("debug_mode", "MasterConfig");
                this.debug_mode2_txt.Text = Program.F.Read("debug_mode2", "MasterConfig");
                this.no_watchdog_txt.Text = Program.F.Read("no_watchdog", "MasterConfig");
                this.database_utime_txt.Text = Program.F.Read("database_utime", "MasterConfig");
                this.refresh_reg_txt.Text = Program.F.Read("refresh_reg", "MasterConfig");
                this.request_delay_txt.Text = Program.F.Read("request_delay", "MasterConfig");
                this.db_delay_txt.Text = Program.F.Read("db_delay", "MasterConfig");
            }
            // 
            // Master
            // 
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.confirm_btn);
            this.Controls.Add(this.sample_period_s_lbl);
            this.Controls.Add(this.master_port_lbl);
            this.Controls.Add(this.master_addr_lbl);
            this.Controls.Add(this.clients_num_lbl);
            this.Controls.Add(this.debug_mode_lbl);
            this.Controls.Add(this.debug_mode2_lbl);
            this.Controls.Add(this.no_watchdog_lbl);
            this.Controls.Add(this.database_utime_lbl);
            this.Controls.Add(this.refresh_reg_lbl);
            this.Controls.Add(this.request_delay_lbl);
            this.Controls.Add(this.db_delay_lbl);
            this.Controls.Add(this.sample_period_s_txt);
            this.Controls.Add(this.master_port_txt);
            this.Controls.Add(this.master_addr_txt);
            this.Controls.Add(this.clients_num_txt);
            this.Controls.Add(this.debug_mode_txt);
            this.Controls.Add(this.debug_mode2_txt);
            this.Controls.Add(this.no_watchdog_txt);
            this.Controls.Add(this.database_utime_txt);
            this.Controls.Add(this.refresh_reg_txt);
            this.Controls.Add(this.request_delay_txt);
            this.Controls.Add(this.db_delay_txt);
            this.Name = "Master";
            this.Text = "Master Config Form";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        public void buttonMasterConfirm_Click(object sender, EventArgs e)
        {
            string v1 = Convert.ToString(sample_period_s_txt.Text);
            string v2 = Convert.ToString(master_port_txt.Text);
            string v3 = Convert.ToString(master_addr_txt.Text);
            string v4 = Convert.ToString(clients_num_txt.Text);
            string v5 = Convert.ToString(debug_mode_txt.Text);
            string v6 = Convert.ToString(debug_mode2_txt.Text);
            string v7 = Convert.ToString(no_watchdog_txt.Text);
            string v8 = Convert.ToString(database_utime_txt.Text);
            string v9 = Convert.ToString(refresh_reg_txt.Text);
            string v10 = Convert.ToString(request_delay_txt.Text);
            string v11 = Convert.ToString(db_delay_txt.Text);

            if (string.IsNullOrEmpty(clients_num_txt.Text))
            {
                MessageBox.Show("Please enter clients num first!");
            }
            else
            {
                Master_object mas_obj = new Master_object(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11);
                Program.M = mas_obj;

                if (create_f == null && this.Mod == "c")
                {
                    create_f = new Create_form();
                    create_f.Show();
                    Program.MasterConfig_btn.Enabled = false;
                    Program.PinConfig_btn.Enabled = true;
                    Program.SlaveConfig_btn.Enabled = false;
                    Program.CreateINI_btn.Enabled = false;
                    Hide();
                }
                if (modify_f == null && this.Mod == "m")
                {
                    modify_f = new Modify_form();
                    modify_f.Show();
                    Program.MasterConfig_btn.Enabled = false;
                    Program.PinConfig_btn.Enabled = true;
                    Program.SlaveConfig_btn.Enabled = false;
                    Program.SaveINI_btn.Enabled = false;
                    Hide();
                }

            }
        }
        #endregion
    }
}