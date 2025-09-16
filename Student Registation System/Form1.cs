using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Registation_System
{
    
    public partial class mainForm : Form
    {
        
        public mainForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void studentRegisterButton_Click(object sender, EventArgs e)
        {
            Form registationForm = new Student_Registation();
            registationForm.Show();
            this.Hide();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult result =  MessageBox.Show(
                "You Need to Exit the Studen Rejistetion System",
                "Exit-Message",
                MessageBoxButtons.YesNo
                );
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void viewStudentsDetailsButton_Click(object sender, EventArgs e)
        {
            Form studentDetails = new Student_Details();
            studentDetails.Show();
            this.Hide();


        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
