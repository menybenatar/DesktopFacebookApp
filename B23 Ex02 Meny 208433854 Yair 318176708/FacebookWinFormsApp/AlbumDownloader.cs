using System.Collections.Generic;
using System.Drawing;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class AlbumDownloader
    {
        private readonly FacebookObjectCollection<Album> r_Albums;

        public AlbumDownloader()
        {
            r_Albums = LoggedInUserSingleton.Instance?.LoggedInUser?.Albums;
        }

        public bool DownloadAlbumsImages(List<int> i_SelectedIndexs, string i_Path)
        {
            bool isAlbumsSaved = false;
            if(!string.IsNullOrEmpty(i_Path))
            {
                foreach(int index in i_SelectedIndexs)
                {
                    if (r_Albums[index] != null)
                    {
                        PhotoAdpter photoAdpter = new PhotoAdpter();
                        foreach (Photo photo in r_Albums[index].Photos)
                        {
                            photoAdpter.Photo = photo;
                            photoAdpter.Save(i_Path);
                        }
                    }
                }

                isAlbumsSaved = true;
            }

            return isAlbumsSaved;
        }
    }
}
