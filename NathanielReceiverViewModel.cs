using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight; //For mvvmlight 
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;//for class Messenger
using wpfmvvm.Messages;

namespace wpfmvvm.ViewModel
{
    public class NathanielReceiverViewModel : ViewModelBase
    {
        private string _contentText;

        public string ContentText
        {
            get { return _contentText; }
            set
            {
                _contentText = value;
                RaisePropertyChanged("ContentText");
            }
        }

        public NathanielReceiverViewModel()
        {
            Messenger.Default.Register<NathanielViewModelMessage>(this, OnReceiveMessageAction);
        }

        private void OnReceiveMessageAction(NathanielViewModelMessage obj)
        {
            ContentText = obj.Text;
        }
    }
}
