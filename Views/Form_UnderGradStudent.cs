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
    public partial class Form_UnderGradStudent : Form
    {
        public Form_UnderGradStudent()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UnderGradStudent under = new UnderGradStudent(txt_fname.Text, txt_lname.Text, txt_address.Text, txt_city.Text, int.Parse(txt_tel.Text), int.Parse(txt_test1.Text), int.Parse(txt_test2.Text), int.Parse(txt_voterid.Text));

            try
            {
                UniversityBDContext db = new UniversityBDContext();

                db.UnderGradStudents.Add(under);
                db.SaveChanges();
                MessageBox.Show("Data Saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UnderGradStudent grad = new UnderGradStudent();
            string result = grad.ComputeGrade();
            txt_grade.Text = result.ToString();
        }
    }
}