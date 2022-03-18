using System;
using System.Data;

namespace lesson2
{
    internal class Program
    {
        enum Month
        {
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        };

        public static void Main(string[] args)
        {
            //Общие переменные 
            float minT = 0;
            float maxT = 0;
            float averageT = 0;
            Month currentMonth = Month.January; //January по умолчанию
                    
            //по п.1
            try
            {
                //Нет уверенности, что введут данные правильно тем более в разных ОС разные представления
                Console.WriteLine("Enter minimum temperature (using ',' as separator of whole and fractional parts): ");
                float minTmpTemp = float.Parse(Console.ReadLine());
                
                Console.WriteLine("Enter maximum temperature (using ',' as separator of whole and fractional parts): ");
                float maxTmpTemp = float.Parse(Console.ReadLine());
                
                //Если что, температуры меняем местами
                minT = Math.Min(minTmpTemp, maxTmpTemp);
                maxT = Math.Max(minTmpTemp, maxTmpTemp);
                averageT = (minT + maxT) / 2;
                
                Console.WriteLine($"Minimal temperature {minT}, " +
                                  $"maximum temperature {maxT}, " +
                                  $"average temperature {averageT}");
            }
            catch (Exception errorException)
            {
                Console.WriteLine(errorException.Message);
            }

            //по п.2
            try
            {
                Console.WriteLine("Enter the number of current month, where 0 is January and 11 is December:");
                currentMonth = (Month) Enum.Parse(typeof(Month), Console.ReadLine()) ;
                Console.WriteLine($"The name of this month is {currentMonth.ToString()}");
            }
            catch (Exception error)
            { 
                Console.WriteLine(error.Message);
            }

            //по п.5
            bool rainyWinter = (currentMonth == Month.January || currentMonth == Month.February || currentMonth == Month.December) && (averageT >= 0); //Знаю, что это ужастно, потом так делать не буду 
            if (rainyWinter) {
                Console.WriteLine(".... rainy winter");
            };

          

        }
    }
}