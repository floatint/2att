using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharedlib
{
    public class MatrixTools
    {
        int[,] matrix { get; set; }

        public MatrixTools(int[,] matr)
        {
            matrix = matr;
        }


        public int[,] GetNeighboursMatrix()
        {
            int[,] resMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
            if (matrix.GetLength(0) == 0)
                throw new Exception("Пустая матрица");
            int[] neigbrs = new int[8]; //по условию задачи максимум соседей
            int lastneig = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int n = 0; n < matrix.GetLength(1); n++)
                {
                    //находится ли элемент в пределах матрицы
                    if (((i - 1 >= 0) || (i + 1 <= matrix.GetLength(0) - 1)) ||
                        ((n - 1 >= 0) || (n + 1 <= matrix.GetLength(1) - 1))
                       )
                    {
                        //считаем кол-во соседей у элемента
                        if ((i - 1 >= 0) && (n - 1 >= 0)) //левый верхний
                        {
                            neigbrs[lastneig] = matrix[i - 1, n - 1];
                            lastneig++;
                        }
                        if ((i - 1 >= 0) && (n >= 0)) //верхний
                        {
                            neigbrs[lastneig] = matrix[i - 1, n];
                            lastneig++;
                        }
                        if ((i - 1 >= 0) && ((n + 1 >= 0) && (n + 1 <= matrix.GetLength(1) - 1))) //правый верхний
                        {
                            neigbrs[lastneig] = matrix[i - 1, n + 1];
                            lastneig++;
                        }
                        if ((i >= 0) && (n - 1 >= 0)) //левый
                        {
                            neigbrs[lastneig] = matrix[i, n - 1];
                            lastneig++;
                        }
                        if ((i >= 0) && ((n + 1 >= 0) && (n + 1 <= matrix.GetLength(1) - 1))) //правый
                        {
                            neigbrs[lastneig] = matrix[i, n + 1];
                            lastneig++;
                        }
                        if ((i + 1 <= matrix.GetLength(0) - 1) && (n - 1 >= 0)) //левый нижний
                        {
                            neigbrs[lastneig] = matrix[i + 1, n - 1];
                            lastneig++;
                        }
                        if ((i + 1 <= matrix.GetLength(0) - 1) && (n + 1 <= matrix.GetLength(1) - 1)) //правый нижний
                        {
                            neigbrs[lastneig] = matrix[i + 1, n + 1];
                            lastneig++;
                        }
                        if ((i + 1 <= matrix.GetLength(0) - 1) && (n >= 0)) //нижний
                        {
                            neigbrs[lastneig] = matrix[i + 1, n];
                            lastneig++;
                        }
                        //проверяем соседей
                        for (int k = 0; k < lastneig; k++)
                        {
                            if (neigbrs[k] == matrix[i, n])
                            {
                                resMatrix[i, n]++;
                            }
                        }
                        //обнуление
                        lastneig = 0;

                    }
                    else
                    {
                        //resMatrix[0, 0] = 100;
                        throw new Exception("Ошибка обработки матрицы.");
                        //return false;
                    }
                }
            }
            return resMatrix;
        }

        public int SumMainDiagonal()
        {
            int tmp = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if ((i+1) % 2 == 0)
                {
                    tmp += matrix[i, i];
                }
            }
            return tmp;
        }
    }
}
