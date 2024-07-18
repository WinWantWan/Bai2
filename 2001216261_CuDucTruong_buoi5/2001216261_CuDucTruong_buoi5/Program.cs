using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001216261_CuDucTruong_buoi5
{
    static class Program
    {
        public static FrmMain frmMain = null;
        public static FrmLogin frmLogin = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin = new FrmLogin();
            Application.Run(new FrmCauHinh());
        }
    }
}
