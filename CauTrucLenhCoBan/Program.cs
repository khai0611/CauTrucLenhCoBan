using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using <TênThưViện>; //Dùng để chỉ cho trình biên dịch biết rằng những thư viện được sử dụng trong chương trình

//Từ khóa namespace + tên namespace
namespace CauTrucLenhCoBan
{
    //Từ khóa class + tên class
    internal class Program
    {
        //Hàm chạy đầu tiên khi chương trình được biên dịch, được tạo sẵn khi tạo project
        static void Main(string[] args)
        {
            #region Console.Write() 
            //In ra giá trị trên màn hình nhưng không xuống dòng
            //Console.Write("HQK"); //In ra màn hình dòng chữ HQK
            //Console.Write(10); //In ra màn hình số 10
            //Console.Write(10.5f); //In ra màn hình số 10.5 (f biểu thị cho kiểu dữ liệu float)
            //Console.Write(true); //In ra màn hình chữ true của kiểu dữ liệu bool
            //Console.Write("Học C# \n"); //Có thể sử dụng \n để xuống dòng, tự động xuống dòng khi in ra màn hình
            #endregion

            #region Console.WriteLine()
            //In ra giá trị trên màn hình nhưng có xuống dòng
            //Console.WriteLine("HQK"); //In ra màn hình chữ HQK có xuống dòng
            //Console.WriteLine(22); //In ra màn hình số 22 có xuống dòng


            #endregion

            #region Console.Read()
            //Console.WriteLine(Console.Read()); //Đọc 1 kí tự từ bàn phím bằng lệnh Console.Read() sau đó in ra ký tự vừa đọc được
            #endregion

            #region Console.ReadLine()
            //Console.WriteLine(Console.ReadLine()); //đọc dữ liệu từ bàn phím cho đến khi gặp ký tự xuống dòng thì dừng. Sau đó in giá trị nhập ra màn hình
            #endregion

            #region Console.ReadKey()
            //Console.WriteLine("HQK"); 

            //Console.ReadKey(); //không truyền tham số vào thì mặc định là false
            //Console.ReadKey(false); // hiển thị phím ấn lên màn hình
            //Console.ReadKey(true); //không hiển thị phím ấn lên màn hình
            #endregion
        }
    }
}
