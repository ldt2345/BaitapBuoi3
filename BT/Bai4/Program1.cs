using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Program1
    {
        static void Main(string[] args)
        {
            Vehicle vh = new Vehicle("Tu", "Honda",35.000f,100);
            vh.xuat();
            Console.ReadKey();
        }
    }
}
