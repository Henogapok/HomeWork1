using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lesson1
{
    internal class HomeWork1
    {
        //1
        static void Exp10()
        {
            Console.Write("Введите двухзначное число: ");//запрос на добавление пользоваетелем числа 
            int num = Convert.ToInt32(Console.ReadLine());//ввод числа 
            if (num > 9 && num <= 99)
            {//проверка на условие того что число двухзначное 
                Console.WriteLine("Число десятков данного числа - {0}", num / 10);
                Console.WriteLine("Число единиц данного числа - {0}", num % 10);
                Console.WriteLine("Сумма цифр данного числа равна {0}", num / 10 + num % 10);
                Console.WriteLine("Произвидение цифр данного числа  - {0}", num / 10 * num % 10);
            }
            else
            {
                num = Convert.ToInt32(Console.ReadLine());//ввод числа
            }

        }

        //2
        static void Exp1()
        {
            int count = 0;
            char inputChar;
            Console.WriteLine("Введите символы с клавиатуры. Введите точку ('.') для завершения.");
            do
            {
                inputChar = Convert.ToChar(Console.ReadLine());
                if (inputChar == ' ')
                {
                    count++;
                }

            } while (inputChar != '.');

            Console.WriteLine("Количество введенных пробелов: {0}", count);

        }

        //3
        static void Exp41()
        {
            Console.WriteLine("Введите вес в фунтах");
            int funt = Convert.ToInt32(Console.ReadLine());
            double kg = funt * 0.453;
            Console.WriteLine("вес в киллограммах-{0}", kg);
        }

        //4
        static void Exp42()
        {
            for (int i = 0; i <= 10; i++)
            {
                int result = i * 9;
                Console.WriteLine("9 x {0}={1}", i, result);
            }

        }

        //5
        static void Exp34()
        {
            Console.WriteLine("Введите число");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1: Console.WriteLine("Понедельник"); break;
                case 2: Console.WriteLine("Вторник"); break;
                case 3: Console.WriteLine("Среда"); break;
                case 4: Console.WriteLine("Четверг"); break;
                case 5: Console.WriteLine("Пятница"); break;
                case 6: Console.WriteLine("Суббота"); break;
                case 7: Console.WriteLine("Воскресенье"); break;
                default: Console.WriteLine("В неделе всего 7 дней"); break;
            }
        }

        //6
        static void Exp35()
        {

            Console.WriteLine("Введите число");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1: Console.WriteLine("Январь"); break;
                case 2: Console.WriteLine("Февраль"); break;
                case 3: Console.WriteLine("Март"); break;
                case 4: Console.WriteLine("Апрель"); break;
                case 5: Console.WriteLine("Май"); break;
                case 6: Console.WriteLine("Июнь"); break;
                case 7: Console.WriteLine("Июль"); break;
                case 8: Console.WriteLine("Август"); break;
                case 9: Console.WriteLine("Сентябрь"); break;
                case 10: Console.WriteLine("Октябрь"); break;
                case 11: Console.WriteLine("Ноябрь"); break;
                case 12: Console.WriteLine("Декабрь"); break;
            }

        }

        //7
        static void Exp29()
        {
            bool X = false;
            bool Y = true;
            bool Z = false;

            // a. X и не (Z или Y) или не Z;
            bool resultA = X && !(Z || Y) || !Z;
            Console.WriteLine("a. Результат: {0}", resultA);

            // b. не X или X и (Y или Z);
            bool resultB = !X || (X && (Y || Z));
            Console.WriteLine("b. Результат: {0}", resultB);

            // c. (X или Y и не Z) и Z;
            bool resultC = (X || (Y && !Z)) && Z;
            Console.WriteLine("c. Результат: {0}", resultC);


        }

        //8
        static void Exp22()
        {
            Console.WriteLine("Введите число а");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число в");
            double b = Convert.ToInt32(Console.ReadLine());
            double arf = (a + b) / 2;
            double geom = Math.Pow(2, Math.Sqrt(a + b));
            Console.WriteLine("Среднее арифсетическое-{0}\n Среднее геометрическое {1}", arf, geom);
        }
        //9
        static void Exp23()
        {
            Console.WriteLine("Введите массу");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите объем");
            int v = Convert.ToInt32(Console.ReadLine());
            int p = m / v;
            Console.WriteLine("Плотность материала равна-{0}", p);
        }
        //10
        static void Exp18()
        {
            Console.WriteLine("Введите число-");
            int a = Convert.ToInt32(Console.ReadLine());
            int perimetr = a * 4;
            Console.WriteLine("Периметр квадрата равен-{0}", perimetr);
        }

        //11
        static void Exp19()
        {
            Console.WriteLine("Введите радиус окружности");
            int r = Convert.ToInt32(Console.ReadLine());
            int diametr = 2 * r;
            Console.WriteLine("Диаметр окружности равен-{0}", diametr);
        }

        //12 z=x3-2.5xy+1.78x2-2.5y+
        static void Exp21()
        {
            Console.WriteLine("Введите Х");
            var x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите У");
            var y = Convert.ToInt32(Console.ReadLine());

            var z = Math.Pow(3, x) - 2.5 * x * y + 1.78 * Math.Pow(2, x) - 2.5 * y + 1;
            Console.WriteLine("Решение  z=x^3-2.5xy+1.78x^2-2.5y+1= {0}", z);
        }
        //13 
        static void Exp28()
        {
            bool A = true;
            bool B = false;
            bool C = false;

            bool resultA = !(A && B);
            Console.WriteLine("a. Результат: {0}", resultA);
            bool resultB = A || !(B);
            Console.WriteLine("b. Результат: {0}", resultB);
            bool resultC = A && B || C;
            Console.WriteLine("c. Результат: {0}", resultC);

        }

        //14
        static void Exp31()
        {
            double Kilometrs = 1000;
            double Feets = 1000;
            Console.WriteLine("Расстояние в метрах-{0}\nРасстояние в футах-{1}", Kilometrs, Feets);
            double DistanceFeetToKilometrs = Feets * 0.000305;

            if (Kilometrs > DistanceFeetToKilometrs)
            {
                Console.WriteLine("Расстояние в киллометрах больше");
            }
            else
            {
                Console.WriteLine("Растояние в футах больше");
            }
        }

        //15
        static void Exp32()
        {
            Console.WriteLine("Введите число");
            double a = double.Parse(Console.ReadLine());
            if (a % 2 == 0) Console.WriteLine("Число четное");
            else Console.WriteLine("Число не четное ");

            if (a % 10 == 7) Console.WriteLine("Число заканчивается на 7");
            else Console.WriteLine("Число не заканчивается на 7");
        }

        //16
        static void Exp39()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.Write("20 ");
            }
        }
        //17
        static void Exp4()
        {
            Console.WriteLine("Введите А");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите B");
            int b = int.Parse(Console.ReadLine());

            if (a >= b)
            {
                Console.WriteLine("B должно быть больше A.");
                return;
            }

            for (int i = a; i <= b; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine(); // Переход на новую строку после вывода числа i несколько раз.
            }
        }

        //18
        static void Exp5()
        {
            int N = int.Parse(Console.ReadLine());
            int reverseN = 0;
            int originalN = N;

            while (N > 10)
            {
                int digit = N % 10;
                reverseN = reverseN * 10 + digit;
                N = N / 10;

            }
            Console.WriteLine("reverse number is-{0}", reverseN);
        }

        //19
        static void Exp8()
        {
            Console.WriteLine("Введите количество сантиметров");
            int santimetrs = int.Parse(Console.ReadLine());
            int meters = santimetrs / 100;
            Console.WriteLine("{0} сантиметров в метрах-{1}", santimetrs, meters);
        }
        //20
        static void Exp9()
        {
            int days = 234;
            int weeks = days / 7;
            Console.WriteLine("Количество прошедших недель-{0}", weeks);
        }
        static void Main(string[] args)
        {
            //Exp1();
            //Exp1();
            Exp4();

        }
    }

}
