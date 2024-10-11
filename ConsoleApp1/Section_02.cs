using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangNguyenPhuongAnh_31231027548
{
    internal class Section_02
    {
        public static void Main()
        {

            Question_03();
            Question_04();
            Console.WriteLine("Press any key to stop");
            Console.ReadKey();

        }
        /// <summary>
        /// . to Add / Sum Two Numbers.
        /// </summary>
        public static void Question_01()
        {
            Console.Write("Enter a number a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter a number b = ");
            int b = int.Parse(Console.ReadLine());
            int sum = a + b;
            int product = a * b;
            Console.WriteLine($"{a} + {b} = {sum}");
            Console.WriteLine($"{a} * {b} = {product}");
        }
        /// <summary>
        /// . to Swap Values of Two Variables.
        /// </summary>
        public static void Question_02()
        {
            int a = 10, b = 20;
            Console.WriteLine("So a va b truoc khi doi la: a ={0}, b = {1}", a, b);
            (a, b) = (b, a);
            Console.WriteLine("So a va b sau khi doi la: a={0}, b = {1}", a, b);
            Console.ReadKey();
        }
    }
    /// <summary>
    /// . to Multiply two Floating Point Numbers.
    /// </summary>
    public static void Question_03()
    {
        float a = 10.15f;
        float b = 12.45f;
        Console.WriteLine("So a la: a = {0}", a);
        Console.WriteLine("So b la: b = {0}", b);
        float kq = a * b;
        Console.WriteLine($"{a} * {b} = {kq}");

    }
    /// <summary>
    /// . to convert feet to meter.
    /// </summary>
    public static void Question_04()
}
    public static void Question_10()
    (//365 = 1 y 1 w 3 da
     int days = int.Parse(Console.ReadLine());
int years = days / 365 
int 






