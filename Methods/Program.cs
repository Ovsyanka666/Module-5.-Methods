﻿namespace Methods {
    class Program {
        static void Main()
        {

            //(string Name, string[] Dishes) User;
            //User.Dishes = new string[5];
            //Console.Write("Enter your name ");
            //User.Name = Console.ReadLine();

            //Console.WriteLine("Enter your favourite dishes ");
            //for (byte i = 0; i < 5; i++)
            //    User.Dishes[i] = Console.ReadLine();

            //Console.WriteLine("Your name is " + User.Name);
            //for (byte i = 0; i < 5; i++)
            //    Console.Write(User.Dishes[i] + " ");

            //var (name, age) = ("Евгения", 27);

            //Console.WriteLine("Мое имя: {0}", name);
            //Console.WriteLine("Мой возраст: {0}", age);




            //(string name, int age) anketa;
            //anketa.name = "Lera";
            //anketa.age = 22;

            ////Console.Write("Введите имя: ");
            ////anketa.name = Console.ReadLine();
            ////Console.Write("Введите возраст цифрами: ");
            ////anketa.age = Convert.ToInt32(Console.ReadLine());

            ////Console.WriteLine("Ваше имя: {0}", anketa.name);
            ////Console.WriteLine("Ваш возраст: {0}", anketa.age);

            //string[] FavColors = new string[3];

            //for (byte i = 0; i < 3; i++)
            //{
            //    FavColors[i] = ShowColor(anketa.name, anketa.age);
            //}


            //ShowColors();
            //ShowColors(FavColors);


            static string ShowColor(string username, int userage)
                {
                    Console.WriteLine(username + ", " + userage + "\nНапишите свой любимый цвет на английском с маленькой буквы");
                string color = Console.ReadLine();

                    switch (color)
                    {
                        case "red":
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.Black;

                            Console.WriteLine("Your color is red!");
                            break;

                        case "green":
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.ForegroundColor = ConsoleColor.Black;

                            Console.WriteLine("Your color is green!");
                            break;
                        case "cyan":
                            Console.BackgroundColor = ConsoleColor.Cyan;
                            Console.ForegroundColor = ConsoleColor.Black;

                            Console.WriteLine("Your color is cyan!");
                            break;
                        default:
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.ForegroundColor = ConsoleColor.Red;

                            Console.WriteLine("Your color is yellow!");
                            break;
                    }
                    return color;
                
                }


            //int[] array = GetArrayFromConsole();
            //Console.Write("Исходный массив: ");
            //foreach (int el in array)
            //    Console.Write(el + " ");
            //array = SortArray(array);
            //Console.Write("\nОтсортированный массив: ");
            //foreach (int el in array)
            //    Console.Write(el + " ");



            static void ShowColors(string username = "Dave", params string[] favcolors)
            {
                Console.WriteLine("Ваши любимые цвета: ");
                foreach (string col in favcolors)
                    Console.WriteLine(col);
                Console.WriteLine(username);
            }


            //int[] array = GetArrayFromConsole(3);
            //int[] sortedarray = SortArray(array);
            //PrintArray(sortedarray);



            static int[] GetArrayFromConsole(int size = 5)
            {
                
                var result = new int[size];

                for (int i = 0; i < result.Length; i++)
                {
                    Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                    result[i] = int.Parse(Console.ReadLine());
                }
                return result;
            }

            static int[] SortArray(int[] array)
            {
                foreach (int el in array)
                {
                    for (byte i = 0; i < array.Length - 1; i++)
                    {
                        if (array[i] > array[i + 1])
                        {
                            int temp = array[i];
                            array[i] = array[i + 1];
                            array[i + 1] = temp;
                        }
                    }
                }
                return array;
            }

            static void PrintArray(int[] array)
            {
                foreach (int el in array)
                    Console.Write(el + " ");
            }

            //5.2.17
            //Создайте метод ShowArray с параметрами: массив чисел, признак сортировки логического типа, необязательный параметр, по умолчанию ЛОЖЬ.
            //Метод должен выводить массив на экран. Если значение признака сортировки равно ИСТИНА, то предварительно массив нужно отсортировать.

            static void ShowArray(int[] nums, bool sort = false)
            {
                Console.Write("Ваш массив: ");

                if (sort == true) {
                    foreach (int el in nums)
                    {
                        for (byte i = 0; i < nums.Length - 1; i++)
                        {
                            if (nums[i] > nums[i + 1])
                            {
                                int temp = nums[i];
                                nums[i] = nums[i + 1];
                                nums[i + 1] = temp;
                            }
                        }
                    }
                }

                foreach (int el in nums)
                    Console.Write(el + " ");
            }

            int[] Test = GetArrayFromConsole(10);
            ShowArray(Test, true);

        }
    }
}