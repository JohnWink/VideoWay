using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoWay

{
    public class Parameters
    {
        public static Form CurrentForm = Form.ActiveForm; // Hides previous form every time it switches to a new form
        public static string user;
    }
    static class Program
    {

       
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
