using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Breaworlds_PrivateServerManager
{
    public partial class AddServer : Form
    {
        private Main mainForm;

        public AddServer(Main mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string code = txt_serverCode.Text;
            if (code.Length < 0) return;

            try
            {
                string b64 = base64.Base64Decode(code);

                ServerData data = JsonConvert.DeserializeObject<ServerData>(b64);

                mainForm.AddServer(data);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"There was a problem adding this server.\n\n{ex.Message}");
            }
        }
    }
}
