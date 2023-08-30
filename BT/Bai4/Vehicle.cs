using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Vehicle
    {
        string chuxe;

        public string Chuxe
        {
            get { return chuxe; }
            set { chuxe = value; }
        }
        string loaixe;

        public string Loaixe
        {
            get { return loaixe; }
            set { loaixe = value; }
        }
        float trigiaxe;

        public float Trigiaxe
        {
            get { return trigiaxe; }
            set 
            {
                if (value >= 0)
                    trigiaxe = value;
                else Console.WriteLine("Loi roi");
            }
        }
        int dungtichxilanh;

        public int Dungtichxilanh
        {
            get { return dungtichxilanh; }
            set 
            {
                if (value >= 0)
                    dungtichxilanh = value;
                else Console.WriteLine("Loi roi");
            }
        }
        public float thue()
        {
            if (Dungtichxilanh <= 100)
                return Trigiaxe * 0.01f;
            else if (Dungtichxilanh <= 200)
                return Trigiaxe * 0.03f;
            else return Trigiaxe * 0.05f;
        }
        public Vehicle()
        { 
        }
        public Vehicle(string chuxe, string loaixe, float trigiaxe, int dungtichxilanh)
        {
            this.chuxe = chuxe;
            this.loaixe = loaixe;
            Trigiaxe = trigiaxe;
            Dungtichxilanh = dungtichxilanh;
        }
        public void xuat()
        {
            Console.WriteLine("Ten chu xe: {0}, Loai xe: {1}, Dung tich: {2}, Tri gia: {3}, Thue phai nop: {4}", chuxe, loaixe, Dungtichxilanh, Trigiaxe, thue());
        }
    }
}
