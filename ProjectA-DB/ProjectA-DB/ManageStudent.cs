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
    public partial class ManageStudent : Form
    {
        string conString = "Data Source=DESKTOP-OF558HL\\SQLEXPRESS;Initial Catalog=ProjectA;Integrated Security=True";
        public ManageStudent()
        {
            InitializeComponent();
        }

        private void creat_Click(object sender, EventArgs e)
        {
            AddInformation o = new AddInformation();
            o.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                string query = "Select p.Id, p.FirstName,p.LastName,p.Contact,p.Email,p.DateOfBirth,p.Gender,s.RegistrationNo from Person as p Inner join Student as s on p.Id = s.Id ";
                SqlCommand b = new SqlCommand(query, con);
                SqlDataAdapter ad = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["Delete"].DisplayIndex = 9;
                dataGridView1.Columns["Update"].DisplayIndex = 8;
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

                            string Q2 = String.Format("Delete from Student where Id = @Id");
                            SqlCommand cmd1 = new SqlCommand(Q2, con);
                            cmd1.Parameters.Add(new SqlParameter("@Id", G));
                            // b.Parameters["@ID"].Value = w;
                            int k = cmd1.ExecuteNonQuery();
                            MessageBox.Show(k + "rows deleted from Student!");

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
                    UpdateData.Show();
                    try
                    {

                        using (SqlConnection con = new SqlConnection(conString))
                        {
                            con.Open();
                            int d = dataGridView1.CurrentCell.RowIndex;
                            int G = Convert.ToInt32(dataGridView1.Rows[d].Cells["Id"].Value);
                            string query = String.Format("Select p.Id, p.FirstName,p.LastName,p.Contact,p.Email,p.DateOfBirth,p.Gender,s.RegistrationNo from Person as p Inner join Student as s on p.Id = s.Id where p.Id = @Id");
                            SqlCommand cmd1 = new SqlCommand(query, con);
                            cmd1.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int));
                            cmd1.Parameters["@Id"].Value = G;
                            SqlDataReader rdr = cmd1.ExecuteReader();
                            if (rdr.HasRows)
                            {
                                while (rdr.Read())
                                {
                                    FirstName1.Text = rdr.GetString(1);
                                    LastANme1.Text = rdr.GetString(2);
                                    Contact1.Text = rdr.GetString(3);
                                    Email1.Text = rdr.GetString(4);
                                    dateTimePicker1.Value = Convert.ToDateTime(rdr.GetValue(5));
                                    if (Convert.ToInt32(rdr.GetValue(6)) == 2)
                                    {
                                        Gender1.Text = "Female";
                                    }
                                    else
                                    {
                                        Gender1.Text = "Male";
                                    }
                                    //Gender1.Text = rdr.GetValue(6);
                                    RegistrationNumber1.Text = rdr.GetString(7);
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

        private void UpdateData_Enter(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            FirstName1.Clear();
            LastANme1.Clear();
            RegistrationNumber1.Text = "";
            Contact1.Text = "";
            Email1.Text = "";
            Gender1.Text = "";
            dateTimePicker1.Text = "";
        }

        private void Update1_Click(object sender, EventArgs e)
        {

            int lookup_idd = 0;

            try
            {
                Student s1 = new Student();
                s1.setFirstName(FirstName1.Text);
                s1.setLastName(LastANme1.Text);
                s1.setContact(Contact1.Text);
                s1.setEmail(Email1.Text);
                s1.setDOB(dateTimePicker1.Value);
                s1.setGender(Gender1.Text);
                s1.setRegistartionNumber(RegistrationNumber1.Text);
                bool i = false, j = false, k = false, l = false, m = false, n = false, o = false;
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
                if (s1.getRegistrationNumber() == null)
                {
                    o = true;
                }
                if (i == true || j == true || k == true || l == true || m == true || n == true || o == true)
                {
                    MessageBox.Show("Please Enter Valid Input");
                }
                else
                {
                    if (FirstName1.Text != " " && LastANme1.Text != " " && Contact1.Text != " " && Email1.Text != " " && dateTimePicker1.Text != " " && RegistrationNumber1.Text != " ")
                    {
                        using (SqlConnection con = new SqlConnection(conString))
                        {
                            con.Open();
                            int d = dataGridView1.CurrentCell.RowIndex;
                            int G = Convert.ToInt32(dataGridView1.Rows[d].Cells["ID"].Value);
                            string query = "select p.Id From Person as p join Student s on p.Id = s.Id where p.Id = @Id";
                            SqlCommand b = new SqlCommand(query, con);
                            b.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int));
                            b.Parameters["@Id"].Value = G;
                            int w = (int)b.ExecuteScalar();


                            string G2 = "GENDER";
                            string query2 = string.Format("Select Id from dbo.Lookup WHERE Category = @Category and Value = @Value");
                            SqlCommand cmd2 = new SqlCommand(query2, con);
                            cmd2.Parameters.Add(new SqlParameter("@Category", G2));
                            cmd2.Parameters.Add(new SqlParameter("@Value", this.Gender1.Text));
                           lookup_idd= (int)cmd2.ExecuteScalar();
                            string query1 = "UPDATE Person SET FirstName = '" + FirstName1.Text + "',LastName = '" + LastANme1.Text + "',Contact = '" + Contact1.Text + "',Email = '" + Email1.Text + "',DateOfBirth = '" + Convert.ToDateTime(dateTimePicker1.Value) + "',Gender = '" + lookup_idd + "' where Id = "+G;
                           
                            SqlCommand cmd = new SqlCommand(query1, con);
                           
                            int f = cmd.ExecuteNonQuery();
                            MessageBox.Show("Record Updated Successfully in Person");

                            string query3 = "UPDATE Student SET Id = '"+G+"',RegistrationNo = '"+RegistrationNumber1.Text+"' where Id = "+G;
                            

                            SqlCommand cmd3 = new SqlCommand(query3, con);
                            
                            int s = cmd3.ExecuteNonQuery();
                            MessageBox.Show("Record Updated Successfully in Student");
                            
                            UpdateData.Hide();
                           
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

        private void cancel_Click(object sender, EventArgs e)
        {
            FirstName1.Clear();
            LastANme1.Clear();
            RegistrationNumber1.Text = "";
            Contact1.Text = "";
            Email1.Text = "";
            Gender1.Text = "";
            dateTimePicker1.Text = "";
            UpdateData.Hide();
        }

        private void ManageStudent_Load(object sender, EventArgs e)
        {
           
            //  dataGridView1.Columns[0].Visible = false;
            UpdateData.Hide();

            try
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                string query = "Select p.Id, p.FirstName,p.LastName,p.Contact,p.Email,p.DateOfBirth,p.Gender,s.RegistrationNo from Person as p Inner join Student as s on p.Id = s.Id ";
                SqlCommand b = new SqlCommand(query, con);

                /*   SqlDataReader rdr = b.ExecuteReader();
                   rdr.Read();
                   while (rdr.Read())
                   {
                       int n = dataGridView1.Rows.Add();


                       int cellNum = 0;
                       int rowNum = 0;
                       foreach (DataGridViewRow row in dataGridView1.Rows)
                       {
                           cellNum = cellNum + 1;
                           dataGridView1.Rows[rowNum].Cells[0].Value = cellNum;
                           rowNum = rowNum + 1;
                       }

                       dataGridView1.Rows[n].Cells[0].Value = rdr["Id"].ToString();
                       dataGridView1.Rows[n].Cells[1].Value = rdr["FirstName"].ToString();
                       dataGridView1.Rows[n].Cells[2].Value = rdr["LastName"].ToString();
                       dataGridView1.Rows[n].Cells[3].Value = rdr["Contact"].ToString();
                       dataGridView1.Rows[n].Cells[4].Value = rdr["Email"].ToString();
                       dataGridView1.Rows[n].Cells[5].Value = rdr["DateOfBirth"].ToString();
                       dataGridView1.Rows[n].Cells[6].Value = rdr["Gender"].ToString();
                       dataGridView1.Rows[n].Cells[7].Value = rdr["RegistrationNo"].ToString();

                       dataGridView1.Rows[n].Cells[0].Value = Convert.ToInt16(rdr.GetValue(0));
                       dataGridView1.Rows[n].Cells[1].Value = rdr.GetString(1);
                       dataGridView1.Rows[n].Cells[2].Value = rdr.GetString(2);
                       dataGridView1.Rows[n].Cells[3].Value = rdr.GetString(3);
                       dataGridView1.Rows[n].Cells[4].Value = rdr.GetString(4);
                       dataGridView1.Rows[n].Cells[5].Value = rdr.GetValue(5);
                       dataGridView1.Rows[n].Cells[6].Value = rdr.GetValue(6);
                       dataGridView1.Rows[n].Cells[7].Value = rdr.GetString(7);

                   }*/
                SqlDataAdapter ad = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
                //dt.Columns["FirstName"].ColumnName = "First Name";
                //dt.Columns["LastName"].ColumnName = "Last Name";

                //dt.Columns["DateOfBirth"].ColumnName = "Date Of Birth";
                //dt.Columns["Gender"].ColumnName = "Gender";
                dataGridView1.Columns["Delete"].DisplayIndex = 9;
                dataGridView1.Columns["Update"].DisplayIndex = 8;
                dataGridView1.Columns["Id"].Visible = false;
                con.Close();
                //string q = "select FirstName,LastName,Contact,Email,DateOfBirth,Gender,RegistrationNo from Person cross join Student";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Back_Click(object sender, EventArgs e)
        {
            FYPM h = new FYPM();
            h.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
