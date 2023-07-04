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
    internal partial class Master : Form
    {
        public Master(string mod)
        {
            this.Mod = mod;
            InitializeComponent();
        }
    }
}
