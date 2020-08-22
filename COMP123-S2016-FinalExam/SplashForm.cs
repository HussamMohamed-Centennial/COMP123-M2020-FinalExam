using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_FinalExam
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// splash timer tick event handler will
        /// 1-show next form
        /// 2-hide this form
        /// 3- disable timer to prevent repeated action when the timer interval end.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            Program.generateNameForm.Show();
            this.Hide();
            SplashFormTimer.Enabled = false;
        }
    }
}
