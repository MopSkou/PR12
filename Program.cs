using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] crop = {"Пшеница", "Овёс",
            "Греча", "Картофель", "Морковь", "Рис"};//исходное множество
            string[] crop1 = {"Пшеница", "Морковь",
            "Рис"};
            string[] crop2 = { "Пшеница",
            "Картофель", "Рис"};
            string[] crop3 = {"Пшеница", "Морковь",
             "Греча"};
            //есть у каждого
            var rez1 = crop.Intersect(crop1).Intersect(crop2).Intersect(crop3);
            Console.WriteLine("Выращиваемые во всех колхозах");
            PrintSet(rez1);
            //есть хотя бы у одного
            var rez2 = crop1.Union(crop2).Union(crop3).Intersect(crop);
            Console.WriteLine("Выращиваемые в некоторых из колхозов");
            PrintSet(rez2);


            Console.ReadKey();
        }
        private static void PrintSet(IEnumerable<string> rez1)
        {
            foreach (var fl in rez1)
            {
                Console.WriteLine(fl);
            }
        }

        private static void printSet(IEnumerable<int> mas)
        {
            foreach (int x in mas)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine();
        }

        private static void printArray(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write($"{mas[i]} ");
            }
            Console.WriteLine();

        }
    }
}
