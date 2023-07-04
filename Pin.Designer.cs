using System;
using System.Windows.Forms;

namespace INI
{
    internal partial class Pin
    {
        public string Mod;

        public Button confirm_btn;

        public Label model_lbl;
        public Label pin1_lbl;
        public Label pin2_lbl;
        public Label pin3_lbl;
        public Label pin4_lbl;
        public Label pin5_lbl;
        public Label pin6_lbl;
        public Label rel1_lbl;
        public Label rel2_lbl;

        public TextBox model_txt;
        public TextBox pin1_txt;
        public TextBox pin2_txt;
        public TextBox pin3_txt;
        public TextBox pin4_txt;
        public TextBox pin5_txt;
        public TextBox pin6_txt;
        public TextBox rel1_txt;
        public TextBox rel2_txt;

        public Form create_f;
        public Form modify_f;

        #region
        private void InitializeComponent()
        {
            this.confirm_btn = new System.Windows.Forms.Button();
            this.model_lbl = new System.Windows.Forms.Label();
            this.pin1_lbl = new System.Windows.Forms.Label();
            this.pin2_lbl = new System.Windows.Forms.Label();
            this.pin3_lbl = new System.Windows.Forms.Label();
            this.pin4_lbl = new System.Windows.Forms.Label();
            this.pin5_lbl = new System.Windows.Forms.Label();
            this.pin6_lbl = new System.Windows.Forms.Label();
            this.rel1_lbl = new System.Windows.Forms.Label();
            this.rel2_lbl = new System.Windows.Forms.Label();
            this.model_txt = new System.Windows.Forms.TextBox();
            this.pin1_txt = new System.Windows.Forms.TextBox();
            this.pin2_txt = new System.Windows.Forms.TextBox();
            this.pin3_txt = new System.Windows.Forms.TextBox();
            this.pin4_txt = new System.Windows.Forms.TextBox();
            this.pin5_txt = new System.Windows.Forms.TextBox();
            this.pin6_txt = new System.Windows.Forms.TextBox();
            this.rel1_txt = new System.Windows.Forms.TextBox();
            this.rel2_txt = new System.Windows.Forms.TextBox();
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
            this.confirm_btn.Click += new System.EventHandler(this.buttonPinConfirm_Click);
            // 
            // model_lbl
            // 
            this.model_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.model_lbl.Location = new System.Drawing.Point(37, 45);
            this.model_lbl.Name = "model_lbl";
            this.model_lbl.Size = new System.Drawing.Size(165, 40);
            this.model_lbl.Text = "model";
            this.model_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pin1_lbl
            // 
            this.pin1_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pin1_lbl.Location = new System.Drawing.Point(37, 105);
            this.pin1_lbl.Name = "pin1_lbl";
            this.pin1_lbl.Size = new System.Drawing.Size(165, 40);
            this.pin1_lbl.Text = "pin1";
            this.pin1_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pin2_lbl
            // 
            this.pin2_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pin2_lbl.Location = new System.Drawing.Point(37, 165);
            this.pin2_lbl.Name = "pin2_lbl";
            this.pin2_lbl.Size = new System.Drawing.Size(165, 40);
            this.pin2_lbl.Text = "pin2";
            this.pin2_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pin3_lbl
            // 
            this.pin3_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pin3_lbl.Location = new System.Drawing.Point(37, 225);
            this.pin3_lbl.Name = "pin3_lbl";
            this.pin3_lbl.Size = new System.Drawing.Size(165, 40);
            this.pin3_lbl.Text = "pin3";
            this.pin3_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pin4_lbl
            // 
            this.pin4_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pin4_lbl.Location = new System.Drawing.Point(37, 285);
            this.pin4_lbl.Name = "pin4_lbl";
            this.pin4_lbl.Size = new System.Drawing.Size(165, 40);
            this.pin4_lbl.Text = "pin4";
            this.pin4_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pin5_lbl
            // 
            this.pin5_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pin5_lbl.Location = new System.Drawing.Point(314, 45);
            this.pin5_lbl.Name = "pin5_lbl";
            this.pin5_lbl.Size = new System.Drawing.Size(165, 40);
            this.pin5_lbl.Text = "pin5";
            this.pin5_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pin6_lbl
            // 
            this.pin6_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pin6_lbl.Location = new System.Drawing.Point(314, 105);
            this.pin6_lbl.Name = "pin6_lbl";
            this.pin6_lbl.Size = new System.Drawing.Size(165, 40);
            this.pin6_lbl.Text = "pin6";
            this.pin6_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rel1_lbl
            // 
            this.rel1_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rel1_lbl.Location = new System.Drawing.Point(314, 165);
            this.rel1_lbl.Name = "rel1_lbl";
            this.rel1_lbl.Size = new System.Drawing.Size(165, 40);
            this.rel1_lbl.Text = "rel1";
            this.rel1_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rel2_lbl
            // 
            this.rel2_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rel2_lbl.Location = new System.Drawing.Point(314, 225);
            this.rel2_lbl.Name = "rel2_lbl";
            this.rel2_lbl.Size = new System.Drawing.Size(165, 40);

            this.rel2_lbl.Text = "rel2";
            this.rel2_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // model_txt
            // 
            this.model_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.model_txt.Location = new System.Drawing.Point(208, 57);
            this.model_txt.Name = "model_txt";
            this.model_txt.Size = new System.Drawing.Size(100, 26);
            this.pin1_txt.TabIndex = 0;
            // 
            // pin1_txt
            // 
            this.pin1_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pin1_txt.Location = new System.Drawing.Point(208, 117);
            this.pin1_txt.Name = "pin1_txt";
            this.pin1_txt.Size = new System.Drawing.Size(100, 26);
            this.pin1_txt.TabIndex = 1;
            // 
            // pin2_txt
            // 
            this.pin2_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pin2_txt.Location = new System.Drawing.Point(208, 177);
            this.pin2_txt.Name = "pin2_txt";
            this.pin2_txt.Size = new System.Drawing.Size(100, 26);
            this.pin2_txt.TabIndex = 2;
            // 
            // pin3_txt
            // 
            this.pin3_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pin3_txt.Location = new System.Drawing.Point(208, 237);
            this.pin3_txt.Name = "pin3_txt";
            this.pin3_txt.Size = new System.Drawing.Size(100, 26);
            this.pin3_txt.TabIndex = 3;
            // 
            // pin4_txt
            // 
            this.pin4_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pin4_txt.Location = new System.Drawing.Point(208, 296);
            this.pin4_txt.Name = "pin4_txt";
            this.pin4_txt.Size = new System.Drawing.Size(100, 26);
            this.pin4_txt.TabIndex = 4;
            // 
            // pin5_txt
            // 
            this.pin5_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pin5_txt.Location = new System.Drawing.Point(485, 57);
            this.pin5_txt.Name = "pin5_txt";
            this.pin5_txt.Size = new System.Drawing.Size(100, 26);
            this.pin5_txt.TabIndex = 5;
            // 
            // pin6_txt
            // 
            this.pin6_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pin6_txt.Location = new System.Drawing.Point(485, 117);
            this.pin6_txt.Name = "pin6_txt";
            this.pin6_txt.Size = new System.Drawing.Size(100, 26);
            this.pin6_txt.TabIndex = 6;
            // 
            // rel1_txt
            // 
            this.rel1_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rel1_txt.Location = new System.Drawing.Point(485, 177);
            this.rel1_txt.Name = "rel1_txt";
            this.rel1_txt.Size = new System.Drawing.Size(100, 26);
            this.rel1_txt.TabIndex = 7;
            // 
            // rel2_txt
            // 
            this.rel2_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rel2_txt.Location = new System.Drawing.Point(485, 237);
            this.rel2_txt.Name = "rel2_txt";
            this.rel2_txt.Size = new System.Drawing.Size(100, 26);
            this.rel2_txt.TabIndex = 8;
            //
            // reading from file
            //
            if (this.Mod == "m")
            {
                this.model_txt.Text = Program.F.Read("model", "pinConfig");
                this.pin1_txt.Text = Program.F.Read("pin1", "pinConfig");
                this.pin2_txt.Text = Program.F.Read("pin2", "pinConfig");
                this.pin3_txt.Text = Program.F.Read("pin3", "pinConfig");
                this.pin4_txt.Text = Program.F.Read("pin4", "pinConfig");
                this.pin5_txt.Text = Program.F.Read("pin5", "pinConfig");
                this.pin6_txt.Text = Program.F.Read("pin6", "pinConfig");
                this.rel1_txt.Text = Program.F.Read("rel1", "pinConfig");
                this.rel2_txt.Text = Program.F.Read("rel2", "pinConfig");
            }
            // 
            // Pin
            //
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.confirm_btn);
            this.Controls.Add(this.model_lbl);
            this.Controls.Add(this.pin1_lbl);
            this.Controls.Add(this.pin2_lbl);
            this.Controls.Add(this.pin3_lbl);
            this.Controls.Add(this.pin4_lbl);
            this.Controls.Add(this.pin5_lbl);
            this.Controls.Add(this.pin6_lbl);
            this.Controls.Add(this.rel1_lbl);
            this.Controls.Add(this.rel2_lbl);
            this.Controls.Add(this.model_txt);
            this.Controls.Add(this.pin1_txt);
            this.Controls.Add(this.pin2_txt);
            this.Controls.Add(this.pin3_txt);
            this.Controls.Add(this.pin4_txt);
            this.Controls.Add(this.pin5_txt);
            this.Controls.Add(this.pin6_txt);
            this.Controls.Add(this.rel1_txt);
            this.Controls.Add(this.rel2_txt);
            this.Name = "Pin";
            this.Text = "Pin Config Form";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private void buttonPinConfirm_Click(object sender, EventArgs e)
        {
            string v1 = Convert.ToString(model_txt.Text);
            string v2 = Convert.ToString(pin1_txt.Text);
            string v3 = Convert.ToString(pin2_txt.Text);
            string v4 = Convert.ToString(pin3_txt.Text);
            string v5 = Convert.ToString(pin4_txt.Text);
            string v6 = Convert.ToString(pin5_txt.Text);
            string v7 = Convert.ToString(pin6_txt.Text);
            string v8 = Convert.ToString(rel1_txt.Text);
            string v9 = Convert.ToString(rel2_txt.Text);

            Pin_object pin_obj = new Pin_object(v1, v2, v3, v4, v5, v6, v7, v8, v9);
            Program.P = pin_obj;

            if (create_f == null && this.Mod == "c")
            {
                create_f = new Create_form();
                create_f.Show();
                Program.MasterConfig_btn.Enabled = false;
                Program.PinConfig_btn.Enabled = false;
                Program.SlaveConfig_btn.Enabled = true;
                Program.CreateINI_btn.Enabled = false;
                Hide();
            }
            if (modify_f == null && this.Mod == "m")
            {
                modify_f = new Modify_form();
                modify_f.Show();
                Program.MasterConfig_btn.Enabled = false;
                Program.PinConfig_btn.Enabled = false;
                Program.SlaveConfig_btn.Enabled = true;
                Program.SaveINI_btn.Enabled = false;
                Hide();
            }
        }
        #endregion
    }
}