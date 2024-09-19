using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {

        public class Tasks
        {
            public void FirstTask()
            {
                Console.WriteLine("Известны первый и пятый члены арифметической прогрессии. Найти величину члена прогрессии с номером N и сумму N членов.");
                Console.Write("Введите первый член арифметической прогрессии: ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите пятый член арифметической прогрессии: ");
                double b = Convert.ToDouble(Console.ReadLine());
                double d = (b - a) / 4;
                // Формула n-го члена: an = a1 + (n - 1) * d
                // Формула суммы n-го члена: Sn = (a1 + an)/2 * n

                Console.Write("Введите число N: ");
                double n = Convert.ToDouble(Console.ReadLine());
                double an = (n - 1) * d + a;
                double sn = (a + an) / 2 * n;

                Console.WriteLine($"N-ный член прогрессии: {an}");
                Console.WriteLine($"Сумма {n} членов: {sn}");
            }
            public void SecondTask()
            {
                Console.WriteLine("Известны члены арифметической прогрессии с номерами N и M. Найти сумму членов с номерами от M до N (считать M < N).");
                Console.Write("Введите номер первого члена прогрессии (M): ");
                double m = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите первый член арифметической прогрессии: ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите номер второго члена прогрессии (N): ");
                double n = Convert.ToDouble(Console.ReadLine());

                if (m >= n)
                {
                    Console.WriteLine("Число M больше, чем N");
                    return;
                }

                Console.Write("Введите второй член арифметической прогрессии: ");
                double b = Convert.ToDouble(Console.ReadLine());

                //double d = (b - a) / (m - n);
                double s = (a + b) / 2 * n;
                Console.WriteLine($"Сумма членов от {a} до {b} : {s}");
            }
            public void ThirdTask()
            {
                Console.WriteLine("Заданы первый член и знаменатель геометрической прогрессии. Найти сумму членов с номерами от заданного номера K до заданного номера P (считать K < P).");
                Console.Write("Введите значение первого члена прогрессии: ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите знаменатель прогрессии: ");
                double q = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите последний номер прогрессии (кол-во итераций): ");
                double p = Convert.ToDouble(Console.ReadLine());
                double S = a * (1 - Math.Pow(q, p)) / (1 / 1 - q);

                Console.WriteLine($"Вывод прогрессии: {S}");
            }
            public void FourthTask()
            {
                Console.WriteLine($"451 градус по Фаренгейту? Как насчёт {(double)5 / 9 * (451 - 32)} градус по Цельсию?");
            }
            public void FifthTask()
            {
                Console.WriteLine("В классе N учеников. После контрольной работы было получено: А – пятерок, В – четверок, С – двоек, остальные тройки. Найти процент троек.");
                Console.Write("Введите кол-во учеников (N):");
                int n = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите кол-во пятёрок (A):");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите кол-во четверок (B):");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите кол-во двоек (C):");
                int c = Convert.ToInt32(Console.ReadLine());

                if (a + b + c > n)
                {
                    Console.WriteLine("Оценок больше, чем учеников.");
                    return;
                }

                int d = Convert.ToInt32((double)(n-(a+b+c))/n*100);
                Console.WriteLine($"Процент троек: {d}");
            }
        }
        static void Main(string[] args)
        {
            Tasks CurrentTask = new Tasks();
            CurrentTask.FifthTask();

            Console.ReadLine();
        }
    }
}
