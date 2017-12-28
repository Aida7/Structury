using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество нуждающихся в общежитии:");
            int n;
            int.TryParse(Console.ReadLine(), out n);
            Studentcs[] stud = new Studentcs[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("{0} Нуждаюшиийся:", i + 1);
                Console.WriteLine("Имя:");
                stud[i].Name = Console.ReadLine();
                Console.WriteLine("Номер группы:");

                stud[i].Grup = Console.ReadLine();
                Console.WriteLine("Доход:");

                Console.WriteLine("Средний балл:");
                stud[i].Score = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Доход:");
                stud[i].Income = Convert.ToInt32(Console.ReadLine());


            }

            Console.WriteLine("");
            Console.WriteLine("Введите количество мест в общежитии:");
            int place;
            int.TryParse(Console.ReadLine(), out place);
            int price = 2000;

            for (int i = 0; i < n; i++)
            {
                if (stud[i].Income <= price)
                    Console.WriteLine("{0} - Выдана комната!", stud[i]);

                if (stud[i].Income > price)
                    Console.WriteLine("Не хватает");

            }
        }
    }

}