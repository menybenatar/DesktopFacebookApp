using System.Collections;

namespace BasicFacebookFeatures
{
    public class AlbumsIterator : IEnumerator
    {
        private AlbumDownloader m_Collection;
        private int m_CurrentIdx = -1;
        private int m_Count = -1;

        public AlbumsIterator(AlbumDownloader i_Collection)
        {
            m_Collection = i_Collection;
            m_Count = m_Collection.AlbumsToSave.Count;
        }

        public object Current
        {
            get
            {
                return m_Collection.AlbumsToSave[m_CurrentIdx];
            }
        }

        public bool MoveNext()
        {
            ++m_CurrentIdx;
            return m_CurrentIdx < m_Collection.AlbumsToSave.Count;
        }

        public void Reset()
        {
            m_CurrentIdx = 0;
        }
    }
}