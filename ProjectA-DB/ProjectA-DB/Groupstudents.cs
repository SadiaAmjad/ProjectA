using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA_DB
{
    class Groupstudents
    {
        private DateTime Created_on;
        private string Status;
        private DateTime AssignmentDate;
        public void setCreatedOn(DateTime createdOn)
        {
            Created_on = createdOn;
        }
        public DateTime GetCreatedOn()
        {
            return Created_on;
        }
        public void setStatus(string status)
        {
            Status = status;
        }
        public string GetStatus()
        {
            return Status;
        }
        public DateTime getAssignmentDate()
        {
            return AssignmentDate;
        }
        public void setAssignmentDate(DateTime assignmentDate)
        {
            AssignmentDate = assignmentDate;
        }
    }
}
