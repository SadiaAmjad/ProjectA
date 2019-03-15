using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectA_DB
{
    class Student
    {
        private string FirstName;
        private string LastName;
        private string Contact;
        private string Email;
        private string gender;
        private string registration_number;
        private DateTime DateOfBirth;

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
        public Student()
        {
            FirstName = null;
            registration_number = null;

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
            else if(val == "")
            {
                MessageBox.Show("Please Enter First Name ");
            }
            else
            {
                FirstName = val;
               // MessageBox.Show("First Name Successfully Entered!");

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
            else if(val == "")
            {
                MessageBox.Show("Please Enter Last Name");
                

            }
            else
            {
                LastName = val;
                //MessageBox.Show("Last Name Successfully Entered!");
            }
        }
        /// <summary>
        /// it is the getter of registration number
        /// </summary>
        /// <returns>
        /// it returns the string of registration number in the format 2016-CE-068
        /// </returns>
        public string getRegistrationNumber()
        {
            return registration_number;
        }

        /// <summary>
        /// it is the setter of registration number
        /// </summary>
        /// <param name="RegNo">
        /// </param>

        public void setRegistartionNumber(string regNo)
        {
            int q = regNo.Length;
            if (q == 11)
            {
                bool n = false;
                if (n == false)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        if (!Char.IsDigit(regNo[i]))
                        {
                            n = true;
                        }
                    }
                    if (n == true)
                    {
                        MessageBox.Show("Invalid Registration Number !");
                    }
                    n = false;
                    int j = 4;
                    if (!(regNo[j] == '-'))
                    {
                        n = true;
                    }
                    if (n == true)
                    {
                        MessageBox.Show("Invalid Registration Number !");
                    }
                    n = false;
                    for (int m = 5; m < 7; m++)
                    {
                        if (!Char.IsLetter(regNo[m]))
                        {
                            n = true;
                        }
                    }
                    if (n == true)
                    {
                        MessageBox.Show("Invalid Registration Number !");
                    }
                    n = false;
                    int g1 = 7;
                    if (!(regNo[g1] == '-'))
                    {
                        n = true;
                    }
                    if (n == true)
                    {
                        MessageBox.Show("Invalid Registration Number !");
                    }
                    n = false;
                    for (int f = 8; f < 11; f++)
                    {
                        if (!Char.IsDigit(regNo[f]))
                        {
                            n = true;
                        }
                    }
                    if (n == true)
                    {
                        MessageBox.Show("Enter the Valid registration number:");
                    }
                    // g = false;
                }
                if (n == false)
                {
                    registration_number = regNo;
                  //  MessageBox.Show("Registration Number Entered Sucessfully!:");

                }
            }
            else if(q == 10)
            {
                bool n = false;
                if (n == false)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        if (!Char.IsDigit(regNo[i]))
                        {
                            n = true;
                        }
                    }
                    if (n == true)
                    {
                        MessageBox.Show("Invalid Registration Number !");
                    }
                    n = false;
                    int j = 4;
                    if (!(regNo[j] == '-'))
                    {
                        n = true;
                    }
                    if (n == true)
                    {
                        MessageBox.Show("Invalid Registration Number !");
                    }
                    n = false;
                    for (int m = 5; m < 7; m++)
                    {
                        if (!Char.IsLetter(regNo[m]))
                        {
                            n = true;
                        }
                    }
                    if (n == true)
                    {
                        MessageBox.Show("Invalid Registration Number !");
                    }
                    n = false;
                    int g1 = 7;
                    if (!(regNo[g1] == '-'))
                    {
                        n = true;
                    }
                    if (n == true)
                    {
                        MessageBox.Show("Invalid Registration Number !");
                    }
                    n = false;
                    for (int f = 8; f < 10; f++)
                    {
                        if (!Char.IsDigit(regNo[f]))
                        {
                            n = true;
                        }
                    }
                    if (n == true)
                    {
                        MessageBox.Show("Enter the Valid registration number:");
                    }
                    // g = false;
                }
                if (n == false)
                {
                    registration_number = regNo;
                    //MessageBox.Show("Registration Number Entered Sucessfully!:");

                }
            }
            else if(regNo == "")
            {
                MessageBox.Show("Please Enter Registration Number");
            }
            else
            {
                MessageBox.Show("Enter the valid Registration Number!");
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
                  //  MessageBox.Show("contact Entered Successfully");
                }
                else
                {

                    MessageBox.Show("Invalid contact");
                }
            }
            else if(ContactNo == "")
            {
                MessageBox.Show("Please Enter Contact Number");
            }
            else
            {

                MessageBox.Show("Invalid contact");
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
            else if(email == "")
            {
                MessageBox.Show("Please Enter Email");
            }
            else
            {

                MessageBox.Show("Invalid Email");
            }
        }
    }
}
