using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class Sorter
    {
        public Comparison<Page> ComparerMethod { get; set; }

        public Sorter(Comparison<Page> comparerMethod)
        {
            ComparerMethod = comparerMethod;
        }

        public void Sort(List<Page> i_ListToSort)
        {
            Quicksort(i_ListToSort, 0, i_ListToSort.Count - 1);
        }

        private void Quicksort(List<Page> i_ListToSort, int i_Left, int i_Right)
        {
            if (i_Left < i_Right)
            {
                int partitionIndex = Partition(i_ListToSort, i_Left, i_Right);
                Quicksort(i_ListToSort, i_Left, partitionIndex - 1);
                Quicksort(i_ListToSort, partitionIndex + 1, i_Right);
            }
        }

        private int Partition(List<Page> i_List, int i_Left, int i_Right)
        {
            Page pivot = i_List[i_Right];
            int i = i_Left - 1;

            for (int j = i_Left; j < i_Right; j++)
            {
                if (ComparerMethod.Invoke(i_List[j], pivot) <= 0)
                {
                    i++;
                    Swap(i_List, i, j);
                }
            }

            Swap(i_List, i + 1, i_Right);
            return i + 1;
        }

        private void Swap(List<Page> list, int i, int j)
        {
            Page temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }
}
