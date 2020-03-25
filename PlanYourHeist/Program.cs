using System;

namespace PlanYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");

            var teamMember1 = new TeamMember();

            Console.WriteLine("Please enter the team member's first name.");
            teamMember1.Name = Console.ReadLine();

            Console.WriteLine("Please enter the team member's skill level, in intergers, between 0-10.");
            teamMember1.SkillLevel = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the team membe's courage factor, as a decimal, between 0.0-2.0.");
            teamMember1.CourageFactor = decimal.Parse(Console.ReadLine());
        }
    }
}
