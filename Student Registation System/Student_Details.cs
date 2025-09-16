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
    public partial class Student_Details : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-6D47JTU;Initial Catalog=MIT1469;Integrated Security=True");

        public Student_Details()
        {
            InitializeComponent();
        }

        private void Student_Details_Load(object sender, EventArgs e)
        {
           //Open Connecion
            con.Open();

            string sql = "SELECT * FROM MIT1469";
            SqlCommand cmd = new SqlCommand(sql, con);

            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["st_id"], reader["f_name"], reader["l_name"], reader["address"], reader["gender"], reader["grade"], reader["telephone_number"]);
            }


            //Close Connection
            con.Close();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form studentRegister = new Student_Registation();
            studentRegister.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form mainForm = new mainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
