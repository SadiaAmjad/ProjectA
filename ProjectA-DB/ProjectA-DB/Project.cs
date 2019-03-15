using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectA_DB
{
    class Project
    {
        private string Title;
        private string Description;

        public string GetTitle()
        {
            return Title;
        }
        public void setTitle(string title)
        {
            if(title == "")
            {
                MessageBox.Show("Please Enter title");
            }
            else
            {
                Title = title;
            }
            
        }
        public string GeDescription()
        {
            return Description;
        }
        public void setDescription(string description)
        {
            if(description == "")
            {
                MessageBox.Show("Please Enter Description");
            }
            else
            {
                Description = description;
            }
        }
    }
}
