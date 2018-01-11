using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sharedlib;
namespace ConsoleLib
{
    public class ConsoleMatrix
    {
        public static int[,] Input()
        {
            string tmp,tmp2 = "";
            tmp = Console.ReadLine();
            while (tmp != "")
            {
                tmp2 += '\n' + tmp + " ";
                tmp = Console.ReadLine();
            }
            return MatrixUtils.StrToMatrix(tmp2);
        }

        public static void Output(int[,] matrix)
        {
            Console.WriteLine(MatrixUtils.MatrixToStr(matrix));
        }
    }
}
