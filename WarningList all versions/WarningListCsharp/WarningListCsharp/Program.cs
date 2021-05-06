using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarningListCsharp
{
    class Program
    {
        static void intro()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("|WarningList 0.2.1 BASIC|");
            Console.WriteLine("|Created AMPrograms     |");
            Console.WriteLine("-------------------------");
        }
        enum Score {two = 2, three , four , five };
        static void Main(string[] args)
        {
            Score score;
            int arrx = 0;
            double Count = 0;
            double result;
            double[] totalryr = new double[14];
            double totalresult;
            string [] arr = { "Match: ", "Rus.Iaz: ", "Physics: ", "History: ", "Eng.Iaz: ", "Chemistry: ", "Literature: ", "Socialscience: ", "Biology: ", "Geography: ", "LSF: ", "PE: ", "PD: ", "Informatics: " } ;
            intro();
          
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
                Console.WriteLine("Enter quality array: ");
                arrx = int.Parse(Console.ReadLine());
                int[] size = new int[arrx];
                for (int c = 0; c < arrx; c++)
                {
                    Console.WriteLine("Enter score");
                    size[c] = int.Parse(Console.ReadLine());
                    switch(size[c])
                    {
                        case 2:
                           score = Score.two;
                            break;
                        case 3:
                            score = Score.three;
                            break;
                        case 4:
                            score = Score.four;
                            break;
                        case 5:
                            score = Score.five;
                            break;
                    }
                    
                    if (size[c] == 1 || size[c] > 5)
                    {
                        Console.WriteLine("Error! Wrong number!");
                        return;
                    }
                    
                    Count += size[c];
                }
                result = Count / arrx;

                totalryr[i] = result;
                if (totalryr[i] <= 2.5)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your middle score = " + result);
                    Console.WriteLine("WARNING!!! Low-score!");
                    Console.ResetColor();
                }
                else if (totalryr[i] <= 3.5)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Your middle score = " + result);
                    Console.WriteLine("Warning! Score equal 3! Geting 4 for total score 4");
                    Console.ResetColor();
                }
                else if (totalryr[i] <= 4.5)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Your middle score = " + result);
                    Console.WriteLine("Warning! Score equal 4! Geting 5 for total score 5");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Your middle score = " + result);
                    Console.WriteLine("Total score is normal! ;)");
                    Console.ResetColor();
                }
                Count = 0;
            }
            totalresult = (totalryr[0] + totalryr[1] + totalryr[2] + totalryr[3] + totalryr[4] + totalryr[5] + totalryr[6] + totalryr[7] + totalryr[8] + totalryr[9] + totalryr[10] + totalryr[11] + totalryr[12] + totalryr[13]) / 14;
            Console.WriteLine("Your total result: " + totalresult);
        }
    }
}
