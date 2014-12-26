using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsingClassFullAndReverseName.DLL.DAO;

namespace UsingClassFullAndReverseName
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Name aName=new Name();
        void TakeInput()
        {
            if (firstNameTextBox == null || middleNameTextBox.Text == null || lstNameTextBox.Text == null)
            {
                MessageBox.Show("Please fill all the text box");
            }
            else
            {
                aName.firstName = firstNameTextBox.Text;
                aName.middleName = middleNameTextBox.Text;
                aName.lastName = lstNameTextBox.Text;
            }
           
        }
        private void showButton_Click(object sender, EventArgs e)
        {
            TakeInput();
            fullNameTextBox.Text = aName.GetFullName();
            reverseNameTextBox.Text = aName.GetReverseName();
        }
    }
}
