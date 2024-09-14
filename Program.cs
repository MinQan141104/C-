namespace FunctionIn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DoSomeThing(1000);
            DoSomeThingV2(200);
        }

        static void DoSomeThing(int n)//đây gọi là kiểu truyền tham trị
            //không bị ảnh hưởng bởi giá trị gốc
        {
            n = 500;
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{i} ");
            }
            //lam gi cung phai co trach nhiem, in xong phai xuong dong.
            Console.WriteLine();
        }

        static void DoSomeThingV2(in int n)
            //Truyền tham trị 
            //in khiến cho tham số đầu vào trở thành READONLY, tức là chỉ xài mà ko dc sửa. Đảm bảo đầu vào giữ nguyên ý định dc truyền vào hàm.
        {
            //n = 1000; ko thể gán giá trị khác
            Console.WriteLine("The list of numbers from 1 to " + n);
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{i} ", n);
            }
            Console.WriteLine();
        }
    }
}
