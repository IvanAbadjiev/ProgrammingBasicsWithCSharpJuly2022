using System;

namespace _07._Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {

            int qtyGroup = int.Parse(Console.ReadLine());

            int sumPeopleInAllGroup = 0;
            int musala = 0;
            int monblan = 0;
            int kilimandjaro = 0;
            int k2 = 0;
            int everest = 0;

            for (int i = 0; i < qtyGroup; i++)
            {
                int peopoleInOneGroup = int.Parse(Console.ReadLine());
                sumPeopleInAllGroup += peopoleInOneGroup;

                if (peopoleInOneGroup <= 5)
                {
                    musala += peopoleInOneGroup;
                }
                else if (peopoleInOneGroup <= 12)
                {
                    monblan += peopoleInOneGroup;
                }
                else if (peopoleInOneGroup <= 25)
                {
                    kilimandjaro += peopoleInOneGroup;
                }
                else if (peopoleInOneGroup <= 40)
                {
                    k2 += peopoleInOneGroup;
                }
                else
                {
                    everest += peopoleInOneGroup;
                }

            }

            Console.WriteLine($"{(musala + 0.00) / sumPeopleInAllGroup * 100:f2}%");
            Console.WriteLine($"{(monblan + 0.00) / sumPeopleInAllGroup * 100:f2}%");
            Console.WriteLine($"{(kilimandjaro + 0.00) / sumPeopleInAllGroup * 100:f2}%");
            Console.WriteLine($"{(k2 + 0.00) / sumPeopleInAllGroup * 100:f2}%");
            Console.WriteLine($"{(everest + 0.00) / sumPeopleInAllGroup * 100:f2}%");
        }
    }
}
