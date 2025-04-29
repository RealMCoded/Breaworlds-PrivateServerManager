namespace Breaworlds_PrivateServerManager
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            list_Servers = new ListBox();
            pnl_serverData = new Panel();
            txt_bio = new RichTextBox();
            btn_copyServer = new Button();
            lbl_socialLink = new LinkLabel();
            btn_deleteServ = new Button();
            lbl_serverName = new Label();
            btn_launch = new Button();
            btn_addServer = new Button();
            btn_createServer = new Button();
            pnl_serverData.SuspendLayout();
            SuspendLayout();
            // 
            // list_Servers
            // 
            list_Servers.FormattingEnabled = true;
            list_Servers.ItemHeight = 15;
            list_Servers.Location = new Point(12, 12);
            list_Servers.Name = "list_Servers";
            list_Servers.Size = new Size(209, 229);
            list_Servers.TabIndex = 0;
            list_Servers.SelectedIndexChanged += list_Servers_SelectedIndexChanged;
            list_Servers.DoubleClick += list_Servers_DoubleClick;
            // 
            // pnl_serverData
            // 
            pnl_serverData.BorderStyle = BorderStyle.FixedSingle;
            pnl_serverData.Controls.Add(txt_bio);
            pnl_serverData.Controls.Add(btn_copyServer);
            pnl_serverData.Controls.Add(lbl_socialLink);
            pnl_serverData.Controls.Add(btn_deleteServ);
            pnl_serverData.Controls.Add(lbl_serverName);
            pnl_serverData.Controls.Add(btn_launch);
            pnl_serverData.Location = new Point(227, 12);
            pnl_serverData.Name = "pnl_serverData";
            pnl_serverData.Size = new Size(414, 289);
            pnl_serverData.TabIndex = 1;
            // 
            // txt_bio
            // 
            txt_bio.Location = new Point(15, 63);
            txt_bio.Name = "txt_bio";
            txt_bio.ReadOnly = true;
            txt_bio.Size = new Size(381, 165);
            txt_bio.TabIndex = 5;
            txt_bio.Text = "";
            // 
            // btn_copyServer
            // 
            btn_copyServer.Location = new Point(232, 239);
            btn_copyServer.Name = "btn_copyServer";
            btn_copyServer.Size = new Size(146, 23);
            btn_copyServer.TabIndex = 4;
            btn_copyServer.Text = "Copy Server Code";
            btn_copyServer.UseVisualStyleBackColor = true;
            btn_copyServer.Click += btn_copyServer_Click;
            // 
            // lbl_socialLink
            // 
            lbl_socialLink.AutoSize = true;
            lbl_socialLink.Location = new Point(15, 33);
            lbl_socialLink.Name = "lbl_socialLink";
            lbl_socialLink.Size = new Size(63, 15);
            lbl_socialLink.TabIndex = 3;
            lbl_socialLink.TabStop = true;
            lbl_socialLink.Text = "Social Link";
            lbl_socialLink.LinkClicked += lbl_socialLink_LinkClicked;
            // 
            // btn_deleteServ
            // 
            btn_deleteServ.Location = new Point(232, 261);
            btn_deleteServ.Name = "btn_deleteServ";
            btn_deleteServ.Size = new Size(146, 23);
            btn_deleteServ.TabIndex = 2;
            btn_deleteServ.Text = "Remove from List";
            btn_deleteServ.UseVisualStyleBackColor = true;
            btn_deleteServ.Click += btn_deleteServ_Click;
            // 
            // lbl_serverName
            // 
            lbl_serverName.AutoSize = true;
            lbl_serverName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_serverName.Location = new Point(15, 12);
            lbl_serverName.Name = "lbl_serverName";
            lbl_serverName.Size = new Size(105, 21);
            lbl_serverName.TabIndex = 1;
            lbl_serverName.Text = "ServerName";
            // 
            // btn_launch
            // 
            btn_launch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_launch.Location = new Point(80, 239);
            btn_launch.Name = "btn_launch";
            btn_launch.Size = new Size(146, 44);
            btn_launch.TabIndex = 0;
            btn_launch.Text = "Start and Connect";
            btn_launch.UseVisualStyleBackColor = true;
            btn_launch.Click += btn_launch_Click;
            // 
            // btn_addServer
            // 
            btn_addServer.Location = new Point(12, 252);
            btn_addServer.Name = "btn_addServer";
            btn_addServer.Size = new Size(209, 23);
            btn_addServer.TabIndex = 2;
            btn_addServer.Text = "Add Server";
            btn_addServer.UseVisualStyleBackColor = true;
            btn_addServer.Click += btn_addServer_Click;
            // 
            // btn_createServer
            // 
            btn_createServer.Location = new Point(12, 281);
            btn_createServer.Name = "btn_createServer";
            btn_createServer.Size = new Size(209, 23);
            btn_createServer.TabIndex = 3;
            btn_createServer.Text = "Create Server Information";
            btn_createServer.UseVisualStyleBackColor = true;
            btn_createServer.Click += btn_createServer_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 315);
            Controls.Add(btn_createServer);
            Controls.Add(btn_addServer);
            Controls.Add(pnl_serverData);
            Controls.Add(list_Servers);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            Text = "Breaworlds Private Server Manager";
            pnl_serverData.ResumeLayout(false);
            pnl_serverData.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox list_Servers;
        private Panel pnl_serverData;
        private Button btn_addServer;
        private Button btn_createServer;
        private Button btn_launch;
        private Label lbl_serverName;
        private Button btn_deleteServ;
        private LinkLabel lbl_socialLink;
        private Button btn_copyServer;
        private RichTextBox txt_bio;
    }
}
