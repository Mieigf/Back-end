using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13App
{
    class TaiLieu
    {
        //khai báo các thuộc tính
        protected string? maTL;
        protected string? tenNXB;
        protected int soBanPH;
        //phuong thuc khoi tao mac dinh
        public TaiLieu() { }
        //phuong thhuc khoi tao co tham so
       public TaiLieu(string maTl,string tenNXB,int soBanPH)
        {
            this.maTL = maTl;
            this.tenNXB = tenNXB;
            this.soBanPH = soBanPH;
        }
        //phương thức nhập thông tin tai liệu
        public virtual void Nhap()
        {
            try
            {
                Console.Write("+Ma tai lieu: ");
                maTL = Console.ReadLine();
                Console.WriteLine("+Ten nha xua ban: ");
                tenNXB = Console.ReadLine();
                Console.WriteLine("+So ban phat hanh: ");
                soBanPH = int.Parse(Console.ReadLine() ?? "");
            }
            catch (Exception) 
            {
                throw;
            }
        }
        //phương thức xuất thông tin tai liệu
        public virtual void Xuat()
        {
            Console.WriteLine($"+Ma tai lieu: {maTL}");
            Console.WriteLine($"+Ten nha xuat ban: {tenNXB}");
            Console.WriteLine($"+So ban phat hanh: {soBanPH}");
        }
    }
}
