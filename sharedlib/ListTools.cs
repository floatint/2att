using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sharedlib
{
    public class ListTools
    {
        public List<int> FirstList;
        public List<int> SecondList;

        public List<int> CreateNewList()
        {
            List<int> resultList = new List<int>();


            if ((FirstList.Count < 1) || (SecondList.Count < 1))
            {
                MessageBox.Show("Недостаточно элементов в списке. Повторите ввод.");
                return resultList;
            }

            //Основная работа

            //Список с наибольшим кол-вом элементов (0 если равны)
            List<int> largerList = null;
            //вычисление размера наименьшего списка
            int limit = FirstList.Count;
            if (FirstList.Count > SecondList.Count)
            {
                limit = SecondList.Count;
                largerList = FirstList;
            }
            if (FirstList.Count < SecondList.Count)
            {
                limit = FirstList.Count;
                largerList = SecondList;
            }
            for (int i = 0; i <= limit-1; i++)
            {
                if (i % 2 == 0)
                {
                    resultList.Add(FirstList[i]);
                    //resultList.Add(secondList[lastInSecond]);
                    //lastInSecond ++;
                }
                else
                {
                    resultList.Add(SecondList[i]);
                    //resultList.Add(firstList[lastInFirst]);
                    //lastInFirst++;
                }
            }
            //Дополним недостающими элементами
            if (!(largerList == null))
            {
                for (int i = resultList.Count; i < largerList.Count; i++)
                {
                    resultList.Add(largerList[i]);
                }
            }

            return resultList;
        }
    }
}
