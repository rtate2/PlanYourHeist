using System;
using System.Collections.Generic;
using System.Linq;

namespace PlanYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan your heist!");

            var teamMembers = new List<TeamMember>();

            var newBank = new Bank();

            Console.WriteLine("Please enter the difficulty level of the bank.");
            var difficultyLevel = int.Parse(Console.ReadLine());

            newBank.BankDifficulty = difficultyLevel;

            while (true)
            {
                Console.WriteLine("Please enter the team member's first name.");
                var teamMemberName = Console.ReadLine();
                if (teamMemberName == "") break;

                Console.WriteLine("Please enter the team member's skill level as an integer from 0 to 50.");
                var teamMemberSkillLevel = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the team member's courage factor as a decimal 0.0-2.0.");
                var teamMemberCourageFactor = decimal.Parse(Console.ReadLine());

                var teamMember = new TeamMember
                {
                    Name = teamMemberName,
                    SkillLevel = teamMemberSkillLevel,
                    CourageFactor = teamMemberCourageFactor
                };

                teamMembers.Add(teamMember);

            }

            Console.WriteLine("Please enter the number of trial runs this app should execute.");
            var trialRuns = int.Parse(Console.ReadLine());

            var successfulRuns = 0;
            var failedRuns = 0;

            for (int i = 0; i < trialRuns; i++)
            {
                var outcome = newBank.TryRob(teamMembers);
                if (outcome)
                {
                    successfulRuns++;
                }
                else
                {
                    failedRuns++;
                }
            }

            /*var numOfMembers = teamMembers.Count();
            Console.WriteLine($"There are {numOfMembers} members");
            foreach (var teamMember in teamMembers)
            {
                Console.WriteLine($"{teamMember.Name} has a skill level of {teamMember.SkillLevel} and courage factor of {teamMember.CourageFactor}.");
            }*/

            Console.WriteLine($"You succeeded {successfulRuns} times and failed {failedRuns} times.");



        }

        //public static bool RobTheBank(Bank bankDifficulty, List<TeamMember> teamMembers)
        //{
        //    var random = new Random();
        //    var luckValue = random.Next(-10, 10);

        //    var bankDifficultyLevelWithLuck = bankDifficulty.BankDifficulty + luckValue;

        //    var sumOfMembersSkill = teamMembers.Sum(teamMember => teamMember.SkillLevel);

        //    /*foreach(var teamMember in teamMembers)
        //    {
        //        sumOfMembersSkill += teamMember.SkillLevel;
        //    }*/

        //    Console.WriteLine($"Your team has a total skill level of {sumOfMembersSkill}.");
        //    Console.WriteLine($"This bank has a difficulty of {bankDifficultyLevelWithLuck}");

        //    if (sumOfMembersSkill >= bankDifficultyLevelWithLuck)
        //    {
        //        Console.WriteLine("You rob the bank and get away scot free!");
        //        return true;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Your team kind of sucks so you go to jail.");
        //        return false;
        //    }
        //}
    }
}
