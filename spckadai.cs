using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            while (num + 1 > num)
            {
                Console.WriteLine("男性の平均身長");
                Console.WriteLine("身長を入力。[単位：cm]");
                int myon = int.Parse(Console.ReadLine());
                if (myon >= 116 && myon < 122)
                {
                    Console.WriteLine("6歳の平均身長です。");
                }
                else if (myon >= 122 && myon < 128)
                {
                    Console.WriteLine("7歳の平均身長です。");
                }
                else if (myon >= 128 && myon < 133)
                {
                    Console.WriteLine("8歳の平均身長です。");
                }
                else if (myon >= 133 && myon < 138)
                {
                    Console.WriteLine("9歳の平均身長です。");
                }
                else if (myon >= 138 && myon < 145)
                {
                    Console.WriteLine("10歳の平均身長です。");
                }
                else if (myon >= 145 && myon < 152)
                {
                    Console.WriteLine("11歳の平均身長です。");
                }
                else if (myon >= 152 && myon < 159)
                {
                    Console.WriteLine("12歳の平均身長です。");
                }
                else if (myon >= 159 && myon < 165)
                {
                    Console.WriteLine("13歳の平均身長です。");
                }
                else if (myon >= 165 && myon < 168)
                {
                    Console.WriteLine("14歳の平均身長です。");
                }
                else if (myon >= 168 && myon < 169)
                {
                    Console.WriteLine("15歳の平均身長です。");
                }
                else if (myon >= 169 && myon < 170)
                {
                    Console.WriteLine("16歳の平均身長です。");
                }
                else if (myon >= 170 && myon < 171)
                {
                    Console.WriteLine("17歳の平均身長です。");
                }
                else
                    break;
            }
        }
    }
}
