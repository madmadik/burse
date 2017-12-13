using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            list.
            int menu;
            do {
                Console.WriteLine("1-добавить человека\n2-действия\n0-выход\n");
                bool result = int.TryParse(Console.ReadLine(), out menu);
                if (result)
                {
                    
                    switch (menu)
                    {
                        case 1:
                            Console.Clear();
                            Person person = new Person();
                            Console.WriteLine("введите имя : ");
                            person.Name = Console.ReadLine();
                            Console.WriteLine("введите фамилию : ");
                            person.SurName = Console.ReadLine();
                            list.Add(person);
                            break;
                        case 2:
                            Console.Clear();
                            int choise;
                            Console.WriteLine("1-купить\n2-продать\n3-назад\n");
                            bool check = int.TryParse(Console.ReadLine(), out choise);
                            if (check)
                            {
                                Console.Clear();
                                int count = 0;
                                foreach (var persons in list)
                                {
                                    count++;
                                    Console.WriteLine(string.Format("{0,3}.{1,3}", count, persons.Name));
                                }
                                switch (choise)
                                {
                                    case 1:
                                        int first, second,size;
                                        Console.Write("купить У - ");
                                        first = int.Parse(Console.ReadLine());
                                        Console.Write("от кого  - ");
                                        second = int.Parse(Console.ReadLine());
                                        Console.Write("сколько  - ");
                                        size = int.Parse(Console.ReadLine());
                                        list[second].Buy(list[first], size);
                                        break;
                                    case 2:
                                        int first2, second2, size2;
                                        Console.Write("продать кому - ");
                                        first = int.Parse(Console.ReadLine());
                                        Console.Write("от кого  - ");
                                        second = int.Parse(Console.ReadLine());
                                        Console.Write("сколько  - ");
                                        size = int.Parse(Console.ReadLine());
                                        list[second].Sell(list[first], size);
                                        break;
                                    case 3:
                                        Console.Clear();
                                        break;


                                }

                                
                            }
                            else
                            {
                                    Console.WriteLine("not correct\n");
                            }
                            break;

                    }

                }
                else
                {
                    Console.WriteLine("not correct\n");
                }
            }
            while (menu != 0);
            
        }
    }
}
