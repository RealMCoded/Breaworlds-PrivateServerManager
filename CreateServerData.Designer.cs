namespace Breaworlds_PrivateServerManager
{
    partial class CreateServerData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateServerData));
            lbl_serverName = new Label();
            txt_serverName = new TextBox();
            txt_ServerIp = new TextBox();
            lbl_serverIp = new Label();
            txt_ServerPort = new TextBox();
            lbl_serverPort = new Label();
            txt_socialLink = new TextBox();
            lbl_socialLink = new Label();
            txt_linkText = new TextBox();
            lbl_socialLinkText = new Label();
            txt_bio = new RichTextBox();
            lbl_serverBio = new Label();
            btn_create = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbl_serverName
            // 
            lbl_serverName.AutoSize = true;
            lbl_serverName.Location = new Point(12, 9);
            lbl_serverName.Name = "lbl_serverName";
            lbl_serverName.Size = new Size(79, 15);
            lbl_serverName.TabIndex = 0;
            lbl_serverName.Text = "Server Name*";
            // 
            // txt_serverName
            // 
            txt_serverName.Location = new Point(12, 27);
            txt_serverName.Name = "txt_serverName";
            txt_serverName.Size = new Size(250, 23);
            txt_serverName.TabIndex = 1;
            // 
            // txt_ServerIp
            // 
            txt_ServerIp.Location = new Point(12, 75);
            txt_ServerIp.Name = "txt_ServerIp";
            txt_ServerIp.Size = new Size(180, 23);
            txt_ServerIp.TabIndex = 3;
            // 
            // lbl_serverIp
            // 
            lbl_serverIp.AutoSize = true;
            lbl_serverIp.Location = new Point(12, 57);
            lbl_serverIp.Name = "lbl_serverIp";
            lbl_serverIp.Size = new Size(57, 15);
            lbl_serverIp.TabIndex = 2;
            lbl_serverIp.Text = "Server IP*";
            // 
            // txt_ServerPort
            // 
            txt_ServerPort.Location = new Point(198, 75);
            txt_ServerPort.Name = "txt_ServerPort";
            txt_ServerPort.Size = new Size(64, 23);
            txt_ServerPort.TabIndex = 4;
            // 
            // lbl_serverPort
            // 
            lbl_serverPort.AutoSize = true;
            lbl_serverPort.Location = new Point(198, 57);
            lbl_serverPort.Name = "lbl_serverPort";
            lbl_serverPort.Size = new Size(69, 15);
            lbl_serverPort.TabIndex = 5;
            lbl_serverPort.Text = "Server Port*";
            // 
            // txt_socialLink
            // 
            txt_socialLink.Location = new Point(273, 27);
            txt_socialLink.Name = "txt_socialLink";
            txt_socialLink.Size = new Size(250, 23);
            txt_socialLink.TabIndex = 7;
            // 
            // lbl_socialLink
            // 
            lbl_socialLink.AutoSize = true;
            lbl_socialLink.Location = new Point(273, 9);
            lbl_socialLink.Name = "lbl_socialLink";
            lbl_socialLink.Size = new Size(158, 15);
            lbl_socialLink.TabIndex = 6;
            lbl_socialLink.Text = "Social Link (without https://)";
            // 
            // txt_linkText
            // 
            txt_linkText.Location = new Point(273, 74);
            txt_linkText.Name = "txt_linkText";
            txt_linkText.Size = new Size(250, 23);
            txt_linkText.TabIndex = 9;
            // 
            // lbl_socialLinkText
            // 
            lbl_socialLinkText.AutoSize = true;
            lbl_socialLinkText.Location = new Point(273, 56);
            lbl_socialLinkText.Name = "lbl_socialLinkText";
            lbl_socialLinkText.Size = new Size(87, 15);
            lbl_socialLinkText.TabIndex = 8;
            lbl_socialLinkText.Text = "Social Link Text";
            // 
            // txt_bio
            // 
            txt_bio.Location = new Point(12, 131);
            txt_bio.Name = "txt_bio";
            txt_bio.Size = new Size(511, 96);
            txt_bio.TabIndex = 10;
            txt_bio.Text = "";
            // 
            // lbl_serverBio
            // 
            lbl_serverBio.AutoSize = true;
            lbl_serverBio.Location = new Point(12, 113);
            lbl_serverBio.Name = "lbl_serverBio";
            lbl_serverBio.Size = new Size(107, 15);
            lbl_serverBio.TabIndex = 11;
            lbl_serverBio.Text = "Server Description*";
            // 
            // btn_create
            // 
            btn_create.Location = new Point(12, 233);
            btn_create.Name = "btn_create";
            btn_create.Size = new Size(511, 23);
            btn_create.TabIndex = 12;
            btn_create.Text = "Create";
            btn_create.UseVisualStyleBackColor = true;
            btn_create.Click += btn_create_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 259);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 13;
            label1.Text = "* = required";
            // 
            // CreateServerData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 280);
            Controls.Add(label1);
            Controls.Add(btn_create);
            Controls.Add(lbl_serverBio);
            Controls.Add(txt_bio);
            Controls.Add(txt_linkText);
            Controls.Add(lbl_socialLinkText);
            Controls.Add(txt_socialLink);
            Controls.Add(lbl_socialLink);
            Controls.Add(lbl_serverPort);
            Controls.Add(txt_ServerPort);
            Controls.Add(txt_ServerIp);
            Controls.Add(lbl_serverIp);
            Controls.Add(txt_serverName);
            Controls.Add(lbl_serverName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CreateServerData";
            Text = "Server Data Creator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_serverName;
        private TextBox txt_serverName;
        private TextBox txt_ServerIp;
        private Label lbl_serverIp;
        private TextBox txt_ServerPort;
        private Label lbl_serverPort;
        private TextBox txt_socialLink;
        private Label lbl_socialLink;
        private TextBox txt_linkText;
        private Label lbl_socialLinkText;
        private RichTextBox txt_bio;
        private Label lbl_serverBio;
        private Button btn_create;
        private Label label1;
    }
}