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
16.	Описать процедуру SplitStr(S, W, N), которая формирует по данной строке S набор слов W,
входящих в S (W — выходной строковый массив; N — его размер; предполагается, 
что N не будет превышать 10). Под словом понимается набор символов, не содержащий 
пробелов и ограниченный пробелами или началом/концом строки. Используя эту функцию, 
вывести количество слов N, содержащихся в данной строке S, и сами эти слова.
 */



namespace _6._1._16
{
    public partial class Form1 : Form
    {
        private StrParser StrWork;
        public Form1()
        {
            InitializeComponent();
            StrWork = new StrParser();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wordList.Items.Clear();
            wordList.Items.AddRange(StrWork.SplitStr());
            outLabel.Text = String.Format("Слова : {0}", wordList.Items.Count);
        }

        private void enterBox_TextChanged(object sender, EventArgs e)
        {
            StrWork.Str = enterBox.Text;
        }

        private void editNValue_TextChanged(object sender, EventArgs e)
        {
            try
            {
                StrWork.N = uint.Parse(editNValue.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
