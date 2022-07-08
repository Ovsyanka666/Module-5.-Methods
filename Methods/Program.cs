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

            //Console.Write("Введите имя: ");
            //name = Console.ReadLine();
            //Console.Write("Введите возрас с цифрами:");
            //age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Ваше имя: {0}", name);
            //Console.WriteLine("Ваш возраст: {0}", age);

            //string[] FavColors = new string[3];

            //for (byte i = 0; i < 3; i++)
            //{
            //    FavColors[i] = ShowColor();
            //}

            //Console.Write("Ваши любимые цвета: ");
            //for (byte i = 0; i < 3; i++)
            //{
            //    Console.Write(FavColors[i] + " ");
            //}



                static string ShowColor()
                {
                    Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
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
            foreach (int el in array)
                Console.WriteLine(el);

            


            static int[] GetArrayFromConsole()
            {
                var result = new int[5];

                for (int i = 0; i < result.Length; i++)
                {
                    Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                    result[i] = int.Parse(Console.ReadLine());
                }

                foreach (int el in result)
                {
                    for (byte i = 0; i < result.Length - 1; i++)
                    {
                        if (result[i] > result[i + 1])
                        {
                            int temp = result[i];
                            result[i] = result[i + 1];
                            result[i + 1] = temp;
                        }
                    }
                }

                return result;
            }

        }
    }
}