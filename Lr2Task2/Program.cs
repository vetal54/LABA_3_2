using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr2Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите время в формате 24 в виде <часы минуты секунды> через пробел:");
            string[] temp = Console.ReadLine().Split(' ');
            int h = Convert.ToInt32(temp[0]);
            int m = Convert.ToInt32(temp[1]);
            int s = Convert.ToInt32(temp[2]);
            MyTime t = new MyTime(h, m, s);
            Console.WriteLine(t.ToString());
            Console.WriteLine("Количество секунд с начала суток указанной даты");
            Console.WriteLine(t.TimeSinceMidnight());

            Console.WriteLine("Добавим к времени 1 минуту:  {0}", t.AddOneMinute());

            Console.WriteLine("Добавим к времени еще 1 час:  {0}", t.AddOneHour());

            Console.WriteLine("Добавим к времени еще 1 секунду:  {0}", t.AddOneSecond());

            Console.WriteLine("Введите количество секунд, которое хотите добавить:");
            int seconds = int.Parse(Console.ReadLine());
            Console.WriteLine(t.AddSeconds(seconds));

            Console.WriteLine("Введите количество секунд с начала суток, чтобы узнать время");
            int SecondFromTheStart = int.Parse(Console.ReadLine());
            Console.WriteLine(t.TimeSinceMidnight(SecondFromTheStart));

            Console.WriteLine("Для нахождения разницы двух моментов введите первое время в формате 24 в виде <часы минуты секунды> через пробел");
            string[] temp1 = Console.ReadLine().Split(' ');
            int h1 = Convert.ToInt32(temp1[0]);
            int m1 = Convert.ToInt32(temp1[1]);
            int s1 = Convert.ToInt32(temp1[2]);
            MyTime mt1 = new MyTime(h1, m1, s1);
            Console.WriteLine("Введите второе время в формате 24 в виде <часы минуты секунды> через пробел");
            string[] temp2 = Console.ReadLine().Split(' ');
            int h2 = Convert.ToInt32(temp2[0]);
            int m2 = Convert.ToInt32(temp2[1]);
            int s2 = Convert.ToInt32(temp2[2]);
            MyTime mt2 = new MyTime(h2, m2, s2);
            Console.WriteLine("Разница в секундах равняется: {0}", mt1.Difference(mt1, mt2));

            Console.WriteLine("Для того, чтобы узнать расписание звонков, введите нужное время в формате 24 в виде <часы минуты секунды> через пробел");
            string[] temp3 = Console.ReadLine().Split(' ');
            int h3 = Convert.ToInt32(temp3[0]);
            int m3 = Convert.ToInt32(temp3[1]);
            int s3 = Convert.ToInt32(temp3[2]);
            MyTime y3 = new MyTime(h3, m3, s3);
            Console.WriteLine(y3.WhatLesson());

            Console.ReadKey();
        }
    }
}
