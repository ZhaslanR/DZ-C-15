using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    public delegate void GetMassage(string mas);
    public class Forex
    {
        public string NameShare { get; set; }
        public int Price { get; private set; }

        private GetMassage massage;

        public Forex()
        {
            NameShare = "Акция Tele2";
            Price = 2000;
        }

        public void PurchaseOfShare(int price, string name)
        {
            if(Price <= price && NameShare == name)
            {
                Console.WriteLine("Вы купили акции " + name + " за " + price + "$");
            }
            else if(Price > price)
            {
                Console.WriteLine("У вас недостаточно средств");
            }
            else if(NameShare == name)
            {
                Console.WriteLine("У нас нету такой акции");
            }
        }

    }
}
