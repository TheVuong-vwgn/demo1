using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_XE_KT
{
    internal class XeDuLich : Xe
    {
        int soChoNgoi;

        public XeDuLich()
        {
        }

        public XeDuLich(string bienSo, string tenXe, int trongTai, DateTime ngayDangKiem) : base(bienSo, tenXe, trongTai, ngayDangKiem)
        {
            this.soChoNgoi = soChoNgoi;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhập số tấn: ");
            this.soChoNgoi = int.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Số Chổ ngồi: {0}", this.soChoNgoi);
        }
    }
}
