using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MyClassLib.WordOfTanks
{
    /*2.	В библиотеке классов «MyClassLib» создать папку «WordOfTanks»,
     *  а в ней разработать класс с именем «Tank».
*/
     public class Tank
    {
        /*В классе должно быть реализовано
●	Поля
закрытые поля, предназначенные для представления
1.	Названия танка.
2.	Уровня боекомплекта танка.
3.	Уровня брони. 
4.	Уровня маневренности.*/
       public string name;
        private int ammunation;
        private int armor;
        private int maneuver;
        /*●	Конструктор
        Конструктор с параметрами, обеспечивающий инициализацию всех полей класса Tank. 
        При этом Боекомплект, Уровень брони, Уровень маневренности инициализируются
        случайными числами от 0 до 100 %. 
        Название танка передаются в конструктор из функции Main(). 
        */

       static Random rnd = new Random();
        
        public Tank(string name)
        {
            Thread.Sleep(100);
            this.name = name;
          ammunation=rnd.Next(100);
           armor = rnd.Next(100);
           maneuver = rnd.Next(100);
        }

      

        /*
●	Перегрузка оператора «^»(произведение)
При перегрузке оператора «^» (произведение) 
должна быть реализована проверка на победу в бою одного танка
по отношению к другому. 
Критерий победы — победивший танк должен превышать проигравший 
танк не менее чем по двум из трех параметров 
(Боекомплект, Уровень брони, Уровень маневренности). 
*/
        public static Tank operator*(Tank obj1, Tank obj2)
        {
            int count1 = 0;
            int count2 = 0;
            Tank obj3=new Tank(" ");
            if (obj1.ammunation > obj2.ammunation)
            {
                count1++; }
            else { count2++; }
            if (obj1.armor > obj2.armor)
            {
                count1++;
            }
            else { count2++; }
            if (obj1.maneuver > obj2.maneuver)
            {
                count1++;
            }
            else { count2++; }


            if (count1 > count2) { 
                obj3.name = obj1.name;
                obj3.ammunation = obj1.ammunation;
                obj3.armor = obj1.armor;
                obj3.maneuver = obj1.maneuver;
               
            }
            else
            {
                obj3.name = obj2.name;
                obj3.ammunation = obj2.ammunation;
                obj3.armor = obj2.armor;
                obj3.maneuver = obj2.maneuver;
               
            }

            return obj3;
        }
        /*
●	Методы:
Получение текущих значений параметров танка: 
Бое­комплект, Уровень брони, Уровень маневренности 
в виде строки.
*/
        public string Show()
        {
            return name+"\tБоекомплект = "+ammunation+"\n\t\tУровень брони = "+armor+"\n\t\tУровень маневренности = "+maneuver;
        }

        /*
Важно! При разработке программы использовать обработку 
исключительных ситуаций. 
Варианты возможных исключительных ситуаций рассмотреть
самостоятельно!
*/

            
    }
    
}
