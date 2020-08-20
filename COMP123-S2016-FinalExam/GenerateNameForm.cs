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
    public partial class GenerateNameForm : Form
    {
        public GenerateNameForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// this method will select first name and last name randomly from the list box 
        /// </summary>
        public void GenerateName()
        {
            Random selction = new Random();
            int firstNamePostion = selction.Next(1, FirstNameListBox.Items.Count);
            var firstNameSelection = FirstNameListBox.Items[firstNamePostion];
            int lastNamePostion = selction.Next(1, listBox1.Items.Count);
            var lastNameSelection = listBox1.Items[lastNamePostion];
            textBox1.Text = firstNameSelection.ToString();
            LastNameTextBox.Text = lastNameSelection.ToString();
        }

        private void GenerateNameForm_Load(object sender, EventArgs e)
        {
            GenerateName();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            GenerateName();
            Program.character.FirstName = textBox1.Text;
            Program.character.LastName = LastNameTextBox.Text;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            AbilityGeneratorForm abilityGeneratorForm = new AbilityGeneratorForm();
            abilityGeneratorForm.Show();
            this.Hide();

            //These 2 extra steps to set values of firstname and lastname prop. when next button clicked 
            Program.character.FirstName = textBox1.Text;
            Program.character.LastName = LastNameTextBox.Text;
        }
    }
}
