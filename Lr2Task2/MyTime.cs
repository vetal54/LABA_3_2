using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr2Task2
{
    class MyTime
    {
        protected int hour;
        protected int minute;
        protected int second;
        public MyTime(int h, int m, int s)
        {
            hour = h;
            minute = m;
            second = s;
        }
        public override string ToString()
        {
            DateTime td = new DateTime(0001, 1, 1, hour, minute, second);
            return td.ToString("HH:mm:ss");
        }
        public int TimeSinceMidnight()
        {
            int secPerDay = 86400;//60 * 60 * 24
            int sec = (((second + minute * 60 + hour * 3600) % secPerDay) + secPerDay) % secPerDay;
            return sec;
        }
        public MyTime TimeSinceMidnight(int t)
        {
            int secPerDay = 86400;//60 * 60 * 24
            t = ((t % secPerDay) + secPerDay) % secPerDay;
            hour= t / 3600;
           minute = (t / 60) % 60;
            second = t % 60;
            return new MyTime(hour, minute, second);
        }
        public MyTime AddOneMinute()
        {//Тут можно было бы воспользоваться предедущими функциями, но, чтобы менять конкретную структуру 
         // (t) и сохранять изменения, я их не использую. Аналогично и в последствии.

            int temp = (((second + (minute + 1) * 60 + hour * 3600) % 86400) + 86400) % 86400;
            hour = temp / 3600;
            minute = (temp / 60) % 60;
            second = temp % 60;
            return new MyTime(hour, minute, second);
        }
        public MyTime AddOneHour()
        {
            int temp = (((second + minute * 60 + (hour + 1) * 3600) % 86400) + 86400) % 86400;
            hour = temp / 3600;
            minute = (temp / 60) % 60;
            second = temp % 60;
            return new MyTime(hour, minute, second);
        }
        public MyTime AddOneSecond()
        {
            int temp = (((second + 1 + minute * 60 + hour * 3600) % 86400) + 86400) % 86400;
            hour = temp / 3600;
            minute = (temp / 60) % 60;
            second = temp % 60;
            return new MyTime(hour, minute, second);
        }
        public MyTime AddSeconds(int s)
        {
            int temp = (((second + s + minute * 60 + hour * 3600) % 86400) + 86400) % 86400;
            hour = temp / 3600;
            minute = (temp / 60) % 60;
            second = temp % 60;
            return new MyTime(hour, minute, second);
        }
        public int Difference(MyTime mt1, MyTime mt2)
        {
            return mt1.TimeSinceMidnight() - mt2.TimeSinceMidnight();
        }
        public string WhatLesson()
        {
            int seconds = TimeSinceMidnight();
            if (seconds > 0 && seconds < 28800) return "Пары еще не начались";
            else if (seconds >= 28800 && seconds < 33600) return "1-ая пара";
            else if (seconds >= 33600 && seconds < 34800) return "перемена между 1-ой и 2-ой парой";
            else if (seconds >= 34800 && seconds < 39600) return "2-ая пара";
            else if (seconds >= 39600 && seconds < 40800) return "перемена между 2-ой и 3-ей парой";
            else if (seconds >= 40800 && seconds < 45600) return "3-ая пара";
            else if (seconds >= 45600 && seconds < 46800) return "перемена между 3-ей и 4-ой парой";
            else if (seconds >= 46800 && seconds < 51600) return "4-ая пара";
            else if (seconds >= 51600 && seconds < 52800) return "перемена между 4-ой и 5-ой парой";
            else if (seconds >= 52800 && seconds < 57600) return "5-ая пара";
            else if (seconds >= 57600 && seconds < 58200) return "перемена между 5-ой и 6-ой парой";
            else if (seconds >= 58200 && seconds < 63000) return "6-ая пара";
            else if (seconds >= 63000 && seconds < 86400) return "пары уже кончились";
            else return "Вы ввели неверное значение";
        }
    }
}
