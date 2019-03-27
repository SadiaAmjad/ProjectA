using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectA_DB
{
    class Evaluation
    {
        private string name;
        private string TotalMarks;
        private string TotalWeightage;
        private string ObtainedMarks;
        
        public void setObtainedMarks(string val)
        {
            bool f = false;
            foreach (char c in val)
            {

                if (!(c >= '0' && c <= '9'))
                {
                    f = true;
                }
            }
            if (f == true)
            {

                MessageBox.Show("Obtained marks should be integer valued");
            }
            else if (val == "")
            {
                MessageBox.Show("Please Enter total marks");
            }
            else
            {
                ObtainedMarks = val;
                //MessageBox.Show("Successfully Entered total marks");
            }
        }
        public string getObtainedMarks()
        {
            return ObtainedMarks;
        }



        public void SetName(string val)
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
                MessageBox.Show("Please Enter Name");
            }
            else
            {
                name = val;
               // MessageBox.Show("Name Successfully Entered!");

            }
        }
        public String GetName()
        {
            return name;
        }
        public void setTotalMarks(string totalMarks)
        {
            bool f = false;
            foreach (char c in totalMarks)
            {
                
                if (!(c >= '0' && c <= '9'))
                {
                    f = true;
                }
            }
            if (f == true)
            {

                MessageBox.Show("Total marks should be integer valued");
            }
            else if(totalMarks == "")
            {
                MessageBox.Show("Please Enter total marks");
            }
            else
            {
                TotalMarks = totalMarks;
                //MessageBox.Show("Successfully Entered total marks");
            }
        }
        public string getTotalMarks()
        {
            return TotalMarks;
        }
        public void setTotalWeitage(string totalweightage)
        {

            bool f = false;
            foreach (char c in totalweightage)
            {
                //string s = @"$KUH% I*$)OFNlkfn$";
                //var withoutSpecial = new string(s.Where(c1 => Char.IsLetterOrDigit(c1)
                // || Char.IsWhiteSpace(c1)).ToArray());

                if (!(c >= '0' && c <= '9'))
                {
                    f = true;
                }
            }
            if (f == true)
            {

                MessageBox.Show("Total weightage should be integer valued");
            }
            else if(totalweightage == "")
            {
                MessageBox.Show("Please Enter total weightage");
            }
            else
            {
                TotalWeightage = totalweightage;
               // MessageBox.Show("Successfully Entered total weightage");
            }
        }
        public string getTotalweightage()
        {
            return TotalWeightage;
        }

    }
}
