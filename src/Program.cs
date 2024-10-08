namespace _7oct2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool task_check = true;
            while (task_check)
            {
                Console.Clear();
                Console.WriteLine("Выберите задачу (введите 100, чтобы прекратить выполнение): ");
                int task = Convert.ToInt32(Console.ReadLine());
// Задача 1
                if (task == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Задача 1.\r\nРазработайте программу, " +
                        "которая принимает четыре числа\r\nи находит среднее значение между ними");
                    Console.WriteLine("Введите первое число: ");
                    int n1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе число: ");
                    int n2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите третье число: ");
                    int n3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите четвертое число: ");
                    int n4 = Convert.ToInt32(Console.ReadLine());
                    double result = (n1 + n2 + n3 + n4) / 4.0;
                    Console.WriteLine($"Среднее значение из {n1}, {n2}, {n3}, {n4}: {result}");
                }
// Задача 2
                else if (task == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Задача 2.\r\nРазработайте программу-калькулятор, " +
                        "в которой можно выбрать действие\r\nдля двух вводимых пользователем чисел");
                    Console.WriteLine("Введите два числа: ");
                    double n1 = Convert.ToDouble(Console.ReadLine());
                    double n2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Вы ввели числа: {n1} и {n2}" +
                        "\r\nКакое действие выполнить?" +
                        "\r\n1. Сложение" +
                        "\r\n2. Вычитание" +
                        "\r\n3. Умножение" +
                        "\r\n4. Деление" +
                        "\r\n5. Нахождение остатка");
                    int step = Convert.ToInt32(Console.ReadLine());
                    if (step == 1)
                    {
                        Console.WriteLine($"{n1} + {n2} = {n1 + n2}");
                    }
                    else if (step == 2)
                    {
                        Console.WriteLine($"{n1} - {n2} = {n1 - n2}");
                    }
                    else if (step == 3)
                    {
                        Console.WriteLine($"{n1} * {n2} = {n1 * n2}");
                    }
                    else if (step == 4)
                    {
                        Console.WriteLine($"{n1} / {n2} = {n1 / n2}");
                    }
                    else if (step == 5)
                    {
                        Console.WriteLine($"{n1} % {n2} = {n1 % n2}");
                    }
                    else
                    {
                        Console.WriteLine("Введен неверный номер.\r\nТребуется число от 1 до 5." +
                        "\r\nНажмите на любую клавишу, чтобы вернуться к списку задач");
                    }
                }
// Задача 3
                else if (task == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Разработайте программу для конвертации температуры" +
                        "\r\nмежду градусами Цельсия, Кельвина, Фаренгейта");
                    Console.WriteLine("Выберите шкалу вводимой температуры:" +
                        "\r\n1. Цельсий" +
                        "\r\n2. Кельвин" +
                        "\r\n3. Фаренгейт");
                    int current_t = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите температуру: ");
                    double temp = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Выберите тип шкалы для конвертации:" +
                        "\r\n1. Цельсий" +
                        "\r\n2. Кельвин" +
                        "\r\n3. Фаренгейт");
                    int needed_t = Convert.ToInt32(Console.ReadLine());
                    if ((current_t == 1 && needed_t == 1) || (current_t == 2 && needed_t == 2) || (current_t == 3 && needed_t == 3))
                    {
                        Console.WriteLine("Выбраны одинаковые шкалы." +
                            "\r\nНажмите на любую клавишу, чтобы вернуться к списку задач");
                    }
                    else if (current_t == 1 && needed_t == 2)
                    {
                        Console.WriteLine($"Результат конвертации: {temp + 273.15} K");
                    }
                    else if (current_t == 1 && needed_t == 3)
                    {
                        Console.WriteLine($"Результат конвертации: {temp * 9 / 5 + 32} F");
                    }
                    else if (current_t == 2 && needed_t == 1)
                    {
                        Console.WriteLine($"Результат конвертации: {temp - 273.15} C");
                    }
                    else if (current_t == 2 && needed_t == 3)
                    {
                        Console.WriteLine($"Результат конвертации: {(temp - 273.15) * 9 / 5 + 32} F");
                    }
                    else if (current_t == 3 && needed_t == 1)
                    {
                        Console.WriteLine($"Результат конвертации: {(temp - 32) * 5 / 9} C");
                    }
                    else if (current_t == 3 && needed_t == 2)
                    {
                        Console.WriteLine($"Результат конвертации: {(temp - 32) * 5 / 9 + 273.15} K");
                    }
                    else
                    {
                        Console.WriteLine("Введены неверные числа.");
                    }
                }
// Задача 4
                else if (task == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Разработайте программу, которая позволяет определить имя файла (с расширением)" +
                        "\r\nпо введенному пути");
                    Console.WriteLine("Введите путь до файла:");
                    string? path = Console.ReadLine();
                    string[] files = path.Split("/");
                    Console.WriteLine($"Имя файла: {files[files.Length - 1]}");
                }
