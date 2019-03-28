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
    public partial class AddInformation : Form
    {
        string conURL = "Data Source=DESKTOP-OF558HL\\SQLEXPRESS;Initial Catalog=ProjectA;Integrated Security=True";
        
        public AddInformation()
        {
            InitializeComponent();
            //this.Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddInformation_Load(object sender, EventArgs e)
        {
            //this.Show()
      
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            
        }

        private void clear_Click(object sender, EventArgs e)
        {

           
        }

        private void Submit_Click(object sender, EventArgs e)
        {

        }

        private void cancel1_Click(object sender, EventArgs e)
        {
            
            /*FirstName1.Clear();
            LastANme1.Clear();
            RegistrationNumber1.Text = "";
            Contact1.Text = "";
            Email1.Text = "";
            Gender1.Text = "";
            dateTimePicker1.Text = "";
            //this.Hide();
            ManageStudent o = new ManageStudent();
            o.Show();
            this.Hide();*/
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            FirstName1.Clear();
            LastANme1.Clear();
            RegistrationNumber1.Text = "";
            Contact1.Text = "";
            Email1.Text = "";
            Gender1.Text = "";
            dateTimePicker1.Text = "";
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

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
                    SqlConnection conn = new SqlConnection(conURL);
                    MessageBox.Show("ALL DATA SUCESSFULLY ENTERED!");
                    conn.Open();
                    string G = "GENDER";
                    string query = string.Format("Select Id from dbo.Lookup WHERE Category = @Category and Value = @Value");
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.Add(new SqlParameter("@Category", G));
                    cmd.Parameters.Add(new SqlParameter("@Value", this.Gender1.Text));
                    int id = (int)cmd.ExecuteScalar();

                    string Query = "INSERT INTO Person(FirstName,LastName,Contact,Email,DateOfBirth,Gender) VALUES(@FirstName,@LastName,@Contact,@Email ,@DateOfBirth ,@Gender)";
                    using (SqlConnection cnn = new SqlConnection(conURL))
                    {
                        cnn.Open();
                        SqlCommand Cmd = new SqlCommand(Query, cnn);
                        Cmd.Parameters.AddWithValue("@FirstName", FirstName1.Text);
                        Cmd.Parameters.AddWithValue("@LastName", LastANme1.Text);
                        Cmd.Parameters.AddWithValue("@Contact", Contact1.Text);
                        Cmd.Parameters.AddWithValue("@Email", Email1.Text);
                        Cmd.Parameters.AddWithValue("@DateOfBirth", dateTimePicker1.Value);
                        Cmd.Parameters.AddWithValue("@Gender", id);
                        //Cmd.Parameters.AddWithValue("@RegistrationNumber", RegistrationNumber1.Text);
                        int affectedRowsOfPerson = Cmd.ExecuteNonQuery();
                        MessageBox.Show(affectedRowsOfPerson + "rows inserted in Person!");
                        cnn.Close();
                    }
                    string q = "Select max(Id) from Person";
                    SqlCommand a = new SqlCommand(q, conn);
                    int w = (int)a.ExecuteScalar();

                    string q1 = "Insert into Student(Id,RegistrationNo) values('" + w + "','" + RegistrationNumber1.Text + "')";
                    SqlCommand h = new SqlCommand(q1, conn);
                    int affectedRowsOfStudent = h.ExecuteNonQuery();
                    MessageBox.Show(affectedRowsOfStudent + "rows inserted in Student!");
                    conn.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            ManageStudent s = new ManageStudent();
            s.Show();
        }
    }
    
}
