using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_XE_KT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            QuanLyXe ds = new QuanLyXe();
            int menu;
            do 
            {
                Console.WriteLine("Nhap 0: Thoat \t 1: Nhap \t 2: Xuat \t 3: Tim 1");
                menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 0: break;
                    case 1: ds.Nhap(); break;
                    case 2: ds.Xuat(); break;
                    case 3: ds.Tim1(); break;
                }
            } while (menu != 0);
        }
    }
}
