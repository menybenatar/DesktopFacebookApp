using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class AlbumDownloader : IEnumerable
    {
        private readonly FacebookObjectCollection<Album> r_Albums;
        public List<Album> AlbumsToSave { get; set; }

        public AlbumDownloader()
        {
            r_Albums = LoggedInUserSingleton.Instance?.LoggedInUser?.Albums;
            AlbumsToSave = new List<Album>();
        }

        public IEnumerator GetEnumerator()
        {
            return new AlbumsIterator(this);
        }

        public bool DownloadAlbumImages(Album i_Album, string i_Path)
        {
            bool isAlbumSaved = false;
            if(!string.IsNullOrEmpty(i_Path))
            {
                if (i_Album != null)
                {
                    PhotoAdapter photoAadpter = new PhotoAdapter();
                    foreach (Photo photo in i_Album.Photos)
                    {
                        photoAadpter.Photo = photo;
                        photoAadpter.Save(i_Path);
                    }

                    isAlbumSaved = true;
                }
            }

            return isAlbumSaved;
        }

        public bool LoadAlbumsToSaveByIndexes(List<int> i_Indexes)
        {
            AlbumsToSave.Clear();
            foreach (int index in i_Indexes)
            {
                if (r_Albums[index] != null)
                {
                    AlbumsToSave.Add(r_Albums[index]);
                }
            }

            return AlbumsToSave.Count > 0;
        }
    }
}
