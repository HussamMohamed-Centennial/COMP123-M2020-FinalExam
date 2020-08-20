using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_FinalExam
{
    public static class Program
    {
        public static Character character = new Character();
        public static SplashForm splashForm;
        public static GenerateNameForm generateNameForm;
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            splashForm = new SplashForm();
            generateNameForm = new GenerateNameForm();
            Application.Run(splashForm);
        }
    }
}
