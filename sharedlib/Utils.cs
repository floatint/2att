using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace sharedlib
{
    public class Utils
    {
        public static bool InRange(int value, int min, int max)
        {
            return (value > min) && (value <= max);
        }

        public static  T StrToValue<T>(string str)
        {
            return (T) Convert.ChangeType(str, typeof(T));
        }

        public static T[] StrToArray<T>(string str)
        {
            return Array.ConvertAll(
                str.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries),
                (s) => StrToValue<T>(s)
            );
        }

        public static string ArrayToStr<T>(T[] arr, string separator = " ")
        {
            return arr == null ? "null" : String.Join(separator, arr);
        }
    }

    public class MatrixUtils
    {
        public static int[,] StrToMatrix(string str)
        {
            string[] tabs = str.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            if (tabs.Length == 0)
                return new int[0, 0];
            string[] raw = tabs[0].Split(new char[] { ',', ' ', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int[,] result = new int[tabs.Length, raw.Length];
            for (int i = 0; i < result.GetLength(0); i++)
            {
                raw = tabs[i].Split(new char[] { ',', ' ', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                if (raw.Length != result.GetLength(1))
                    throw new Exception("Некорректный размер матрицы.");
                for (int n = 0; n < result.GetLength(1); n++)
                {
                    result[i, n] = int.Parse(raw[n]);
                }
            }
            return result;
        }
        public static string MatrixToStr(int[,] matrix)
        {
            string tmp = "";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int n = 0; n < matrix.GetLength(1); n++)
                {
                    tmp += matrix[i, n].ToString();
                    if (n != matrix.GetLength(1) - 1)
                    {
                        tmp += " ";
                    }
                    else
                    {
                        tmp += "";
                    }
                }
                if (i != matrix.GetLength(0))
                    tmp += '\n';
            }
            return tmp;
        }
        public static int[,] FileToMatrix(string filename)
        {
            if (filename.Length == 0)
               throw new Exception("Пустое имя файла.");
            return StrToMatrix(File.ReadAllText(filename));
        }
        public static void MatrixToFile(int[,] matrix, string filename)
        {
            if (filename.Length == 0 || matrix == null)
               throw new Exception("Имя файла пусто или матрица равна null.");

            File.WriteAllText(filename, MatrixToStr(matrix));
        }
    }
}