// Задача 5
                else if (task == 5)
                {
                    Console.Clear();
                    Console.WriteLine("Разработайте программу для нахождения самого длинного слова в предложении");
                    Console.Clear();
                    Console.WriteLine("Задача 3.\r\nРазработайте программу для нахождения самого длинного слова в предложении");
                    Console.WriteLine("Введите предложение: ");
                    string? sentence = Console.ReadLine();
                    string[] words = sentence.Split();
                    int len = words.Length;
                    int step_count = 0;
                    int letter_count = 0;
                    string biggest_word = "";
                    while (step_count < len)
                    {
                        if (letter_count < Convert.ToInt32(words[step_count].Length))
                        {
                            letter_count = Convert.ToInt32(words[step_count].Length);
                            biggest_word = words[step_count];
                        }
                        step_count++;
                    }
                    Console.WriteLine($"Самое длинное слово: {biggest_word}");
                }
// Задача 6
                else if (task == 6)
                {
                    Console.Clear();
                    Console.WriteLine("Разработайте программу, которая может перемножить два массива значений");
                    Console.WriteLine("Введите значения для первого массива через пробел:");
                    string[] list1 = Console.ReadLine().Split();
                    Console.WriteLine("Введите значения для второго массива через пробел:");
                    string[] list2 = Console.ReadLine().Split();
                    int count = 0;
                    while (count < list1.Length)
                    {
                        Console.WriteLine(Convert.ToDouble(list1[count]) * Convert.ToDouble(list2[count]));
                        count++;
                    }
                }
// Задача 7
                else if (task == 7)
                {
                    Console.Clear();
                    Console.WriteLine("Разработайте программу, которая может найти" +
                        "\r\nмаксимальное и минимальное число из пяти введенных");
                    Console.WriteLine("Введите числа через пробел:");
                    string[] numbers = Console.ReadLine().Split();
                    double n_min = Math.Min(Convert.ToDouble(numbers[0]), Convert.ToDouble(numbers[1]));
                    double n_max = Math.Max(Convert.ToDouble(numbers[0]), Convert.ToDouble(numbers[1]));
                    int count = 0;
                    while (count < numbers.Length)
                    {
                        if (Convert.ToDouble(numbers[count]) < n_min)
                        {
                            n_min = Convert.ToDouble(numbers[count]);
                        }
                        if (Convert.ToDouble(numbers[count]) > n_max)
                        {
                            n_max = Convert.ToDouble(numbers[count]);
                        }
                        count++;
                    }
                    Console.WriteLine($"Минимальное число: {n_min}");
                    Console.WriteLine($"Максимальное число: {n_max}");
                }
// Задача 8
                else if (task == 8)
                {
                    Console.Clear();
                    Console.WriteLine("Разработайте программу, которая выводит “пирамиду” из чисел" +
                        "\r\nиз количества уровней, введенных пользователем");
                    Console.WriteLine("Введите количество ступеней: ");
                    int steps = Convert.ToInt32(Console.ReadLine());
                    int count_main = 2;

                    Console.WriteLine("1");
                    while (count_main <= steps)
                    {
                        string layer = "1";
                        int count_layer = 2;
                        while (count_layer <= count_main)
                        {
                            layer += count_layer;
                            count_layer++;
                        }
                        Console.WriteLine(layer);
                        count_main++;
                    }
                }
// Часть 2
                else if (task == 9)
                {
                    Console.Clear();
                    Console.WriteLine("Напечатать полную таблицу умножения в виде:");
                    for (int n1 = 1; n1 <= 9; n1++)
                    {
                        string layer = "";
                        for (int n2 = 1; n2 <= 9; n2++)
                        {
                            layer += $"{n1} x {n2} = {n2 * n1}   ";
                        }
                        Console.WriteLine(layer);
                    }
                }
// Часть 3
                else if (task == 10)
                {
                    Console.Clear();
                    Console.WriteLine("Вариант 8." +
                        "\r\nРазработайте программу для нахождения самого длинного слова в предложении");
                    Console.WriteLine("Введите предложение: ");
                    string? sentence = Console.ReadLine();
                    string[] words = sentence.Split();
                    int len = words.Length;
                    int step_count = 0;
                    int letter_count = 0;
                    string biggest_word = "";
                    while (step_count < len)
                    {
                        if (letter_count < Convert.ToInt32(words[step_count].Length))
                        {
                            letter_count = Convert.ToInt32(words[step_count].Length);
                            biggest_word = words[step_count];
                        }
                        step_count++;
                    }
                    Console.WriteLine($"Самое длинное слово: {biggest_word}");
                }
// Завершение работы
                else if (task == 100)
                {
                    Console.Clear();
                    task_check = false;
                    Console.WriteLine("Выполнение завершено.");
                    Console.Clear();
                }
// Введено неверное число
                else
                {
                    Console.Clear();
                    Console.WriteLine("Введен неверный номер.");
                }
            }
        }
    }
}
