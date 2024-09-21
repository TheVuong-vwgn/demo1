using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_XE_KT
{
    internal class QuanLyXe
    {
        Dictionary<String, Xe> danhsach = new Dictionary<String, Xe>();
        public void Nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                Console.WriteLine("Nhập 0: thoat \t C: Cho hang \t D: Du lich");
                String option = Console.ReadLine().ToUpper();
                if (option == "0") break;
                else if (option == "C")
                {
                    Console.WriteLine("Nhap thong tin cho hang");
                    XeChoHang c = new XeChoHang();
                    c.Nhap();
                    danhsach.Add(c.BienSo, c);
                }else if (option == "D")
                {
                    Console.WriteLine("Nhap thong tin du lich");
                    Xe d = new XeDuLich();
                    d.Nhap();
                    danhsach.Add(d.BienSo, d);
                }
            }
        }
        public void Xuat()
        {
            foreach (Xe item in danhsach.Values)
                item.Xuat();
        }
        public void Tim1()
        {
            Console.WriteLine("Nhap bien so can tim: ");
            string bsTim = Console.ReadLine();
            if (danhsach.ContainsKey(bsTim))
            {
                Console.WriteLine("Co xe can tim, Thong tin la:");
                danhsach[bsTim].Xuat();
            }
            else Console.WriteLine("khong tim thay xe");
        }
    }
}
