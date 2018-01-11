using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sharedlib;
using GUIlib;


/*
 47.	Дана квадратная целочисленная матрица N×N. Найти суммы 
 элементов строк, имеющих четные элементы на главной диагонали.
 */

namespace _9._2._16_GUI
{
    public partial class Form1 : Form
    {
        GridViewMatrix gv;
        public Form1()
        {
            InitializeComponent();
            gv = new GridViewMatrix(dataGridView1);
        }



        private void buttonClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gv.GetHeight(); i++)
            {
                for (int n = 0; n < gv.GetWidth(); n++)
                {
                    gv.DeleteRow();
                }
                gv.DeleteColumn();
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                gv.SetMatrix(matrix);

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
                    MatrixUtils.MatrixToFile(gv.GetMatrix(), saveFile.FileName);
                }
                catch (Exception ex)
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
            gv.FillMatrix();
        }

        private void buttonDecCol_Click(object sender, EventArgs e)
        {
            gv.DeleteColumn();
        }

        private void buttonAddCol_Click(object sender, EventArgs e)
        {
            gv.AddColumn();
        }

        private void buttonDecRow_Click(object sender, EventArgs e)
        {
            gv.DeleteRow();
        }

        private void buttonAddRow_Click(object sender, EventArgs e)
        {
            gv.AddRow();
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            int[,] r = new int[0, 0];
            try
            {
                r = gv.GetMatrix();
                if (r.GetLength(0) != r.GetLength(1))
                {
                    MessageBox.Show("Матрица должна быть квадратной !");
                    return;
                }
                MatrixTools mt = new MatrixTools(r);
                MessageBox.Show(String.Format("Сумма четных элементов на главной диагонали : {0}", mt.SumMainDiagonal()));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
