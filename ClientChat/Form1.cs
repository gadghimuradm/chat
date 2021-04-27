using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using ClientChat.Service;

namespace ClientChat
{
    public partial class Main : MaterialForm, Service.IServiceCallback
    {
        bool isConnected = false;
        Service.ServiceClient client;
        int ID;
        public Main()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey900, Primary.Grey900, Primary.Blue400, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Main_Load(object sender, EventArgs e)
        {
          

        }

        void ConnectUser()
        {
            if (!isConnected)
            {
                client = new ServiceClient(new System.ServiceModel.InstanceContext(this));
                ID =  client.Connect(tbUserName.Text);
                tbUserName.Enabled = false;
                BConnect.Text = "Disconnect";
                isConnected = true;
            }
        }

        void DisconnectUser()
        {
            if (isConnected)
            {
                client.Disconnect(ID);
                client = null;
                tbUserName.Enabled = true;
                BConnect.Text = "Connect";
                isConnected = false;
            }
        }

        private void BConnect_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                DisconnectUser();
            }
            else
            {
                ConnectUser();
            }
        }

       
        public void MsgCallback(string msg)
        {
            listBox.Items.Add(msg);
        }

        private void Main_Leave(object sender, EventArgs e)
        {
            DisconnectUser();
        }

        private void new_msg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (client != null)
                {
                    client.SendMsg(new_msg.Text, ID);
                    new_msg.Text = string.Empty;
                }    
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
