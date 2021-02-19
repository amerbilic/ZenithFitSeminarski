using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZenithFit.WinUI.Messages
{
    public partial class frmMessagesDetails : Form
    {
        private readonly APIService _serviceMessages = new APIService("Messages");
        private readonly APIService _serviceClients = new APIService("Clients");
        private List<Model.Messages> allMessages = new List<Model.Messages>();
        private int _id;
        public frmMessagesDetails(int ClientId)
        {
            InitializeComponent();
            _id = ClientId;
        }

        private async void frmMessagesDetails_Load(object sender, EventArgs e)
        {
            await LoadMessages();
            dgvMessages.AutoGenerateColumns = false;
            dgvMessages.DataSource = allMessages;
        }

        public async Task LoadMessages()
        {
            var messageList = await _serviceMessages.Get<List<Model.Messages>>(null);
            foreach(var message in messageList)
            {
                if(message.ClientId == _id && message.Sender==true)
                {
                    allMessages.Add(message);
                }
            }
            
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            var newMessage = new Model.Messages()
            {
                ClientId = _id,
                CreatedDate = DateTime.Now,
                Text = txtSendMessage.Text,
                Sender = false
            };
            await _serviceMessages.Insert<Model.Messages>(newMessage);
            await LoadMessages();
            MessageBox.Show("Success");


        }
    }
}
