using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZenithFit.Model.Requests;
using ZenithFit.Model;

namespace ZenithFit.WinUI.Messages
{
    public partial class frmMessagesView : Form
    {
        private readonly APIService _serviceMessages = new APIService("Messages");
        private readonly APIService _serviceClients = new APIService("Clients");
        private List<ClientMessages> _allClientMessages = new List<ClientMessages>(); 
        public frmMessagesView()
        {
            InitializeComponent();

        }

        private async void frmMessagesView_Load(object sender, EventArgs e)
        {
            await LoadMessages();
            dgvMessages.AutoGenerateColumns = false;
            dgvMessages.DataSource = _allClientMessages;


        }

        private async Task LoadMessages ()
        {

            var messageList = await _serviceMessages.Get<List<Model.Messages>>(null);
            var clientList = await _serviceClients.Get<List<Model.Clients>>(null);

            foreach(var client in clientList)
            {
                var tempList = new List<Model.Messages>();
                foreach (var message in messageList)
                {
                    if(message.ClientId == client.ClientId)
                    {
                        tempList.Add(message);
                    }
                }
                if (tempList.Count != 0)
                {
                    var tempMessage = new ClientMessages()
                    {
                        Username = client.ClientUsername,
                        SentDate = tempList[tempList.Count - 1].CreatedDate,
                        ClientId = client.ClientId,
                        Message = tempList[tempList.Count - 1].Text
                    };
                    _allClientMessages.Add(tempMessage);
                }
            }
        }

        public class ClientMessages
        {
            public string Username { get; set; }
            public string Message { get; set; }
            public DateTime SentDate { get; set; }
            public int ClientId { get; set; }
        }

        private void dgvMessages_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvMessages.SelectedRows[0].Cells[0].Value;

            frmMessagesDetails frm = new frmMessagesDetails(int.Parse(id.ToString()));
            frm.Show();
        }
    }
}
