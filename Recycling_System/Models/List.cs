using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21443026_HW04.Models
{
    public static class List
    {
        public static readonly List<Program> programs = new List<Program> ();

        public static void Add(Program program)
        {
            programs.Add(program);
        }

        public static List<Program> Programs()
        {
            return programs;
        }

        public static void Delete(int id)
        {
           for(int i = 0; i < programs.Count; i++)
            {
                if (programs[i].Studentid == id)
                {
                    programs.Remove(programs[i]);
                }
            }
          
        }

        public static void Edit(Program
            program)
        {
            if(program.GetType () == typeof(State))
            {
                State state = (State)program;
                for(int i = 0; i < programs.Count; i++)
                {
                    if(programs[i].Studentid == state.Studentid)
                    {
                        programs[i] = state;
                    }
                }
               

            }

            if (program.GetType() == typeof(Private))
            {
                Private pvt = (Private)program;
                for (int i = 0; i < programs.Count; i++)
                {
                    if (programs[i].Studentid == pvt.Studentid)
                    {
                        programs[i] = pvt;
                    }
                }


            }

        }
    }
}