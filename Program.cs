using System;
using System.Windows.Forms;

namespace MachineForms
{
    static class Program
    {
        //应用程序的主入口点
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
