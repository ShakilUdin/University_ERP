using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University_ERP.Views;

namespace University_ERP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void underGradStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_UnderGradStudent under = new Form_UnderGradStudent();
            under.ShowDialog();
        }

        private void gradStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_GraStudent grad = new Form_GraStudent();
            grad.ShowDialog();
        }

        private void partStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_PartStudent part = new Form_PartStudent();
            part.ShowDialog();
        }
    }
}
