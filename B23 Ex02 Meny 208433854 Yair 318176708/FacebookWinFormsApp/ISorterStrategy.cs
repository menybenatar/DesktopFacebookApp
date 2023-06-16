using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public interface ISorterStrategy
    {
        void Sort(List<Page> i_PagesToSort);
    }
}
