using System;
using System.Security.Cryptography.X509Certificates;

namespace Practice
{
    internal class Program

    {

        public static void back()
        {
            Console.WriteLine("");
            Console.WriteLine("Давай вернемся назад в меню? (нажми любую клавишу для выхода)");
            Console.ReadLine();
            Console.Clear();

        }
        public static void Ex1()
        {
            Console.WriteLine("Среднее из 4 чисел ");
            Console.WriteLine("Введите число");
            decimal a = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Введите число");
            decimal b = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Введите число");
            decimal c = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Введите число");
            decimal d = Convert.ToDecimal(Console.ReadLine());
            decimal avg = ((a + b + c + d) / 4);
            Console.WriteLine("");
            Console.WriteLine("Среднее значение введеных Вами чисел - "+avg);
            back();
        }
        public static void Ex2()
        {
            Console.WriteLine("Калькулятор ");
            Console.WriteLine("Введите первое число");
            decimal x = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            decimal y = decimal.Parse(Console.ReadLine());
            decimal sum = x + y;
            decimal raz = x - y;
            decimal multiply = x * y;
            decimal del = x / y;
            decimal ost = x % y;
            Console.WriteLine("");
            Console.WriteLine("Сумма 2 чисел равна "+sum);
            Console.WriteLine("Разность 2 числен равна "+raz);
            Console.WriteLine("Частное от деления 2 чисел равно "+del);
            Console.WriteLine("Остаток от деления 1 числа на 2 равен "+ost);
            back();

        }
        public static void Ex3()
        {
            Console.WriteLine("Конвертатор температуры ");
            Console.Write("Введите значение температуры: ");
            double temperature = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите единицу измерения (C - Цельсий, K - Кельвин, F - Фаренгейт): ");
            char unit = Convert.ToChar(Console.ReadLine().ToUpper());

            double celsius, kelvin, fahrenheit;
            switch (unit)
            {
                case 'C':
                    celsius = temperature;
                    kelvin = celsius + 273.15;
                    fahrenheit = (celsius * 9 / 5) + 32;
                    break;
                case 'K':
                    kelvin = temperature;
                    celsius = kelvin - 273.15;
                    fahrenheit = (celsius * 9 / 5) + 32;
                    break;
                case 'F':
                    fahrenheit = temperature;
                    celsius = (fahrenheit - 32) * 5 / 9;
                    kelvin = celsius + 273.15;
                    break;
                default:
                    Console.WriteLine("Неверная единица измерения. Пожалуйста, введите C, K, или F (на латыни)");
                    return;
            }
            Console.WriteLine($"Цельсий: {celsius:F2}");
            Console.WriteLine($"Кельвин: {kelvin:F2}");
            Console.WriteLine($"Фаренгейт: {fahrenheit:F2}");
            back();

        }
        public static void Ex4()
        {
            Console.WriteLine("Нахождение имени файла");

            Console.Write("Введите путь к файлу : ");
            string filePath = Console.ReadLine();

            string[] pathComponents = filePath.Split("\\");

            string fileName = pathComponents[pathComponents.Length - 1];

            Console.WriteLine($"Имя файла: {fileName}");
            back();
        }
        public static void Ex5()
        {
            Console.WriteLine("5. Самое длинное слово в предложении");
            Console.Write("Введите предложение: ");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');
            string longestWord = FindLongestWord(words);
            Console.WriteLine($"Самое длинное слово: {longestWord}");

            static string FindLongestWord(string[] words)
            {

                string longestWord = words[0];
                for (int i = 1; i < words.Length; i++)
                {
                    if (words[i].Length > longestWord.Length)
                    {
                        longestWord = words[i];
                    }
                }
                return longestWord;
            }
            back();
        }
        public static void Ex6()
        {
            Console.WriteLine("Произведение членов массива");
            Console.WriteLine("Введите первый массив через пробел");
            string str = Console.ReadLine();
            string[] firstArray = str.Split(' ');

            Console.WriteLine("Введите второй массив через пробел");
            str = Console.ReadLine();
            string[] secondArray = str.Split(' ');
            if (firstArray.Length != secondArray.Length)
            {
                Console.WriteLine("Разное кол-во членов в массивах, попробуйте снова");
                back();
            }
            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.Write($"{Convert.ToInt32(firstArray[i]) * Convert.ToInt32(secondArray[i])} ");
            }
        }

        public static void Ex7()
        {
            Console.WriteLine("7. Минимальное и максимальное число");

            double[] numbers = new double[5];

            Console.WriteLine("Введите пять чисел:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Введите число {i + 1}: ");
                numbers[i] = Convert.ToDouble(Console.ReadLine());
            }

            double max = FindMax(numbers);
            double min = FindMin(numbers);

            Console.WriteLine($"Максимальное значение: {max}");
            Console.WriteLine($"Минимальное значение: {min}");


            static double FindMax(double[] numbers)
            {
                double max = numbers[0];
                for (int i = 1; i < numbers.Length; i++)
                {
                    if (numbers[i] > max)
                    {
                        max = numbers[i];
                    }
                }
                return max;
            }

