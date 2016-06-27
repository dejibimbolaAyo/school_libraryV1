using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class FormLibraryHome : Form
    {
        public FormLibraryHome()
        {
            InitializeComponent();
        }

        private void FormLibraryHome_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonEnrollStudents_Click(object sender, EventArgs e)
        {
            formStudentEnroll studentEnroll_page = new formStudentEnroll();
            studentEnroll_page.Show();
            FormLibraryHome formLibraryHome_page = new FormLibraryHome();
            this.Hide();
        }

    }
}
