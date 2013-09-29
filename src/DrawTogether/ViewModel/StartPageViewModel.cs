using DrawTogether.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace DrawTogether.ViewModel
{
    public partial class StartPageViewModel : Page
    {
        private UserInteractionService _userInteractionService;

        public StartPageViewModel(UserInteractionService userInteractionService)
        {
            _userInteractionService = userInteractionService;
            InitializeComponent();
        }

        private void OnStartButtonClick(object sender, RoutedEventArgs e)
        {
            _userInteractionService.SwitchToPlayersWindow();
        }

    }
}
