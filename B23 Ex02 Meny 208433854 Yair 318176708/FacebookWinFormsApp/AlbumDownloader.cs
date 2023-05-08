using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class AlbumDownloader
    {
        private readonly FacebookObjectCollection<Album> r_Albums;

        public AlbumDownloader(FacebookObjectCollection<Album> i_Albums)
        {
            r_Albums = i_Albums;
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
                        foreach (Photo photo in r_Albums[index].Photos)
                        {
                            photo.ImageNormal.Save($"{i_Path}\\Image{photo.Id}.jpg");
                        }
                    }
                }

                isAlbumsSaved = true;
            }

            return isAlbumsSaved;
        }
    }
}
