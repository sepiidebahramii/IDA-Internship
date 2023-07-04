using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INI
{
    class Slave_object
    {
        public string slave_num = "";
        public string enable = "";
        public string port = "";
        public string baud = "";
        public string bytes = "";
        public string parity = "";
        public string stopbit = "";
        public string slave_id = "";
        public string hreg_start = "";
        public string hreg_stop = "";
        public string ireg_start = "";
        public string ireg_stop = "";
        public string sreg_start = "";
        public string sreg_stop = "";
        public string creg_start = "";
        public string creg_stop = "";
        public string get_hreg = "";
        public string get_ireg = "";
        public string get_creg = "";
        public string get_sreg = "";

        public Slave_object(string v1, string v2, string v3, string v4, string v5, string v6, string v7, string v8, string v9, string v10,
               string v11, string v12, string v13, string v14, string v15, string v16, string v17, string v18, string v19, string v20)
        {
            slave_num = v1;
            enable = v2;
            port = v3;
            baud = v4;
            bytes = v5;
            parity = v6;
            stopbit = v7;
            slave_id = v8;
            hreg_start = v9;
            hreg_stop = v10;
            ireg_start = v11;
            ireg_stop = v12;
            sreg_start = v13;
            sreg_stop = v14;
            creg_start = v15;
            creg_stop = v16;
            get_hreg = v17;
            get_ireg = v18;
            get_creg = v19;
            get_sreg = v20;
        }

        public string Get_slave_num() { return slave_num; }
        public string Get_enable() { return enable; }
        public string Get_port() { return port; }
        public string Get_baud() { return baud; }
        public string Get_bytes() { return bytes; }
        public string Get_parity() { return parity; }
        public string Get_stopbit() { return stopbit; }
        public string Get_slave_id() { return slave_id; }
        public string Get_hreg_start() { return hreg_start; }
        public string Get_hreg_stop() { return hreg_stop; }
        public string Get_ireg_start() { return ireg_start; }
        public string Get_ireg_stop() { return ireg_stop; }
        public string Get_sreg_start() { return sreg_start; }
        public string Get_sreg_stop() { return sreg_stop; }
        public string Get_creg_start() { return creg_start; }
        public string Get_creg_stop() { return creg_stop; }
        public string Get_get_hreg() { return get_hreg; }
        public string Get_get_ireg() { return get_ireg; }
        public string Get_get_creg() { return get_creg; }
        public string Get_get_sreg() { return get_sreg; }
    }
}