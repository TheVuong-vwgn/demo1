using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_XE_KT
{
    internal class XeChoHang : Xe
    {
        double soTan;

        public XeChoHang()
        {
        }

        public XeChoHang(string bienSo, string tenXe, int trongTai, DateTime ngayDangKiem) : base(bienSo, tenXe, trongTai, ngayDangKiem)
        {
            this.soTan = soTan;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhập số tấn: "); 
            this.soTan = double.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Số tấn: {0}", this.soTan);
        }
    }
}
