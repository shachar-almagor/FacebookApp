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
    public partial class FormLogin : Form
    {
        LoginResult m_LoginResult;
        UserSession userSession = new UserSession();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            
            Clipboard.SetText("design.patterns20cc"); /// the current password for Desig Patter

            m_LoginResult = userSession.login();

            this.Hide();

            FormMain facebookAppForm = new FormMain(m_LoginResult.LoggedInUser);
            facebookAppForm.ShowDialog();
        }
    }
}
