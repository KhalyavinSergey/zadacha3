﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha3
{
    class Program
    {
        static void Main(string[] args)

        {
            double sum = 0;//сумма
            int n = 1;//количество проходов
            double temp;//предыдущий результат, для проверки точности
            do
            {
                temp = sum;
                sum += Math.Pow((-1), n + 1) / Factorial(n);
                n++;
            }
            while (Math.Abs(sum - temp) > 0.01);
            Console.WriteLine("Сумма ряда: " + sum);
            Console.ReadLine();
        }
          private static double Factorial(int i)
        {
        if (i <= 1) return 1; 
        else 
            return Factorial(i - 1) * i;
         }
    }
}
