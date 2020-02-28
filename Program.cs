using System;
using System.Collections.Generic;

namespace plan_your_heist {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Plan Your Heist");
            Dictionary<int, string> teamMemberName = new Dictionary<int, string> ();
            Dictionary<string, int> skillLevel = new Dictionary<string, int> ();
            Dictionary<string, decimal> courageLevel = new Dictionary<string, decimal> ();

            Console.WriteLine ("Please enter team member Name!");

            teamMemberName.Add (teamMemberName.Count, Console.ReadLine ());

        }
    }
}