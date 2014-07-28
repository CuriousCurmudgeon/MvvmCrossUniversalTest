using Cirrious.MvvmCross.Plugins.Messenger;
using Cirrious.MvvmCross.ViewModels;
using MvvmCrossUniversalTest.Core.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmCrossUniversalTest.Core.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {
        private IMvxMessenger _mvxMessenger;
        private MvxSubscriptionToken _nameChangedSubscription;

        public FirstViewModel(IMvxMessenger mvxMessenger)
        {
            _mvxMessenger = mvxMessenger;
            _nameChangedSubscription = _mvxMessenger.Subscribe<NameChangedMessage>((message) => TimesChanged++);
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                RaisePropertyChanged(() => Name);
                _mvxMessenger.Publish(new NameChangedMessage(this, _name));
            }
        }

        private int _timesChanged;
        public int TimesChanged
        {
            get { return _timesChanged; }
            set { _timesChanged = value; RaisePropertyChanged(() => TimesChanged); }
        }

    }
}
