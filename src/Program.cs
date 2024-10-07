using System.Security.Cryptography.X509Certificates;

namespace Practice
{
    internal class Program

    {

        public static void back()
        {
            Console.WriteLine("");
            Console.WriteLine("Вернуться назад?");
            Console.ReadLine();
            Console.Clear();

        }
        public static void Ex1()
        {
            Console.WriteLine("Введите число");
            decimal a = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Введите число");
            decimal b = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Введите число");
            decimal c = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Введите число");
            decimal d = decimal.Parse(Console.ReadLine());
            decimal avg = ((a + b + c + d) / 4);
            Console.WriteLine(avg);
            back();
        }
        public static void Ex2()
        {
            Console.WriteLine("Введите первое число");
            decimal x = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            decimal y = decimal.Parse(Console.ReadLine());
            decimal sum = x + y;
            decimal raz = x - y;
            decimal multiply = x * y;
            decimal del = x / y;
            decimal ost = x % y;
            Console.WriteLine(sum);
            Console.WriteLine(raz);
            Console.WriteLine(del);
            Console.WriteLine(ost);
            back();

        }
        public static void Ex3()
        {
            Console.Write("Enter temperature value: ");
            double temperature = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter unit (C for Celsius, K for Kelvin, F for Fahrenheit): ");
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
                    Console.WriteLine("Invalid unit. Please enter C, K, or F.");
                    return;
            }
            Console.WriteLine($"Celsius: {celsius:F2}");
            Console.WriteLine($"Kelvin: {kelvin:F2}");
            Console.WriteLine($"Fahrenheit: {fahrenheit:F2}");
            back();

        }
        public static void Ex4()
        {
            Console.WriteLine("Определение имени файла");

            Console.Write("Введите путь к файлу : ");
            string filePath = Console.ReadLine();

            string[] pathComponents = filePath.Split('\\');

            string fileName = pathComponents[pathComponents.Length - 1];

            Console.WriteLine($"Имя аайла: {fileName}");
            back();
        }
        public static void Ex5()
        {
            Console.WriteLine("Находим самое длинное слово в предложении\n");
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
            Console.Write("Введите размер первого массива: ");
            int size1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите размер второго массива: ");
            int size2 = Convert.ToInt32(Console.ReadLine());

            if (size1 != size2)
            {
                Console.WriteLine("Массивы должны быть одного размера!");
            }
            return;
            back();
        }
        public static void Ex7()
        {
            Console.WriteLine("Нахождение минимального и максимального числа из заданных\n");

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
            Console.WriteLine("Введите количество уровней пирамиды")
            Console.Readline(int a);
            string pyromid = "";
            for (int i = 1; i <= a; i++)
            {
                pyromid += i;
                Console.WriteLine(pyromid);
            }
            back();
        }

        static void Main(string[] args)
        {



            Console.WriteLine("Выберете раздел задач");
            Console.WriteLine("1. Задачи");
            Console.WriteLine("2. Таблица умножения");
            Console.WriteLine("3. Вариантивная часть. Роскомнадзор");
            int part = Convert.ToInt32(Console.ReadLine());
            switch (part)
            {
                case 1:


                    int exercise = Convert.ToInt32(Console.ReadLine());
                    switch (exercise)
                    {
                        case 1:
                            Ex1();
                            break;
                        case 2:
                            Ex2();
                            break;
                        case 3:
                            Ex3();
                            break;
                        case 4:
                            Ex4();
                            break;
                        case 5:
                            Ex5();
                            break;
                        case 6:
                            Ex6();
                            break;
                        case 7:
                            Ex7();
                            break;
                        case 8:
                            Ex8();
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Таблица умножения");
                    for (int i = 1; i < 10; i++)
                    { 
                        for (int j = 1; j < 10; j++)
                        {
                            Console.Write($"{i} x {j} = {i * j} ");
                        }
                        Console.WriteLine();
                    }
                    break;

                case 3:
                    Console.WriteLine("24 вариант. Роскомнадзор");

                    break;

                     

            }
        }
    }
}



