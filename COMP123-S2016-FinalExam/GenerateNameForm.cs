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
            // 1-Generate random number (min one max first name list box items count) to insure the number will not be more than the max value
            int firstNamePostion = selction.Next(1, FirstNameListBox.Items.Count);

            // 2-Select a name based on its index which is the random number generated in the previous step
            var firstNameSelection = FirstNameListBox.Items[firstNamePostion];

            // 3-Generate random number (min one max last name list box items count) to insure the number will not be more than the max value
            int lastNamePostion = selction.Next(1, listBox1.Items.Count);

            // 4-Select a name based on its index which is the random number generated in step 3
            var lastNameSelection = listBox1.Items[lastNamePostion];

            //5- assign the selected names to appropriate text box
            textBox1.Text = firstNameSelection.ToString();
            LastNameTextBox.Text = lastNameSelection.ToString();
        }


        /// <summary>
        /// Loading the form will triger this event handler which will call generate name method
        /// sp each time form loaded new names will be selected 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateNameForm_Load(object sender, EventArgs e)
        {
            GenerateName();
        }

        /// <summary>
        /// Selecting random names can be done manually by pressing generate name button in the form
        /// which will trigger this event handler 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            GenerateName();
            Program.character.FirstName = textBox1.Text;
            Program.character.LastName = LastNameTextBox.Text;
        }


        /// <summary>
        /// This event handler will be trigger by pressing next button which will open Ability form
        /// and assign the random  selected names to the appropriate class  fields
        /// which will allow the app to transfer data between forms 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
