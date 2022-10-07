using System;
using System.Linq;

namespace Task_0110
{
    public struct Zloyded
    {
        public string name;
        public enum Level_grouchiness
        {
            level1 = 1,
            level2 = 2,
            level3 = 3,
            level4 = 4
        }
        public string[] phrases_for_пrumbling;
        public int count_bruises;
        public Zloyded(string name, string[] phrases_for_пrumbling, int count_bruises = 0)
        {
            this.name = name;
            this.phrases_for_пrumbling = phrases_for_пrumbling;
            this.count_bruises = count_bruises;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 1");
            double[] Yrav(double a, double b, double c) //x1 + x2 + x3 = 
            {
                double d = b * b - 4 * a * c;
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                double[] otv = new double[2] {x1, x2};
                return otv;
            }
            double[] otv = Yrav(3, -14, -5);
            Console.WriteLine($"x1 = {otv[0]}, x2 = {otv[1]}");


            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Задача 2");
            int[] randint = new int[20];
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                randint[i] = rnd.Next();
                Console.Write($"{i + 1}={randint[i]} ");
            }
            Console.WriteLine("Введи два числа (0 <= n1, n2 <= 20)");
            Console.Write("n1 = ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("n2 = ");
            int n2 = int.Parse(Console.ReadLine());
            int num = randint[n1 - 1];
            randint[n1 - 1] = randint[n2 - 1];
            randint[n2 - 1] = num;
            int c = 1;
            foreach (int h in randint)
            {
                Console.Write($"{c}={h} ");
                c++;
            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Задача 3");
            int[] BubbleSort(int[] numbers)
            {
                int[] numbers_copy = numbers;
                int copy;
                for (int i = 0; i < numbers_copy.Length; i++)
                {
                    for (int j = i + 1; j < numbers_copy.Length; j++)
                    {
                        if (numbers_copy[i] > numbers_copy[j])
                        {
                            copy = numbers_copy[i];
                            numbers_copy[i] = numbers_copy[j];
                            numbers_copy[j] = copy;
                        }
                    }

                }
                return numbers_copy;
            }
            int[] numbers = { 3, 2, 7, 1 };
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers = BubbleSort(numbers);
            }
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Задача 4");
            int[] Ln(params int[] list)
            {
                return list;
            }
            int[] arr = Ln(1, 4,56 , 754, 432, 646);
            int sum = 0;
            double ar;
            
            void Sum(int[] arr, ref int sum, out double ar)
            {
                foreach (int i in arr)
                {
                    sum += i;
                }
                ar = sum / arr.Length;
                return;
            }
            Sum(arr, ref sum, out ar);
            Console.WriteLine($"сумма = {sum}, среднее арифметическое = {ar}");

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Задача 5");
            num = 0;
            string str;
            do
            {
                str = Console.ReadLine();
                if (str == "exit" || str == "закрыть")
                {
                    break;
                }
                try
                {
                    num = int.Parse(str);
                    switch (num)
                    {
                        case 0:
                            Zero(); break;
                        case 1:
                            One(); break;
                        case 2:
                            Two(); break;
                        case 3:
                            Three(); break;
                        case 4:
                            Four(); break;
                        case 5:
                            Five(); break;
                        case 6:
                            Six(); break;
                        case 7:
                            Seven(); break;
                        case 8:
                            Eight(); break;
                        case 9:
                            Nine(); break;
                        default:
                            Console.WriteLine("12121");
                            Console.ForegroundColor = ConsoleColor.Red;
                            System.Threading.Thread.Sleep(3000);
                            Console.WriteLine("ERROR 404");
                            Console.ResetColor();
                            break;

                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("ТЫ ВВЕЛ СТРОКУ!!");
                }
            } while (num >= 1 || num <= 9);
            void Zero()
            {
                Console.WriteLine(" #"); Console.WriteLine("# #"); Console.WriteLine("# #"); Console.WriteLine(" #");
            }
            void One()
            {
                Console.WriteLine(" #"); Console.WriteLine(" #"); Console.WriteLine(" #"); Console.WriteLine(" #");
            }
            void Two()
            {
                Console.WriteLine("###"); Console.WriteLine("  #"); Console.WriteLine("##"); Console.WriteLine("###");
            }
            void Three()
            {
                Console.WriteLine("##"); Console.WriteLine("  #"); Console.WriteLine("##"); Console.WriteLine("  #"); Console.WriteLine("##");
            }
            void Four()
            {
                Console.WriteLine("# #"); Console.WriteLine("# #"); Console.WriteLine("###"); Console.WriteLine("  #");
            }
            void Five()
            {
                Console.WriteLine("###"); Console.WriteLine("#  "); Console.WriteLine("###"); Console.WriteLine("  #"); Console.WriteLine("###");
            }
            void Six()
            {
                Console.WriteLine("###"); Console.WriteLine("#  "); Console.WriteLine("###"); Console.WriteLine("# #"); Console.WriteLine("###");
            }
            void Seven()
            {
                Console.WriteLine("###"); Console.WriteLine("  #"); Console.WriteLine(" # "); Console.WriteLine(" # "); Console.WriteLine(" # ");
            }
            void Eight()
            {
                Console.WriteLine("###"); Console.WriteLine("# #"); Console.WriteLine(" # "); Console.WriteLine("# #"); Console.WriteLine("###");
            }
            void Nine()
            {
                Console.WriteLine("###"); Console.WriteLine("# #"); Console.WriteLine("###"); Console.WriteLine("  #"); Console.WriteLine("###");
            }


            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Задача 6");
            Zloyded ded = new Zloyded("Вася", new string[] { "проститутки", "гады" });
            Zloyded ded2 = new Zloyded("Петар", new string[] { "геи", "тупой", "проститутки", "гады" });
            Zloyded ded3 = new Zloyded("Валентин", new string[] { "геи", "гады" });
            Zloyded ded4 = new Zloyded("Николай", new string[] { "гады" }, 6);
            Zloyded ded5 = new Zloyded("Рома", new string[] { "тупой", "проститутки" }, 3);

            int Babka(Zloyded ded, params string[] curse_words)
            {
                foreach (string curse in curse_words)
                {
                    if (ded.phrases_for_пrumbling.Contains(curse))
                    {
                        ded.count_bruises++;
                    }
                }
                return ded.count_bruises;
            }
            Console.WriteLine($"у {ded.name} {Babka(ded, "гей", "проститутки")} синяков");
            Console.WriteLine($"у {ded2.name} {Babka(ded2, "гады")} синяков");
            Console.WriteLine($"у {ded3.name} {Babka(ded3, "тупой", "проститутки")} синяков");
            Console.WriteLine($"у {ded4.name} {Babka(ded4, "гей", "гады")} синяков");
            Console.WriteLine($"у {ded5.name} {Babka(ded5, "геи", "тупой", "проститутки", "гады")} синяков");
        }
    }
}
