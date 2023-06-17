using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class Sorter<T> where T : class
    {

        public IComparer<T> Comparer { get; set; }

        public Sorter(IComparer<T> i_Comparer)
        {
            Comparer = i_Comparer;
        }
         
        public void Sort(List<T> i_ItemToSort)
        {
            i_ItemToSort.Sort((item1, item2) => Comparer.Compare(item1, item2));
        }
    }
        
}
