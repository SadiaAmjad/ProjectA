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
    public partial class groupS : Form
    {
        string conURL = "Data Source=DESKTOP-OF558HL\\SQLEXPRESS;Initial Catalog=ProjectA;Integrated Security=True;";
        public groupS()
        {
            InitializeComponent();
        }

        private void groupS_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conURL))
                {

                    connection.Open();
                    string query = "select p.Id , p.FirstName,p.LastName,s.RegistrationNo from Student as s join Person as p on p.Id = s.Id except select StudentId , FirstName,LastName,RegistrationNo from GroupStudent  join Student on Id = StudentId join Person as p on StudentId = p.Id; ";
                    using (SqlCommand c = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter ad = new SqlDataAdapter(query, connection);
                        DataTable dt = new DataTable();
                        ad.Fill(dt);
                        dataGridView1.DataSource = dt;
                        dataGridView1.Columns["AssignStudent"].DisplayIndex = 4;
                        dataGridView1.Columns["Id"].Visible = false;
                    }
                    connection.Close();
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int d1 = dataGridView1.CurrentCell.RowIndex;
                bool k1 = dataGridView1.Rows[d1].Cells["AssignStudent"].Selected;
                if (k1 == true)
                {
                    using (SqlConnection con = new SqlConnection(conURL))
                    {
                        con.Open();
                        if (DialogResult.Yes == MessageBox.Show("Are you sure you want to add this Student in group ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                        {

                            int d3 = dataGridView1.CurrentCell.RowIndex;
                            string q2 = "Select max(Id) from [Group]";
                            SqlCommand a2 = new SqlCommand(q2, con);
                            int w2 = (int)a2.ExecuteScalar();

                            string G2 = "STATUS";
                            string status2 = "InActive";
                            string query2 = string.Format("Select Id from dbo.Lookup WHERE Category = @Category and Value = @Value");
                            SqlCommand cmd4 = new SqlCommand(query2, con);
                            cmd4.Parameters.Add(new SqlParameter("@Category", G2));
                            cmd4.Parameters.Add(new SqlParameter("@Value", status2));
                            int id4 = (int)cmd4.ExecuteScalar();

                            int g2 = Convert.ToInt32(dataGridView1.Rows[d3].Cells["Id"].Value);
                            string Q = String.Format("Insert into GroupStudent(GroupId ,StudentId,Status,AssignmentDate)Values('" + w2 + "','" + g2 + "','" + id4 + "','" + DateTime.Today + "')");
                            SqlCommand cmd5 = new SqlCommand(Q, con);
                            int k3 = cmd5.ExecuteNonQuery();
                            MessageBox.Show(k3 + "rows inserted in group student!");
                            dataGridView1.Rows.RemoveAt(d3);
                            goto label1;
                            
                        }
                    label1:
                            var choice = MessageBox.Show("Do You Want to add more Students to group ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if(choice == DialogResult.Yes)
                            {
                               
                            }
                            else
                            {
                                this.Close();
                                groupEvaluation e1 = new groupEvaluation();
                                e1.Show();
                            }

                       
                     con.Close();
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
            this.Close();
            groupStudent n = new groupStudent();
            n.Show();
        }
    }
}
