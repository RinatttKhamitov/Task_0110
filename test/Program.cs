using System;
using System.Linq;

namespace test
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
            Zloyded ded = new Zloyded("Вася", new string[] {"проститутки", "гады" });
            Zloyded ded2 = new Zloyded("Петар", new string[] { "геи", "тупой", "проститутки", "гады" });
            Zloyded ded3 = new Zloyded("Валентин", new string[] { "геи", "гады" });
            Zloyded ded4 = new Zloyded("Николай", new string[] { "гады"}, 6);
            Zloyded ded5 = new Zloyded("Рома", new string[] { "тупой", "проститутки"}, 3);

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