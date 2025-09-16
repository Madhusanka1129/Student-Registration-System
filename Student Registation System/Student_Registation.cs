using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Registation_System
{
    public partial class Student_Registation : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-6D47JTU;Initial Catalog=MIT1469;Integrated Security=True");

        public Student_Registation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO MIT1469 (st_id, f_name, l_name, address, gender,grade, telephone_number) VALUES (@st_id, @f_name, @l_name, @address, @gender, @grade, @telephone_number)";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@st_id", stNumberTextBox.Text);
            cmd.Parameters.AddWithValue("@f_name", fnameTextBox.Text);
            cmd.Parameters.AddWithValue("@l_name", lNameTextBox.Text);
            cmd.Parameters.AddWithValue("@address", addressTextBox.Text);
            cmd.Parameters.AddWithValue("@telephone_number", tNumberTextBox.Text);

            //Radio button add
            string gender = mailRadioButton.Checked ? "Male" : "Female";
            cmd.Parameters.AddWithValue("@gender", gender);

            //combobox add
            cmd.Parameters.AddWithValue("@grade", gradeComboBox.SelectedItem?.ToString() ?? "Not Selected");

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("User saved successfully!");

            stNumberTextBox.Clear();
            fnameTextBox.Clear();
            lNameTextBox.Clear();
            addressTextBox.Clear();
            mailRadioButton.Checked = false;
            femailRadioButton.Checked = false;
            gradeComboBox.SelectedIndex = -1;
            tNumberTextBox.Clear();
            stNumberTextBox.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            stNumberTextBox.Clear();
            fnameTextBox.Clear();
            lNameTextBox.Clear();
            addressTextBox.Clear();
            mailRadioButton.Checked = false;
            femailRadioButton.Checked = false;
            gradeComboBox.SelectedIndex = -1;
            tNumberTextBox.Clear();
            stNumberTextBox.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form studentDetails = new Student_Details();
            studentDetails.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form mainForm = new mainForm();
            mainForm.Show();
            this.Hide();
        }

        private void Student_Registation_Load(object sender, EventArgs e)
        {

        }
    }
}
