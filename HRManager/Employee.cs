using System;
using System.Collections.Generic;
using System.Text;

namespace HRManager
{
    public class Employee
    {
        public int EmpNum { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        /*public virtual string GetPaySummary()
        {
            return "No pay for base class employee.";
        }*/

        public virtual string PaySummary
        {
            get { return "No pay for base class employee."; }
        }

    }

}
