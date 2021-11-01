
namespace BasicFacebookFeatures
{
    partial class FormProfile
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
            if(disposing && (components != null))
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
            this.pictureBoxAlbums = new System.Windows.Forms.PictureBox();
            this.linkAlbums = new System.Windows.Forms.LinkLabel();
            this.labelAlbums = new System.Windows.Forms.Label();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.listBoxComments = new System.Windows.Forms.ListBox();
            this.linkPosts = new System.Windows.Forms.LinkLabel();
            this.labelPosts = new System.Windows.Forms.Label();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.pictureBoxCover = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbums)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAlbums
            // 
            this.pictureBoxAlbums.Location = new System.Drawing.Point(428, 633);
            this.pictureBoxAlbums.Name = "pictureBoxAlbums";
            this.pictureBoxAlbums.Size = new System.Drawing.Size(142, 81);
            this.pictureBoxAlbums.TabIndex = 68;
            this.pictureBoxAlbums.TabStop = false;
            // 
            // linkAlbums
            // 
            this.linkAlbums.AutoSize = true;
            this.linkAlbums.Location = new System.Drawing.Point(22, 546);
            this.linkAlbums.Name = "linkAlbums";
            this.linkAlbums.Size = new System.Drawing.Size(93, 17);
            this.linkAlbums.TabIndex = 67;
            this.linkAlbums.TabStop = true;
            this.linkAlbums.Text = "Fetch Albums";
            this.linkAlbums.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAlbums_LinkClicked);
            // 
            // labelAlbums
            // 
            this.labelAlbums.AutoSize = true;
            this.labelAlbums.Location = new System.Drawing.Point(22, 570);
            this.labelAlbums.Name = "labelAlbums";
            this.labelAlbums.Size = new System.Drawing.Size(260, 17);
            this.labelAlbums.TabIndex = 66;
            this.labelAlbums.Text = "(Click an album to view its cover picture)";
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 16;
            this.listBoxAlbums.Location = new System.Drawing.Point(25, 598);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(545, 116);
            this.listBoxAlbums.TabIndex = 65;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // listBoxComments
            // 
            this.listBoxComments.FormattingEnabled = true;
            this.listBoxComments.ItemHeight = 16;
            this.listBoxComments.Location = new System.Drawing.Point(332, 448);
            this.listBoxComments.Name = "listBoxComments";
            this.listBoxComments.Size = new System.Drawing.Size(238, 132);
            this.listBoxComments.TabIndex = 64;
            // 
            // linkPosts
            // 
            this.linkPosts.AutoSize = true;
            this.linkPosts.Location = new System.Drawing.Point(22, 342);
            this.linkPosts.Name = "linkPosts";
            this.linkPosts.Size = new System.Drawing.Size(82, 17);
            this.linkPosts.TabIndex = 63;
            this.linkPosts.TabStop = true;
            this.linkPosts.Text = "Fetch Posts";
            this.linkPosts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPosts_LinkClicked);
            // 
            // labelPosts
            // 
            this.labelPosts.AutoSize = true;
            this.labelPosts.Location = new System.Drawing.Point(22, 366);
            this.labelPosts.Name = "labelPosts";
            this.labelPosts.Size = new System.Drawing.Size(237, 17);
            this.labelPosts.TabIndex = 62;
            this.labelPosts.Text = "(Click on post to view the comments)";
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 16;
            this.listBoxPosts.Location = new System.Drawing.Point(25, 394);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(545, 116);
            this.listBoxPosts.TabIndex = 61;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged_1);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(363, 129);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(258, 171);
            this.pictureBoxProfile.TabIndex = 82;
            this.pictureBoxProfile.TabStop = false;
            // 
            // pictureBoxCover
            // 
            this.pictureBoxCover.Location = new System.Drawing.Point(1, 0);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(972, 273);
            this.pictureBoxCover.TabIndex = 83;
            this.pictureBoxCover.TabStop = false;
            // 
            // FormProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 809);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.pictureBoxCover);
            this.Controls.Add(this.pictureBoxAlbums);
            this.Controls.Add(this.linkAlbums);
            this.Controls.Add(this.labelAlbums);
            this.Controls.Add(this.listBoxAlbums);
            this.Controls.Add(this.listBoxComments);
            this.Controls.Add(this.linkPosts);
            this.Controls.Add(this.labelPosts);
            this.Controls.Add(this.listBoxPosts);
            this.Name = "FormProfile";
            this.Text = "FormProfile";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbums)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAlbums;
        private System.Windows.Forms.LinkLabel linkAlbums;
        private System.Windows.Forms.Label labelAlbums;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.ListBox listBoxComments;
        private System.Windows.Forms.LinkLabel linkPosts;
        private System.Windows.Forms.Label labelPosts;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.PictureBox pictureBoxCover;
    }
}