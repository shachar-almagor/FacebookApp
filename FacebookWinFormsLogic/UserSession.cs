using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FacebookWinFormsLogic
{
    public class UserSession
    {
        public LoginResult login() 
        {
            LoginResult loginResult = FacebookService.Login(
                    /// (This is Desig Patter's App ID. replace it with your own)
                    "584799942640350",
                    /// requested permissions:
                    "email",
                    "public_profile",
                    "user_age_range",
                    "user_birthday",
                    "user_events",
                    "user_friends",
                    "user_gender",
                    "user_hometown",
                    "user_likes",
                    "user_link",
                    "user_location",
                    "user_photos",
                    "user_posts",
                    "user_videos"
                    /// add any relevant permissions
                    );

            User loggedInUser = loginResult.LoggedInUser;
            string accessToken = loginResult.AccessToken;

            return loginResult;
        }
    }
}
