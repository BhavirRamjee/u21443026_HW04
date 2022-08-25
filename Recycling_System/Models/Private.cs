using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21443026_HW04.Models
{
    public class Private: Program
    {
        public string SchoolType { get; set; }    
        public double Months { get; set; }
 

        public Private(int studentid, string classId, double grade, int hours, string schoolType, double months) : base(studentid, classId, grade, hours)
        {
            SchoolType = schoolType;
            Months = months;
           
        }

        public Private():base()
        {

        }

        public override double CalculateCost()
        {
            return Months * 500;
         }

    }
}