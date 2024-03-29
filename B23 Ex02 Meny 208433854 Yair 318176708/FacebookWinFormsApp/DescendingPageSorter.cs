﻿using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class DescendingPageSorter : IComparer<Page>
    {
        public int Compare(Page i_Page1, Page i_Page2)
        {
            return string.Compare(i_Page2.Name, i_Page1.Name);
        }
    }
}
