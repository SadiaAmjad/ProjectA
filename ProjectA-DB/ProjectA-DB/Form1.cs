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
            //this.Hide();
            
        }

        private void creat_Click(object sender, EventArgs e)
        {
            
        }

        private void FYPM_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        
        int selectedid = 0;
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            selectedid = e.RowIndex;
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
        }

        private void Clear_Click(object sender, EventArgs e)
        {
          
            //this.Hide();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
           
        }

        private void Update1_Click(object sender, EventArgs e)
        {
        }

        private void UpdateData_Enter(object sender, EventArgs e)
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageStudent o = new ManageStudent();
            o.Show();
            this.Hide();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
           
            ManageStudent o = new ManageStudent();
            o.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ManageProject q1 = new ManageProject();
            q1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManageEvaluation o = new ManageEvaluation();
            o.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ManageAdvisor p = new ManageAdvisor();
            p.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
