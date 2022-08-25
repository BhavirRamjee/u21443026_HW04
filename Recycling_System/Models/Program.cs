using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21443026_HW04.Models
{
    public abstract class  Program

    {
        public int Studentid { get; set; } 
        public string ClassId { get; set; } 
        public double Grade { get; set; } 
        public int Hours { get; set; } 
                    
   

        public Program(int studentid, string classId, double grade, int hours)
        {
            Studentid = studentid;
            ClassId = classId;
            Grade = grade;
            Hours = hours;

        }
        public Program() { }

        public abstract double CalculateCost();

        public virtual double AccumulatedCost()
        {
          return Hours * 40;
        }




    }
}