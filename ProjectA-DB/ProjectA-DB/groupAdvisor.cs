using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectA_DB
{
    public partial class groupAdvisor : Form
    {
        string conURL = "Data Source=DESKTOP-OF558HL\\SQLEXPRESS;Initial Catalog=ProjectA;Integrated Security=True;";
        public groupAdvisor()
        {
            InitializeComponent();
            fillCombo6();
        }
        void fillCombo6()
        {
            string query = "select Value from Lookup where Category = 'ADVISOR_ROLE'";
            SqlConnection con = new SqlConnection(conURL);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr;
            try
            {
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string category = dr.GetString(0);
                    comboBox6.Items.Add(category);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void groupAdvisor_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conURL);
            con.Open();
            string query4 = "Select p.Id ,p.FirstName,p.LastName, Designation from Advisor as a join Person as p on a.Id = p.Id except select AdvisorId,FirstName,LastName,Designation from ProjectAdvisor join Person as p on p.Id = AdvisorId join Advisor as d on d.Id = p.Id;";
            SqlCommand b = new SqlCommand(query4, con);
            SqlDataAdapter ad = new SqlDataAdapter(query4, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["AssignAdvisor"].DisplayIndex = 4;
            dataGridView1.Columns["Id"].Visible = false;
            
           
            con.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               if(comboBox6.Text != "")
               {
                    int d1 = dataGridView1.CurrentCell.RowIndex;
                    bool k1 = dataGridView1.Rows[d1].Cells["AssignAdvisor"].Selected;
                    if(dataGridView1.Rows.Count != 0)
                    {
                        if (k1 == true)
                        {
                            if (comboBox6.Text != "")
                            {
                                using (SqlConnection con = new SqlConnection(conURL))
                                {
                                    con.Open();
                                    string q = "Select max(Id) from [Group]";
                                    SqlCommand a = new SqlCommand(q, con);
                                    int w = (int)a.ExecuteScalar();

                                    string q1 = "Select max(ProjectId) from GroupProject";
                                    SqlCommand a1 = new SqlCommand(q1, con);
                                    int w1 = (int)a1.ExecuteScalar();

                                    string G1 = "ADVISOR_ROLE";
                                    string query1 = string.Format("Select Id from dbo.Lookup WHERE Category = @Category and Value = @Value");
                                    SqlCommand cmd1 = new SqlCommand(query1, con);
                                    cmd1.Parameters.Add(new SqlParameter("@Category", G1));
                                    cmd1.Parameters.Add(new SqlParameter("@Value", this.comboBox6.Text));
                                    int id1 = (int)cmd1.ExecuteScalar();

                                    int g = Convert.ToInt32(dataGridView1.Rows[d1].Cells["Id"].Value);

                                    string Q2 = String.Format("Insert into ProjectAdvisor(AdvisorId,ProjectId,AdvisorRole,AssignmentDate)Values('" + g + "','" + w1 + "','" + id1 + "','" + DateTime.Today + "') ");
                                    SqlCommand cmd2 = new SqlCommand(Q2, con);
                                    int k = cmd2.ExecuteNonQuery();
                                    MessageBox.Show(k + "rows inserted in Project Advisor!");
                                    dataGridView1.Rows.RemoveAt(d1);

                                    var choice = MessageBox.Show("Do You Want to Assign Another Advisor to group ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                    if (choice == DialogResult.Yes)
                                    {

                                    }
                                    if (dataGridView1.Rows.Count == 0)
                                    {
                                        MessageBox.Show("No more data to add");
                                        this.Close();
                                        groupS s = new groupS();
                                        s.Show();
                                    }
                                    else
                                    {
                                        this.Close();
                                        groupS s = new groupS();
                                        s.Show();
                                    }

                                    con.Close();
                                }


                            }
                            else
                            {
                                MessageBox.Show("Please select Advisor Role !");
                            }

                        }

                    }
                    else
                    {
                        MessageBox.Show("No data to assign");
                    }

                }
                else
                {
                    MessageBox.Show("Please select Advisor Role !");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            groupStudent g = new groupStudent();
            g.Show();
        }
    }
}
