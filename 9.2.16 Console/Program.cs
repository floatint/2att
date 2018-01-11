using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sharedlib;
using ConsoleLib;

namespace _9._2._16_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Способ ввода данных : (1 - файл, 2 - ручной ввод)");
            string tmp = "";
            tmp = Console.ReadLine();
            if ((tmp != "1") && (tmp != "2"))
            {
                Console.WriteLine("Неверный способ ввода.");
                return;
            }
            int[,] r = new int[0, 0];
            if (tmp == "2")
            {
                try
                {
                    r = ConsoleMatrix.Input();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            if (tmp == "1")
            {
                Console.WriteLine("Введите имя загружаемого файла :");
                try
                {
                    r = MatrixUtils.FileToMatrix(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            if (r.GetLength(0) != r.GetLength(1))
            {
                Console.WriteLine("Матрица должна быть квадратной !");
                return;
            }
            MatrixTools mt = new MatrixTools(r);
            Console.WriteLine("Результат работы : ---------------");
            try
            {
                Console.WriteLine(mt.SumMainDiagonal());
                Console.WriteLine("Сохранить введенную матрицу ? (1 - да, 2 - нет) :");
                tmp = Console.ReadLine();
                if ((tmp != "1") && (tmp != "2"))
                {
                    Console.WriteLine("Неверный ответ.");
                }
                if (tmp == "1")
                {
                    MatrixUtils.MatrixToFile(r, Console.ReadLine());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
