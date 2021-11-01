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
        User m_LoggedInUser;

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
    }
}
