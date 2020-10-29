using System;

namespace MidExam_29._02._2020
{
    class BonusSocringSystem
    {
        static void Main()
        {
            int countStudents = int.Parse(Console.ReadLine());
            int lectures = int.Parse(Console.ReadLine());
            int additionalBonus = int.Parse(Console.ReadLine());

            double maxBonus = 0.00;
            int bestStrudent = 0;
            for (int i = 0; i < countStudents; i++)
            {
                int attendancesForEachStudent = int.Parse(Console.ReadLine());

                double totalBonus = (double)(attendancesForEachStudent) / (double)(lectures) * (5 + additionalBonus);

                if (maxBonus < totalBonus)
                {
                    maxBonus = totalBonus;
                    bestStrudent = attendancesForEachStudent;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {bestStrudent} lectures.");
        }
    }
}
