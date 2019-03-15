using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectA_DB
{
    class Advisor
    {
        private string FirstName;
        private string LastName;
        private string Contact;
        private string Email;
        private string gender;
        private DateTime DateOfBirth;
        private string Designation;
        private string salary;
        public string getSalary()
        {
            return salary;
        }
        public void setSalary(string Salary)
        {
            string expression = @"^\d+\.?\d*$";
            if (Regex.IsMatch(Salary, expression))
            {
                if (Regex.Replace(Salary, expression, string.Empty).Length == 0)
                {

                    salary = Salary;
                    //MessageBox.Show("Salary Entered Successfully");
                }
                else
                {

                    MessageBox.Show("Invalid Salary");
                }
            }
            else
            {

                MessageBox.Show("Invalid Salary");
            }

        }
        public string getDesignation()
        {
            return Designation;
        }
        public void setDesignation(string designation)
        {
            Designation = designation;
        }
        public string getGender()
        {
            return gender;
        }
        public void setGender(string Gender)
        {
            gender = Gender;
        }

        public DateTime GetDOB()
        {
            return DateOfBirth;
        }
        public void setDOB(DateTime value)
        {
            DateOfBirth = value;
        }
        public string getFirstName()
        {
            return FirstName;
        }
        /// <summary>
        /// it is the setter of Name attribute which sets the valid value of name.
        /// </summary>
        /// <param name="val"></param>
        public void setFirstName(string val)
        {
            bool f = false;
            foreach (char c in val)
            {
                if (!((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c == ' ')))
                {
                    f = true;
                }
            }
            if (f == true)
            {
                MessageBox.Show("Name should be Alphabetic,Enter Your Name once more!");
            }
            else
            {
                FirstName = val;
                //MessageBox.Show("First Name Successfully Entered!");

            }
        }
        public string getLastName()
        {
            return LastName;
        }
        /// <summary>
        /// it is the setter of Name attribute which sets the valid value of name.
        /// </summary>
        /// <param name="val"></param>
        public void setLastName(string val)
        {
            bool f = false;
            foreach (char c in val)
            {
                if (!((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c == ' ')))
                {
                    f = true;
                }
            }
            if (f == true)
            {
                MessageBox.Show("Name should be Alphabetic,Enter Your Name once more!");
            }
            else
            {
                LastName = val;
                //MessageBox.Show("Last Name Successfully Entered!");

            }
        }
        public string getContact()
        {
            return Contact;
        }
        public void setContact(string ContactNo)
        {
            string expresion;
            expresion = "^((\\+92)|(0092))-{0,1}3{1}\\d{2}-{0,1}\\d{7}$|^0{0,1}3{1}\\d{10}$|^0{0,1}3{1}\\d{2}-\\d{7}$";
            if (Regex.IsMatch(ContactNo, expresion))
            {
                if (Regex.Replace(ContactNo, expresion, string.Empty).Length == 0)
                {

                    Contact = ContactNo;
                  //  MessageBox.Show("Contact Entered Successfully");
                }
                else
                {
                    MessageBox.Show("Invalid contact");
                }
            }
            else
            {

                MessageBox.Show("Invalid Contact");
            }
        }
        public string GetEmail()
        {
            return Email;
        }
        public void setEmail(string email)
        {

            string expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, string.Empty).Length == 0)
                {

                    Email = email;
                    //MessageBox.Show("Email Entered Successfully");
                }
                else
                {

                    MessageBox.Show("Invalid Email");
                }
            }
            else
            {

                MessageBox.Show("Invalid Email");
            }
        }
    }
}
