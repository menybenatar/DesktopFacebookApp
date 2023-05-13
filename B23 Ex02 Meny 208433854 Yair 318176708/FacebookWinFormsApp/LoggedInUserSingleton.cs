using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class LoggedInUserSingleton
    {
        private static LoggedInUserSingleton s_Instance = null;
        private static object s_LockObj = new Object();

        public User LoggedInUser { get; private set; } = null;

        private LoggedInUserSingleton()
        {
        }

        public static LoggedInUserSingleton Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (s_LockObj)
                    {
                        if (s_Instance == null)
                        {
                            // LoginResult loginResult =  = FacebookWrapper.LoginResult loginResult = FacebookService.Login(
                            //      "908976190225309",
                            //      "email",
                            //      "user_hometown",
                            //      "user_birthday",
                            //      "user_gender",
                            //      "user_photos",
                            //      "user_friends",
                            //      "user_likes",
                            //      "user_posts",
                            //      "public_profile",
                            //      "groups_access_member_info");

                            LoginResult loginResult = FacebookService.Connect("EAAM6tYLte50BAPDvBZAvFAn2Lv94GAITqPgVVJn6NWZCe3K5zDdpqIogBIR2IPnJ0ZB4VBYxU1fWCk6ZBQkiXsTmX31C3ceeEOF8qS4y2nlT9vZAztA3qDYXdZBama3GVDKGyMu4sb0qsJA6VfdkEvp2HMxuMu3UcTAZCNwckKplnq45IN7h8dt");
                            if (loginResult != null && !string.IsNullOrEmpty(loginResult.AccessToken))
                            {
                                s_Instance = new LoggedInUserSingleton();
                                s_Instance.LoggedInUser = loginResult.LoggedInUser;
                            }
                        }
                    }
                }

                return s_Instance;
            }
        }

    }     
}
