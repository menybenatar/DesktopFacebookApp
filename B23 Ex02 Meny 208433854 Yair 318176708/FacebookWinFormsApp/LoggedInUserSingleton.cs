﻿using System;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public sealed class LoggedInUserSingleton
    {
        private static LoggedInUserSingleton s_Instance = null;
        private static object s_LockObj = new object();

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
                            try
                            {
                                LoginResult loginResult = FacebookService.Connect("EAAM6tYLte50BAK6BH1zf0rI3E1NyWvagAHzXluZAKb4fJZBL5xgP6V5WGyXcXeLi9ZBtKUq1d3aBGVrE4ZC14ytWSMiz47ZALZBStkhRFHyaCXh1LRY61rXtNvzTK1xwpM81oeUDZAXI64Tuah3umpOmb84FcyXZBAdzOpL6mZCGtzf1t5YSIluOr");
                                //LoginResult loginResult = FacebookService.Login(
                                //     "908976190225309",
                                //     "email",
                                //     "user_hometown",
                                //     "user_birthday",
                                //     "user_gender",
                                //     "user_photos",
                                //     "user_friends",
                                //     "user_likes",
                                //     "user_posts",
                                //     "public_profile",
                                //     "groups_access_member_info");

                                if (loginResult != null && !string.IsNullOrEmpty(loginResult.AccessToken))
                                {
                                    s_Instance = new LoggedInUserSingleton();
                                    s_Instance.LoggedInUser = loginResult.LoggedInUser;
                                }
                            }
                            catch(Exception ex)
                            {
                                throw new Exception(null, ex);
                            }
                        }
                    }
                }

                return s_Instance;
            }
        }
    }
}
