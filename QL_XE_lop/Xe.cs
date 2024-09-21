using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_XE_lop
{
    internal class Xe
    {
        String bienSo;
        String tenXe;
        DateTime ngayDangKy;
        public Xe(){ }
        public Xe(string bienSo, string tenXe, DateTime ngayDangKy)
        {
            this.BienSo = bienSo;
            this.tenXe = tenXe;
            this.ngayDangKy = ngayDangKy;
        }

        public string BienSo { get => bienSo; set => bienSo = value; }

        public void Nhap(){     Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập biển số: "); BienSo = Console.ReadLine();
            Console.WriteLine("Nhập tên xe: "); tenXe = Console.ReadLine();
            Console.WriteLine("Nhập ngày đăng ký: ");
            ngayDangKy = DateTime.Parse(Console.ReadLine());
        }
        public void Xuat() { Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Thông tin các xe");
            Console.WriteLine("Biển số: " + this.BienSo);
            Console.WriteLine("Tên xe: {0}", this.tenXe);
            Console.WriteLine(String.Format("Ngày ĐK: {0: dd/MM/yyyy}", this.ngayDangKy));
        }
    }
}
