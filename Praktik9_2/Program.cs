using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik9_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone();
            phone.Brend = "Honor";
            phone.BattaryLevel = 28;
            int battary = phone.BattaryLevel;

            phone.UsePhone(phone.Brend, ref battary);
            phone.UsePhone(phone.Brend, ref battary);
        }
    }
}
