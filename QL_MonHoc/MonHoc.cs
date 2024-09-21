using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_MonHoc
{
    internal class MonHoc
    {
        String maMon;
        public string MaMon { get => maMon; set => maMon = value; }
        String tenMon;
        DateTime ngayDK;
        int soTC;
        public MonHoc()
        {
        }
        public MonHoc(string maMon, string tenMon, DateTime ngayDK, int soTC)
        {
            this.maMon = maMon;
            this.tenMon = tenMon;
            this.ngayDK = ngayDK;
            this.soTC = soTC;
        }
        public void Nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập mã môn: "); this.MaMon = Console.ReadLine();
            Console.WriteLine("Nhập tên môn: "); this.tenMon = Console.ReadLine();
            Console.WriteLine("Nhập ngày ĐK: "); this.ngayDK = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số TC: "); this.soTC = int.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("----- Xuất thông tin các môn học");
            Console.WriteLine("Mã môn: " + this.MaMon);
            Console.WriteLine("Tên môn: " + this.tenMon);
            Console.WriteLine(String.Format("Ngày ĐK: {0: dd/MM/yyyy}", this.ngayDK));
            Console.WriteLine("Số TC: {0}", this.soTC);
        }
    }
}
