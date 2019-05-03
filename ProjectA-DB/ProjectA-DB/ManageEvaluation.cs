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
    public partial class ManageEvaluation : Form
    {
        string conURL = "Data Source=DESKTOP-OF558HL\\SQLEXPRESS;Initial Catalog=ProjectA;Integrated Security=True";
        public ManageEvaluation()
        {
            InitializeComponent();
        }
        
        private void Cancel_Click_1(object sender, EventArgs e)
        {
            /*name1.Clear();
            totalmarks1.Clear();
            totalweightage1.Clear();*/
            
        }

        private void Submit_Click_1(object sender, EventArgs e)
        {
        }

        private void Clear_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Back_Click_1(object sender, EventArgs e)
        {

            FYPM g = new FYPM();
            g.Show();
            this.Hide();
        }

        private void Retrieve_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int d1 = dataGridView1.CurrentCell.RowIndex;
                bool k1 = dataGridView1.Rows[d1].Cells["Delete"].Selected;
                bool k2 = dataGridView1.Rows[d1].Cells["Update"].Selected;
                if (k1 == true)
                {
                    if (DialogResult.Yes == MessageBox.Show("Do You Want Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        using (SqlConnection con = new SqlConnection(conURL))
                        {
                            int d = dataGridView1.CurrentCell.RowIndex;
                            con.Open();
                            int G = Convert.ToInt32(dataGridView1.Rows[d].Cells["Id"].Value);

                            string Q3 = String.Format("Delete from GroupEvaluation where EvaluationId = '" + G + "'");
                            SqlCommand cmd2 = new SqlCommand(Q3, con);
                            int k3 = cmd2.ExecuteNonQuery();
                           // MessageBox.Show(k3 + "rows deleted from group Evaluation!");

                            string Q2 = String.Format("Delete from Evaluation where Id = '" + G + "'");
                            SqlCommand cmd1 = new SqlCommand(Q2, con);
                            int k = cmd1.ExecuteNonQuery();
                            MessageBox.Show(k + "rows deleted!");
                            con.Close();
                            dataGridView1.Rows.RemoveAt(d);
                        }
                    }
                }
                else if (k2 == true)
                {
                    UpdateEvaluation.Show();
                    try
                    {

                        using (SqlConnection con = new SqlConnection(conURL))
                        {
                            con.Open();
                            int d = dataGridView1.CurrentCell.RowIndex;
                            int G = Convert.ToInt32(dataGridView1.Rows[d].Cells["Id"].Value);
                            string q2 = "select Name,TotalMarks,TotalWeightage from Evaluation where Id = '" + G + "' ";
                            SqlCommand cmd1 = new SqlCommand(q2, con);
                            SqlDataReader rdr = cmd1.ExecuteReader();
                            if (rdr.HasRows)
                            {
                                while (rdr.Read())
                                {
                                    //Id.Text = rdr.GetString(1);
                                    UName.Text = rdr.GetString(0);
                                    Utm.Text = Convert.ToString(rdr.GetInt32(1));
                                    Utw.Text = Convert.ToString(rdr.GetInt32(2));
                                }
                                con.Close();
                            }
                            else
                            {
                                MessageBox.Show("No rows Found!");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void ManageEvaluation_Load(object sender, EventArgs e)
        {
            UpdateEvaluation.Hide();
            try
            {
                SqlConnection con = new SqlConnection(conURL);
                con.Open();
                string q1 = "Select Id,Name,TotalMarks,TotalWeightage from Evaluation ";
                SqlCommand i = new SqlCommand(q1, con);
                SqlDataAdapter ad = new SqlDataAdapter(q1, con);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["Delete"].DisplayIndex = 5;
                dataGridView1.Columns["Update"].DisplayIndex = 4;
                dataGridView1.Columns["Id"].Visible = false;

                DataGridViewButtonColumn c = (DataGridViewButtonColumn)dataGridView1.Columns["Delete"];
                c.FlatStyle = FlatStyle.Popup;
                c.DefaultCellStyle.ForeColor = Color.WhiteSmoke;
                c.DefaultCellStyle.BackColor = Color.Crimson;

                DataGridViewButtonColumn c1 = (DataGridViewButtonColumn)dataGridView1.Columns["Update"];
                c1.FlatStyle = FlatStyle.Popup;
                c1.DefaultCellStyle.ForeColor = Color.WhiteSmoke;
                c1.DefaultCellStyle.BackColor = Color.Crimson;


                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

           
        }

        private void circularButton5_Click(object sender, EventArgs e)
        {

            name1.Clear();
            totalmarks1.Clear();

            totalweightage1.Clear();
        }

        private void circularButton1_Click(object sender, EventArgs e)
        {

            try
            {
                Evaluation p = new Evaluation();
                p.SetName(name1.Text);
                p.setTotalMarks(totalmarks1.Text);
                p.setTotalWeitage(totalweightage1.Text);
                bool i = false, j = false, k = false;
                if (p.GetName() == null)
                {
                    i = true;
                }
                if (p.getTotalMarks() == null)
                {
                    j = true;
                }
                if (p.getTotalweightage() == null)
                {
                    k = true;
                }
                if (i == true || j == true || k == true)
                {
                    MessageBox.Show("Please Enter Valid Input");
                }
                else
                {
                    SqlConnection conn = new SqlConnection(conURL);
                    MessageBox.Show("ALL DATA SUCESSFULLY ENTERED!");
                    conn.Open();
                    string query = "Insert into Evaluation (Name,TotalMarks,TotalWeightage) Values('" + name1.Text + "','" + Convert.ToInt32(totalmarks1.Text) + "','" + Convert.ToInt32(totalweightage1.Text) + "')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    int affectedRowsOfProject = cmd.ExecuteNonQuery();
                    MessageBox.Show(affectedRowsOfProject + "rows inserted in Evaluation!");
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void circularButton3_Click(object sender, EventArgs e)
        {
            this.Close();
            FYPM k = new FYPM();
            k.Show();
        }

        private void circularButton2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(conURL);
                con.Open();
                string q1 = "Select Id,Name,TotalMarks,TotalWeightage from Evaluation ";
                SqlCommand i = new SqlCommand(q1, con);
                SqlDataAdapter ad = new SqlDataAdapter(q1, con);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["Delete"].DisplayIndex = 5;
                dataGridView1.Columns["Update"].DisplayIndex = 4;
                //dataGridView1.Columns["Id"].Visible = false;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void circularButton7_Click(object sender, EventArgs e)
        {
            UName.Clear();
            Utm.Clear();

            Utw.Clear();
        }

        private void circularButton4_Click(object sender, EventArgs e)
        {

            try
            {
                Evaluation s1 = new Evaluation();
                s1.SetName(UName.Text);
                s1.setTotalMarks(Utm.Text);
                s1.setTotalWeitage(Utw.Text);
                if (UName.Text != " " && Utm.Text != " " && Utw.Text != " ")
                {
                    using (SqlConnection con = new SqlConnection(conURL))
                    {
                        con.Open();
                        int d = dataGridView1.CurrentCell.RowIndex;
                        int G = Convert.ToInt32(dataGridView1.Rows[d].Cells["Id"].Value);
                        string query = "select Name,TotalMarks,TotalWeightage from Evaluation where Id = '" + G + "'";
                        SqlCommand b = new SqlCommand(query, con);
                        string query1 = "UPDATE Evaluation SET Name = '" + UName.Text + "', TotalMarks = '" + Convert.ToInt32(Utm.Text) + "' ,TotalWeightage='" + Convert.ToInt32(Utw.Text) + "' where Id = '" + G + "'";
                        SqlCommand cmd = new SqlCommand(query1, con);
                        int f = cmd.ExecuteNonQuery();
                        MessageBox.Show("Record Updated Successfully in Evaluation");
                        con.Close();
                        UpdateEvaluation.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Please Provide Details");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void circularButton6_Click(object sender, EventArgs e)
        {
            UName.Clear();
            Utm.Clear();

            Utw.Clear();
            UpdateEvaluation.Hide();
        }
    }
}
