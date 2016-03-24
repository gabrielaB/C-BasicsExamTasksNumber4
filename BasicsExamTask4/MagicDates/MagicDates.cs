using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDates
{
    class MagicDates
    {
        static void Main(string[] args)
        {
            int startYear = int.Parse(Console.ReadLine());
            int endYear = int.Parse(Console.ReadLine());
            int magicWeight = int.Parse(Console.ReadLine());

            DateTime startDate = new DateTime(startYear, 1, 1);
            DateTime endDate = new DateTime(endYear, 12, 31);
            int counter = 0;

            for (DateTime currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1))
            {
                string result = currentDate.Day.ToString() + currentDate.Month.ToString() + currentDate.Year.ToString();
                int currentWeight = 0;

                for (int i = 0; i < result.Length; i++)
                {
                    for (int j = i + 1; j < result.Length; j++)
                    {
                        currentWeight +=int.Parse(result[i].ToString()) * int.Parse(result[j].ToString());
                    }
                }

                if(currentWeight == magicWeight)
                {
                    string day = currentDate.Day > 9 ? currentDate.Day.ToString() : "0" + currentDate.Day;
                    string month = currentDate.Month > 9 ? currentDate.Month.ToString() : "0" + currentDate.Month;
                    Console.WriteLine(day + "-" + month + "-" + currentDate.Year);
                    counter++;
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
