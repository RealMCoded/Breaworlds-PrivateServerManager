using System.Diagnostics;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Security.Policy;
using System.Net.NetworkInformation;

namespace Breaworlds_PrivateServerManager
{
    public partial class Main : Form
    {
        public static List<ServerData> ServerList = new List<ServerData>();

        public Main()
        {
            InitializeComponent();

            Discord.InitRPC();

            btn_launch.Enabled = false;
            btn_deleteServ.Enabled = false;
            btn_copyServer.Enabled = false;

            lbl_serverName.Text = "Select a server to start!";
            lbl_socialLink.Visible = false;
            txt_bio.Text = String.Empty;

            LoadJsonData();
        }

        private void btn_launch_Click(object sender, EventArgs e)
        {
            int selected = list_Servers.SelectedIndex;
            string ip = ServerList[selected].ServerIp;
            string port = ServerList[selected].ServerPort;
            string name = ServerList[selected].ServerName;

            LaunchGame(ip, port, name);
        }

        private void LoadJsonData()
        {
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string appFolder = Path.Combine(appDataPath, "BreaworldsPrivateServerManager");
            Directory.CreateDirectory(appFolder); // Ensure the directory exists

            if (File.Exists(Path.Combine(appFolder, "servers.json")))
            {
                string jsonContent = File.ReadAllText(Path.Combine(appFolder, "servers.json"));

                ServerList = JsonConvert.DeserializeObject<List<ServerData>>(jsonContent);

                foreach (ServerData item in ServerList.ToList())
                {
                    list_Servers.Items.Add(item.ServerName);
                }
            }
        }

        private void SaveJsonData()
        {
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string appFolder = Path.Combine(appDataPath, "BreaworldsPrivateServerManager");
            Directory.CreateDirectory(appFolder); // Ensure the directory exists

            string filepath = Path.Combine(appFolder, "servers.json");

            string jsonContent = JsonConvert.SerializeObject(ServerList, Formatting.Indented);

            File.WriteAllText(filepath, jsonContent);
        }

        public void AddServer(ServerData serverData)
        {
            ServerList.Add(serverData);

            list_Servers.Items.Add(serverData.ServerName);

            SaveJsonData();
        }

        public static void LaunchGame(string ServerIp, string ServerPort, string ServerName)
        {
            Process[] pname = Process.GetProcessesByName("Breaworlds-PrivateServer");

            if (pname.Length == 0)
            {
                string procArgs = ServerIp + " " + ServerPort + " " + ServerName;

                Process.Start("./BreaworldsClient/Breaworlds-PrivateServer.exe", procArgs);

                Discord.UpdateRPC($"Playing on {ServerName}", "", true);
            }
            else
            {
                MessageBox.Show("An instance of Breaworlds is already open. Close it before opening another.");
            }
        }

        private void btn_addServer_Click(object sender, EventArgs e)
        {
            new AddServer(this).Show();
        }

        private void btn_createServer_Click(object sender, EventArgs e)
        {
            new CreateServerData(this).Show();
        }

        private void list_Servers_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = list_Servers.SelectedIndex;
            if (selected == -1) return;

            btn_launch.Enabled = true;
            btn_deleteServ.Enabled = true;
            btn_copyServer.Enabled = true;

            lbl_serverName.Text = ServerList[selected].ServerName;

            lbl_socialLink.Visible = true;
            lbl_socialLink.Text = ServerList[selected].ServerSocialName;

            txt_bio.Text = ServerList[selected].ServerBio;
            Discord.UpdateRPC($"Selected {lbl_serverName.Text}", "Idle", false);
        }

        private void lbl_socialLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int selected = list_Servers.SelectedIndex;

            Process.Start(new ProcessStartInfo
            {
                FileName = $"https://{ServerList[selected].ServerSocialLink}",
                UseShellExecute = true
            });
        }

        public static string GetServerCode(ServerData data)
        {
            string jsonContent = JsonConvert.SerializeObject(data, Formatting.Indented);

            string b64 = base64.Base64Encode(jsonContent);

            return b64;
        }

        private void btn_copyServer_Click(object sender, EventArgs e)
        {
            int selected = list_Servers.SelectedIndex;

            string codeData = GetServerCode(ServerList[selected]);

            Clipboard.SetText(codeData);

            MessageBox.Show("Copied Server Code to Clipboard!");
        }

        private void btn_deleteServ_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this server?\nYou won't be able to access it unless you add it again.", String.Empty, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int selected = list_Servers.SelectedIndex;
                list_Servers.SelectedIndex = -1;
                btn_launch.Enabled = false;
                btn_deleteServ.Enabled = false;
                btn_copyServer.Enabled = false;

                lbl_serverName.Text = "Select a server to start!";
                lbl_socialLink.Visible = false;
                txt_bio.Text = String.Empty;

                list_Servers.Items.Remove(ServerList[selected].ServerName);
                ServerList.Remove(ServerList[selected]);

                SaveJsonData();
            }
        }

        private void list_Servers_DoubleClick(object sender, EventArgs e)
        {
            int selected = list_Servers.SelectedIndex;
            if (selected == -1) return;

            btn_launch.Enabled = true;
            btn_deleteServ.Enabled = true;
            btn_copyServer.Enabled = true;

            lbl_serverName.Text = ServerList[selected].ServerName;

            lbl_socialLink.Visible = true;
            lbl_socialLink.Text = ServerList[selected].ServerSocialName;

            txt_bio.Text = ServerList[selected].ServerBio;

            string ip = ServerList[selected].ServerIp;
            string port = ServerList[selected].ServerPort;
            string name = ServerList[selected].ServerName;

            LaunchGame(ip, port, name);
        }
    }
}
