using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib
{
   public class Present
    {
        /*
ДОПОЛНИТЕЛЬНО.
1.	Создать класс с несколькими свойствами. Реализовать перегрузку 
операторов ==, != и Equals.*/
        public string name;
      public string productedBy;
        public int volume;
        public int price;
       
       
        public Present(string name, string productedBy, int volume, int price)
        {
            this.name = name;
            this.productedBy = productedBy;
            this.volume = volume;
            this.price = price;
         }
        
        public void Show()
        {
            Console.WriteLine("Наименование = "+name+"\n\tПроизводсво = "+productedBy+":\n\tОбъем = "+ volume+"\n\tЦена ="+ price);
        }
         public static bool operator==(Present obj1, Present obj2)
        {
            if ((obj1.volume == obj2.volume) && (obj1.price == obj2.price))
                return true;
            return false;
        }
        public static bool operator !=(Present obj1, Present obj2)
        {
            if ((obj1.volume != obj2.volume) && (obj1.price != obj2.price))
                return true;
            return false;
        }
       
    }
}
