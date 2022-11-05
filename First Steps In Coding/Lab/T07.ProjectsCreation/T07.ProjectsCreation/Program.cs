using System;

namespace T07.ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string аrchitectName = Console.ReadLine();
            int howMenyProject = int.Parse(Console.ReadLine());
            int hourNead = howMenyProject * 3;

            Console.WriteLine($"The architect {аrchitectName} will need {hourNead} hours to complete {howMenyProject} project/s.");
        }
    }
}
