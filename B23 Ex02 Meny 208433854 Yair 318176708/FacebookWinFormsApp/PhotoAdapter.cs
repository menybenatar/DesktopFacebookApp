using System;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class PhotoAdapter : IPhoto
    {
        public Photo Photo { get; set; }

        public void Save(string i_Path)
        {
            if(Photo != null)
            {
                DateTime createdTime = Photo.CreatedTime.Value;
                string createdTimeStr = $"{createdTime.Year}-{createdTime.Month}-{createdTime.Day} {createdTime.Hour}-{createdTime.Minute}-{createdTime.Second}";
                string str = string.Format($"{i_Path}\\Image{Photo.Id} {createdTimeStr}.jpg");
                Photo.ImageNormal.Save(str);
            }
        }
    }
}
