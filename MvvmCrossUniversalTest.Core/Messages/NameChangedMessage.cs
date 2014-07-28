using Cirrious.MvvmCross.Plugins.Messenger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmCrossUniversalTest.Core.Messages
{
    public class NameChangedMessage : MvxMessage
    {

        public NameChangedMessage(object sender, string newName) : base(sender)
        {
            NewName = newName;
        }

        public string NewName { get; set; }
    }
}
