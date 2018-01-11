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


/*
 16.	Дан массив размера N. Преобразовать его, вставив перед1|после2 каждого положительного3|отрицательного4 элемента нулевой элемент.
 */

namespace _7._1._16
{
    public partial class Form1 : Form
    {
        private ArrayTools ArrayWork;
        public Form1()
        {
            InitializeComponent();
            ArrayWork = new ArrayTools();
            beforeCheckBox.Checked = true;
            negativeCheckBox.Checked = true;
        }

        private void afterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (afterCheckBox.Checked == true)
                beforeCheckBox.Checked = false;
        }

        private void beforeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (beforeCheckBox.Checked == true)
                afterCheckBox.Checked = false;
        }

        private void negativeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (negativeCheckBox.Checked == true)
                positiveCheckBox.Checked = false;
        }

        private void positiveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (positiveCheckBox.Checked == true)
                negativeCheckBox.Checked = false;
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            string result;
            try
            {
                result = Utils.ArrayToStr<int>(ArrayWork.DoInsert(afterCheckBox.Checked, negativeCheckBox.Checked));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            outBox.Text =  result;
            //inputBox.Text = result;
        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {
            ArrayWork.Str = inputBox.Text;
        }
    }
}
