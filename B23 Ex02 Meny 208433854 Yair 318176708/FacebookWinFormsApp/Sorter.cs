using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class Sorter
    {
        /// use a delegate to a method as the strategy:
        public Func<int, int, bool> ComparerMethod { get; set; }

        public Sorter(Func<int, int, bool> i_ComparerMethod)
        {
            ComparerMethod = i_ComparerMethod;
        }

        public void Sort(int[] i_Array)
        {
            for (int g = i_Array.Length / 2; g > 0; g /= 2)
            {
                for (int i = g; i < i_Array.Length; i++)
                {
                    for (int j = i - g; j >= 0; j -= g)
                    {
                        if (ComparerMethod.Invoke(i_Array[j], i_Array[j + g]))
                        {
                            doSwap(ref i_Array[j], ref i_Array[j + g]);
                        }
                    }
                }
            }
        }

        private void doSwap(ref int io_Num1, ref int io_Num2)
        {
            int temp = io_Num1;
            io_Num1 = io_Num2;
            io_Num2 = temp;
        }
    }
}
