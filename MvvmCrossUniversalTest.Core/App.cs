using Cirrious.CrossCore;
using Cirrious.CrossCore.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmCrossUniversalTest.Core
{
    public class App : Cirrious.MvvmCross.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            InitializeInterfaces();

            RegisterAppStart<ViewModels.FirstViewModel>();
        }

        private void InitializeInterfaces()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

        }
    }
}
