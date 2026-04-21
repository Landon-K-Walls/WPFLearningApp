using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFLearningApp.Services;
using WPFLearningApp.Stores;
using WPFLearningApp.ViewModels;

namespace WPFLearningApp.Commands
{
    class NavigateCommand : CommandBase
    {
        NavigationService _navigationService;

        public NavigateCommand(NavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public override void Execute(object parameter)
        {
            _navigationService.Navigate();
        }
    }
}
