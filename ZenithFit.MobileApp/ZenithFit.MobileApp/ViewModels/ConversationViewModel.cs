using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using ZenithFit.Model.Requests;

namespace ZenithFit.MobileApp.ViewModels
{
    public class ConversationViewModel : BaseViewModel
    {
        private Model.Clients _client = null;
        private readonly APIService _messagesService = new APIService("Messages");
        private bool _noMessages;
        private string _messageText;
        public ConversationViewModel()
        {
            InitCommand = new Command(async () => await Init());
            SendCommand = new Command(async () => await Send());
        }
        public ObservableCollection<ClientMessages> AllMessages { get; set; } = new ObservableCollection<ClientMessages>();
        public ICommand InitCommand { get; private set; }
        public ICommand SendCommand { get; private set; }
        public string MessageText
        {
            get { return _messageText; }
            set { SetProperty(ref _messageText, value); }
        }
        public bool ShowNoMessages
        {
            get { return _noMessages; }
            set { SetProperty(ref _noMessages, value); }
        }
        public Model.Clients Client
        {
            get { return _client; }
            set { SetProperty(ref _client, value); }
        }

        public class ClientMessages
        {
            public string Username { get; set; }
            public string Message { get; set; }
            public DateTime SentDate { get; set; }
        }

        async Task Init()
        {
            IsBusy = true;
            AllMessages.Clear();
            MessagesSearchRequest search = new MessagesSearchRequest()
            {
                CurrentClient = LoggedInUser.ActiveClient.ClientId,
            };

            var messageList = await _messagesService.Get<List<Model.Messages>>(search);
            if (messageList.Count != 0)
            {
                ShowNoMessages = false;
                foreach (var item in messageList)
                {
                 
                    if (item.ClientId == LoggedInUser.ActiveClient.ClientId && item.Sender == true)
                    {
                        var temp = new ClientMessages()
                        {
                            Username = "You",
                            Message = item.Text,
                            SentDate = item.CreatedDate
                        };
                        AllMessages.Add(temp);
                    }
                    if (item.ClientId == LoggedInUser.ActiveClient.ClientId && item.Sender == false)
                    {
                        var temp = new ClientMessages()
                        {
                            Username = "Zaposlenik",
                            Message = item.Text,
                            SentDate = item.CreatedDate
                        };
                        AllMessages.Add(temp);
                    }
                }
            }
            else
            {
                ShowNoMessages = true;
            }
            IsBusy = false;
        }
        async Task Send()
        {
            if (!string.IsNullOrWhiteSpace(MessageText))
            {
                var request = new MessagesInsertRequest()
                {
                    CreatedDate = DateTime.Now,
                    ClientId = LoggedInUser.ActiveClient.ClientId,
                    Text = MessageText,
                    Sender = true
                };
                var p = await _messagesService.Insert<Model.Messages>(request);
                var newmessage = new ClientMessages()
                {
                    Message = p.Text,
                    Username = "You",
                    SentDate = p.CreatedDate
                   
                };
                AllMessages.Add(newmessage);
            }
        }
    }
}


