using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class228
{
    class Program
    {
        static void Main(string[] args)
        {
            dogs dog1 = new dogs(3, 56, "Бультерьер");
            dogs dog2 = new dogs(2, 80, "Бультерьер");
            dogs dog3 = new dogs(4, 76, "Пудель");
            int t = 0;
            dog1.holka(ref t);
            dog2.holka(ref t);
            dog3.holka(ref t);
            Console.WriteLine("Всего подходящих собак - " + t);
                Console.ReadLine();
        }
    }

    class dogs
    {
        protected int year;
        protected int hight;
        protected string poroda;
        int count = 0;
        public dogs(int year, int hight, string poroda)
        {
            this.year = year;
            this.hight = hight;
            this.poroda = poroda;
        }
        public void holka(ref int count)
        {
            if ((year >= 2 && year <= 3) && (hight >= 55) && poroda.CompareTo("Бультерьер") == 0)
            {
                show();
                count++;
            }
        }

        public void show()
        {
            Console.WriteLine("{0} лет;  {1} см;  {2}  \n", year, hight, poroda);
        }
    }
    }

