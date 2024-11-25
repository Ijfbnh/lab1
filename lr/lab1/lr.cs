using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr
{
    internal class Lr
    {
        public void task1()
        {
            double x = 27.3198;
            double factionalPart = x - Math.Floor(x);
            int d = (int)(factionalPart * 10);
            Console.WriteLine($"Первая цифра дробной части числа {x} = {d}");
        }
        public void task2()
        {
            Console.Write("введите количество секунд, прошедших с начала суток: ");
            int totalSecods = int.Parse(Console.ReadLine());
            int hours = totalSecods / 3600;
            int minutes = (totalSecods % 3600) / 60;
            Console.WriteLine($"прошло  {hours} часов и {minutes} минут");

        }
        public void task3()
        {
            Console.Write("введите часы  (0-10):");
            int hours = int.Parse(Console.ReadLine());
            Console.Write("введите минуты (0-59): ");
            int minutes = int.Parse(Console.ReadLine());
            Console.Write("введите секунды (0-59): ");
            int seconds = int.Parse(Console.ReadLine());
            double hourAngle = (hours % 12) * 30.0 + minutes * 0.5 + seconds * 0.0083;
            double minuteAngle = minutes * 6.0 + seconds * 0.1;
            double angle = Math.Abs(hourAngle - minuteAngle);
            Console.WriteLine($"угол между положением часовой стрелки в начале и ее положение в {hours}:{minutes}:{seconds} составляет {angle:F2} градусов ");
        }
        public void task4()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine($"до обмена : a={a}, b={b}");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"после обмена : a= {a}, b={b}");

        }
        public void task5()
        {
            Console.Write("введите длину первого катета : ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("введите длину второго катета :");
            double b = double.Parse(Console.ReadLine());

            double area = (a * b) / 2;
            double c = Math.Sqrt(a * a + b * b);
            double perimeter = a + b + c;
            Console.WriteLine($"площадь треугольника:{area}");
            Console.WriteLine($"периметр треугольника:{perimeter}");
        }
        public void task6()
        {
            Console.Write("введите четырехзначное число: ");
            int number = int.Parse(Console.ReadLine());
            if (number < 1000 || number > 9999)
            {
                Console.WriteLine("ошибка :чсло должно быть четырехзначным");
                return;
            }
            int product = 1;
            while (number > 0)
            {
                product *= number % 10;
                number /= 10;
            }
            Console.WriteLine($"ПРОИЗВЕДЕНИЕ ЦИФР : {product}");



        }
        public void task7()
        {
            Console.Write("введите трехзначное число");
            int number = int.Parse(Console.ReadLine());

            if (number < 100 || number > 999)
            {
                Console.WriteLine("ошибка");
                return;
            }
            string reversed = number.ToString()[2].ToString() + number.ToString()[1].ToString() + number.ToString()[0];
            Console.WriteLine($"обратное число {reversed}");

        }
        public void task8()
        {
            Console.Write("ВВЕДИТЕ ДЕЙСТВИТЕЛЬНОЕ ЧИСЛО ");
            double x = double.Parse(Console.ReadLine());
            double x2 = x * x;
            double x3 = x2 * x;
            double x4 = x3 * x;
            double result = 3 * x4 - 5 * x3 + 2 * x2 - x + 7;
            Console.WriteLine($"результат {result}");

        }
        public void task9()
        {
            Console.WriteLine("введите коэффициенты систем уравнений");
            Console.Write("a1: ");
            double a1 = double.Parse(Console.ReadLine());
            Console.Write("b1: ");
            double b1 = double.Parse(Console.ReadLine());
            Console.Write("c1: ");
            double c1 = double.Parse(Console.ReadLine());
            Console.Write("d1: ");
            double d1 = double.Parse(Console.ReadLine());

            Console.Write("a2: ");
            double a2 = double.Parse(Console.ReadLine());
            Console.Write("b2: ");
            double b2 = double.Parse(Console.ReadLine());
            Console.Write("c2: ");
            double c2 = double.Parse(Console.ReadLine());
            Console.Write("d2: ");
            double d2 = double.Parse(Console.ReadLine());

            Console.Write("a3: ");
            double a3 = double.Parse(Console.ReadLine());
            Console.Write("b3: ");
            double b3 = double.Parse(Console.ReadLine());
            Console.Write("c3: ");
            double c3 = double.Parse(Console.ReadLine());
            Console.Write("d3: ");
            double d3 = double.Parse(Console.ReadLine());

            // Вычисление определителей
            double D = a1 * (b2 * c3 - b3 * c2) - b1 * (a2 * c3 - a3 * c2) + c1 * (a2 * b3 - a3 * b2);

            if (D == 0)
            {
                Console.WriteLine("Определитель системы равен 0. Система не имеет единственного решения.");
            }
            else
            {

                double DX = d1 * (b2 * c3 - b3 * c2) - b1 * (d2 * c3 - d3 * c2) + c1 * (d2 * b3 - d3 * b2);

                double DY = a1 * (d2 * c3 - d3 * c2) - d1 * (a2 * c3 - a3 * c2) + c1 * (a2 * d3 - a3 * d2);

                double DZ = a1 * (b2 * d3 - b3 * d2) - b1 * (a2 * d3 - a3 * d2) + d1 * (a2 * b3 - a3 * b2);

                // Вычисление значений переменных
                double x = DX / D;
                double y = DY / D;
                double z = DZ / D;
                Console.WriteLine("\nсистема уровнений ");
                Console.WriteLine($"{a1,5}x +{b1,5}y + {c1,5}z = {d1,5}");
                Console.WriteLine($"{a2,5}x +{b2,5}y + {c2,5}z = {d2,5}");
                Console.WriteLine($"{a3,5}x +{b3,5}y + {c3,5}z = {d3,5}");
                Console.WriteLine($" решение системы x={x}, y={y}, z={z}");
            }


        }
        public void task10()
        {
            Console.WriteLine("География");
            Console.WriteLine("Государство   Столица   Население     Строй");
            Console.WriteLine("-----------------------------------------");

            // переменные
            string country1 = "Австралия";
            string capital1 = "Канберра";
            int population1 = 23130391;
            char structure1 = 'Ф';
            string country2 = "Австрия";
            string capital2 = "Вена";
            int population2 = 8420010;
            char structure2 = 'Ф';
            string country3 = "Италия";
            string capital3 = "Рим";
            int population3 = 61482020;
            string s1 = " УГ ";
            // вывод таблицы
            Console.WriteLine($" {country1,-12} {capital1,-10} {population1,10} {structure1}");
            Console.WriteLine($" {country2,-12} {capital2,-10} {population2,10} {structure2}");
            Console.WriteLine($" {country3,-12} {capital3,-10} {population3,10} {s1}");
            // примечание
            Console.WriteLine("\nПеречисляемый тип: Ф - федерация, УГ - унитарное государство");
        }
        public void task11()
        {
            Console.Write("Введите значение a: ");
            if (!double.TryParse(Console.ReadLine(), out double a))
            {
                Console.WriteLine("Некорректный ввод для a.");
                return;
            }

            Console.Write("Введите значение b: ");
            if (!double.TryParse(Console.ReadLine(), out double b))
            {
                Console.WriteLine("Некорректный ввод для b.");
                return;
            }

            Console.Write("Введите значение x: ");
            if (!double.TryParse(Console.ReadLine(), out double x))
            {
                Console.WriteLine("Некорректный ввод для x.");
                return;
            }

            Console.Write("Введите значение c: ");
            if (!double.TryParse(Console.ReadLine(), out double c))
            {
                Console.WriteLine("Некорректный ввод для c.");
                return;
            }

            // Проверки на допустимые значения для первой формулы
            if (a + Math.Pow(x, 2) <= 0)
            {
                Console.WriteLine("Ошибка: a + x^2 должно быть больше 0 для логарифма.");
                return;
            }

            if (b == 0)
            {
                Console.WriteLine("Ошибка: b не должно быть равно 0 для деления.");
                return;
            }

            // Вычисление первой формулы f
            double f = Math.Log(a + Math.Pow(x, 2)) + Math.Pow(Math.Sin(x / b), 2);
            Console.WriteLine($"Значение f: {f:F4}");

            // Проверки на допустимые значения для второй формулы
            if (x + a < 0)
            {
                Console.WriteLine("Ошибка: x + a должно быть больше или равно 0 для корня.");
                return;
            }

            if (x - b == 0)
            {
                Console.WriteLine("Ошибка: x не должно быть равно b для избежания деления на 0.");
                return;
            }

            // Вычисление второй формулы z
            double numerator = x + Math.Sqrt(x + a);
            double denominator = x - Math.Sqrt(Math.Abs(x - b));
            if (denominator == 0)
            {
                Console.WriteLine("Ошибка: знаменатель равен нулю.");
                return;
            }

            double z = Math.Exp(-c * x) * (numerator / denominator);
            Console.WriteLine($"Значение z: {z:F4}");
        }

    }
}
