using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIlib
{
    public class GridViewMatrix
    {
        DataGridView GVMatrix;

        public GridViewMatrix(DataGridView gv)
        {
            GVMatrix = gv;
        }

        public int[,] GetMatrix()
        {
            int[,] matrix = new int[GVMatrix.RowCount, GVMatrix.ColumnCount];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (GVMatrix[j, i].Value == null)
                        matrix[i, j] = 0;
                    else
                        matrix[i, j] = int.Parse(GVMatrix[j, i].Value.ToString());
                }
            }
            return matrix;
        }

        public int GetWidth()
        {
            return GVMatrix.ColumnCount;
        }

        public int GetHeight()
        {
            return GVMatrix.RowCount;
        }

        public void SetMatrix(int[,] matrix)
        {
            if ((matrix.Length == 0) || (matrix == null))
            {
                throw new Exception("Матрица пуста или не существует.");
            }
            GVMatrix.ColumnCount = 0;
            string colname;
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                colname = i.ToString();
                GVMatrix.Columns.Add(colname, colname);
                GVMatrix.Columns[colname].Width = 30;
            }
            GVMatrix.RowCount = matrix.GetLength(0);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    GVMatrix[j, i].Value = matrix[i, j];
                }
            }
        }

        public void FillMatrix()
        {
            Random rnd = new Random();
            for (int i = 0; i < GVMatrix.ColumnCount; i++)
            {
                for (int j = 0; j < GVMatrix.RowCount; j++)
                {
                    GVMatrix[i, j].Value = rnd.Next(100);
                }
            }
        }

        public void ClearMatrix()
        {

        }

        public void DeleteRow()
        {
            if (GVMatrix.RowCount != 1)
                GVMatrix.Rows.RemoveAt(GVMatrix.RowCount - 1);
        }
        public void AddRow()
        {
            GVMatrix.Rows.Add();
            for (int i = 0; i < GVMatrix.ColumnCount; i++)
            {
                GVMatrix[i, GVMatrix.RowCount - 1].Value = 0;
            }
        }
        public void DeleteColumn()
        {
            if (GVMatrix.ColumnCount != 1)
                GVMatrix.Columns.RemoveAt(GVMatrix.ColumnCount - 1);
        }
        public void AddColumn()
        {
            string s = GVMatrix.ColumnCount.ToString();
            GVMatrix.Columns.Add(s, s);
            GVMatrix.Columns[s].Width = 30;
            for (int i = 0; i < GVMatrix.RowCount; i++)
            {
                GVMatrix[GVMatrix.ColumnCount - 1, i].Value = 0;
            }
        }
    }
}
