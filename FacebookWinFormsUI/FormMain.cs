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
using FacebookWinFormsLogic;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        User m_LoggedInUser;
        FetchUserData m_fetchUserData = new FetchUserData();

        public FormMain(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;

            InitializeComponent();

            FacebookService.s_CollectionLimit = 100;
        }

        private void buttonProfilePage_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormProfile formProfile = new FormProfile(m_LoggedInUser);
            formProfile.ShowDialog();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
			FacebookService.LogoutWithUI();
		}

        private void linkLabelEvents_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            listBoxEvents.Items.Clear();
            listBoxEvents.DisplayMember = "Name";
            FacebookObjectCollection<Event> userEvents = m_fetchUserData.fetchEvents(m_LoggedInUser);

            foreach(Event facebookbEvent in userEvents)
            {
                listBoxEvents.Items.Add(facebookbEvent);
            }

            if(listBoxEvents.Items.Count == 0)
            {
                MessageBox.Show("No Events to retrieve...");
            }
        }

        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxEvents.SelectedItems.Count == 1)
            {
                Event selectedEvent = listBoxEvents.SelectedItem as Event;
                pictureBoxEvent.LoadAsync(selectedEvent.Cover.SourceURL);
            }
        }

        private void linkLabelGroups_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FacebookObjectCollection<Group> userGroups = m_fetchUserData.fetchGroups(m_LoggedInUser);

            listBoxGroups.Items.Clear();
            listBoxGroups.DisplayMember = "Name";

            try
            {
                foreach(Group group in userGroups)
                {
                    if(group.Name != null)
                    {
                        listBoxGroups.Items.Add(group);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if(listBoxGroups.Items.Count == 0)
            {
                MessageBox.Show("No groups to retrieve :(");
            }
        }

        private void listBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedGroup();
        }

        private void displaySelectedGroup()
        {
            if(listBoxGroups.SelectedItems.Count == 1)
            {
                Group selectedGroup = listBoxGroups.SelectedItem as Group;
                pictureBoxGroup.LoadAsync(selectedGroup.PictureNormalURL);
            }
        }
    }
}
