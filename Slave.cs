using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INI
{
    internal partial class Slave : Form
    {
        public Slave(string mod, string section)
        {
            this.Mod = mod;
            this.section_name = section;
            InitializeComponent();
        }

        //protected string section_name { get; set; }
    }
}
