using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik9_2
{
    internal class Phone
    {
        private string brend;
        private int battarylevel;

        public string Brend
        {
            get { return brend; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    brend = value;
                }
                else
                {
                    Console.WriteLine("Ошибка: строка пустая или null.");
                }
            }
        }
        public int BattaryLevel
        {
            get { return battarylevel; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    battarylevel = value;
                }
                else
                {
                    Console.WriteLine("Ошибка: заряд батареи не может быть меньше %0 или больше %100.");
                }
            }
        }

        public void UsePhone(string brend, ref int battarylevel)
        {
            if (battarylevel > 0)
            {
                battarylevel -= 10;
                Console.WriteLine($"Телефон {brend}, заряд %{battarylevel}.");
            }
            else
            {
                Console.WriteLine($"Телефон {brend}, разряжен.");
            }
        }
    }
}
