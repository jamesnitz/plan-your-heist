using System;
using System.Collections.Generic;

namespace plan_your_heist
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Plan Your Heist");
      List<Member> team = new List<Member>();
      Console.WriteLine("Enter Bank's difficulty");
      int defaultBankDifficulty = int.Parse(Console.ReadLine());
      Console.Clear();
      int totalTeamSkillLevel = 0;
      int successfulRuns = 0;
      int failedRuns = 0;
      while (true)
      {
        Console.WriteLine("Please enter team member Name!");
        string singleMember = Console.ReadLine();
        if (singleMember == "")
        {
          Console.WriteLine("How many times would you like to run this heist scenario?");
          int scenarioRunTimes = int.Parse(Console.ReadLine());
          Console.WriteLine($"You're making {scenarioRunTimes} attempts");
          foreach (Member singleTeamMember in team)
          {

            totalTeamSkillLevel += singleTeamMember.Skill;
          }
          for (int i = 0; i < scenarioRunTimes; i++)
          {
            Random bankLuck = new Random();
            int tempBankDifficulty = defaultBankDifficulty;
            int bankLuckInt = bankLuck.Next(-10, 11);
            tempBankDifficulty += bankLuckInt;
            Console.WriteLine($"Attempt #{i + 1}.");
            if (totalTeamSkillLevel >= tempBankDifficulty)
            {
              Console.WriteLine($"The Teams combined skill {totalTeamSkillLevel}. The bank's difficulty is {tempBankDifficulty}");
              Console.WriteLine($"You can do it");
              successfulRuns++;
            }
            else
            {
              Console.WriteLine($"The Teams combined skill {totalTeamSkillLevel}. The bank's difficulty is {tempBankDifficulty}");
              Console.WriteLine("You can't do it. You'll fail");
              failedRuns++;
            }
          }
          break;
        }
        Member member = new Member();
        member.Name = singleMember;
        Console.WriteLine("Please enter team member skill!");
        member.Skill = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter team member Courage!");
        member.Courage = decimal.Parse(Console.ReadLine());
        team.Add(member);
      }
      Console.WriteLine($"You suceeded {successfulRuns}! You failed {failedRuns}.");
    }
  }
}