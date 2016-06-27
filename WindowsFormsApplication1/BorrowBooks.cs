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

namespace WindowsFormsApplication1
{
    public partial class formBorrowBooks : Form
    {
        public formBorrowBooks()
        {
            InitializeComponent();
                           
        }

        private void formBorrowBooks_Load(object sender, EventArgs e)
        {

        }

        private void labelStudentID_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string myConnectionString = "server=localhost;port=8080;database=library;uid=root;pwd=root;";
            MySqlConnection connection = new MySqlConnection(myConnectionString);
           // MySqlDataReader reader = null;


            connection.Open();
            try
            {
                string sqlcom = "DELETE FROM book_info WHERE book_ID=" + textBoxBook1.Text;
                MySqlCommand cmd = new MySqlCommand(sqlcom, connection);
               // reader = cmd.ExecuteReader();

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
    }
}
