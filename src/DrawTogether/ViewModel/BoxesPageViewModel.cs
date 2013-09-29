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
        private PlayersCount _playersCount;

        public BoxesPageViewModel(UserInteractionService userInteractionService, PlayersCount playersCount)
        {
            _userInteractionService = userInteractionService;
            _playersCount = playersCount;
            InitializeComponent();

        }

        private void OnBoxItemClick(object sender, RoutedEventArgs e)
        {
            int boxId = 0;

            _userInteractionService.SwitchToLevelsWindow(_playersCount, boxId);
        }
    }
}
