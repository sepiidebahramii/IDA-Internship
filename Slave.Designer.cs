using System;
using System.Windows.Forms;

namespace INI
{
    internal partial class Slave
    {
        public string section_name;
        public string Mod;

        public Button confirm_btn;

        public Label slave_num_lbl;
        public Label enable_lbl;
        public Label port_lbl;
        public Label baud_lbl;
        public Label bytes_lbl;
        public Label parity_lbl;
        public Label stopbit_lbl;
        public Label slave_id_lbl;
        public Label hreg_start_lbl;
        public Label hreg_stop_lbl;
        public Label ireg_start_lbl;
        public Label ireg_stop_lbl;
        public Label sreg_start_lbl;
        public Label sreg_stop_lbl;
        public Label creg_start_lbl;
        public Label creg_stop_lbl;
        public Label get_hreg_lbl;
        public Label get_ireg_lbl;
        public Label get_creg_lbl;
        public Label get_sreg_lbl;

        public TextBox slave_num_txt;
        public TextBox enable_txt;
        public TextBox port_txt;
        public TextBox baud_txt;
        public TextBox bytes_txt;
        public TextBox parity_txt;
        public TextBox stopbit_txt;
        public TextBox slave_id_txt;
        public TextBox hreg_start_txt;
        public TextBox hreg_stop_txt;
        public TextBox ireg_start_txt;
        public TextBox ireg_stop_txt;
        public TextBox sreg_start_txt;
        public TextBox sreg_stop_txt;
        public TextBox creg_start_txt;
        public TextBox creg_stop_txt;
        public TextBox get_hreg_txt;
        public TextBox get_ireg_txt;
        public TextBox get_creg_txt;
        public TextBox get_sreg_txt;

        public Form create_f;
        public Form SlaveL;

