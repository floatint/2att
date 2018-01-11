using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUIlib;
using sharedlib;


/*
 16.	Будем называть соседями элемента с индексами (r, c) в двумерном массиве такие элементы, 
 индексы которых отличатся от (r, c) не более чем на единицу. 
 Для  переданного двумерного массива составить новый двумерный массив, 
 где каждый элемент (r, c) нового массива будет содержать число соседей 
 элемента (r, c) в переданном массиве, равных элементу (r, c) (в переданном массиве).
 */

namespace _9._1._16.GUI
{
    public partial class Form1 : Form
    {
        GridViewMatrix SourceGridMatrix;
        GridViewMatrix ResultGridMatrix;

        public Form1()
        {
            InitializeComponent();
            SourceGridMatrix = new GridViewMatrix(dataGridView1);
            ResultGridMatrix = new GridViewMatrix(dataGridView3);
            //GridViewMatrix m = new GridViewMatrix(dataGridView1);
            //int[,] j = new int[,] { {50,12, 10}, {50,50, 0}, {50,50, 50} };
            //int[,] r = null;
            //MatrixTools h = new MatrixTools(j);
            //h.GetNeighboursMatrix(out r);
            //MessageBox.Show(MatrixUtils.MatrixToStr(r));
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < SourceGridMatrix.GetHeight(); i++)
            {
                for (int n = 0; n < SourceGridMatrix.GetWidth(); n++)
                {
                    SourceGridMatrix.DeleteRow();
                    ResultGridMatrix.DeleteRow();
                }
                SourceGridMatrix.DeleteColumn();
                ResultGridMatrix.DeleteColumn();
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                int[,] matrix = new int[0, 0];
                try
                {
                    matrix = MatrixUtils.FileToMatrix(openFile.FileName);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                SourceGridMatrix.SetMatrix(matrix);
               
            }
            else
            {
                MessageBox.Show("Файл не существует или не выбран.");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    MatrixUtils.MatrixToFile(SourceGridMatrix.GetMatrix(), saveFile.FileName);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Сохранение отменено пользователем.");
            }
        }

        private void buttonFill_Click(object sender, EventArgs e)
        {
            SourceGridMatrix.FillMatrix();
        }

        private void buttonDecCol_Click(object sender, EventArgs e)
        {
            SourceGridMatrix.DeleteColumn();
        }

        private void buttonAddCol_Click(object sender, EventArgs e)
        {
            SourceGridMatrix.AddColumn();
        }

        private void buttonDecRow_Click(object sender, EventArgs e)
        {
            SourceGridMatrix.DeleteRow();
        }

        private void buttonAddRow_Click(object sender, EventArgs e)
        {
            SourceGridMatrix.AddRow();
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            int[,] r;
            MatrixTools work = new MatrixTools(SourceGridMatrix.GetMatrix());
            try
            {
                r = work.GetNeighboursMatrix();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            ResultGridMatrix.SetMatrix(r);
        }
    }
}
