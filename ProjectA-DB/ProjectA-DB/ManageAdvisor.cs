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
    public partial class ManageAdvisor : Form
    {
        string conString = "Data Source=DESKTOP-OF558HL\\SQLEXPRESS;Initial Catalog=ProjectA;Integrated Security=True";
        public ManageAdvisor()
        {
            InitializeComponent();
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
                        using (SqlConnection con = new SqlConnection(conString))
                        {
                            int d = dataGridView1.CurrentCell.RowIndex;

                            //int n = dataGridView1.Rows.Add();
                            con.Open();
                            int G = Convert.ToInt32(dataGridView1.Rows[d].Cells["ID"].Value);
                            string query = "select Id From Person where Id = @Id";
                            SqlCommand b = new SqlCommand(query, con);
                            b.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int));
                            b.Parameters["@Id"].Value = G;
                            // cmd.Parameters.Add(new SqlParameter("@Value", this.Gender1.Text));
                            int w = (int)b.ExecuteScalar();

                            string Q2 = String.Format("Delete from Advisor where Id = @Id");
                            SqlCommand cmd1 = new SqlCommand(Q2, con);
                            cmd1.Parameters.Add(new SqlParameter("@Id", G));
                            // b.Parameters["@ID"].Value = w;
                            int k = cmd1.ExecuteNonQuery();
                            MessageBox.Show(k + "rows deleted from Advisor!");

                            string Q1 = String.Format("Delete from Person where Id = @Id");
                            SqlCommand cmd = new SqlCommand(Q1, con);
                            cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int));
                            cmd.Parameters["@Id"].Value = w;
                            int h = cmd.ExecuteNonQuery();
                            MessageBox.Show(h + "rows Deleted from Person!");
                            con.Close();
                            dataGridView1.Rows.RemoveAt(d);
                            MessageBox.Show("Row Deleted");
                        }
                    }

                }

                else if (k2 == true)
                {
                    UpdateAdvisorData.Show();
                    try
                    {

                        using (SqlConnection con = new SqlConnection(conString))
                        {
                            con.Open();
                            int d = dataGridView1.CurrentCell.RowIndex;
                            int G = Convert.ToInt32(dataGridView1.Rows[d].Cells["Id"].Value);
                            string query = String.Format("Select p.FirstName,p.LastName,p.Contact,p.Email,p.DateOfBirth,p.Gender,s.Designation,s.Salary from Person as p Inner join Advisor as s on p.Id = s.Id where p.Id = @Id");
                            SqlCommand cmd1 = new SqlCommand(query, con);
                            cmd1.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int));
                            cmd1.Parameters["@Id"].Value = G;
                            SqlDataReader rdr = cmd1.ExecuteReader();
                            if (rdr.HasRows)
                            {
                                while (rdr.Read())
                                {
                                    UFirstName1.Text = rdr.GetString(0);
                                    ULastANme1.Text = rdr.GetString(1);
                                    UContact1.Text = rdr.GetString(2);
                                    UEmail1.Text = rdr.GetString(3);
                                    dateTimePicker1.Value = Convert.ToDateTime(rdr.GetValue(4));
                                    if (Convert.ToInt32(rdr.GetValue(5)) == 2)
                                    {
                                        UGender1.Text = "Female";
                                    }
                                    else
                                    {
                                        UGender1.Text = "Male";
                                    }
                                    if (Convert.ToInt32(rdr.GetValue(6)) == 6)
                                    {
                                        UDesignation.Text = "Professor";
                                    }
                                    else if(Convert.ToInt32(rdr.GetValue(6)) == 7)
                                    {
                                        UDesignation.Text = "Associate Professor";
                                    }
                                    else if(Convert.ToInt32(rdr.GetValue(6)) == 8)
                                    {
                                        UDesignation.Text = " Assistant Professor";
                                    }
                                    else if (Convert.ToInt32(rdr.GetValue(6)) == 9)
                                    {
                                        UDesignation.Text = " Lecturer";
                                    }
                                    else
                                    {
                                        UDesignation.Text = " Industry Professional";
                                    }
                                    Usalary1.Text = Convert.ToString(rdr.GetDecimal(7));
                                }
                            }
                            else
                            {
                                MessageBox.Show("No rows found");
                            }
                            con.Close();
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

        private void creat_Click(object sender, EventArgs e)
        {
            AddAdvisorInformation k = new AddAdvisorInformation();
            k.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                string query = "Select p.Id, p.FirstName,p.LastName,p.Contact,p.Email,p.DateOfBirth,p.Gender,s.Designation ,s.Salary from Person as p Inner join Advisor as s on p.Id = s.Id ";
                SqlCommand b = new SqlCommand(query, con);
                SqlDataAdapter ad = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["Delete"].DisplayIndex = 10;
                dataGridView1.Columns["Update"].DisplayIndex = 9;
                dataGridView1.Columns["Id"].Visible = false;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ManageAdvisor_Load(object sender, EventArgs e)
        {
            UpdateAdvisorData.Hide();

            try
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                string query = "Select p.Id, p.FirstName,p.LastName,p.Contact,p.Email,p.DateOfBirth,p.Gender,s.Designation ,s.Salary from Person as p Inner join Advisor as s on p.Id = s.Id ";
                SqlCommand b = new SqlCommand(query, con);
                SqlDataAdapter ad = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["Delete"].DisplayIndex = 10;
                dataGridView1.Columns["Update"].DisplayIndex = 9;
                dataGridView1.Columns["Id"].Visible = false;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            FYPM o = new FYPM();
            o.Show();
            this.Hide();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            UFirstName1.Clear();
            ULastANme1.Clear();
            // RegistrationNumber1.Text = "";
            UContact1.Text = "";
            UEmail1.Text = "";
            UGender1.Text = "";
            dateTimePicker1.Text = "";
            UDesignation.Text = "";
            Usalary1.Text = "";
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            UFirstName1.Clear();
            ULastANme1.Clear();
            // RegistrationNumber1.Text = "";
            UContact1.Text = "";
            UEmail1.Text = "";
            UGender1.Text = "";
            dateTimePicker1.Text = "";
            UDesignation.Text = "";
            Usalary1.Text = "";
            UpdateAdvisorData.Hide();
        }

        private void Update1_Click(object sender, EventArgs e)
        {
            int lookup_idd = 0;

            try
            {
                Advisor s1 = new Advisor();
                s1.setFirstName(UFirstName1.Text);
                s1.setLastName(ULastANme1.Text);
                s1.setContact(UContact1.Text);
                s1.setEmail(UEmail1.Text);
                s1.setDOB(dateTimePicker1.Value);
                s1.setGender(UGender1.Text);
                s1.setDesignation(UDesignation.Text);
                s1.setSalary(Usalary1.Text);
                bool i = false, j = false, k = false, l = false, m = false, n = false, o = false, p = false;
                if (s1.getFirstName() == null)
                {
                    i = true;
                }
                if (s1.getLastName() == null)
                {
                    j = true;
                }
                if (s1.getContact() == null)
                {
                    k = true;
                }
                if (s1.GetEmail() == null)
                {
                    l = true;
                }
                if (s1.getGender() == null)
                {
                    m = true;
                }
                if (s1.GetDOB() == null)
                {
                    n = true;
                }
                if (s1.getDesignation() == null)
                {
                    o = true;
                }
                if (s1.getSalary() == null)
                {
                    p = true;
                }
                if (i == true || j == true || k == true || l == true || m == true || n == true || o == true || p == true)
                {
                    MessageBox.Show("Please Enter valid Input");
                }
                else
                {
                    if (UFirstName1.Text != " " && ULastANme1.Text != " " && UContact1.Text != " " && UEmail1.Text != " " && dateTimePicker1.Text != " " && UGender1.Text != " " && UDesignation.Text != "" && Usalary1.Text != "")
                    {
                        using (SqlConnection con = new SqlConnection(conString))
                        {
                            con.Open();
                            int d = dataGridView1.CurrentCell.RowIndex;
                            int G = Convert.ToInt32(dataGridView1.Rows[d].Cells["ID"].Value);
                            string query = "select p.Id From Person as p join Advisor s on p.Id = s.Id where p.Id = @Id";
                            SqlCommand b = new SqlCommand(query, con);
                            b.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int));
                            b.Parameters["@Id"].Value = G;
                            int w = (int)b.ExecuteScalar();


                            string G2 = "GENDER";
                            string query2 = string.Format("Select Id from dbo.Lookup WHERE Category = @Category and Value = @Value");
                            SqlCommand cmd2 = new SqlCommand(query2, con);
                            cmd2.Parameters.Add(new SqlParameter("@Category", G2));
                            cmd2.Parameters.Add(new SqlParameter("@Value", this.UGender1.Text));
                            lookup_idd = (int)cmd2.ExecuteScalar();

                            string G1 = "DESIGNATION";
                            string query1 = string.Format("Select Id from dbo.Lookup WHERE Category = @Category and Value = @Value");
                            SqlCommand cmd1 = new SqlCommand(query1, con);
                            cmd1.Parameters.Add(new SqlParameter("@Category", G1));
                            cmd1.Parameters.Add(new SqlParameter("@Value", this.UDesignation.Text));
                            int id1 = (int)cmd1.ExecuteScalar();

                            string query3 = "UPDATE Person SET FirstName = '" + UFirstName1.Text + "',LastName = '" + ULastANme1.Text + "',Contact = '" + UContact1.Text + "',Email = '" + UEmail1.Text + "',DateOfBirth = '" + Convert.ToDateTime(dateTimePicker1.Value) + "',Gender = '" + lookup_idd + "' where Id = " + G;

                            SqlCommand cmd = new SqlCommand(query3, con);

                            int f = cmd.ExecuteNonQuery();
                            MessageBox.Show("Record Updated Successfully in Person");

                            string query4 = "UPDATE Advisor SET Id = '" + G + "',Designation = '" + id1 + "',Salary = '" + Convert.ToDecimal(Usalary1.Text) + "' where Id = " + G;


                            SqlCommand cmd3 = new SqlCommand(query3, con);

                            int s = cmd3.ExecuteNonQuery();
                            MessageBox.Show("Record Updated Successfully in Advisor");

                            UpdateAdvisorData.Hide();

                            con.Close();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Provide Details!");
                    }
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

