using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class CommonInterestsFinder
    {
        private readonly User r_LoggedInUser;

        public CommonInterestsFinder()
        {
            r_LoggedInUser = LoggedInUserSingleton.Instance.LoggedInUser;
        }

        public KeyValuePair<User, List<Page>> GetCommonInterestsFriends()
        {
            FacebookObjectCollection<Page> userPages = r_LoggedInUser.LikedPages;
            Dictionary<User, List<Page>> friendsWithCommonPages = new Dictionary<User, List<Page>>();
            foreach (User friend in r_LoggedInUser.Friends)
            {
                if(friend.LikedPages.Count > 0)
                {
                    friendsWithCommonPages.Add(friend, new List<Page> { });
                    foreach (Page page in friend.LikedPages)
                    {
                        if (userPages.Any(x => x.Id == page.Id))
                        {
                            friendsWithCommonPages[friend].Add(page);
                        }
                    }
                }
            }

            KeyValuePair<User, List<Page>> result = friendsWithCommonPages.FirstOrDefault(x => x.Value == friendsWithCommonPages.Values.Max());

            return result;
        }
    }
}
