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
            ProjectDescription.Text = "";
           
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            ProjectTitle1.Clear();
            ProjectDescription.Text = "";
            FYPM o = new FYPM();
            o.Show();
            this.Hide();

        }

        private void Submit_Click(object sender, EventArgs e)
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
                    string query = "Insert into Project (Description,Title) Values('"+textBox1.Text+"','"+ProjectTitle1.Text+"')";
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

        private void Back_Click(object sender, EventArgs e)
        {
            FYPM g = new FYPM();
            g.Show();
            this.Hide();
        }

        private void Retrieve_Click(object sender, EventArgs e)
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            ProjectTitle1.Clear();
            textBox1.Clear();
            this.Hide();
            FYPM k = new FYPM();
            k.Show();
        }

        private void Clear_Click_1(object sender, EventArgs e)
        {
            ProjectTitle1.Clear();
            textBox1.Clear();
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

        private void Clear1_Click(object sender, EventArgs e)
        {
            PTitle.Clear();
            PDescription.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PTitle.Clear();
            PDescription.Clear();
            UpdateProject.Hide();
        }
    }
}
