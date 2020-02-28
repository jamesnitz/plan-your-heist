using System;
using System.Collections.Generic;

namespace plan_your_heist {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Plan Your Heist");
            Dictionary<int, string> teamMemberName = new Dictionary<int, string> ();
            Dictionary<int, int> skillLevel = new Dictionary<int, int> ();
            Dictionary<int, decimal> courageLevel = new Dictionary<int, decimal> ();
            while (true) {
                Console.WriteLine ("Please enter team member Name!");
                string singleMember = Console.ReadLine ();
                if (singleMember == "") {
                    foreach (KeyValuePair<int, string> person in teamMemberName) {
                        int personSkillLevel = skillLevel[person.Key];
                        decimal personCourageLevel = courageLevel[person.Key];
                        Console.WriteLine ($"{person.Value} has skill level: {personSkillLevel} and courage level:  {personCourageLevel}");
                    }
                    break;
                }
                teamMemberName.Add (teamMemberName.Count, singleMember);
                Console.WriteLine ("Please enter team member skill!");
                skillLevel.Add (skillLevel.Count, int.Parse (Console.ReadLine ()));
                Console.WriteLine ("Please enter team member courage!");
                courageLevel.Add (courageLevel.Count, decimal.Parse (Console.ReadLine ()));
            }

        }
    }
}