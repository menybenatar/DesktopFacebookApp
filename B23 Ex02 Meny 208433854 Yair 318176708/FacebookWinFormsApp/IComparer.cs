using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public interface IComparer<T> where T : class
    {
        int Compare(T i_Item1, T i_Item2);
    }
}
