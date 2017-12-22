using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib
{
   
    public class Money
    {
        /*
3.	Задание на примере из урока:
Необходимо реализовать второй вариант сложения денег – чтобы можно было 
суммировать деньги в разных валютах.
Для этого создайте отдельный класс, который будет предоставлять механизм
конвертации денег по заданному курсу.
Кроме этого, перегрузите для класса Money оператор сравнения «==» (при перегрузке
данного оператора, 
обязательной является и перегрузка противоположного ему оператора «!=»).
*/
       public double money;
        public string currency;
       public double exchange;
        public Money(double money, string currency)
        {
            this.money = money;
            this.currency = currency;
            exchange = 0;
        }
        
        public static bool operator==(Money obj1, Money obj2)
        {
            if (obj1.currency == obj2.currency)
                return true;
            return false;
        }
        public static bool operator !=(Money obj1, Money obj2)
        {
            if (obj1.currency != obj2.currency)
                return true;
            return false;
        }
        public double Convert(int i)
        {
            double temp=0;
            switch (i) {
                case 1:
            exchange = 334.13;
            temp=money / exchange;
            return Math.Round(temp, 2);
               case 2:
                    exchange= 396.91;
                    temp = money / exchange;
                    return Math.Round(temp, 2);
                case 3:
                    exchange= 5.71;
                    temp = money / exchange;
                    return  Math.Round(temp, 2);
                case 4:
                    if (currency == "dollars")
                    {
                        exchange = 334.13;
                        temp = money * exchange;
                    }
                    if (currency == "euro")
                    {
                        exchange = 396.91;
                        temp = money * exchange;
                    }
                    if (currency == "rub")
                    {
                        exchange = 5.71;
                        temp = money * exchange;
                    }
                    return Math.Round(temp, 2);
                default: return Math.Round(temp, 2);
               

            }
        }
    }
}