        #region
        private void InitializeComponent()
        {
            this.confirm_btn = new System.Windows.Forms.Button();
            this.slave_num_lbl = new System.Windows.Forms.Label();
            this.enable_lbl = new System.Windows.Forms.Label();
            this.port_lbl = new System.Windows.Forms.Label();
            this.baud_lbl = new System.Windows.Forms.Label();
            this.bytes_lbl = new System.Windows.Forms.Label();
            this.parity_lbl = new System.Windows.Forms.Label();
            this.stopbit_lbl = new System.Windows.Forms.Label();
            this.slave_id_lbl = new System.Windows.Forms.Label();
            this.hreg_start_lbl = new System.Windows.Forms.Label();
            this.hreg_stop_lbl = new System.Windows.Forms.Label();
            this.ireg_start_lbl = new System.Windows.Forms.Label();
            this.ireg_stop_lbl = new System.Windows.Forms.Label();
            this.sreg_start_lbl = new System.Windows.Forms.Label();
            this.sreg_stop_lbl = new System.Windows.Forms.Label();
            this.creg_start_lbl = new System.Windows.Forms.Label();
            this.creg_stop_lbl = new System.Windows.Forms.Label();
            this.get_hreg_lbl = new System.Windows.Forms.Label();
            this.get_ireg_lbl = new System.Windows.Forms.Label();
            this.get_creg_lbl = new System.Windows.Forms.Label();
            this.get_sreg_lbl = new System.Windows.Forms.Label();
            this.slave_num_txt = new System.Windows.Forms.TextBox();
            this.enable_txt = new System.Windows.Forms.TextBox();
            this.port_txt = new System.Windows.Forms.TextBox();
            this.baud_txt = new System.Windows.Forms.TextBox();
            this.bytes_txt = new System.Windows.Forms.TextBox();
            this.parity_txt = new System.Windows.Forms.TextBox();
            this.stopbit_txt = new System.Windows.Forms.TextBox();
            this.slave_id_txt = new System.Windows.Forms.TextBox();
            this.hreg_start_txt = new System.Windows.Forms.TextBox();
            this.hreg_stop_txt = new System.Windows.Forms.TextBox();
            this.ireg_start_txt = new System.Windows.Forms.TextBox();
            this.ireg_stop_txt = new System.Windows.Forms.TextBox();
            this.sreg_start_txt = new System.Windows.Forms.TextBox();
            this.sreg_stop_txt = new System.Windows.Forms.TextBox();
            this.creg_start_txt = new System.Windows.Forms.TextBox();
            this.creg_stop_txt = new System.Windows.Forms.TextBox();
            this.get_hreg_txt = new System.Windows.Forms.TextBox();
            this.get_ireg_txt = new System.Windows.Forms.TextBox();
            this.get_creg_txt = new System.Windows.Forms.TextBox();
            this.get_sreg_txt = new System.Windows.Forms.TextBox();
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
            this.confirm_btn.Click += new System.EventHandler(this.buttonSlaveConfirm_Click);
            // 
            // slave_num_lbl
            // 
            this.slave_num_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slave_num_lbl.Location = new System.Drawing.Point(-68, 19);
            this.slave_num_lbl.Name = "slave_num_lbl";
            this.slave_num_lbl.Size = new System.Drawing.Size(165, 40);
            this.slave_num_lbl.Text = "slave num";
            this.slave_num_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // enable_lbl
            // 
            this.enable_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enable_lbl.Location = new System.Drawing.Point(-68, 79);
            this.enable_lbl.Name = "enable_lbl";
            this.enable_lbl.Size = new System.Drawing.Size(165, 40);
            this.enable_lbl.Text = "enable";
            this.enable_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // port_lbl
            // 
            this.port_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.port_lbl.Location = new System.Drawing.Point(-68, 139);
            this.port_lbl.Name = "port_lbl";
            this.port_lbl.Size = new System.Drawing.Size(165, 40);
            this.port_lbl.Text = "port";
            this.port_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // baud_lbl
            // 
            this.baud_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baud_lbl.Location = new System.Drawing.Point(-68, 199);
            this.baud_lbl.Name = "baud_lbl";
            this.baud_lbl.Size = new System.Drawing.Size(165, 40);
            this.baud_lbl.Text = "baud";
            this.baud_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bytes_lbl
            // 
            this.bytes_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bytes_lbl.Location = new System.Drawing.Point(-68, 259);
            this.bytes_lbl.Name = "bytes_lbl";
            this.bytes_lbl.Size = new System.Drawing.Size(165, 40);
            this.bytes_lbl.Text = "bytes";
            this.bytes_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // parity_lbl
            // 
            this.parity_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parity_lbl.Location = new System.Drawing.Point(-68, 319);
            this.parity_lbl.Name = "parity_lbl";
            this.parity_lbl.Size = new System.Drawing.Size(165, 40);
            this.parity_lbl.Text = "parity";
            this.parity_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // stopbit_lbl
            // 
            this.stopbit_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopbit_lbl.Location = new System.Drawing.Point(-68, 379);
            this.stopbit_lbl.Name = "stopbit_lbl";
            this.stopbit_lbl.Size = new System.Drawing.Size(165, 40);
            this.stopbit_lbl.Text = "stopbit";
            this.stopbit_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // slave_id_lbl
            // 
            this.slave_id_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slave_id_lbl.Location = new System.Drawing.Point(209, 19);
            this.slave_id_lbl.Name = "slave_id_lbl";
            this.slave_id_lbl.Size = new System.Drawing.Size(165, 40);
            this.slave_id_lbl.Text = "slave id";
            this.slave_id_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hreg_start_lbl
            // 
            this.hreg_start_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hreg_start_lbl.Location = new System.Drawing.Point(209, 79);
            this.hreg_start_lbl.Name = "hreg_start_lbl";
            this.hreg_start_lbl.Size = new System.Drawing.Size(165, 40);
            this.hreg_start_lbl.Text = "hreg start";
            this.hreg_start_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hreg_stop_lbl
            // 
            this.hreg_stop_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hreg_stop_lbl.Location = new System.Drawing.Point(209, 139);
            this.hreg_stop_lbl.Name = "hreg_stop_lbl";
            this.hreg_stop_lbl.Size = new System.Drawing.Size(165, 40);
            this.hreg_stop_lbl.Text = "hreg stop";
            this.hreg_stop_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ireg_start_lbl
            // 
            this.ireg_start_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ireg_start_lbl.Location = new System.Drawing.Point(209, 199);
            this.ireg_start_lbl.Name = "ireg_start_lbl";
            this.ireg_start_lbl.Size = new System.Drawing.Size(165, 40);
            this.ireg_start_lbl.Text = "ireg start";
            this.ireg_start_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ireg_stop_lbl
            // 
            this.ireg_stop_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ireg_stop_lbl.Location = new System.Drawing.Point(209, 259);
            this.ireg_stop_lbl.Name = "ireg_stop_lbl";
            this.ireg_stop_lbl.Size = new System.Drawing.Size(165, 40);
            this.ireg_stop_lbl.Text = "ireg stop";
            this.ireg_stop_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sreg_start_lbl
            // 
            this.sreg_start_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sreg_start_lbl.Location = new System.Drawing.Point(209, 319);
            this.sreg_start_lbl.Name = "sreg_start_lbl";
            this.sreg_start_lbl.Size = new System.Drawing.Size(165, 40);
            this.sreg_start_lbl.Text = "sreg start";
            this.sreg_start_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sreg_stop_lbl
            // 
            this.sreg_stop_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sreg_stop_lbl.Location = new System.Drawing.Point(209, 379);
            this.sreg_stop_lbl.Name = "sreg_stop_lbl";
            this.sreg_stop_lbl.Size = new System.Drawing.Size(165, 40);
            this.sreg_stop_lbl.Text = "sreg stop";
            this.sreg_stop_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // creg_start_lbl
            // 
            this.creg_start_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creg_start_lbl.Location = new System.Drawing.Point(486, 19);
            this.creg_start_lbl.Name = "creg_start_lbl";
            this.creg_start_lbl.Size = new System.Drawing.Size(165, 40);
            this.creg_start_lbl.Text = "creg start";
            this.creg_start_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // creg_stop_lbl
            // 
            this.creg_stop_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creg_stop_lbl.Location = new System.Drawing.Point(486, 79);
            this.creg_stop_lbl.Name = "creg_stop_lbl";
            this.creg_stop_lbl.Size = new System.Drawing.Size(165, 40);
            this.creg_stop_lbl.Text = "creg stop";
            this.creg_stop_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // get_hreg_lbl
            // 
            this.get_hreg_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.get_hreg_lbl.Location = new System.Drawing.Point(486, 139);
            this.get_hreg_lbl.Name = "get_hreg_lbl";
            this.get_hreg_lbl.Size = new System.Drawing.Size(165, 40);
            this.get_hreg_lbl.Text = "get hreg";
            this.get_hreg_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // get_ireg_lbl
            // 
            this.get_ireg_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.get_ireg_lbl.Location = new System.Drawing.Point(486, 199);
            this.get_ireg_lbl.Name = "get_ireg_lbl";
            this.get_ireg_lbl.Size = new System.Drawing.Size(165, 40);
            this.get_ireg_lbl.Text = "get ireg";
            this.get_ireg_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // get_creg_lbl
            // 
            this.get_creg_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.get_creg_lbl.Location = new System.Drawing.Point(486, 259);
            this.get_creg_lbl.Name = "get_creg_lbl";
            this.get_creg_lbl.Size = new System.Drawing.Size(165, 40);
            this.get_creg_lbl.Text = "get creg";
            this.get_creg_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // get_sreg_lbl
            // 
            this.get_sreg_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.get_sreg_lbl.Location = new System.Drawing.Point(486, 319);
            this.get_sreg_lbl.Name = "get_sreg_lbl";
            this.get_sreg_lbl.Size = new System.Drawing.Size(165, 40);
            this.get_sreg_lbl.Text = "get sreg";
            this.get_sreg_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // slave_num_txt
            // 
            this.slave_num_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slave_num_txt.Location = new System.Drawing.Point(103, 31);
            this.slave_num_txt.Name = "slave_num_txt";
            this.slave_num_txt.Size = new System.Drawing.Size(100, 26);
            this.slave_num_txt.TabIndex = 0;
            // 
            // enable_txt
            // 
            this.enable_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enable_txt.Location = new System.Drawing.Point(103, 91);
            this.enable_txt.Name = "enable_txt";
            this.enable_txt.Size = new System.Drawing.Size(100, 26);
            this.enable_txt.TabIndex = 1;
            // 
            // port_txt
            // 
            this.port_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.port_txt.Location = new System.Drawing.Point(103, 151);
            this.port_txt.Name = "port_txt";
            this.port_txt.Size = new System.Drawing.Size(100, 26);
            this.port_txt.TabIndex = 2;
            // 
            // baud_txt
            // 
            this.baud_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baud_txt.Location = new System.Drawing.Point(103, 211);
            this.baud_txt.Name = "baud_txt";
            this.baud_txt.Size = new System.Drawing.Size(100, 26);
            this.baud_txt.TabIndex = 3;
            // 
            // bytes_txt
            // 
            this.bytes_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bytes_txt.Location = new System.Drawing.Point(103, 271);
            this.bytes_txt.Name = "bytes_txt";
            this.bytes_txt.Size = new System.Drawing.Size(100, 26);
            this.bytes_txt.TabIndex = 4;
            // 
            // parity_txt
            // 
            this.parity_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parity_txt.Location = new System.Drawing.Point(103, 331);
            this.parity_txt.Name = "parity_txt";
            this.parity_txt.Size = new System.Drawing.Size(100, 26);
            this.parity_txt.TabIndex = 5;
            // 
            // stopbit_txt
            // 
            this.stopbit_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopbit_txt.Location = new System.Drawing.Point(103, 391);
            this.stopbit_txt.Name = "stopbit_txt";
            this.stopbit_txt.Size = new System.Drawing.Size(100, 26);
            this.stopbit_txt.TabIndex = 6;
            // 
            // slave_id_txt
            // 
            this.slave_id_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slave_id_txt.Location = new System.Drawing.Point(380, 31);
            this.slave_id_txt.Name = "slave_id_txt";
            this.slave_id_txt.Size = new System.Drawing.Size(100, 26);
            this.slave_id_txt.TabIndex = 7;
            // 
            // hreg_start_txt
            // 
            this.hreg_start_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hreg_start_txt.Location = new System.Drawing.Point(380, 91);
            this.hreg_start_txt.Name = "hreg_start_txt";
            this.hreg_start_txt.Size = new System.Drawing.Size(100, 26);
            this.hreg_start_txt.TabIndex = 8;
            // 
            // hreg_stop_txt
            // 
            this.hreg_stop_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hreg_stop_txt.Location = new System.Drawing.Point(380, 151);
            this.hreg_stop_txt.Name = "hreg_stop_txt";
            this.hreg_stop_txt.Size = new System.Drawing.Size(100, 26);
            this.hreg_stop_txt.TabIndex = 9;
            // 
            // ireg_start_txt
            // 
            this.ireg_start_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ireg_start_txt.Location = new System.Drawing.Point(380, 211);
            this.ireg_start_txt.Name = "ireg_start_txt";
            this.ireg_start_txt.Size = new System.Drawing.Size(100, 26);
            this.ireg_start_txt.TabIndex = 10;
            // 
            // ireg_stop_txt
            // 
            this.ireg_stop_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ireg_stop_txt.Location = new System.Drawing.Point(380, 271);
            this.ireg_stop_txt.Name = "ireg_stop_txt";
            this.ireg_stop_txt.Size = new System.Drawing.Size(100, 26);
            this.ireg_stop_txt.TabIndex = 11;
            // 
            // sreg_start_txt
            // 
            this.sreg_start_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sreg_start_txt.Location = new System.Drawing.Point(380, 331);
            this.sreg_start_txt.Name = "sreg_start_txt";
            this.sreg_start_txt.Size = new System.Drawing.Size(100, 26);
            this.sreg_start_txt.TabIndex = 12;
            // 
            // sreg_stop_txt
            // 
            this.sreg_stop_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sreg_stop_txt.Location = new System.Drawing.Point(380, 391);
            this.sreg_stop_txt.Name = "sreg_stop_txt";
            this.sreg_stop_txt.Size = new System.Drawing.Size(100, 26);
            this.sreg_stop_txt.TabIndex = 13;
            // 
            // creg_start_txt
            // 
            this.creg_start_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creg_start_txt.Location = new System.Drawing.Point(657, 31);
            this.creg_start_txt.Name = "creg_start_txt";
            this.creg_start_txt.Size = new System.Drawing.Size(100, 26);
            this.creg_start_txt.TabIndex = 14;
            // 
            // creg_stop_txt
            // 
            this.creg_stop_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creg_stop_txt.Location = new System.Drawing.Point(657, 91);
            this.creg_stop_txt.Name = "creg_stop_txt";
            this.creg_stop_txt.Size = new System.Drawing.Size(100, 26);
            this.creg_stop_txt.TabIndex = 15;
            // 
            // get_hreg_txt
            // 
            this.get_hreg_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.get_hreg_txt.Location = new System.Drawing.Point(657, 151);
            this.get_hreg_txt.Name = "get_hreg_txt";
            this.get_hreg_txt.Size = new System.Drawing.Size(100, 26);
            this.get_hreg_txt.TabIndex = 16;
            // 
            // get_ireg_txt
            // 
            this.get_ireg_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.get_ireg_txt.Location = new System.Drawing.Point(657, 211);
            this.get_ireg_txt.Name = "get_ireg_txt";
            this.get_ireg_txt.Size = new System.Drawing.Size(100, 26);
            this.get_ireg_txt.TabIndex = 17;
            // 
            // get_creg_txt
            // 
            this.get_creg_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.get_creg_txt.Location = new System.Drawing.Point(657, 271);
            this.get_creg_txt.Name = "get_creg_txt";
            this.get_creg_txt.Size = new System.Drawing.Size(100, 26);
            this.get_creg_txt.TabIndex = 18;
            // 
            // get_sreg_txt
            // 
            this.get_sreg_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.get_sreg_txt.Location = new System.Drawing.Point(657, 331);
            this.get_sreg_txt.Name = "get_sreg_txt";
            this.get_sreg_txt.Size = new System.Drawing.Size(100, 26);
            this.get_sreg_txt.TabIndex = 19;
            //
            // reading from file
            //
            if (this.Mod == "m")
            {
                this.slave_num_txt.Text = this.section_name;
                this.enable_txt.Text = Program.F.Read("enable", this.section_name);
                this.port_txt.Text = Program.F.Read("port", this.section_name);
                this.baud_txt.Text = Program.F.Read("baud", this.section_name);
                this.bytes_txt.Text = Program.F.Read("bytes", this.section_name);
                this.parity_txt.Text = Program.F.Read("parity", this.section_name);
                this.stopbit_txt.Text = Program.F.Read("stopbit", this.section_name);
                this.slave_id_txt.Text = Program.F.Read("slave_id", this.section_name);
                this.hreg_start_txt.Text = Program.F.Read("hreg_start", this.section_name);
                this.hreg_stop_txt.Text = Program.F.Read("hreg_stop", this.section_name);
                this.ireg_start_txt.Text = Program.F.Read("ireg_start", this.section_name);
                this.ireg_stop_txt.Text = Program.F.Read("ireg_stop", this.section_name);
                this.sreg_start_txt.Text = Program.F.Read("sreg_start", this.section_name);
                this.sreg_stop_txt.Text = Program.F.Read("sreg_stop", this.section_name);
                this.creg_start_txt.Text = Program.F.Read("creg_start", this.section_name);
                this.creg_stop_txt.Text = Program.F.Read("creg_stop", this.section_name);
                this.get_hreg_txt.Text = Program.F.Read("get_hreg", this.section_name);
                this.get_ireg_txt.Text = Program.F.Read("get_ireg", this.section_name);
                this.get_creg_txt.Text = Program.F.Read("get_creg", this.section_name);
                this.get_sreg_txt.Text = Program.F.Read("get_sreg", this.section_name);
            }
            // 
            // Slave
            // 
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.confirm_btn);
            this.Controls.Add(this.slave_num_lbl);
            this.Controls.Add(this.enable_lbl);
            this.Controls.Add(this.port_lbl);
            this.Controls.Add(this.baud_lbl);
            this.Controls.Add(this.bytes_lbl);
            this.Controls.Add(this.parity_lbl);
            this.Controls.Add(this.stopbit_lbl);
            this.Controls.Add(this.slave_id_lbl);
            this.Controls.Add(this.hreg_start_lbl);
            this.Controls.Add(this.hreg_stop_lbl);
            this.Controls.Add(this.ireg_start_lbl);
            this.Controls.Add(this.ireg_stop_lbl);
            this.Controls.Add(this.sreg_start_lbl);
            this.Controls.Add(this.sreg_stop_lbl);
            this.Controls.Add(this.creg_start_lbl);
            this.Controls.Add(this.creg_stop_lbl);
            this.Controls.Add(this.get_hreg_lbl);
            this.Controls.Add(this.get_ireg_lbl);
            this.Controls.Add(this.get_creg_lbl);
            this.Controls.Add(this.get_sreg_lbl);
            this.Controls.Add(this.slave_num_txt);
            this.Controls.Add(this.enable_txt);
            this.Controls.Add(this.port_txt);
            this.Controls.Add(this.baud_txt);
            this.Controls.Add(this.bytes_txt);
            this.Controls.Add(this.parity_txt);
            this.Controls.Add(this.stopbit_txt);
            this.Controls.Add(this.slave_id_txt);
            this.Controls.Add(this.hreg_start_txt);
            this.Controls.Add(this.hreg_stop_txt);
            this.Controls.Add(this.ireg_start_txt);
            this.Controls.Add(this.ireg_stop_txt);
            this.Controls.Add(this.sreg_start_txt);
            this.Controls.Add(this.sreg_stop_txt);
            this.Controls.Add(this.creg_start_txt);
            this.Controls.Add(this.creg_stop_txt);
            this.Controls.Add(this.get_hreg_txt);
            this.Controls.Add(this.get_ireg_txt);
            this.Controls.Add(this.get_creg_txt);
            this.Controls.Add(this.get_sreg_txt);
            this.Name = "Slave";
            this.Text = "Slave Config Form";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private void buttonSlaveConfirm_Click(object sender, EventArgs e)
        {
            if (create_f == null && this.Mod == "c")
            {
                string v1 = Convert.ToString(slave_num_txt.Text);
                string v2 = Convert.ToString(enable_txt.Text);
                string v3 = Convert.ToString(port_txt.Text);
                string v4 = Convert.ToString(baud_txt.Text);
                string v5 = Convert.ToString(bytes_txt.Text);
                string v6 = Convert.ToString(parity_txt.Text);
                string v7 = Convert.ToString(stopbit_txt.Text);
                string v8 = Convert.ToString(slave_id_txt.Text);
                string v9 = Convert.ToString(hreg_start_txt.Text);
                string v10 = Convert.ToString(hreg_stop_txt.Text);
                string v11 = Convert.ToString(ireg_start_txt.Text);
                string v12 = Convert.ToString(ireg_stop_txt.Text);
                string v13 = Convert.ToString(sreg_start_txt.Text);
                string v14 = Convert.ToString(sreg_stop_txt.Text);
                string v15 = Convert.ToString(creg_start_txt.Text);
                string v16 = Convert.ToString(creg_stop_txt.Text);
                string v17 = Convert.ToString(get_hreg_txt.Text);
                string v18 = Convert.ToString(get_ireg_txt.Text);
                string v19 = Convert.ToString(get_creg_txt.Text);
                string v20 = Convert.ToString(get_sreg_txt.Text);

                Slave_object sl_obj = new Slave_object(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10,
                                                       v11, v12, v13, v14, v15, v16, v17, v18, v19, v20);
                Program.slaves.Add(sl_obj);

                create_f = new Create_form();
                create_f.Show();
                Program.MasterConfig_btn.Enabled = false;
                Program.PinConfig_btn.Enabled = false;
                Program.SlaveConfig_btn.Enabled = true;
                Program.CreateINI_btn.Enabled = true;
                Hide();
            }
            if (SlaveL == null && this.Mod == "m")
            {
                Program.F.Write("enable", this.enable_txt.Text, this.section_name);
                Program.F.Write("port", this.port_txt.Text, this.section_name);
                Program.F.Write("baud", this.baud_txt.Text, this.section_name);
                Program.F.Write("bytes", this.bytes_txt.Text, this.section_name);
                Program.F.Write("parity", this.parity_txt.Text, this.section_name);
                Program.F.Write("stopbit", this.stopbit_txt.Text, this.section_name);
                Program.F.Write("slave_id", this.slave_id_txt.Text, this.section_name);
                Program.F.Write("hreg_start", this.hreg_start_txt.Text, this.section_name);
                Program.F.Write("hreg_stop", this.hreg_stop_txt.Text, this.section_name);
                Program.F.Write("ireg_start", this.ireg_start_txt.Text, this.section_name);
                Program.F.Write("ireg_stop", this.ireg_stop_txt.Text, this.section_name);
                Program.F.Write("sreg_start", this.sreg_start_txt.Text, this.section_name);
                Program.F.Write("sreg_stop", this.sreg_stop_txt.Text, this.section_name);
                Program.F.Write("creg_start", this.creg_start_txt.Text, this.section_name);
                Program.F.Write("creg_stop", this.creg_stop_txt.Text, this.section_name);
                Program.F.Write("get_hreg", this.get_hreg_txt.Text, this.section_name);
                Program.F.Write("get_ireg", this.get_hreg_txt.Text, this.section_name);
                Program.F.Write("get_sreg", this.get_hreg_txt.Text, this.section_name);
                Program.F.Write("get_creg", this.get_hreg_txt.Text, this.section_name);

                SlaveL = new SlaveList();
                SlaveL.Show();
                Program.MasterConfig_btn.Enabled = false;
                Program.PinConfig_btn.Enabled = false;
                Program.SlaveConfig_btn.Enabled = false;
                Program.SaveINI_btn.Enabled = true;
                Hide();
            }
        }
        #endregion
    }
}