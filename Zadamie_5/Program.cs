using System;
using System.Collections.Generic;


namespace Zadamie_5
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Массив чисел в диапозоне от -100 до 100:");
            int[,] numbers = new int[5, 10];  // задаются строки и столбцы
            Random ran = new Random(); // задаем переменую для рандомных чисел 
            var check = new HashSet<int>(); // будет смотреть дубль числа

            for (int i = 0; i < numbers.GetLength(0); i++) // numbers.GetLength(0) сьроки 5
            {
                for (int j = 0; j < numbers.GetLength(1); j++) // numbers.GetLength(1) столбцы 10
                {
                    int Numbers;
                    Numbers = ran.Next(-100, 100); // генерирует рандомные числа
                    while (check.Contains(Numbers))  // если находит такоеже число то его пересоздает 
                    {
                        Numbers = ran.Next(-100, 100); // если есть дубль то по новой
                    }
                    check.Add(Numbers);     // если нету дубля то дальше
                    numbers[i, j] = Numbers;

                }
            }

            for (int i = 0; i < numbers.GetLength(0); i++) //задает строки
            {
                for (int j = 0; j < numbers.GetLength(1); j++) // задает столбцы
                {
                    Console.Write($" |{numbers[i, j]} \t"); // выводит получившийся результат

                }
                Console.WriteLine();

            }

            Console.WriteLine("____________________________________________________________________________________");   // разделяет 

            Console.WriteLine("");
            for (int i = 0; i < numbers.GetLength(0); i++) // numbers.GetLength(0) сьроки 5
            {
                double min = int.MaxValue;          //перменная которая смотрит минимальное значение из отрицательных
                for (var j = 0; j < numbers.GetLength(1); j++) //  столбцы 10
                {
                    if (numbers[i, j] < min)        // смотрит минимальное по каждой строке
                    {
                        min = numbers[i, j];        // Минимальное
                    }

                }
                Console.WriteLine("Минимальное значение: " + min);      //выводим все минимальные
            }
            Console.WriteLine("____________________________________________________________________________________");   // разделяет 

            Console.WriteLine();
            for (int i = 0; i < numbers.GetLength(0); i++)    // numbers.GetLength(0) сьроки 5        
            {
                double max = int.MinValue;          //перменная которая смотрит минимальное значение из отрицательных
                for (var j = 0; j < numbers.GetLength(1); j++)   //  столбцы 10   
                {
                    if (numbers[i, j] > max)        // смотрит максимальное 
                    {
                        max = numbers[i, j];        // Максимальное
                    }

                }
                Console.WriteLine("Максимальное значение: " + max);         //выводим все максимальные
            }

            Console.WriteLine("____________________________________________________________________________________");    // разделяет 

            Console.WriteLine("");
            for (int i = 0; i < numbers.GetLength(0); i++) // numbers.GetLength(0) сьроки 5
            {
                double min = int.MaxValue;          //перменная которая смотрит минимальное значение из отрицательных
                for (var j = 0; j < numbers.GetLength(1); j++) //  столбцы 10
                {
                    if (numbers[i, j] < min)        // смотрит минимальное по каждой строке
                    {
                        min = numbers[i, j];        // Минимальное
                    }

                }
                Console.WriteLine("Минимальное значение: " + min);      //выводим все минимальные
                Console.WriteLine("____________________________________________________________________________________");   // разделяет 

                for (int j = -10; j < 10; j++)      // диапозон просчета
                {
                    Console.WriteLine();
                    double sin = Math.Sin(j * min);         //синус
                    double cos = Math.Cos(j * min);         //косинус
                    double tan = Math.Tan(j * min);         // тангенс
                    double sin2 = Math.Round(sin, 2);       // округляет значения до 2 знаков после запятой
                    double cos2 = Math.Round(cos, 2);
                    double tan2 = Math.Round(tan, 2);

                    Console.Write(sin2 + "s\t");
                    Console.Write(cos2 + "c\t");
                    Console.Write(tan2 + "t\t");
                    Console.WriteLine();
                }
            }

            Console.WriteLine("____________________________________________________________________________________");  // разделяет 

            double[] per = new double[5];       // строки
            for (int i = 0; i < numbers.GetLength(0); i++)         // смотрит 5 строк
            {
                double ss = 0;
                for (int j = 0; j < numbers.GetLength(1); j++) // столбы
                {
                    ss += Math.Abs(numbers[i, j]); // обсолютное значение по горизантале и вертикале 
                    ss /= 10; // с 10 столбцов среднее арифмитическое 
                }
                per[i] = ss; // строка равна столбам
                Console.WriteLine("Среднее значение по строке: " + per[i]);
            }

            Console.WriteLine("____________________________________________________________________________________");  // разделяет 

            double Min = double.MaxValue;       //новые перемные мксимума и минимума
            double Max = double.MinValue;
            for (int i = 0; i < numbers.GetLength(0); i++)   // строки
            {
                if (per[i] < Min) // минимальное значение берет из строки
                {
                    Min = per[i];
                }
            }
            for (int i = 0; i < numbers.GetLength(0); i++)   // строки
            {
                if (per[i] > Max)   // максимальное значение берет из строки
                {
                    Max = per[i];
                }
            }
            Console.Write("Минимальное значение: " + Min); // из придыдущего берет минимальное по строке
            Console.WriteLine();
            Console.Write("Максимальное значение: " + Max); // из придыдущего берет максимальное по строке
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Среднее арифмитическое в cos, sin, tangens");
            for (int j = -10; j < 10; j++)     // берем от минимума
            {
                double sin = Math.Sin(j * Min);         //синус среднего
                double cos = Math.Cos(j * Min);         //косинус среднего
                double tan = Math.Tan(j * Min);         // тангенс среднего
                double sin2 = Math.Round(sin, 2);       // округляет значения до 2 знаков после запятой
                double cos2 = Math.Round(cos, 2);
                double tan2 = Math.Round(tan, 2);
                Console.WriteLine("");
                Console.Write(sin2 + "\t");
                Console.Write(cos2 + "\t");
                Console.Write(tan2 + "\t");
            }
        }    
    }   
}
