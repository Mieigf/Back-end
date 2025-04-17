using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13App
{
    class TapChi : TaiLieu
    {
        //khai bao thuoc tinh
        private int soPH;
        private int thangPH;
        //phuong thuc khoi tao mac dinh
        public TapChi() { }
        //phuong thuc khoi tao co tham so
        public TapChi(string maTL,string tenNXB,int soBanPH,int soPH,int thangPH) : base(maTL,tenNXB,soBanPH)
        {
            this.soPH = soPH;
            this.thangPH = thangPH;
        }
        public override void Nhap()
        {
            try
            {
                base.Nhap();
                Console.Write($"+ So phat hanh: ");
                soPH = int.Parse(Console.ReadLine() ?? " ");
                Console.Write("+Thang phat hanh: ");
                thangPH = int.Parse(Console.ReadLine() ?? " ");   
            }
            catch(Exception) 
            {
                throw;
            }
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"+So phat hanh: {soPH} ");
            Console.WriteLine($"+Thang phat hanh: {thangPH}");
        }
    }
}
