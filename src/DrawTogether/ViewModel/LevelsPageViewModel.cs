using DrawTogether.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DrawTogether.ViewModel
{

    public partial class LevelsPageViewModel : Page
    {
        private UserInteractionService _userInteractionService;
        private PlayersCount _playersCount;
        private int _boxId;

        public LevelsPageViewModel(UserInteractionService userInteractionService, PlayersCount playersCount, int boxId)
        {
            _userInteractionService = userInteractionService;
            _playersCount = playersCount;
            _boxId = boxId;
            InitializeComponent();
        }
        private void OnLevelClick(object sender, RoutedEventArgs e)
        {
            int levelId = 0;
            _userInteractionService.SwitchToGameWindow(_playersCount, _boxId, levelId);
        }
    }
}
