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

            //int length = 6;
            //int[] array = GetArrayFromConsole(ref length);
            //int[] sortedarray = SortArray(array);
            //PrintArray(sortedarray);
            //Console.WriteLine("Lenght is " + length);



            static int[] GetArrayFromConsole(ref int size)
            {
                
                var result = new int[size];

                for (int i = 0; i < result.Length; i++)
                {
                    Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                    result[i] = int.Parse(Console.ReadLine());
                }
                return result;
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

            //int[] Test = GetArrayFromConsole(10);
            //ShowArray(Test, true);



            //int MyAge = 22;
            //ChangeAge(ref MyAge);
            //Console.WriteLine(MyAge);

            static void ChangeAge(ref int age)
            {
                Console.Write("Enter your age: ");
                age = Convert.ToInt32(Console.ReadLine());

            }

            //string Name = "Евгения";
            //GetName(out Name);
            //Console.WriteLine(Name);

            static void GetName(out string name)
            {
                Console.WriteLine("Введите имя ");
                name = Console.ReadLine();

            }



            //var arr = new int[] { 1, 2, 3 };
            //int Data = 0;
            //BigDataOperation(arr, ref Data);

            //Console.WriteLine(arr[0] + " данные " + Data);

            //Напишите сигнатуру(объявление) метода GetAge с выходными параметрами Name и Age типов string и byte соответственно.

            static void GetAge(out string Name, out byte Age)
            {
                Name = "kek";
                Age = 69;
            }

            static void BigDataOperation(int[] arr, ref int data)
            {
                arr[0] = 4;
                data = 15;
            }

            //Напишите объявление метода SumNumbers для суммирования четырех чисел, где: первое значение передается по ссылке и меняется,
            //второе значение передается по ссылке и не меняется, третье значение является результатом суммирования двух первых и возвращается
            //методом, а четвертое значение является обычным параметром, и на него умножается результат метода.
            //Метод возвращает значения типа int, все входные параметры также имеют тип int и называются: num1...num4.

            //int Num1 = 1, Num2 = 5, Num3 = 10, Num4 = 7;
            //Console.WriteLine(SumNumbers(ref Num1, ref Num2, out Num3, Num4));

            static int SumNumbers(ref int num1, ref int num2, out int num3, int num4)
            {
                num1 = Convert.ToInt32(Console.ReadLine());
                num3 = num1 + num2;
                int result = num1 + num2 + num3 + num4;
                return result * num4; 
            }

            //Используйте код метода SortArray. Сейчас этот метод сортирует массив по возрастанию значения.
            //Создайте методы SortArrayDesc и SortArrayAsc — сортировка массива от большего к меньшему и сортировка массива от меньшего к большему.

            //Метод SortArray модифицируйте так, чтобы он вызвал оба этих метода.Результаты методов SortArrayAsc и SortArrayDesc должны представлять собой массивы.

            //Метод SortArray должен иметь один входной параметр array и два выходных: sorteddesc и sortedasc.
            int[] ArrayForSort = { 4, 3, 1, 2};
            //int[] ArrayDown = new int[8];
            //int[] ArrayUp = new int[8];
            SortArray(ArrayForSort, out int[] ArrayDown, out int[] ArrayUp);
            ShowArray(ArrayUp);
            ShowArray(ArrayDown);


            ArrayUp = SortArrayAsc(ArrayForSort);
            ShowArray(ArrayUp);
            ArrayDown = SortArrayDesc(ArrayForSort);
            ShowArray(ArrayDown);
            

            static void SortArray(in int[] array, out int[] sorteddesc, out int[] sortedasc)
            {                
                sorteddesc = SortArrayDesc(array);
                sortedasc = SortArrayAsc(array);
            }

            static int[] SortArrayDesc(int[] array)
            {
                foreach (int el in array)
                {
                    for (byte i = 0; i < array.Length - 1; i++)
                    {
                        if (array[i] < array[i + 1])
                        {
                            int temp = array[i];
                            array[i] = array[i + 1];
                            array[i + 1] = temp;
                        }
                    }
                }
                return array;
            }

            static int[] SortArrayAsc(int[] array)
            {
                foreach (int el in array)
                {
                    for (byte i = 0; i < array.Length - 1; i++)
                    {
                        if (array[i] > array[i + 1])
                        {
                            int temp1 = array[i];
                            array[i] = array[i + 1];
                            array[i + 1] = temp1;
                        }
                    }
                }
                return array;
            }
        }
    }
}