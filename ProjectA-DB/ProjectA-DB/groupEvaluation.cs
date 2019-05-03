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
    public partial class groupEvaluation : Form
    {
        string conURL = "Data Source=DESKTOP-OF558HL\\SQLEXPRESS;Initial Catalog=ProjectA;Integrated Security=True;";
        public groupEvaluation()
        {
            InitializeComponent();
        }

        private void groupEvaluation_Load(object sender, EventArgs e)
        {
            string query = "select Id ,Name,TotalMarks from Evaluation";
            SqlConnection con = new SqlConnection(conURL);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter ad = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["evaluation"].DisplayIndex = 3;
            dataGridView1.Columns["Id"].Visible = false;
            DataGridViewButtonColumn c = (DataGridViewButtonColumn)dataGridView1.Columns["evaluation"];
            c.FlatStyle = FlatStyle.Popup;
            c.DefaultCellStyle.ForeColor = Color.WhiteSmoke;
            c.DefaultCellStyle.BackColor = Color.Crimson;
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Evaluation f = new Evaluation();
            f.setObtainedMarks(textBox1.Text);
            bool i = false;
            if (f.getObtainedMarks() == null)
            {
                i = true;
            }
            if (i == true)
            {
                MessageBox.Show("Enter Input");
            }
            else
            {
                int d1 = dataGridView1.CurrentCell.RowIndex;
                bool k1 = dataGridView1.Rows[d1].Cells["evaluation"].Selected;
                if(dataGridView1.Rows.Count != 0)
                {
                    if (k1 == true)
                    {
                        if (textBox1.Text != "")
                        {
                            try
                            {
                                SqlConnection con = new SqlConnection(conURL);
                                con.Open();

                                int g = Convert.ToInt32(dataGridView1.Rows[d1].Cells["Id"].Value);
                                string q = "Select max(Id) from [Group]";
                                SqlCommand a = new SqlCommand(q, con);
                                int w = (int)a.ExecuteScalar();

                                string Q2 = String.Format("Insert into GroupEvaluation(GroupId,EvaluationId,ObtainedMarks,EvaluationDate)Values('" + w + "','" + g + "','" + Convert.ToInt32(textBox1.Text) + "','" + DateTime.Today + "') ");
                                SqlCommand cmd1 = new SqlCommand(Q2, con);
                                int k = cmd1.ExecuteNonQuery();
                                MessageBox.Show(k + "rows inserted in Group Evaluation!");
                                dataGridView1.Rows.RemoveAt(d1);

                                var choice = MessageBox.Show("Do You Want to add more evaluation to group ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                if (choice == DialogResult.Yes)
                                {

                                }
                                else if (dataGridView1.Rows.Count == 0)
                                {
                                    MessageBox.Show("No more data to add");
                                    this.Close();
                                    groupStudent s = new groupStudent();
                                    s.Show();
                                }
                                else
                                {
                                    this.Close();
                                    groupStudent s = new groupStudent();
                                    s.Show();
                                }
                                con.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please Enter Obtained Marks");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No data available");
                }
                
                   
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void circularButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            groupStudent n = new groupStudent();
            n.Show();
        }
    }
}
