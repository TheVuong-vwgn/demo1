using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_XE_lop
{
    internal class DanhSach
    {
        Dictionary<String, Xe> ds = new Dictionary<string, Xe> ();
        public void Nhap(){         Console.OutputEncoding = Encoding.UTF8;
            /*while (true){
                Console.WriteLine("------Nhập 0 để thoát, 1 để nhập");
                String option = Console.ReadLine ();
                if (option == "0") break;
                else if (option == "1"){
                    Xe x = new Xe ();
                    x.Nhap();
                    ds.Add(x.BienSo, x);
                }
            }*/
            Xe x = new Xe("T01", "Tai 1", DateTime.Parse("11/11/2021"));
            ds.Add(x.BienSo, x);
            ds.Add("K02", new Xe("K02", "Khach 2", DateTime.Parse("2/2/2022")));
        }
        public void Xuat(){
            foreach(Xe item in ds.Values)
                item.Xuat();
        }
    }
}
