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
using System.Configuration;

namespace ProjectA_DB
{
    public partial class groupStudent : Form
    {
        string conURL = "Data Source=DESKTOP-OF558HL\\SQLEXPRESS;Initial Catalog=ProjectA;Integrated Security=True;";
        public groupStudent()
        {
            InitializeComponent();
            dataGridView1.Hide();
            panel5.Hide();
            dataGridView2.Hide();
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            dataGridView3.Hide();
            comboBox6.Hide();
            label2.Hide();
            textBox1.Hide();
            dataGridView4.Hide();
            label6.Hide();
            fillCombo1();
            fillCombo6();
         
        }
        void fillCombo1()
        {
            string query = "select Id from [Group]";
            SqlConnection con = new SqlConnection(conURL);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr;
            try
            {
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int category = Convert.ToInt32(dr.GetValue(0));
                    comboBox1.Items.Add(category);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
        private void groupStudent_Load(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection con = new SqlConnection(conURL))
                {
                    con.Open();
                    string query4 = "select Id ,Title,Description from Project except select ProjectId ,Title,Description from GroupProject join Project on Id = ProjectId";
                    SqlCommand b = new SqlCommand(query4, con);
                    SqlDataAdapter ad = new SqlDataAdapter(query4, con);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns["AssignProject"].DisplayIndex = 3;
                    dataGridView1.Columns["Id"].Visible = false;
                    DataGridViewButtonColumn c8 = (DataGridViewButtonColumn)dataGridView1.Columns["AssignProject"];
                    c8.FlatStyle = FlatStyle.Popup;
                    c8.DefaultCellStyle.ForeColor = Color.WhiteSmoke;
                    c8.DefaultCellStyle.BackColor = Color.Crimson;
                    

                    string query5 = "Select p.Id ,p.FirstName,p.LastName, Designation from Advisor as a join Person as p on a.Id = p.Id except select AdvisorId,FirstName,LastName,Designation from ProjectAdvisor join Person as p on p.Id = AdvisorId join Advisor as d on d.Id = p.Id;";
                    SqlCommand b1 = new SqlCommand(query5, con);
                    SqlDataAdapter ad1 = new SqlDataAdapter(query5, con);
                    DataTable dt1 = new DataTable();
                    ad1.Fill(dt1);
                    dataGridView2.DataSource = dt1;
                    dataGridView2.Columns["advisor"].DisplayIndex = 4;
                    dataGridView2.Columns["Id"].Visible = false;
                    DataGridViewButtonColumn c1 = (DataGridViewButtonColumn)dataGridView2.Columns["advisor"];
                    c1.FlatStyle = FlatStyle.Popup;
                    c1.DefaultCellStyle.ForeColor = Color.WhiteSmoke;
                    c1.DefaultCellStyle.BackColor = Color.Crimson;


                    string query = "select p.Id , p.FirstName,p.LastName,s.RegistrationNo from Student as s join Person as p on p.Id = s.Id except select StudentId , FirstName,LastName,RegistrationNo from GroupStudent  join Student on Id = StudentId join Person as p on StudentId = p.Id; ";
                    using (SqlCommand c = new SqlCommand(query, con))
                    {
                        SqlDataAdapter ad2 = new SqlDataAdapter(query, con);
                        DataTable dt2 = new DataTable();
                        ad2.Fill(dt2);
                        dataGridView3.DataSource = dt2;
                        dataGridView3.Columns["AssignStudent"].DisplayIndex = 4;
                        dataGridView3.Columns["Id"].Visible = false;
                        DataGridViewButtonColumn c2 = (DataGridViewButtonColumn)dataGridView3.Columns["AssignStudent"];
                        c2.FlatStyle = FlatStyle.Popup;
                        c2.DefaultCellStyle.ForeColor = Color.WhiteSmoke;
                        c2.DefaultCellStyle.BackColor = Color.Crimson;
                    }

                    string query2 = "select Id ,Name,TotalMarks from Evaluation except select EvaluationId ,Name,TotalMarks from Evaluation join GroupEvaluation on EvaluationId = Id ";
                    
                    SqlCommand cmd = new SqlCommand(query2, con);
                    SqlDataAdapter ad7 = new SqlDataAdapter(query2, con);
                    DataTable dt7 = new DataTable();
                    ad7.Fill(dt7);
                    dataGridView4.DataSource = dt7;
                    dataGridView4.Columns["evaluation"].DisplayIndex = 3;
                    dataGridView4.Columns["Id"].Visible = false;

                    DataGridViewButtonColumn c3 = (DataGridViewButtonColumn)dataGridView4.Columns["evaluation"];
                    c3.FlatStyle = FlatStyle.Popup;
                    c3.DefaultCellStyle.ForeColor = Color.WhiteSmoke;
                    c3.DefaultCellStyle.BackColor = Color.Crimson;
                    con.Close();

                } //connection closed and disposed here

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
       
        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int d1 = dataGridView1.CurrentCell.RowIndex;
                bool k1 = dataGridView1.Rows[d1].Cells["AssignProject"].Selected;
                if(dataGridView1.Rows.Count != 0)
                {
                    if (k1 == true)
                    {
                        using (SqlConnection con = new SqlConnection(conURL))
                        {
                            con.Open();
                            string q = "Select max(Id) from [Group]";
                            SqlCommand a = new SqlCommand(q, con);
                            int w = (int)a.ExecuteScalar();

                            int g = Convert.ToInt32(dataGridView1.Rows[d1].Cells["Id"].Value);

                            string Q2 = String.Format("Insert into GroupProject(ProjectId,GroupId,AssignmentDate)Values('" + g + "','" + w + "','" + DateTime.Today + "') ");
                            SqlCommand cmd1 = new SqlCommand(Q2, con);
                            int k = cmd1.ExecuteNonQuery();
                            MessageBox.Show(k + "rows inserted in group project!");
                            //dataGridView1.Hide();
                            this.Close();
                            groupAdvisor h = new groupAdvisor();
                            h.Show();
                            con.Close();
                        }

                    }

                }
                else
                {
                    MessageBox.Show("No more projects available");
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void selectProject_Enter(object sender, EventArgs e)
        {
           
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
              
                    

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void selectAdvisor_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (comboBox1.Text != "" && comboBox6.Text != "")
                {
                    int d1 = dataGridView2.CurrentCell.RowIndex;
                    bool k1 = dataGridView2.Rows[d1].Cells["advisor"].Selected;
                    if (k1 == true)
                    {

                        using (SqlConnection con = new SqlConnection(conURL))
                        {
                            con.Open();
                            int gId = Convert.ToInt32(comboBox1.Text);

                            string query = "select ProjectId from GroupProject where GroupId = '" + gId + "'";
                            SqlCommand cmd = new SqlCommand(query, con);
                            int w = (int)cmd.ExecuteScalar();

                            string G1 = "ADVISOR_ROLE";
                            string query1 = string.Format("Select Id from dbo.Lookup WHERE Category = @Category and Value = @Value");
                            SqlCommand cmd1 = new SqlCommand(query1, con);
                            cmd1.Parameters.Add(new SqlParameter("@Category", G1));
                            cmd1.Parameters.Add(new SqlParameter("@Value", this.comboBox6.Text));
                            int id1 = (int)cmd1.ExecuteScalar();

                            int g = Convert.ToInt32(dataGridView2.Rows[d1].Cells["Id"].Value);

                            string Q2 = String.Format("Insert into ProjectAdvisor(AdvisorId,ProjectId,AdvisorRole,AssignmentDate)Values('" + g + "','" + w + "','" + id1 + "','" + DateTime.Today + "') ");
                            SqlCommand cmd2 = new SqlCommand(Q2, con);
                            int k = cmd2.ExecuteNonQuery();
                            MessageBox.Show(k + "rows inserted in Project Advisor!");
                            dataGridView2.Rows.RemoveAt(d1);

                            var choice = MessageBox.Show("Do You Want to Assign Another Advisor to group ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (choice == DialogResult.Yes)
                            {

                            }
                            if(dataGridView2.Rows.Count == 0)
                            {
                                MessageBox.Show("No more data to add");
                                dataGridView2.Hide();
                                panel1.Hide();
                                panel2.Show();
                                comboBox6.Hide();
                                label6.Hide();
                                dataGridView3.Show();
                            }
                            else
                            {
                                dataGridView2.Hide();
                                panel1.Hide();
                                panel2.Show();
                                comboBox6.Hide();
                                label6.Hide();
                                dataGridView3.Show();
                            }
                           
                            con.Close();
                        }
                        
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

        private void dataGridView3_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                int d1 = dataGridView3.CurrentCell.RowIndex;
                bool k1 = dataGridView3.Rows[d1].Cells["AssignStudent"].Selected;
                if (k1 == true)
                {
                    using (SqlConnection con = new SqlConnection(conURL))
                    {
                        con.Open();
                        if (DialogResult.Yes == MessageBox.Show("Are you sure you want to add this Student in group ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                        {

                            int d3 = dataGridView3.CurrentCell.RowIndex;
                            int gId = Convert.ToInt32(comboBox1.Text);

                            string G2 = "STATUS";
                            string status2 = "InActive";
                            string query2 = string.Format("Select Id from dbo.Lookup WHERE Category = @Category and Value = @Value");
                            SqlCommand cmd4 = new SqlCommand(query2, con);
                            cmd4.Parameters.Add(new SqlParameter("@Category", G2));
                            cmd4.Parameters.Add(new SqlParameter("@Value", status2));
                            int id4 = (int)cmd4.ExecuteScalar();

                            int g2 = Convert.ToInt32(dataGridView3.Rows[d3].Cells["Id"].Value);
                            string Q = String.Format("Insert into GroupStudent(GroupId ,StudentId,Status,AssignmentDate)Values('" + gId + "','" + g2 + "','" + id4 + "','" + DateTime.Today + "')");
                            SqlCommand cmd5 = new SqlCommand(Q, con);
                            int k3 = cmd5.ExecuteNonQuery();
                            MessageBox.Show(k3 + "rows inserted in group student!");
                            dataGridView3.Rows.RemoveAt(d3);
                            var choice = MessageBox.Show("Do You Want to Add Another Student to group ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (choice == DialogResult.Yes)
                            {

                            }
                            if (dataGridView3.Rows.Count == 0)
                            {
                                MessageBox.Show("No more data to add");
                                dataGridView3.Hide();
                                panel2.Hide();
                                panel3.Show();
                                dataGridView4.Show();
                                label2.Show();
                                textBox1.Show();
                            }
                            else
                            {
                                dataGridView3.Hide();
                                panel2.Hide();
                                panel3.Show();
                                dataGridView4.Show();
                                label2.Show();
                                textBox1.Show();
                            }



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

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                int d1 = dataGridView4.CurrentCell.RowIndex;
                bool k1 = dataGridView4.Rows[d1].Cells["evaluation"].Selected;
                if (k1 == true)
                {
                    if (textBox1.Text != "")
                    {
                        try
                        {
                            SqlConnection con = new SqlConnection(conURL);
                            con.Open();

                            int g = Convert.ToInt32(dataGridView4.Rows[d1].Cells["Id"].Value);
                            int gId = Convert.ToInt32(comboBox1.Text);

                            string Q2 = String.Format("Insert into GroupEvaluation(GroupId,EvaluationId,ObtainedMarks,EvaluationDate)Values('" + gId + "','" + g + "','" + Convert.ToInt32(textBox1.Text) + "','" + DateTime.Today + "') ");
                            SqlCommand cmd1 = new SqlCommand(Q2, con);
                            int k = cmd1.ExecuteNonQuery();
                            MessageBox.Show(k + "rows inserted in Group Evaluation!");
                            dataGridView4.Rows.RemoveAt(d1);

                            var choice = MessageBox.Show("Do You Want to Add Another group Evaluation ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (choice == DialogResult.Yes)
                            {

                            }
                            if(dataGridView4.Rows.Count == 0)
                            {
                                MessageBox.Show("No more data to add");

                                panel3.Hide();
                                dataGridView4.Hide();
                                label2.Hide();
                                textBox1.Hide();
                            }
                            else
                            {
                                panel3.Hide();
                                dataGridView4.Hide();
                                label2.Hide();
                                textBox1.Hide();
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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void circularButton4_Click(object sender, EventArgs e)
        {
            this.Close();
            FYPM k = new FYPM();
            k.Show();
        }

        private void circularButton5_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text != "")
            {
                panel1.Show();
                dataGridView2.Show();
                comboBox6.Show();
                label6.Show();
            }
        }

        private void circularButton6_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(conURL);
                conn.Open();
                string query = "INSERT INTO [Group](Created_On) Values('" + DateTime.Today + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                int affectedRowsOfProject = cmd.ExecuteNonQuery();
                MessageBox.Show(affectedRowsOfProject + "rows inserted in Group!");
                panel5.Show();
                dataGridView1.Show();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
