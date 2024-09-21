using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_XE_KT
{
    internal class Xe
    {
        string bienSo;
        string tenXe;
        int trongTai;
        DateTime ngayDangKiem;
        public Xe() { }
        public Xe(string bienSo, string tenXe, int trongTai, DateTime ngayDangKiem)
        {
            this.bienSo = bienSo;
            this.tenXe = tenXe;
            this.trongTai = trongTai;
            this.ngayDangKiem = ngayDangKiem;
        }

        public string BienSo { get => bienSo; set => bienSo = value; }

        public virtual void Nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập biển số: ");
            this.bienSo = Console.ReadLine();
            Console.WriteLine("Nhập tên xe: ");
            this.tenXe = Console.ReadLine();
            Console.WriteLine("Nhập trọng tải: ");
            this.trongTai = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập ngày đăng kiểm: ");
            this.ngayDangKiem = DateTime.Parse(Console.ReadLine());
        }
        public virtual void Xuat()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Thông tin các xe");
            Console.WriteLine("Biển số: " + this.bienSo);
            Console.WriteLine("Tên xe: {0}", this.tenXe);
            Console.WriteLine("Trọng tải: {0}", this.trongTai);
            Console.WriteLine(String.Format("Ngày đăng kiểm: {0}", this.ngayDangKiem));
        }
    }
}
