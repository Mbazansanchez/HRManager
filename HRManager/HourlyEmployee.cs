using System;
using System.Collections.Generic;
using System.Text;

namespace HRManager
{
    public class HourlyEmployee : Employee
    {
        public decimal HourlyRate { get; set; }

        public HourlyEmployee() : base()
        {
            HourlyRate = 15.0M;
        }

        /*public override string GetPaySummary()
        {
            return "This employee is payed " + HourlyRate + " per hour";
        }*/

        /*public string GetPaySummary()
        {
            return "This employee is payed " + HourlyRate + " per hour";
        }*/

        /*public override string ToString()
        {
            return base.ToString() + " Hourly Employee";
        }*/

        public string ToString()
        {
            return base.ToString() + " Hourly Employee";
        }

        new public string GetPaySummary()
        {
            return "This employee is payed " + HourlyRate + " per hour";
        }

        public override string PaySummary
        {
            get { return "This employee is payed " + HourlyRate + " per hour"; }
        }


        




    }

}
