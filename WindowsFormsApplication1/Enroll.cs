using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using WindowsFormsApplication1;

namespace WindowsFormsApplication1
{
    public partial class formStudentEnroll : Form
    {
        public formStudentEnroll()
        {
            InitializeComponent();
        }
        //private void Enroll_FormClosing (object sender, FormClosingEventArgs e)
        //{
        //    if (string.Equals((sender as Button).Name, @"CloseButton"))
        //    {
        //        FormLibraryHome formLibraryHome_page = new FormLibraryHome();
        //        formLibraryHome_page.Show();
        //        else
                
        //        FormLibraryHome formLibraryHome_page1 = new FormLibraryHome();
        //        formLibraryHome_page1.Show();
        //    }
        //}

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDepartment_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFaculty_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string myConnectionString = "server=localhost;port=8080;database=library;uid=root;pwd=root;";
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            MySqlCommand cmd;
            connection.Open();
                                 
           // MessageBox.Show("Data Submitted to Database \n Data waiting for Validation");



            try
            {

                cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT INTO students_info(firstName,lastName,middleName,dateOfBirth,phone,matNo,session,department,faculty,createdBy,createdOn) VALUES(@firstName,@lastName,@middleName,@dateOfBirth,@phone,@matNo,@session,@department,@faculty,@createdBy,@createdOn)";
                cmd.Parameters.AddWithValue("@firstName", textBoxFirstName.Text);
                cmd.Parameters.AddWithValue("@lastName", textBoxLastName.Text);
                cmd.Parameters.AddWithValue("@middleName", textBoxMiddleName.Text);
                cmd.Parameters.AddWithValue("@dateOfBirth", dateTimePickerDob.Text);
                cmd.Parameters.AddWithValue("@emailAddress", textBoxEmail.Text);
                cmd.Parameters.AddWithValue("@phone", textBoxPhone.Text);
                cmd.Parameters.AddWithValue("@MatNo", textBoxMatNo.Text);
                cmd.Parameters.AddWithValue("@session", textBoxSession.Text);
                cmd.Parameters.AddWithValue("@department", textBoxDepartment.Text);
                cmd.Parameters.AddWithValue("@faculty", textBoxFaculty.Text);
                cmd.Parameters.AddWithValue("@createdBy", SystemInformation.UserName);
                cmd.Parameters.AddWithValue("@createdOn", System.DateTime.Now);

                cmd.ExecuteNonQuery();
                //formStudentEnroll studentEnroll_page = new formStudentEnroll();
                //studentEnroll_page.Close();
                this.Close();
               
            }
            

            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();

                }
            }

        }
        public class stdFormInput
        {
            public string firstName;
            public string lastName;
            public string middleName;
            public string dateOfBirth;
            public string phone;
            public string matNo;
            public string emailAddress;
            public string session;
            public string department;
            public string faculty;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }

}
