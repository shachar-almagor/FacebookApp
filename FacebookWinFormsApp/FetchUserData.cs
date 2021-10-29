using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    class FetchUserData
    {
        // Should be the opposite - a User should have as composition a fetching service, posting service etc..
        User m_LoggedInUser;
        
        public FacebookObjectCollection<Post> fetchPosts(User i_LoggedInUser)
        {
            return i_LoggedInUser.Posts;
        }

        public FacebookObjectCollection<Comment> fetchPostComments(User i_LoggedInUser, int i_PostNumber)
        {
            return i_LoggedInUser.Posts[i_PostNumber].Comments;
        }

        public FacebookObjectCollection<Album> fetchAlbums(User i_LoggedInUser)
        {
            return i_LoggedInUser.Albums;
        }

    }
}