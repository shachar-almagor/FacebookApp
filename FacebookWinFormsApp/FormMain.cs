using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        FetchUserData m_fetchUserData = new FetchUserData();
        User m_LoggedInUser;
        LoginResult m_LoginResult;

        public FormMain()
        {
            InitializeComponent();

            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns20cc"); /// the current password for Desig Patter

            m_LoginResult = FacebookService.Login(
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

            m_LoggedInUser = m_LoginResult.LoggedInUser;
            string accessToken = m_LoginResult.AccessToken;
            buttonLogin.Text = $"Logged in as {m_LoggedInUser.Name}";
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
			FacebookService.LogoutWithUI();
			buttonLogin.Text = "Login";
		}

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxComments.DisplayMember = "Message";
            listBoxComments.DataSource = m_fetchUserData.fetchPostComments(m_LoggedInUser, listBoxPosts.SelectedIndex);
        }

        private void linkPosts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FacebookObjectCollection<Post> userPosts = m_fetchUserData.fetchPosts(m_LoggedInUser);
            listBoxPosts.Items.Clear();

            foreach(Post post in userPosts)
            {
                if(post.Message != null)
                {
                    listBoxPosts.Items.Add(post.Message);
                }
                else if(post.Caption != null)
                {
                    listBoxPosts.Items.Add(post.Caption);
                }
                else
                {
                    listBoxPosts.Items.Add(string.Format("[{0}]", post.Type));
                }
            }

            if(listBoxPosts.Items.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
        }

        private void linkAlbums_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            listBoxAlbums.Items.Clear();
            listBoxAlbums.DisplayMember = "Name";
            FacebookObjectCollection<Album> userAlbums = m_fetchUserData.fetchAlbums(m_LoggedInUser);

            foreach(Album album in userAlbums)
            {
                listBoxAlbums.Items.Add(album);
                album.ReFetch(DynamicWrapper.eLoadOptions.Full);
            }

            if(listBoxAlbums.Items.Count == 0)
            {
                MessageBox.Show("No Albums to retrieve...");
            }
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedAlbum();
        }

        private void displaySelectedAlbum()
        {
            if(listBoxAlbums.SelectedItems.Count == 1)
            {
                Album selectedAlbum = listBoxAlbums.SelectedItem as Album;
                if(selectedAlbum.PictureAlbumURL != null)
                {
                    pictureBoxAlbums.LoadAsync(selectedAlbum.PictureAlbumURL);
                }
                else
                {
                    pictureBoxAlbums.Image = pictureBoxAlbums.ErrorImage;
                }
            }
        }
    }
}
