using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using FacebookWinFormsLogic;

namespace BasicFacebookFeatures
{
    public partial class FormProfile : Form
    {
        FetchUserData m_fetchUserData = new FetchUserData();
        User m_LoggedInUser;

        public FormProfile(User i_loggedInUser)
        {
            m_LoggedInUser = i_loggedInUser;

            InitializeComponent();
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

        private void listBoxPosts_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            listBoxComments.DisplayMember = "Message";
            listBoxComments.DataSource = m_fetchUserData.fetchPostComments(m_LoggedInUser, listBoxPosts.SelectedIndex);
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
