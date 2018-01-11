using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sharedlib
{
    public class StrParser
    {
        public uint N;
        public string Str;
        //Construct
        public StrParser()
        {
            Str = "";
            N = 1;
        }

        public string[] SplitStr()
        {
            if (Str.Length == 0)
            {
                throw new Exception("Введена пустая строка. Повторите ввод.");
                //return new string[0];
            }
            string[] arr = new string[10];
            string tmp = "";
            int WordCnt = 0;
            for (int i = 0; i <= Str.Length - 1; i++)
            {
                if ((Str[i] != ' '))
                {
                    tmp = tmp + Str[i];
                }
                else
                {
                    if (tmp.Length != 0)
                    {
                        if (WordCnt <= N - 1)
                        {
                            arr[WordCnt] = tmp;
                            tmp = "";
                            WordCnt++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            if (tmp.Length != 0)
            {
                if (WordCnt <= N - 1)
                {
                    arr[WordCnt] = tmp;
                    tmp = "";
                    WordCnt++;
                }
            }
            Array.Resize(ref arr, WordCnt);
            return arr;
        }
    }
}
