using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ProjectA_DB
{
    public partial class FYPM : Form
    {
        //string conString = "Data Source=DESKTOP-OF558HL\\SQLEXPRESS;Initial Catalog=ProjectA;Integrated Security=True";
        public FYPM()
        {
            InitializeComponent();
            

        }
        private int imageNumber = 1;
        private void loadNextImage()
        {
            if (imageNumber == 8)
            {
                imageNumber = 0;
            }
            slidePic.ImageLocation = string.Format(@"images\{0}.jpg", imageNumber);
            imageNumber++;
        }
        

        private void button5_Click_2(object sender, EventArgs e)
        {
            ManageStudent o = new ManageStudent();
            o.Show();
            this.Hide();
        }

        private void FYPM_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loadNextImage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageStudent o = new ManageStudent();
            o.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ManageAdvisor p = new ManageAdvisor();
            p.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManageProject q1 = new ManageProject();
            q1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ManageEvaluation o = new ManageEvaluation();
            o.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            groupStudent s = new groupStudent();
            s.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }

        private void circularButton4_Click(object sender, EventArgs e)
        {
            Report k = new Report();
            k.Show();
            this.Hide();
        }

        private void circularButton1_Click(object sender, EventArgs e)
        {
            Report2 k = new Report2();
            k.Show();
            this.Hide();
        }
    }
}
