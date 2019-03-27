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
    public partial class Group : Form
    {
        string conURL = "Data Source=DESKTOP-OF558HL\\SQLEXPRESS;Initial Catalog=ProjectA;Integrated Security=True;";
        public Group()
        {
            InitializeComponent();
            fillCombo1();
            fillCombo3();
            fillCombo8();
            fillCombo11();
            fillCombo5();
            fillCombo6();
            fillCombo16();
            fillCombo13();
            fillCombo14();
            fillCombo7();
          
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Hide();
            groupBox4.Hide();
            groupBox5.Hide();
            groupBox6.Hide();
            groupBox7.Hide();
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
        
        void fillCombo3()
        {
            string query = "select Id from Project except select ProjectId from GroupProject";
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
                    comboBox3.Items.Add(category);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        void fillCombo5()
        {
            string query = "select Id from Advisor";
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
                    comboBox5.Items.Add(category);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        void fillCombo13()
        {
            string query = "select Id from Advisor except select AdvisorId from ProjectAdvisor";
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
                    comboBox13.Items.Add(category);
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


        void fillCombo7()
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
                    comboBox7.Items.Add(category);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        void fillCombo8()
        {
            string query = "select Id from Evaluation";
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
                    comboBox8.Items.Add(category);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        void fillCombo14()
        {
            string query = "select Id from Evaluation except select EvaluationId from GroupEvaluation";
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
                    comboBox14.Items.Add(category);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        void fillCombo11()
        {
            string query = "select Id from Student except select StudentId from GroupStudent";
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
                    comboBox11.Items.Add(category);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        void fillCombo16()
        {
            string query = "select Id from Student except select StudentId from GroupStudent";
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
                    comboBox16.Items.Add(category);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void Group_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(conURL);
                conn.Open();
                string query = "INSERT INTO [Group](Created_On) Values('" + DateTime.Today + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                int affectedRowsOfProject = cmd.ExecuteNonQuery();
                MessageBox.Show(affectedRowsOfProject + "rows inserted in Group!");

                groupBox1.Show();


                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text != "")
            {
                groupBox5.Show();
                /*using (SqlConnection con = new SqlConnection(conURL))
                {
                    con.Open();
                    groupBox5.Show();
                 
                    con.Close();
                }*/
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                if (comboBox3.Text != "")
                {
                    SqlConnection con = new SqlConnection(conURL);
                    con.Open();
                    string q = "Select max(Id) from [Group]";
                    SqlCommand a = new SqlCommand(q, con);
                    int w = (int)a.ExecuteScalar();

                    string Q2 = String.Format("Insert into GroupProject(ProjectId,GroupId,AssignmentDate)Values('" + Convert.ToInt32(comboBox3.Text) + "','" + w + "','" + DateTime.Today + "') ");
                    SqlCommand cmd1 = new SqlCommand(Q2, con);
                    int k = cmd1.ExecuteNonQuery();
                    MessageBox.Show(k + "rows inserted in group project!");
                    groupBox1.Hide();
                    groupBox2.Show();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Please select the input");
                }
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int pId = Convert.ToInt32(comboBox3.Text);


                if (comboBox5.Text != "" || comboBox6.Text != "")
                {
                    SqlConnection con = new SqlConnection(conURL);
                    con.Open();

                    string q = "Select max(ProjectId) from GroupProject";
                    SqlCommand a = new SqlCommand(q, con);
                    int w = (int)a.ExecuteScalar();


                    string G = "ADVISOR_ROLE";
                    string query = string.Format("Select Id from dbo.Lookup WHERE Category = @Category and Value = @Value");
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(new SqlParameter("@Category", G));
                    cmd.Parameters.Add(new SqlParameter("@Value", this.comboBox6.Text));
                    int id = (int)cmd.ExecuteScalar();


                    string Q2 ="Insert into ProjectAdvisor(AdvisorId,ProjectId,AdvisorRole,AssignmentDate)Values('" + Convert.ToInt32(comboBox5.Text) + "','" + pId + "','"+id+"','" + DateTime.Today + "') ";
                    SqlCommand cmd1 = new SqlCommand(Q2, con);
                    int k = cmd1.ExecuteNonQuery();
                    MessageBox.Show(k + "rows inserted in project Advisor!");
                    groupBox2.Hide();
                    groupBox3.Show();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Please select the input");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Evaluation f = new Evaluation();
            f.setObtainedMarks(textBox2.Text);
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
                if (comboBox8.Text != "" || textBox2.Text != "")
                {
                    //int gId = Convert.ToInt32(comboBox2.Text);
                    SqlConnection con = new SqlConnection(conURL);
                    con.Open();

                    string q = "Select max(Id) from [Group]";
                    SqlCommand a = new SqlCommand(q, con);
                    int w = (int)a.ExecuteScalar();

                    string Q2 = String.Format("Insert into GroupEvaluation(GroupId,EvaluationId,ObtainedMarks,EvaluationDate)Values('" + w + "','" + Convert.ToInt32(comboBox8.Text) + "','"+Convert.ToInt32(textBox2.Text)+"','" + DateTime.Today + "') ");
                    SqlCommand cmd1 = new SqlCommand(Q2, con);
                    int k = cmd1.ExecuteNonQuery();
                    MessageBox.Show(k + "rows inserted in Group Evaluation!");
                    
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Please select the input");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox11.Text != "")
                {
                    SqlConnection con = new SqlConnection(conURL);
                    con.Open();

                    string q = "Select max(Id) from [Group]";
                    SqlCommand a = new SqlCommand(q, con);
                    int w = (int)a.ExecuteScalar();

                   // int gId = Convert.ToInt32(comboBox2.Text); 
                    string G = "STATUS";
                    string status = "Active";
                    string query = string.Format("Select Id from dbo.Lookup WHERE Category = @Category and Value = @Value");
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(new SqlParameter("@Category", G));
                    cmd.Parameters.Add(new SqlParameter("@Value", status));
                    int id = (int)cmd.ExecuteScalar();


                    string Q2 = String.Format("Insert into GroupStudent(GroupId,StudentId,Status,AssignmentDate)Values('" +w + "','" + Convert.ToInt32(comboBox11.Text) + "','"+id+"','" + DateTime.Today + "') ");
                    SqlCommand cmd1 = new SqlCommand(Q2, con);
                    int k = cmd1.ExecuteNonQuery();
                    MessageBox.Show(k + "rows inserted in group Student!");
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Please select the input");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            groupBox4.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            groupBox3.Hide();
            groupBox4.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                if(comboBox13.Text != "" || comboBox7.Text != "")
                {
                    SqlConnection con = new SqlConnection(conURL);
                    con.Open();
                    int k = Convert.ToInt32(comboBox1.Text);
                    string query = "select ProjectId from GroupProject where GroupId = '"+k+"'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    int w = (int)cmd.ExecuteScalar();


                    string G = "ADVISOR_ROLE";
                    string query1 = string.Format("Select Id from dbo.Lookup WHERE Category = @Category and Value = @Value");
                    SqlCommand cmd2 = new SqlCommand(query1, con);
                    cmd2.Parameters.Add(new SqlParameter("@Category", G));
                    cmd2.Parameters.Add(new SqlParameter("@Value", this.comboBox7.Text));
                    int id = (int)cmd2.ExecuteScalar();

                    string Q2 = "Insert into ProjectAdvisor(AdvisorId,ProjectId,AdvisorRole,AssignmentDate)Values('" + Convert.ToInt32(comboBox13.Text) + "','" + w + "','" + id + "','" + DateTime.Today + "') ";
                    SqlCommand cmd1 = new SqlCommand(Q2, con);
                    int k1 = cmd1.ExecuteNonQuery();
                    MessageBox.Show(k1 + "rows inserted in project Advisor!");
                    groupBox5.Hide();
                    groupBox6.Show();
                }
                else
                {
                    MessageBox.Show("Enter input");
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button11_Click(object sender, EventArgs e)
        {

            try
            {
                if (comboBox14.Text != "" || textBox1.Text != "")
                {
                    SqlConnection con = new SqlConnection(conURL);
                    con.Open();
                    int k = Convert.ToInt32(comboBox1.Text);


                    string Q2 = String.Format("Insert into GroupEvaluation(GroupId,EvaluationId,ObtainedMarks,EvaluationDate)Values('" + k + "','" + Convert.ToInt32(comboBox14.Text) + "','" + Convert.ToInt32(textBox1.Text) + "','" + DateTime.Today + "') ");
                    SqlCommand cmd1 = new SqlCommand(Q2, con);
                    int k1 = cmd1.ExecuteNonQuery();
                    MessageBox.Show(k1 + "rows inserted in Group Evaluation!");
                   
                }
                else
                {
                    MessageBox.Show("Enter input");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            groupBox6.Hide();
            groupBox7.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox16.Text != "")
                {
                    SqlConnection con = new SqlConnection(conURL);
                    con.Open();


                    int gId = Convert.ToInt32(comboBox1.Text); 
                    string G = "STATUS";
                    string status = "Active";
                    string query = string.Format("Select Id from dbo.Lookup WHERE Category = @Category and Value = @Value");
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(new SqlParameter("@Category", G));
                    cmd.Parameters.Add(new SqlParameter("@Value", status));
                    int id = (int)cmd.ExecuteScalar();


                    string Q2 = String.Format("Insert into GroupStudent(GroupId,StudentId,Status,AssignmentDate)Values('" + gId + "','" + Convert.ToInt32(comboBox16.Text) + "','" + id + "','" + DateTime.Today + "') ");
                    SqlCommand cmd1 = new SqlCommand(Q2, con);
                    int k = cmd1.ExecuteNonQuery();
                    MessageBox.Show(k + "rows inserted in group Student!");
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Please select the input");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            groupBox7.Hide();
        }
    }
}
