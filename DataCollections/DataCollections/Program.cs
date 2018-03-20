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
            #region List<>

            //var cars = new List<string>();
            //var car1 = "BMW";
            //var car2 = "Lada";
            //var car3 = "Mercedes";
            //var car4 = "Ferrari";
            //var car5 = "Opel";
            //var car6 = "Saab";
            //cars.Add(car1);
            //cars.Add(car2);
            //cars.Add(car3);
            //cars.Add(car4);
            //cars.Add(car5);
            //cars.Add(car6);

            //foreach (var item in cars)
            //{
            //    Console.WriteLine(item);
            //}

            //var cars = new List<string> {"BMW", "Lada", "Mercedes", "Ferrari", "Opel", "Saab" };            
            //for (int index = 0; index < cars.Count; index++)
            //{
            //    Console.WriteLine(cars[index]);
            //}

            //var humans1 = new List<Human>
            //{
            //    new Human(){Name = "Kalle", Age = 20 },
            //    new Human(){Name = "Malle", Age = 25 },
            //    new Human(){Name = "Mari", Age = 30 },
            //    new Human(){Name = "Elmar", Age = 20 },
            //    new Human(){Name = "Juku", Age = 20 },
            //};

            //var human1 = new Human();
            //human1.Name = "Priit";
            //human1.Age = 25;
            //humans1.Add(human1);

            //var human2 = new Human();
            //Console.WriteLine("Sisestage nimi");
            //human2.Name = Console.ReadLine();
            //Console.WriteLine("Sisestage vanus");
            //human2.Age = int.Parse(Console.ReadLine());
            //humans1.Add(human2);

            //foreach (var item in humans1)
            //{
            //    Console.WriteLine(item.Name + " " + item.Age);
            //}
            #endregion

            #region Dictionary

            //var openWith = new Dictionary<string, string>();

            ////            key      value
            //openWith.Add("txt", "notepad.exe");
            //openWith.Add("bmp", "paint.exe");
            //openWith.Add("jpg", "paint.exe");
            //openWith.Add("rtf", "wordpad.exe");

            //openWith["rtf"] = "winword.exe";
            //openWith["doc"] = "winword.exe";



            //try
            //{
            //    openWith.Add("txt", "word.exe");
            //}
            //catch (ArgumentException ex)
            //{               
            //    Console.WriteLine("An element with key \"txt\" already exists");
            //}

            //Console.WriteLine("For key = rtf, value = {0}", openWith["rtf"]);
            //Console.WriteLine("For key = doc, value = {0}", openWith["doc"]);

            //try
            //{
            //    Console.WriteLine("For key = tif, value = {0}", openWith["tif"]);
            //}
            //catch (KeyNotFoundException)
            //{
            //    Console.WriteLine("Key = \"tif\" is not found");
            //}

            //string value = "";
            //if(openWith.TryGetValue("tif", out value))
            //{
            //    Console.WriteLine("For key = \"tif\", value = {0}.", value);
            //}
            //else
            //{
            //    Console.WriteLine("Key = \"tif\" is not found");
            //}

            ////Vaatame kas "ht" võti on olemas, kui ei ole lisame
            //if (!openWith.ContainsKey("ht"))
            //{
            //    openWith.Add("ht", "hyperterm.exe");
            //    Console.WriteLine("Value added for key ht: {0}", openWith["ht"]);
            //}

            ////Küsime võtmed ja väärtused kasutades foreach tsüklit
            //foreach (KeyValuePair<string, string> kvp in openWith)
            //{
            //    Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            //}

            ////Küsime väärtused
            //Dictionary<string, string>.ValueCollection valueCollection = openWith.Values;

            //foreach (string item in valueCollection)
            //{
            //    Console.WriteLine("Value = {0}", item);
            //}

            ////Küsime võtmed
            //Dictionary<string, string>.KeyCollection keyCollection = openWith.Keys;
            //foreach (var item in keyCollection)
            //{
            //    Console.WriteLine("Key = {0}", item);
            //}

            ////Kustutame võtme/väärtuse 
            //openWith.Remove("doc");
            //if(!openWith.ContainsKey("doc"))
            //{
            //    Console.WriteLine("Key \"doc\" is not found.");
            //}

            #endregion

            #region Queue - First in first out (FIFO)

            //////Loome Queue(Järjekorra) 
            //Console.WriteLine("QUEUE:");
            //Queue<string> numbers = new Queue<string>();
            //numbers.Enqueue("one");
            //numbers.Enqueue("two");
            //numbers.Enqueue("three");
            //numbers.Enqueue("four");
            //numbers.Enqueue("five");

            ////Küsime elemendid järjekorrast
            //foreach (string number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //Console.WriteLine();
            ////Võtame välja esimese elemendi
            //Console.WriteLine("Dequeuing '{0}'", numbers.Dequeue());
            ////Piilume järgmist elementi
            //Console.WriteLine("Peek at next item to dequeue: {0}", numbers.Peek());
            ////Võtame välja järgmise
            //Console.WriteLine("Dequeuing '{0}'", numbers.Dequeue());

            ////Teeme koopia järjekorrast
            //Queue<string> queueCopy = new Queue<string>(numbers.ToArray());
            //Console.WriteLine("\n Contents of the first Copy:");
            //foreach (string number in queueCopy)
            //{
            //    Console.WriteLine(number);
            //}

            //string[] array2 = new string[numbers.Count * 2];
            //numbers.CopyTo(array2, numbers.Count);
            //Console.WriteLine("array items");
            //foreach (var item in array2)
            //{
            //    Console.WriteLine(item);
            //}

            //Queue<string> queueCopy2 = new Queue<string>(array2);
            //Console.WriteLine("\nContents of the second Copy, with duplicates and nulls:");
            //foreach (string number in queueCopy2)
            //{
            //    Console.WriteLine(number);
            //}

            //Console.WriteLine("\nqueueCopy contains 'four' = {0}", queueCopy.Contains("four"));
            ////tühjendame järjekorra
            //queueCopy.Clear();
            //Console.WriteLine("\nqueueCopy count is: {0} ",queueCopy.Count);

            #endregion

            #region Stack - Last in first out

            //Console.WriteLine("Stack");
            //Stack<string> numbers = new Stack<string>();
            //numbers.Push("one");
            //numbers.Push("two");
            //numbers.Push("three");
            //numbers.Push("four");
            //numbers.Push("five");

            //foreach (string number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //Console.WriteLine("\nPopping '{0}'",numbers.Pop());
            //Console.WriteLine("Peek at next item to destack: {0}", numbers.Peek());
            //Console.WriteLine("Popping '{0}'", numbers.Pop());

            #endregion

            #region LINQ

            //Andmekogum
            //int[] numbers = new int[7] {0, 1, 2, 3, 4 , 5, 6 };

            //Loome päringu
            //var evenNumQuery = from num in numbers
            //               where (num % 2) == 0
            //               select num;
            //int evenNumCount = evenNumQuery.Count();

            //var evenNumQuery = (from num in numbers
            //                   where (num % 2) == 0
            //                   select num).ToList();

            var humans1 = new List<Human>
            {
                new Human(){Name = "Kalle", Age = 40 },
                new Human(){Name = "Malle", Age = 42 },
                new Human(){Name = "Mari", Age = 30 },
                new Human(){Name = "Elmar", Age = 40 },
                new Human(){Name = "Juku", Age = 80 },
            };


            //Küsime inimesed kelle vanus on üle 20 ning järjestame tulemused
            //var query = (from element in humans1        
            //             orderby element.Age ascending
            //             where element.Age > 20
            //             select element).ToList();

            //foreach (var item in query)
            //{
            //    Console.WriteLine(item.Name + " " + item.Age);
            //}


            //CONTAINS
            //int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            //var a = numbers.Contains(7);

            //var b = false;
            //foreach (var item in numbers)
            //{
            //    if (item == 6)
            //        b = true;
            //}
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            /*int[] numbers = new int[6] {  1, 2, 3, 4, 5, 6 };

            var a = numbers.ElementAtOrDefault(15);
            var b = numbers.FirstOrDefault();
            var c = numbers.Take(3).ToList();
            var d = numbers.Average();
            var e = numbers.Max();
            var f = numbers.Min();

            Console.WriteLine("ElementAtOrDefault: " + a);            
            Console.WriteLine("FirstOrDefault: " + b);
            Console.WriteLine("Take 3");
            foreach (var item in c)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Average: " + d);            
            Console.WriteLine("Max " + e);
            Console.WriteLine("Min " + f);


            var g = humans1.Where(x => x.Name == "Kalle").FirstOrDefault().Name;
            var h = humans1.Where(x => x.Age == 40).ToList();
            var i = humans1.Where(x => x.Name.Contains("a")).ToList();
            var j = humans1.Where(x => x.Name.StartsWith("M")).ToList();

            Console.WriteLine(g);

            foreach (var item in h)
            {
                Console.WriteLine(item.Name +" "+item.Age);
            }
            Console.WriteLine("Contains a");
            foreach (var item in i)
            {
                Console.WriteLine(item.Name + " " + item.Age);
            }
            Console.WriteLine("\nStarts with m");
            foreach (var item in j)
            {
                Console.WriteLine(item.Name + " " + item.Age);
            }*/

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
            

            #endregion
            Console.ReadLine();
        }
    }
}
