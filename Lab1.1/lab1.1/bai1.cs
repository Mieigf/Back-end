using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        int luaChon;
        do
        {
            Console.WriteLine("\n===== MENU BÀI TẬP LAB 1.1 =====");
            Console.WriteLine("1. Xin chào và tuổi");
            Console.WriteLine("2. Diện tích hình chữ nhật");
            Console.WriteLine("3. Đổi độ C sang độ F");
            Console.WriteLine("4. Kiểm tra số chẵn/lẻ");
            Console.WriteLine("5. Tính tổng và tích hai số");
            Console.WriteLine("6. Kiểm tra âm/dương/0");
            Console.WriteLine("7. Kiểm tra năm nhuận");
            Console.WriteLine("8. In bảng cửu chương");
            Console.WriteLine("9. Tính giai thừa");
            Console.WriteLine("10. Kiểm tra số nguyên tố");
            Console.WriteLine("0. Thoát");
            Console.Write("Nhập lựa chọn của bạn: ");

            luaChon = int.Parse(Console.ReadLine());
            Console.WriteLine(); // dòng trống

            switch (luaChon)
            {
                case 1:
                    Bai1();
                    break;
                case 2:
                    Bai2();
                    break;
                case 3:
                    Bai3();
                    break;
                case 4:
                    Bai4();
                    break;
                case 5:
                    Bai5();
                    break;
                case 6:
                    Bai6();
                    break;
                case 7:
                    Bai7();
                    break;
                case 8:
                    Bai8();
                    break;
                case 9:
                    Bai9();
                    break;
                case 10:
                    Bai10();
                    break;
                case 0:
                    Console.WriteLine("Tạm biệt!");
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ, vui lòng thử lại.");
                    break;
            }

        } while (luaChon != 0);
    }

    static void Bai1()
    {
        Console.Write("Nhập tên của bạn: ");
        string ten = Console.ReadLine();

        Console.Write("Nhập tuổi của bạn: ");
        int tuoi = int.Parse(Console.ReadLine());

        Console.WriteLine($"Xin chào {ten}, bạn {tuoi} tuổi!");
    }

    static void Bai2()
    {
        Console.Write("Nhập chiều dài: ");
        double dai = double.Parse(Console.ReadLine());

        Console.Write("Nhập chiều rộng: ");
        double rong = double.Parse(Console.ReadLine());

        Console.WriteLine($"Diện tích hình chữ nhật là: {dai * rong}");
    }

    static void Bai3()
    {
        Console.Write("Nhập nhiệt độ °C: ");
        double c = double.Parse(Console.ReadLine());

        double f = (c * 9 / 5) + 32;
        Console.WriteLine($"Nhiệt độ °F: {f}");
    }

    static void Bai4()
    {
        Console.Write("Nhập số nguyên: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(n % 2 == 0 ? "Số chẵn" : "Số lẻ");
    }

    static void Bai5()
    {
        Console.Write("Nhập số thứ nhất: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Nhập số thứ hai: ");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine($"Tổng: {a + b}");
        Console.WriteLine($"Tích: {a * b}");
    }

    static void Bai6()
    {
        Console.Write("Nhập số: ");
        double n = double.Parse(Console.ReadLine());

        if (n > 0)
            Console.WriteLine("Số dương");
        else if (n < 0)
            Console.WriteLine("Số âm");
        else
            Console.WriteLine("Số 0");
    }

    static void Bai7()
    {
        Console.Write("Nhập năm: ");
        int year = int.Parse(Console.ReadLine());

        bool isLeap = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        Console.WriteLine(isLeap ? "Năm nhuận" : "Không phải năm nhuận");
    }

    static void Bai8()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"\nBảng cửu chương {i}:");
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"{i} x {j} = {i * j}");
            }
        }
    }

    static void Bai9()
    {
        Console.Write("Nhập n: ");
        int n = int.Parse(Console.ReadLine());

        long gt = 1;
        for (int i = 1; i <= n; i++)
        {
            gt *= i;
        }

        Console.WriteLine($"Giai thừa của {n} là: {gt}");
    }

    static void Bai10()
    {
        Console.Write("Nhập số nguyên: ");
        int n = int.Parse(Console.ReadLine());

        bool isPrime = true;

        if (n < 2) isPrime = false;
        else
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        Console.WriteLine(isPrime ? "Là số nguyên tố" : "Không phải số nguyên tố");
    }
}


