using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class AscendingPageSorter : IComparer<Page>
    {

        public int Compare(Page i_Page1, Page i_Page2)
        {
            return string.Compare(i_Page1.Name, i_Page2.Name);
        }
    }
}
