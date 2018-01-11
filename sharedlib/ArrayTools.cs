using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sharedlib
{

    public class ArrayTools
    {
        public string Str;
        public ArrayTools()
        {
            Str = "";
        }

        public int[] DoInsert (bool after, bool negative)
        {
            //Utils utils = new Utils();
            int[] arr = new int[0];
            int[] resultarr = new int[0];

            arr = Utils.StrToArray<int>(Str);

            if (arr.Length < 2)
            {
                throw new Exception("В массиве недостаточно элементов.");
            }
            //Работа
            for (uint i = 0; i <= arr.Length-1; i++)
            {
                if (negative)
                {
                    if (arr[i] < 0)
                    {
                        if (after)
                        {
                            Array.Resize<int>(ref resultarr, resultarr.Length + 2);
                            resultarr[resultarr.Length - 1] = arr[0];
                            resultarr[resultarr.Length - 2] = arr[i];
                        }
                        else
                        {
                            Array.Resize<int>(ref resultarr, resultarr.Length + 2);
                            resultarr[resultarr.Length - 1] = arr[i];
                            resultarr[resultarr.Length - 2] = arr[0];
                        }
                    }
                    else
                    {
                        Array.Resize<int>(ref resultarr, resultarr.Length + 1);
                        resultarr[resultarr.Length - 1] = arr[i];
                        continue;
                    }
                }
                else
                {
                    if (arr[i] > 0)
                    {
                        if (after)
                        {
                            Array.Resize<int>(ref resultarr, resultarr.Length + 2);
                            resultarr[resultarr.Length - 1] = arr[0];
                            resultarr[resultarr.Length - 2] = arr[i];
                        }
                        else
                        {
                            Array.Resize<int>(ref resultarr, resultarr.Length + 2);
                            resultarr[resultarr.Length - 1] = arr[i];
                            resultarr[resultarr.Length - 2] = arr[0];
                        }
                    }
                    else
                    {
                        Array.Resize<int>(ref resultarr, resultarr.Length + 1);
                        resultarr[resultarr.Length - 1] = arr[i];
                        continue;
                    }
                }
            }
            return resultarr;
        }
    }
}
