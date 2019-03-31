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
    public partial class ManageProject : Form
    {
        string conURL = "Data Source=DESKTOP-OF558HL\\SQLEXPRESS;Initial Catalog=ProjectA;Integrated Security=True";
        public ManageProject()
        {
            InitializeComponent();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ProjectTitle1.Clear();
            textBox1.Text = "";
           
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            ProjectTitle1.Clear();
            textBox1.Text = "";
            FYPM o = new FYPM();
            o.Show();
            this.Hide();

        }

        private void Submit_Click(object sender, EventArgs e)
        {
           
        }

        /*private void Back_Click(object sender, EventArgs e)
        {
            FYPM g = new FYPM();
            g.Show();
            this.Close();
        }
        */
        private void Retrieve_Click(object sender, EventArgs e)
        {
           
        }

        private void ManageProject_Load(object sender, EventArgs e)
        {
            UpdateProject.Hide();
            try
            {
                SqlConnection con = new SqlConnection(conURL);
                con.Open();
                string q1 = "Select Id,Description,Title from Project ";
                SqlCommand i = new SqlCommand(q1, con);
                SqlDataAdapter ad = new SqlDataAdapter(q1, con);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["Delete"].DisplayIndex = 4;
                dataGridView1.Columns["Update"].DisplayIndex = 3;
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
                            string Q2 = String.Format("Delete from Project where Id = '" + G + "'");
                            SqlCommand cmd1 = new SqlCommand(Q2, con);
                            int k = cmd1.ExecuteNonQuery();
                            MessageBox.Show(k + "rows deleted from Project!");
                            con.Close();
                            dataGridView1.Rows.RemoveAt(d);
                        }
                    }
                }
                else if (k2 == true)
                {
                    UpdateProject.Show();
                    try
                    {

                        using (SqlConnection con = new SqlConnection(conURL))
                        {
                            con.Open();
                            int d = dataGridView1.CurrentCell.RowIndex;
                            int G = Convert.ToInt32(dataGridView1.Rows[d].Cells["Id"].Value);
                            string q2 = "select Description,Title from Project where Id = '" + G + "' ";
                            SqlCommand cmd1 = new SqlCommand(q2, con);
                            SqlDataReader rdr = cmd1.ExecuteReader();
                            if (rdr.HasRows)
                            {
                                while (rdr.Read())
                                {
                                    //Id.Text = rdr.GetString(1);
                                    PTitle.Text = rdr.GetString(1);
                                    PDescription.Text = rdr.GetString(0);
                                }
                                con.Close();
                            }
                            else
                            {
                                MessageBox.Show("No rows Found!");
                            }
                        }
                    }catch(Exception ex)
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

        private void cancel_Click_1(object sender, EventArgs e)
        {
           
        }

        private void Clear_Click_1(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProjectTitle_Click(object sender, EventArgs e)
        {

        }

        private void ProjectDescription_Click(object sender, EventArgs e)
        {

        }

        private void ProjectTitle1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Update1_Click(object sender, EventArgs e)
        {
           
        }

        private void Clear1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
        }

        private void circularButton5_Click(object sender, EventArgs e)
        {

            ProjectTitle1.Clear();
            textBox1.Clear();
        }

        private void circularButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Project p = new Project();
                p.setTitle(ProjectTitle1.Text);
                p.setDescription(textBox1.Text);
                bool i = false, j = false;
                if (p.GetTitle() == null)
                {
                    i = true;
                }
                if (p.GeDescription() == null)
                {
                    j = true;
                }
                if (i == true || j == true)
                {
                    MessageBox.Show("Please Enter Valid Input");
                }
                else
                {
                    SqlConnection conn = new SqlConnection(conURL);
                    MessageBox.Show("ALL DATA SUCESSFULLY ENTERED!");
                    conn.Open();
                    string query = "Insert into Project (Description,Title) Values('" + textBox1.Text + "','" + ProjectTitle1.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    int affectedRowsOfProject = cmd.ExecuteNonQuery();
                    MessageBox.Show(affectedRowsOfProject + "rows inserted in Project!");
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void circularButton2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(conURL);
                con.Open();
                string q1 = "Select Id,Description,Title from Project ";
                SqlCommand i = new SqlCommand(q1, con);
                SqlDataAdapter ad = new SqlDataAdapter(q1, con);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["Delete"].DisplayIndex = 4;
                dataGridView1.Columns["Update"].DisplayIndex = 3;
                dataGridView1.Columns["Id"].Visible = false;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void circularButton3_Click(object sender, EventArgs e)
        {
            ProjectTitle1.Clear();
            textBox1.Clear();
            this.Close();
            FYPM k = new FYPM();
            k.Show();
        }

        private void circularButton7_Click(object sender, EventArgs e)
        {
            PTitle.Clear();
            PDescription.Clear();
        }

        private void circularButton4_Click(object sender, EventArgs e)
        {
            try
            {
                Project s1 = new Project();
                s1.setTitle(PTitle.Text);
                s1.setDescription(textBox1.Text);
                if (PTitle.Text != " " && PDescription.Text != " ")
                {
                    using (SqlConnection con = new SqlConnection(conURL))
                    {
                        con.Open();
                        int d = dataGridView1.CurrentCell.RowIndex;
                        int G = Convert.ToInt32(dataGridView1.Rows[d].Cells["Id"].Value);
                        string query = "select Description,Title from Project where Id = '" + G + "'";
                        SqlCommand b = new SqlCommand(query, con);
                        string query1 = "UPDATE Project SET Description = '" + PDescription.Text + "',Title = '" + PTitle.Text + "' where Id = '" + G + "'";
                        SqlCommand cmd = new SqlCommand(query1, con);
                        int f = cmd.ExecuteNonQuery();
                        MessageBox.Show("Record Updated Successfully in Person");
                        con.Close();
                        UpdateProject.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("please provide details");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void circularButton6_Click(object sender, EventArgs e)
        {

            PTitle.Clear();
            PDescription.Clear();
            UpdateProject.Hide();
        }
    }
}
