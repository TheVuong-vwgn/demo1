using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_MonHoc
{
    internal class DanhSach
    {
        Dictionary<String, MonHoc> ds = new Dictionary<string, MonHoc> ();
        public void Nhap()
        {
            while (true){
                Console.WriteLine("------Nhập 0 để thoát, 1 để nhập");
                String option = Console.ReadLine ();
                if (option == "0") break;
                else if (option == "1"){
                    MonHoc x = new MonHoc ();
                    try{
                        x.Nhap();
                        ds.Add(x.MaMon, x);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Nhập trùng mã hoặc sai kiểu");
                    }
                }
            }
            //ds.Add("T01", new MonHoc("T01", "Tin UD", DateTime.Parse("11/11/2021"), 3));
            //ds.Add("A02", new MonHoc("A02", "Anh Văn", DateTime.Parse("11/11/2021"), 2));
        }
        public void Xuat()
        {
            foreach(MonHoc x in ds.Values)
                x.Xuat();
        }
    }
}
