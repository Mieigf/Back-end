using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab13App;

namespace Lab13App
{
    class Sach : TaiLieu
    {
        //khai bao cac thuoc tinh
        private string? tenTG;
        private int soTrang;
        //phuong thuc khoi tao mac dinh
        public Sach() { }
        //phuong thuc khoi tao co tham so
        public Sach(string maTL, string tenNXB, int soBanPH, string tenTG, int soTrang) : base(maTL, tenNXB, soBanPH)
        {
            this.tenTG = tenTG;
            this.soTrang = soTrang;
        }
        public override void Nhap()
        {
            try
            {
                base.Nhap();
                Console.Write("+ Ten tac gia: ");
                tenTG = Console.ReadLine();
                Console.Write("+ So trang: ");
                soTrang = int.Parse(Console.ReadLine() ?? "");
            }
            catch (Exception)
            {

                throw;
            }
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"+ Ten tac gia: {tenTG}");
            Console.WriteLine($"+ So trang: {soTrang}"); 
        }
    }
}