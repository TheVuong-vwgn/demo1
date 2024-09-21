using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_MonHoc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DanhSach ds = new DanhSach();
            ds.Nhap();
            ds.Xuat();
            Console.ReadLine();
        }
    }
}
