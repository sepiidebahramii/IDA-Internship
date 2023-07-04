using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace INI
{
    static class Program
    {
        public static Master_object M;
        public static Pin_object P;
        public static List<Slave_object> slaves = new List<Slave_object>();
        public static Create_INI F;

        public static Button MasterConfig_btn;
        public static Button PinConfig_btn;
        public static Button SlaveConfig_btn;

        public static Button NewINI_btn;
        public static Button OpenINI_btn;

        public static Button CreateINI_btn;
        public static Button SaveINI_btn;

        /// The main entry point for the application.
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main_form());
        }
    }
}