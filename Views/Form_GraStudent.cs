using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University_ERP.Data;
using University_ERP.Models;

namespace University_ERP.Views
{
    public partial class Form_GraStudent : Form
    {
        public Form_GraStudent()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UniversityBDContext db = new UniversityBDContext();
            GradStudent grad = new GradStudent(txt_fname.Text, txt_lname.Text, txt_address.Text, txt_city.Text, int.Parse(txt_tel.Text), int.Parse(txt_test2.Text), int.Parse(txt_test2.Text), int.Parse(txt_voterid.Text));

            try
            {
                db.GradStudents.Add(grad);
                db.SaveChanges();
                MessageBox.Show("Data Saved");
                this.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }


        }
    }
}
