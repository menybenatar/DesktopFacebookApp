using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class DescendingSorter : ISorterStrategy
    {
        public void Sort(List<Page> i_PagesToSort)
        {
            i_PagesToSort.Sort((page1, page2) => string.Compare(page2.Name, page1.Name));
        }
    }
    
}
