using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21443026_HW04.Models
{
    public class State : Program
    {
        public string StateOffer { get; set; }
        public string Mentors { get; set; }
        public int LevelEd{ get; set; }
        public State(int studentid, string classId, double grade, int hours, string stateOffer, string mentors, int levelEd) :base(studentid, classId, grade, hours)
        {
            StateOffer = stateOffer;
            Mentors = mentors;
            LevelEd = levelEd;
        }

        public State()
        {

        }
        public override double CalculateCost()
        {
            return 25;
        }
    }
}