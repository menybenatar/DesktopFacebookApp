using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class AscendingSorter : ISorterStrategy
    {
        public void Sort(List<Page> i_PagesToSort)
        {
            i_PagesToSort.Sort((page1, page2) => string.Compare(page1.Name, page2.Name));
        }
    }
}
