using System;
using System.Windows.Forms;

namespace INI
{
    partial class SlaveList
    {
        public Form SlaveConfig;
        public Form modify_f;

        public Label title_lbl;
        public Button confirm_btn;
        public FlowLayoutPanel Slave_List_scbar;
        public void InitializeComponent()
        {
            this.title_lbl = new System.Windows.Forms.Label();
            this.confirm_btn = new System.Windows.Forms.Button();
            //
            // title_txt
            //
            this.title_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.Text = "List of Slaves: ";
            this.title_lbl.Location = new System.Drawing.Point(84, 46);
            this.title_lbl.Size = new System.Drawing.Size(248, 55);
            // 
            // confirm_btn
            //  
            this.confirm_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_btn.Location = new System.Drawing.Point(607, 395);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(181, 43);
            this.confirm_btn.TabIndex = 0;
            this.confirm_btn.Text = "Confirm";
            this.confirm_btn.UseVisualStyleBackColor = true;
            this.confirm_btn.Click += new System.EventHandler(this.buttonSlaveConfirm_Click);
            //
            // Slave_List_scbar
            //
            this.Slave_List_scbar = new System.Windows.Forms.FlowLayoutPanel();
            this.Slave_List_scbar.Location = new System.Drawing.Point(100, 100);
            this.Slave_List_scbar.Size = new System.Drawing.Size(500, 300);
            this.Slave_List_scbar.AutoScroll = true;
            int len = Int32.Parse(Program.F.Read("clients_num", "MasterConfig"));
            for (int i = 0; i < len ; i++)
            {
                Button slave_btn = new Button();
                slave_btn.Text = "Slave " + (i + 1).ToString();
                slave_btn.Name = "slave"+ (i + 1).ToString();
                slave_btn.Size = new System.Drawing.Size(70, 60); ;
                slave_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
                slave_btn.UseVisualStyleBackColor = true;
                slave_btn.Click += new System.EventHandler(this.buttonSlave_Click);
                this.Slave_List_scbar.Controls.Add(slave_btn);
            }
            //
            // SlaveList
            //
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Slave_List_scbar);
            this.Controls.Add(this.title_lbl);
            this.Controls.Add(this.confirm_btn);
        }
        private void buttonSlaveConfirm_Click(object sender, EventArgs e)
        {
            if (modify_f == null)
                modify_f = new Modify_form();
            Hide();
            Program.MasterConfig_btn.Enabled = false;
            Program.PinConfig_btn.Enabled = false;
            Program.SlaveConfig_btn.Enabled = false;
            Program.SaveINI_btn.Enabled = true;
            modify_f.Show();
        }
        public void buttonSlave_Click(object sender, EventArgs e)
        {
            string s = (sender as Button).Name;
            if (SlaveConfig == null)
                SlaveConfig = new Slave("m", s);
            Hide();
            SlaveConfig.Show();
        }
    }
}