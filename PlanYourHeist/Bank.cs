using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlanYourHeist
{
    class Bank
    {
        public int BankDifficulty { get; set; }

        public bool TryRob(List<TeamMember> team)
        {
            var random = new Random();
            var luckValue = random.Next(-10, 10);

            var bankDifficultyLevelWithLuck = BankDifficulty + luckValue;

            var sumOfMembersSkill = team.Sum(teamMember => teamMember.SkillLevel);

            /*foreach(var teamMember in teamMembers)
            {
                sumOfMembersSkill += teamMember.SkillLevel;
            }*/

            Console.WriteLine($"Your team has a total skill level of {sumOfMembersSkill}.");
            Console.WriteLine($"This bank has a difficulty of {bankDifficultyLevelWithLuck}");

            if (sumOfMembersSkill >= bankDifficultyLevelWithLuck)
            {
                Console.WriteLine("You rob the bank and get away scot free!");
                return true;
            }
            else
            {
                Console.WriteLine("Your team kind of sucks so you go to jail.");
                return false;
            }
        }
    }
}
