using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Tamgiac
    {
        int ma;

        public int Ma
        {
            get { return ma; }
            set
            {
                if (value > 0)
                    ma = value;
            }
        }
        int mb;

        public int Mb
        {
            get { return mb; }
            set 
            { 
                if(value > 0)
                mb = value; 
            }
        }
        int mc;

        public int Mc
        {
            get { return mc; }
            set 
            {
                if(value > 0)
                mc = value; 
            }
        }
        public Tamgiac()
        {
            ma = 20;
            mb = 15;
            mc = 10;
        }
        public Tamgiac(int ma, int mb, int mc)
        {
            if (ma < 0 || mb < 0 || mc < 0 || (ma + mb < mc) || (mb + mc < ma) || (ma + mc < mb))
            {
                ma = 0;
                mb = 0;
                mc = 0;
            }
            else
            {
                Ma = ma;
                Mb = mb;
                Mc = mc;
            }
        }
        public int TinhChuVi()
        {
            return ma + mb + mc;
        }
        public double DienTich()
        {
            double p = TinhChuVi()/2;
            return Math.Sqrt(p*(p - ma)*(p-mb)*(p-mc));
        }
        public void XacDinhTamGiac()
        {
           if((ma + mb < mc) || (mb + mc < ma) || (ma + mc < mb))
           {
               Console.WriteLine("Khong phai la tam giac");
           }
           else if(ma ==  mb && mb == mc && ma == mc)
           {
               Console.WriteLine("Tam giac deu");
           }
           else if (ma == mb || ma == mc || mc == mb)
           {
               Console.WriteLine("Tam giac can");
           }
           else Console.WriteLine("Tam giac thuong");
        }
        public void ToString()
        {
            Console.WriteLine( "Chi so ba canh lan luot la: " + ma + " " + mb + " " + mc + " " + "Chu vi la: "  + TinhChuVi() +  "Dien tich la: " + DienTich());
            XacDinhTamGiac();
        }
    }
}
