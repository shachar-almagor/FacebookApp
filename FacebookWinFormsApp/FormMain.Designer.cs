namespace BasicFacebookFeatures
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonProfilePage = new System.Windows.Forms.Button();
            this.listBoxFeed = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabelEvents = new System.Windows.Forms.LinkLabel();
            this.labelEvents = new System.Windows.Forms.Label();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.linkLabelGroups = new System.Windows.Forms.LinkLabel();
            this.labelGroups = new System.Windows.Forms.Label();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(701, 731);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(239, 28);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonProfilePage
            // 
            this.buttonProfilePage.Location = new System.Drawing.Point(25, 242);
            this.buttonProfilePage.Name = "buttonProfilePage";
            this.buttonProfilePage.Size = new System.Drawing.Size(217, 92);
            this.buttonProfilePage.TabIndex = 61;
            this.buttonProfilePage.Text = "My profile";
            this.buttonProfilePage.UseVisualStyleBackColor = true;
            this.buttonProfilePage.Click += new System.EventHandler(this.buttonProfilePage_Click);
            // 
            // listBoxFeed
            // 
            this.listBoxFeed.FormattingEnabled = true;
            this.listBoxFeed.ItemHeight = 16;
            this.listBoxFeed.Location = new System.Drawing.Point(359, 26);
            this.listBoxFeed.Name = "listBoxFeed";
            this.listBoxFeed.Size = new System.Drawing.Size(581, 308);
            this.listBoxFeed.TabIndex = 63;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(428, 494);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 81);
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabelEvents
            // 
            this.linkLabelEvents.AutoSize = true;
            this.linkLabelEvents.Location = new System.Drawing.Point(22, 407);
            this.linkLabelEvents.Name = "linkLabelEvents";
            this.linkLabelEvents.Size = new System.Drawing.Size(90, 17);
            this.linkLabelEvents.TabIndex = 75;
            this.linkLabelEvents.TabStop = true;
            this.linkLabelEvents.Text = "Fetch Events";
            // 
            // labelEvents
            // 
            this.labelEvents.AutoSize = true;
            this.labelEvents.Location = new System.Drawing.Point(22, 431);
            this.labelEvents.Name = "labelEvents";
            this.labelEvents.Size = new System.Drawing.Size(218, 17);
            this.labelEvents.TabIndex = 74;
            this.labelEvents.Text = "(Click an event to view its picture)";
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 16;
            this.listBoxEvents.Location = new System.Drawing.Point(25, 459);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(545, 116);
            this.listBoxEvents.TabIndex = 73;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(428, 678);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(142, 81);
            this.pictureBox2.TabIndex = 80;
            this.pictureBox2.TabStop = false;
            // 
            // linkLabelGroups
            // 
            this.linkLabelGroups.AutoSize = true;
            this.linkLabelGroups.Location = new System.Drawing.Point(22, 591);
            this.linkLabelGroups.Name = "linkLabelGroups";
            this.linkLabelGroups.Size = new System.Drawing.Size(94, 17);
            this.linkLabelGroups.TabIndex = 79;
            this.linkLabelGroups.TabStop = true;
            this.linkLabelGroups.Text = "Fetch Groups";
            // 
            // labelGroups
            // 
            this.labelGroups.AutoSize = true;
            this.labelGroups.Location = new System.Drawing.Point(22, 615);
            this.labelGroups.Name = "labelGroups";
            this.labelGroups.Size = new System.Drawing.Size(212, 17);
            this.labelGroups.TabIndex = 78;
            this.labelGroups.Text = "(Click a group to view its picture)";
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.ItemHeight = 16;
            this.listBoxGroups.Location = new System.Drawing.Point(25, 643);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(545, 116);
            this.listBoxGroups.TabIndex = 77;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(25, 26);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(258, 171);
            this.pictureBoxProfile.TabIndex = 81;
            this.pictureBoxProfile.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 809);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.linkLabelGroups);
            this.Controls.Add(this.labelGroups);
            this.Controls.Add(this.listBoxGroups);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabelEvents);
            this.Controls.Add(this.labelEvents);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.listBoxFeed);
            this.Controls.Add(this.buttonProfilePage);
            this.Controls.Add(this.buttonLogout);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion
		private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonProfilePage;
        private System.Windows.Forms.ListBox listBoxFeed;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabelEvents;
        private System.Windows.Forms.Label labelEvents;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel linkLabelGroups;
        private System.Windows.Forms.Label labelGroups;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
    }
}

