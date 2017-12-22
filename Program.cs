using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLib.WordOfTanks;
using MyClassLib;


namespace Day7__Tanks_
{
    class Program
    {
        static void Main(string[] args)
        {
           

              Tank[] t34 = new Tank[5];
              t34[0] = new Tank("Джейк");
              t34[1] = new Tank("Биби");
              t34[2] = new Tank("Пупырка");
              t34[3] = new Tank("Фин");
              t34[4] = new Tank("БиМо");

              Tank[] Pantera = new Tank[5];
              Pantera[0] = new Tank("Sponge");
              Pantera[1] = new Tank("Patrick");
              Pantera[2] = new Tank("Krabs");
              Pantera[3] = new Tank("Perl");
              Pantera[4] = new Tank("Garry");
              Console.WriteLine("\t\t\tУчастники!");
              Tank[] Vinner = new Tank[5];
              Console.ForegroundColor = ConsoleColor.DarkRed;
              Console.WriteLine("Танки Т-34 : \t");
              Console.ForegroundColor = ConsoleColor.White;
              foreach (var i in t34)
              {
                  Console.WriteLine(i.Show());
              }
              Console.WriteLine();
              Console.ForegroundColor = ConsoleColor.DarkRed;
              Console.WriteLine("Танки Pantera : \t");
              Console.ForegroundColor = ConsoleColor.White;
              foreach (var i in Pantera)
              {
                  Console.WriteLine(i.Show());
              }
              Console.WriteLine();

              Console.WriteLine("");
              for (int i = 0; i < Vinner.Length; i++)
              {
                  Console.ForegroundColor = ConsoleColor.DarkRed;
                  Console.WriteLine((i+1)+" РАУНД! \n"+" танк Т34 против Pantera ");
                  Console.ForegroundColor = ConsoleColor.White;
                  Console.WriteLine(" _____");
                  Console.WriteLine("|  "+(i+1)+"  ||__ ........");
                  Console.WriteLine("|_____||   ********");
                  Console.WriteLine(" ooooo");
                  Vinner[i] = t34[i] * Pantera[i];
                  Console.WriteLine("Победитель: \t"+Vinner[i].Show());
              }
              Console.WriteLine();


              Console.WriteLine();



              /*Разработать программу, моделирующую танковый бой. 
              В танковом бою участвуют 5 танков «Т-34» и 
              5 танков «Pantera». Каждый танк («Т-34» и «Pantera») 
              описываются параметрами: «Боекомплект», «Уровень брони»,
              «Уровень маневренности». 
              Значение данных параметров задаются случайными 
              числами от 0 до 100. 
              Каждый танк участвует в парной битве, 
              т.е. первый танк «Т-34» сражается с первым танком
              «Pantera» и т. д. 
              Победа присуждается тому танку, который превышает
              противника по двум и более параметрам из трех 
              (пример: см. программу). 
              Основное требование: сражение (проверку на победу в бою)
              реализовать путем перегрузки оператора «*» (произведение).
              */
              

            #region
            Console.WriteLine("-------------------------");
            Present[] Candys = new Present[3];

           Candys[0] = new Present("Рахат","Рахат", 250,25);
            Candys[1] = new Present("Kinders", "Ferrero",  110, 45);
            Candys[2] = new Present("Mars", "Mars", 110, 45);
            for(int i=0;i<Candys.Length;i++)
            {
                Console.Write("№" + (i+1));
                 Candys[i].Show();
            }
              Console.WriteLine();
            Console.Write("Выберите номер товара ");
            int k = Int32.Parse(Console.ReadLine())-1;
            Console.Write("И номер второго товара ");
            int l = Int32.Parse(Console.ReadLine())-1;
            Console.WriteLine();
            if (Candys[k] == Candys[l])
                Console.WriteLine("Подарок " + Candys[k].name + " + Подарок " + Candys[l].name + " Одинаковы по весу и цене ");
            else
                Console.WriteLine("Не равноценные продукт ");
            Console.WriteLine();
            #endregion


            #region
            Console.WriteLine("------------------------------");

            Arrays massiv1 = new Arrays(10);
            Arrays massiv2 = new Arrays(10);

            massiv1.Show();
            massiv2.Show();
            Console.WriteLine();
            if (massiv1 > massiv2)
                Console.WriteLine("Сумма элементов первого массива больше второго ");
            else
                Console.WriteLine("Сумма элементов второго массива больше первого ");
            #endregion


            #region
            Console.WriteLine("------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Введите сумму в тенге: ");
            Console.ForegroundColor = ConsoleColor.White;
            int sum = Int32.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Введите вторую сумму :");
            Console.ForegroundColor = ConsoleColor.White;
            int sum2 = Int32.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("и валюту (dollars, euro, rub, tenge) :  ");
            Console.ForegroundColor = ConsoleColor.White;
            string cur = Console.ReadLine();
            Money tenge = new Money(sum,"tenge");

            Money dol = new Money(sum2, cur);
            Console.ForegroundColor = ConsoleColor.Red;
            if (tenge == dol)
            {
                Console.WriteLine(tenge.money + dol.money);
            }
            else
            {
                double res;
                Console.Write("Выберите валюту для конвертации итога : \n1-dollars; 2- euro; 3- rub; 4-tenge ");
                Console.ForegroundColor = ConsoleColor.White;
                int i = Int32.Parse(Console.ReadLine());
                if (i == 4)
                {
                    res = dol.Convert(i);
                    Console.WriteLine("Итого "+(tenge.money + res)+" tenge");
                }
                else
                {
                    res = tenge.Convert(i);
                    Console.WriteLine("Итого "+(dol.money + res)+" "+cur);
                }
            }
            #endregion
        }
    }
}
