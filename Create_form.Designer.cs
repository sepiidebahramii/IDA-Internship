using System;
using System.Windows.Forms;

namespace INI
{
    partial class Create_form
    {
        public Form MasterConfig;
        public Form PinConfig;
        public Form SlaveConfig;
        
        #region
        public void InitializeComponent()
        {
            Program.MasterConfig_btn = new System.Windows.Forms.Button();
            Program.PinConfig_btn = new System.Windows.Forms.Button();
            Program.SlaveConfig_btn = new System.Windows.Forms.Button();
            Program.CreateINI_btn = new System.Windows.Forms.Button();

            this.SuspendLayout();
            // 
            // MasterConfig_btn
            // 
            Program.MasterConfig_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Program.MasterConfig_btn.Location = new System.Drawing.Point(113, 36);
            Program.MasterConfig_btn.Name = "MasterConfig_btn";
            Program.MasterConfig_btn.Size = new System.Drawing.Size(210, 90);
            Program.MasterConfig_btn.Text = "Master Config";
            Program.MasterConfig_btn.UseVisualStyleBackColor = true;
            Program.MasterConfig_btn.Click += new System.EventHandler(this.buttonMasterConfig_Click);
            // 
            // PinConfig_btn
            // 
            Program.PinConfig_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Program.PinConfig_btn.Location = new System.Drawing.Point(113, 132);
            Program.PinConfig_btn.Name = "PinConfig_btn";
            Program.PinConfig_btn.Size = new System.Drawing.Size(210, 90);
            Program.PinConfig_btn.Text = "Pin Config";
            Program.PinConfig_btn.UseVisualStyleBackColor = true;
            Program.PinConfig_btn.Click += new System.EventHandler(this.buttonPinConfig_Click);
            // 
            // SlaveConfig_btn
            // 
            Program.SlaveConfig_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Program.SlaveConfig_btn.Location = new System.Drawing.Point(113, 228);
            Program.SlaveConfig_btn.Name = "SlaveConfig_btn";
            Program.SlaveConfig_btn.Size = new System.Drawing.Size(210, 90);
            Program.SlaveConfig_btn.Text = "Slave Config";
            Program.SlaveConfig_btn.UseVisualStyleBackColor = true;
            Program.SlaveConfig_btn.Click += new System.EventHandler(this.buttonSlaveConfig_Click);
            // 
            // CreateINI_btn
            // 
            Program.CreateINI_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Program.CreateINI_btn.Location = new System.Drawing.Point(607, 395);
            Program.CreateINI_btn.Name = "CreateINI_btn";
            Program.CreateINI_btn.Size = new System.Drawing.Size(181, 43);
            Program.CreateINI_btn.Text = "Create INI";
            Program.CreateINI_btn.UseVisualStyleBackColor = true;
            Program.CreateINI_btn.Click += new System.EventHandler(this.buttonCreateINI_Click);
            // 
            // Create_form
            // 
            Program.PinConfig_btn.Enabled = false;
            Program.SlaveConfig_btn.Enabled = false;
            Program.CreateINI_btn.Enabled = false;

            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(Program.MasterConfig_btn);
            this.Controls.Add(Program.PinConfig_btn);
            this.Controls.Add(Program.SlaveConfig_btn);
            this.Controls.Add(Program.CreateINI_btn);
            this.Name = "Create_form";
            this.Text = "Create New INI";
            this.ResumeLayout(false);
        }
        public void buttonMasterConfig_Click(object sender, EventArgs e)
        {
             if (MasterConfig == null)
                 MasterConfig = new Master("c");
             Hide();
             MasterConfig.Show();
        }
        public void buttonPinConfig_Click(object sender, EventArgs e)
        {
             if (PinConfig == null)
                 PinConfig = new Pin("c");
             Hide();
             PinConfig.Show();
        }
        public void buttonSlaveConfig_Click(object sender, EventArgs e)
        {
             string s = (sender as Button).Name;
             if (SlaveConfig == null)
                 SlaveConfig = new Slave("c", s);
             Hide();
             SlaveConfig.Show();
        }
        public void buttonCreateINI_Click(object sender, EventArgs e)
        {
            var output_INI = new Create_INI("C:\\Users\\Sepide\\source\\repos\\INI\\bin\\Debug\\output.ini");

            // writing master informations
            output_INI.Write("sample_period_s", Program.M.Get_sample_period_s(), "MasterConfig");
            output_INI.Write("master_port", Program.M.Get_master_port(), "MasterConfig");
            output_INI.Write("master_addr", Program.M.Get_master_addr(), "MasterConfig");
            output_INI.Write("clients_num", Program.M.Get_clients_num(), "MasterConfig");
            output_INI.Write("debug_mode", Program.M.Get_debug_mode(), "MasterConfig");
            output_INI.Write("debug_mode2", Program.M.Get_debug_mode2(), "MasterConfig");
            output_INI.Write("no_watchdog", Program.M.Get_no_watchdog(), "MasterConfig");
            output_INI.Write("database_utime", Program.M.Get_database_utime(), "MasterConfig");
            output_INI.Write("request_delay", Program.M.Get_request_delay(), "MasterConfig");
            output_INI.Write("db_delay", Program.M.Get_db_delay(), "MasterConfig");

            // writing pin informations
            output_INI.Write("model", Program.P.Get_model(), "PinConfig");
            output_INI.Write("pin1", Program.P.Get_pin1(), "PinConfig");
            output_INI.Write("pin2", Program.P.Get_pin2(), "PinConfig");
            output_INI.Write("pin3", Program.P.Get_pin3(), "PinConfig");
            output_INI.Write("pin4", Program.P.Get_pin4(), "PinConfig");
            output_INI.Write("pin5", Program.P.Get_pin5(), "PinConfig");
            output_INI.Write("pin6", Program.P.Get_pin6(), "PinConfig");
            output_INI.Write("rel1", Program.P.Get_rel1(), "PinConfig");
            output_INI.Write("rel2", Program.P.Get_rel2(), "PinConfig");

            // writing slave informations
            for (int i = 0; i < Program.slaves.Count; i++)
            {
                string slave_num = Program.slaves[i].Get_slave_num();
                string slave_number = "slave" + slave_num;

                output_INI.Write("enable", Program.slaves[i].Get_enable(), slave_number);
                output_INI.Write("port", Program.slaves[i].Get_port(), slave_number);
                output_INI.Write("baud", Program.slaves[i].Get_baud(), slave_number);
                output_INI.Write("bytes", Program.slaves[i].Get_bytes(), slave_number);
                output_INI.Write("parity", Program.slaves[i].Get_parity(), slave_number);
                output_INI.Write("stopbit", Program.slaves[i].Get_stopbit(), slave_number);
                output_INI.Write("slave_id", Program.slaves[i].Get_slave_id(), slave_number);
                output_INI.Write("hreg_start", Program.slaves[i].Get_hreg_start(), slave_number);
                output_INI.Write("hreg_stop", Program.slaves[i].Get_hreg_stop(), slave_number);
                output_INI.Write("ireg_start", Program.slaves[i].Get_ireg_start(), slave_number);
                output_INI.Write("ireg_stop", Program.slaves[i].Get_ireg_stop(), slave_number);
                output_INI.Write("sreg_start", Program.slaves[i].Get_sreg_start(), slave_number);
                output_INI.Write("sreg_stop", Program.slaves[i].Get_sreg_stop(), slave_number);
                output_INI.Write("creg_start", Program.slaves[i].Get_creg_start(), slave_number);
                output_INI.Write("creg_stop", Program.slaves[i].Get_creg_stop(), slave_number);
                output_INI.Write("get_hreg", Program.slaves[i].Get_get_hreg(), slave_number);
                output_INI.Write("get_ireg", Program.slaves[i].Get_get_ireg(), slave_number);
                output_INI.Write("get_creg", Program.slaves[i].Get_get_creg(), slave_number);
                output_INI.Write("get_sreg", Program.slaves[i].Get_get_sreg(), slave_number);
            }

            if (System.Windows.Forms.Application.MessageLoop)
                System.Windows.Forms.Application.Exit();
            this.Close();
        }
        #endregion
    }
}