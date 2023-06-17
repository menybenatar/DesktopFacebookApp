namespace BasicFacebookFeatures
{
    public interface IComparer<T>
        where T : class
    {
        int Compare(T i_Item1, T i_Item2);
    }
}
