using System;
using System.Windows.Forms;

namespace AddNums
{
    public partial class frmAddition : Form
    {
        public frmAddition()
        {
            InitializeComponent();
        }

        private void lblFirstNum_Click(object sender, EventArgs e)
        {

        }

      
        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblSecNum_Click(object sender, EventArgs e)
        {

        }

        private void frmAddition_Load(object sender, EventArgs e)
        {
            //Set focus on the first number text field
            txtFirstNum.Focus();
            //Disable the sum textbox
            txtSum.Enabled = false;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            //Check whether the first number text box is empty and display an appropriate message
            if(txtFirstNum.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter the first number to be added",
                    "Missing first number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Set Focus on the first number text box
                txtFirstNum.Focus();
                //Stop further method execution
                return;
            }

            if (txtSecNum.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter the second number to be added",
                    "Missing second number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Set Focus on the second number text box
                txtSecNum.Focus();
                //Stop further method execution
                return;
            }

            //Attempt to add the two numbers when the contain valid input
            try
            {
                int num1 = int.Parse(txtFirstNum.Text);
                int num2 = int.Parse(txtSecNum.Text);  //int num2 = Convert.ToInt30(txtSecNum.Text)
                txtSum.Text = AddNums(num1, num2).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid numeric value e.g. \'5\'",
                    "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("The error " + ex.Message + " occured!",
                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Method to  add two integers and return their sum as a long
        /// </summary>
        /// <param name="num1">First integer value to be added</param>
        /// <param name="num2">Second integer value to be added</param>
        /// <returns>Sum of the two integers as a long</returns>
        private long AddNums (int num1, int num2)
        {
            return (num1 + num2);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Clear the first number textbox
            txtFirstNum.Text = "";
            //Clear the second number textbox
            txtSecNum.Clear();
            //Clear the sum number textbox
            txtSum.Clear();
            //Set Focus on the first number text box
            txtFirstNum.Focus();
        }
    }
}