            static double FindMin(double[] numbers)
            {
                double min = numbers[0];
                for (int i = 1; i < numbers.Length; i++)
                {
                    if (numbers[i] < min)
                    {
                        min = numbers[i];
                    }
                }
                return min;
            }
            back();
        }
        public static void Ex8()
        {
            Console.WriteLine("8. МММ - не скам ");
            Console.WriteLine("Введите количество ступеней пирамиды");
            int steps = Convert.ToInt32(Console.ReadLine());
            string pyromid = "";
            for (int i = 1; i <= steps; i++)
            {
                pyromid += i;
                Console.WriteLine(pyromid);
            }
            back();
        }

        static void Main(string[] args)
        {

            bool end = false;
            while (!end)
            {
                Console.WriteLine("Выберете раздел задач");
                Console.WriteLine("1. Задачи");
                Console.WriteLine("2. Таблица умножения");
                Console.WriteLine("3. Вариантивная часть. Роскомнадзор");
            int part = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (part)
                {
                    case 1:

                        Console.WriteLine("1.Среднее из 4 чисел ");
                        Console.WriteLine("2. Калькулятор ");
                        Console.WriteLine("3. Конвертатор температуры ");
                        Console.WriteLine("4. Нахождение имени файла");
                        Console.WriteLine("5. Самое длинное слово в предложении");
                        Console.WriteLine("6. Произведение членов массива ");
                        Console.WriteLine("7. Минимальное и максимальное число");
                        Console.WriteLine("8. МММ - не скам ");
                        int exercise = Convert.ToInt32(Console.ReadLine());
                        switch (exercise)
                        {
                            case 1:
                                Console.Clear();
                                Ex1();
                                break;
                            case 2:
                                Console.Clear();
                                Ex2();
                                break;
                            case 3:
                                Console.Clear();
                                Ex3();
                                break;
                            case 4:
                                Console.Clear();
                                Ex4();
                                break;
                            case 5:
                                Console.Clear();
                                Ex5();
                                break;
                            case 6:
                                Console.Clear();
                                Ex6();
                                break;
                            case 7:
                                Console.Clear();
                                Ex7();
                                break;
                            case 8:
                                Console.Clear();
                                Ex8();
                                break;
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Таблица умножения");
                            for (int i = 1; i < 10; i++)
                            {
                                for (int j = 1; j < 10; j++)
                                {
                                    Console.Write($"{i} x {j} = {i * j}  ");
                                }
                                Console.WriteLine("");
                                
                            }   
                        }
                        back();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("                                                 ");
                        Console.WriteLine("                                                  ");
                        Console.WriteLine("                                                  ");
                        Console.WriteLine("                                                  ");
                        Console.WriteLine("                                                  ");
                        Console.WriteLine("                                                  ");
                        Console.WriteLine("                   .~77777777~                    ");
                        Console.WriteLine("                 .~?YYYYYYYYYY?~.                 ");
                        Console.WriteLine("               .~JYYYYYYYYYYYYYYJ~.               ");
                        Console.WriteLine("             .!JYYYYYYYYJJYYYYYYYYJ~              ");
                        Console.WriteLine("           .!JYYYYYYYYJ!..!JYYYYYJ7:              ");
                        Console.WriteLine("         :!JYYYYYYYYJ~.    .~JYJ!:     ::         ");
                        Console.WriteLine("       :7JYYYYYYYYJ~.        .^.     ^JGGJ:       ");
                        Console.WriteLine("     :7YYYYYYYYY?~.     ~!         ^YGGGGGGJ^     ");
                        Console.WriteLine("   :7YYYYYYYYY?^     .!5GG5!.     :5BGGGGGGGGY^   ");
                        Console.WriteLine("  ^YYYYYYYYY?^     .!5GGGGGG5!.     ~5GGGGGGGGG!  ");
                        Console.WriteLine("  ~YYYYYYY?^     .7PGGGGGGGGGGP7.     ^YGGGGGGG7  ");
                        Console.WriteLine("  ~YYYYYYY?^     .7PGGGGGGGGGGP7.     ^YGGGGGGG7  ");
                        Console.WriteLine("  ^YYYYYYYYY?^     .!5GGGGGG57.     ~YGGGGGGGGG!  ");
                        Console.WriteLine("   :7YYYYYYYYY?:     .!5GG5!.     ~5GGGGGGGGGY~   ");
                        Console.WriteLine("     :7JYYYYY7^         !!     .!5GGGGGGGGGY^     ");
                        Console.WriteLine("       :!JY7:     :!.        .!5GGGGGGGGGJ^       ");
                        Console.WriteLine("         ::     :?PGP7.    .7PGGGGGGGGGJ:         ");
                        Console.WriteLine("              ^JGGGGGGP?:.7PGGGGGGGGP?:           ");
                        Console.WriteLine("              7PGGGGGGGGPPGGGGGGGGP?:             ");
                        Console.WriteLine("               .7PGGGGGGGGGGGGGGP7.               ");
                        Console.WriteLine("                 .!5GGGGGGGGGGP7.                 ");
                        Console.WriteLine("                   .!YYYYYYYY!.                   ");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        string[] blacklist = { "stackoverflow.com", "skillbox.ru", "geekbrains.com", "metanit.com", "w3schools.com", "learn.microsoft.com", "chat.openai.com" };
                        Console.WriteLine("Введите ссылку на сайт\n");
                        string link = Console.ReadLine();
                        if (blacklist.Any(i => link.IndexOf(i) >= 0))
                        {
                            Console.WriteLine("Данный сайт заблокирован в вашей стране");
                        }
                        else
                        {
                            Console.WriteLine("Добро пожаловать сидеть в ваших интернетах");
                        }






                        back();
                        break;
                }

                     

            }
        }
    }
}



