using Cirrious.MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmCrossUniversalTest.Core.ViewModels
{
    public class SecondViewModel : MvxViewModel
    {
        public void Init(string color)
        {
            Color = color;
        }

        private string _color;
        public string Color
        {
            get { return _color; }
            set { _color = value; RaisePropertyChanged(() => Color); }
        }

    }
}
