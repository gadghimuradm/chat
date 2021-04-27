using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ChatClient.ServiceChat;

namespace ChatClient
{
    
    public partial class MainWindow : Window, ServiceChat.IServiceCallback
    {
        bool isConnected = false;
        ServiceChat.ServiceClient client;
        int ID;
        SolidColorBrush mySolidColorBrush = new SolidColorBrush();
        public MainWindow()
        {
            InitializeComponent();
        }

        void ConnectUser()
        {
            if (!isConnected)
            {
                client = new ServiceClient(new System.ServiceModel.InstanceContext(this));
                ID = client.Connect(tbUserName.Text);
                tbUserName.IsEnabled = false;
                bConnDisconn.Content = "disconnect";
                isConnected = true;
                mySolidColorBrush.Color = Color.FromArgb(255, 0, 255, 0);
                ind.Fill = mySolidColorBrush;
            }
        }

        void DisconnectUser()
        {
            if (isConnected)
            {
                client.Disconnect(ID);
                client = null;
                tbUserName.IsEnabled = true;
                bConnDisconn.Content = "connect";
                isConnected = false;

                mySolidColorBrush.Color = Color.FromArgb(255, 255, 0, 0);
                ind.Fill = mySolidColorBrush;
            }
        }

        private void bConnDisconn_Click(object sender, RoutedEventArgs e)
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
            lbChat.Items.Add(msg);
            lbChat.ScrollIntoView(lbChat.Items[lbChat.Items.Count - 1]);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DisconnectUser();
        }

        private void tbMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (client != null)
                {
                    client.SendMsg(tbMessage.Text, ID);
                    tbMessage.Text = string.Empty;
                }
            }
        }

        private void bSend_Click(object sender, RoutedEventArgs e)
        {
            if (client != null)
            {
                client.SendMsg(tbMessage.Text, ID);
                tbMessage.Text = string.Empty;
            }
        }
    }
}
