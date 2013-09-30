using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using DrawTogether.Model;
using System.Windows;

namespace DrawTogether.ViewModel
{
    public partial class BoxesPageViewModel : Page
    {
        private UserInteractionService _userInteractionService;
        private GameMode _gameMode;

        public BoxesPageViewModel(UserInteractionService userInteractionService, GameMode gameMode)
        {
            _userInteractionService = userInteractionService;
            _gameMode = gameMode;
            InitializeComponent();

        }

        private void OnBoxItemClick(object sender, RoutedEventArgs e)
        {
            int boxId = 0;

            _userInteractionService.SwitchToLevelsWindow(_gameMode, boxId);
        }

        private void OnBackButtonClick(object sender, RoutedEventArgs e)
        {
            _userInteractionService.SwitchToPlayersWindow();
        }
    }
}
