namespace Methods {
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

            //Console.Write("Введите имя: ");
            //anketa.name = Console.ReadLine();
            //Console.Write("Введите возраст цифрами: ");
            //anketa.age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Ваше имя: {0}", anketa.name);
            //Console.WriteLine("Ваш возраст: {0}", anketa.age);

            //string[] FavColors = new string[3];

            //for (byte i = 0; i < 3; i++)
            //{
            //    FavColors[i] = ShowColor(anketa.name, anketa.age);
            //}



            //ShowColorArray(FavColors);


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


            int[] array = GetArrayFromConsole();
            Console.Write("Исходный массив: ");
            foreach (int el in array)
                Console.Write(el + " ");
            array = SortArray(array);
            Console.Write("\nОтсортированный массив: ");
            foreach (int el in array)
                Console.Write(el + " ");

            static void ShowColorArray(string[] colors)
            {
                Console.WriteLine("Ваши любимые цвета: ");
                foreach (string col in colors)
                    Console.WriteLine(col);
            }

            


            static int[] GetArrayFromConsole()
            {
                var result = new int[5];

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

        }
    }
}