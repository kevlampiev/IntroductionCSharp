using System;
using System.Data;

namespace lesson2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                //Нет уверенности, что введут данные правильно
                Console.WriteLine("Enter minimum temperature (using ',' as separator ): ");
                float minTmpTemp = float.Parse(Console.ReadLine());
                
                Console.WriteLine("Enter maximum temperature (using ',' as separator ): ");
                float maxTmpTemp = float.Parse(Console.ReadLine());
                
                //Если что, температуры меняем местами
                float minT = Math.Min(minTmpTemp, maxTmpTemp);
                float maxT = Math.Max(minTmpTemp, maxTmpTemp);
                
                Console.WriteLine($"Minimal temperature {minT}, " +
                                  $"maximum temperature {maxT}, " +
                                  $"average temperature {(minT+maxT)/2}");
            }
            catch (SyntaxErrorException errorException)
            {
                Console.WriteLine(errorException.Message);
            }
        }
    }
}