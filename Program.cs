using System;
using System.Collections.Generic;

namespace plan_your_heist {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Plan Your Heist");
            Dictionary<int, string> teamMemberName = new Dictionary<int, string> ();
            Dictionary<int, int> skillLevel = new Dictionary<int, int> ();
            Dictionary<int, decimal> courageLevel = new Dictionary<int, decimal> ();
            Console.WriteLine ("Enter Bank's difficulty");
            int defaultBankDifficulty = int.Parse (Console.ReadLine ());
            int trueBankDifficulty = 0;
            int totalTeamSkillLevel = 0;
            int successfulRuns = 0;
            int failedRuns = 0;

            while (true) {
                Console.WriteLine ("Please enter team member Name!");
                string singleMember = Console.ReadLine ();
                if (singleMember == "") {
                    Console.WriteLine ("How many times would you like to run this heist scenario?");
                    int scenarioRunTimes = int.Parse (Console.ReadLine ());
                    foreach (KeyValuePair<int, string> person in teamMemberName) {
                        int personSkillLevel = skillLevel[person.Key];
                        decimal personCourageLevel = courageLevel[person.Key];
                        totalTeamSkillLevel += personSkillLevel;
                    }
                    Console.WriteLine ($"You're making {scenarioRunTimes} attempts");
                    for (int i = 0; i < scenarioRunTimes; i++) {
                        Random bankLuck = new Random ();
                        int bankLuckInt = bankLuck.Next (-10, 11);
                        trueBankDifficulty = defaultBankDifficulty + bankLuckInt;
                        Console.WriteLine ($"Attempt #{i + 1}.");
                        if (totalTeamSkillLevel >= trueBankDifficulty) {
                            Console.WriteLine ($"The Teams combined skill {totalTeamSkillLevel}. The bank's difficulty is {trueBankDifficulty}");
                            Console.WriteLine ($"You can do it");
                            successfulRuns++;
                        } else {
                            Console.WriteLine ($"The Teams combined skill {totalTeamSkillLevel}. The bank's difficulty is {trueBankDifficulty}");
                            Console.WriteLine ("You can't do it. You'll fail");
                            failedRuns++;
                        }
                    }

                    break;
                }
                teamMemberName.Add (teamMemberName.Count, singleMember);
                Console.WriteLine ("Please enter team member skill!");
                skillLevel.Add (skillLevel.Count, int.Parse (Console.ReadLine ()));
                Console.WriteLine ("Please enter team member courage!");
                courageLevel.Add (courageLevel.Count, decimal.Parse (Console.ReadLine ()));

            }
            Console.WriteLine ($"You suceeded {successfulRuns}! You failed {failedRuns}.");
        }
    }
}