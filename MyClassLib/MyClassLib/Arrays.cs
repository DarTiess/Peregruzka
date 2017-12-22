using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib
{
    public class Arrays
    {
        /*2.	Дан класс сожержащий внутри себя массив. Реализовать перегрузку 
операторов < , > так, чтобы если сумма элементов массива 1 класса больше, возвращалось значение
true и наоборот.*/
        int size;
        int[] arr;
        static Random rand = new Random();
        public Arrays(int size)
        {
            this.size = size;
            this.arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(10, 100);
            }
        }

        public void Show()
        {
            foreach (var i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public static bool operator>(Arrays obj1, Arrays obj2)
        {
            int count1 = 0;
            int count2 = 0;
            for(int i = 0; i < obj1.arr.Length; i++)
            {
                count1 += obj1.arr[i];
            }
            for (int i = 0; i < obj2.arr.Length; i++)
            {
                count2 += obj2.arr[i];
            }
            if (count1>count2)
            return true;
            return false;
        }
        public static bool operator <(Arrays obj1, Arrays obj2)
        {
            int count1 = 0;
            int count2 = 0;
            for (int i = 0; i < obj1.arr.Length; i++)
            {
                count1 += obj1.arr[i];
            }
            for (int i = 0; i < obj2.arr.Length; i++)
            {
                count2 += obj2.arr[i];
            }
            if (count1 <count2)
                return true;
            return false;
        }
    }
}
