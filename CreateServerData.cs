using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Breaworlds_PrivateServerManager
{
    public partial class CreateServerData : Form
    {
        private Main mainForm;

        public CreateServerData(Main main)
        {
            InitializeComponent();
            mainForm = main;
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if (txt_bio.Text == String.Empty
                || txt_serverName.Text == String.Empty
                || txt_ServerIp.Text == String.Empty
                || txt_ServerPort.Text == String.Empty)
            {
                MessageBox.Show("One or more required fields are empty.");
                return;
            }
            else if (txt_serverName.Text.Contains(" "))
            {
                MessageBox.Show("Server name cannot contains spaces.");
                return;
            }

            ServerData serverData = new ServerData()
            {
                ServerBio = txt_bio.Text,
                ServerName = txt_serverName.Text,
                ServerIp = txt_ServerIp.Text,
                ServerPort = txt_ServerPort.Text,
                ServerSocialLink = txt_socialLink.Text,
                ServerSocialName = txt_linkText.Text,
            };

            mainForm.AddServer(serverData);

            this.Close();
        }
    }
}
