using System;
using System.Collections.Generic;
using System.Linq;

namespace PlanYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");

            List<TeamMember> teamMembers = new List<TeamMember>();

            var bankDifficultyLevel = new Bank();

            while (true)
            {
                Console.WriteLine("Please enter the team member's first name.");
                var teamMemberName = Console.ReadLine();
                if (teamMemberName == "") break;

                Console.WriteLine("Please enter the team member's skill level, in intergers, between 0-50.");
                var teamMemberSkillLevel = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the team membe's courage factor, as a decimal, between 0.0-2.0.");
                var teamMemberCourageFactor = decimal.Parse(Console.ReadLine());

                var teamMember = new TeamMember
                {
                    Name = teamMemberName,
                    SkillLevel = teamMemberSkillLevel,
                    CourageFactor = teamMemberCourageFactor
                };

                teamMembers.Add(teamMember);
            }
            var numOfMembers = teamMembers.Count();
            Console.WriteLine($"There are {numOfMembers} members.");

            //foreach (var teamMember in teamMembers)
            //{
            //    Console.WriteLine($"{teamMember.Name} has a skill level of {teamMember.SkillLevel} and courage factor of {teamMember.CourageFactor}.");
            //}

            var sumOfMemberSkill = 0;

            foreach (var teamMember in teamMembers)
            {
                sumOfMemberSkill += teamMember.SkillLevel;
            }

            if (sumOfMemberSkill >= bankDifficultyLevel.BankDifficulty)
            {
                Console.WriteLine("Great job you did it!");
            }
            else
            {
                Console.WriteLine("You are going to prison!");
            }

            var random = new Random();

            var luckValue = random.Next(-10, 10);
            Console.WriteLine($"Your luck value is {luckValue}");

            var bankDifficultyLevelWithLuck = bankDifficultyLevel.BankDifficulty + luckValue;

            //Before displaying the success or failure message, display a report that shows.
            //The team's combined skill level
            //The bank's difficulty level
        }
    }
}
