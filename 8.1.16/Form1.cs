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
 16.	Составить новый список чисел из двух переданных списков следующим образом. На четную позицию ставить 
 элементы из первого списка, на нечетную – из второго. 
 В случае, если один список короче другого, то на недостающие позиции 
 (неважно, четные или нечетные) ставить элементы из более длинного списка 
 (т.е. итоговый список обязательно будет длиной, равной длине более длинного списка), например:
({ 1, 2, 3, 4 }, { 101, 102, 103, 104, 105, 106, 107 }) → { 1, 102, 3, 104, 105, 106, 107 }
Реализовать в виде функции:
public List<int> CreateNewList(IList<int> list1, IList<int> list2)

 */

namespace _8._1._16
{
    public partial class Form1 : Form
    {
        ListTools listWork = new ListTools();
        public Form1()
        {
            InitializeComponent();
            ListTools h = new ListTools();
        }

        private void firstInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                listWork.FirstList = Utils.StrToArray<int>(firstInput.Text).ToList<int>();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void secondInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                listWork.SecondList = Utils.StrToArray<int>(secondInput.Text).ToList<int>();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            try
            {
                outLabel.Text = Utils.ArrayToStr<int>(listWork.CreateNewList().ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }
    }
}
