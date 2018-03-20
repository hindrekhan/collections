using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            var humans1 = new List<Human>
            {
                new Human(){Name = "Kalle", Age = 40 },
                new Human(){Name = "Malle", Age = 42 },
                new Human(){Name = "Mari", Age = 30 },
                new Human(){Name = "Elmar", Age = 40 },
                new Human(){Name = "Juku", Age = 80 },
            };

            var humanOrder = (from human in humans1
                              
                     group human by human.Name.Count() into g
                     orderby g.Key
                     select g).ToList();
                        
            Console.WriteLine("Järjestatud nimed:");
            foreach(var group in humanOrder)
            {
                Console.WriteLine(group.Key);
            }
            Console.WriteLine();

            Console.WriteLine("Mitu nime iga pikkusega:");
            for (int i = 0; i < 100; i++)
            {
                var abc = (from human in humans1
                           where human.Name.Count() == i
                           select human).ToList();
                if (abc.Count != 0)
                    Console.WriteLine(i + ": " + abc.Count());
            }
            Console.WriteLine();

            Console.WriteLine("Paarisarvulised nimed: ");

            var loc = (from human in humans1
                       where human.Name.Count() % 2 == 0
                       select human).ToList();

            foreach(var nam in loc)
            {
                Console.WriteLine(nam.Name);
            }
            
            Console.ReadLine();
        }
    }
}
