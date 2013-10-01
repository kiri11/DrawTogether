using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using DrawTogether.Model;
using System.Windows;
using System.Windows.Media;

namespace DrawTogether.ViewModel
{
    public partial class BoxesPageViewModel : Page
    {
        private UserInteractionService _userInteractionService;
        private int _gameModeId;
        private MenuBoxItem[] _boxItems;

        public BoxesPageViewModel(UserInteractionService userInteractionService, int gameModeId, MenuBoxItem[] boxItems)
        {
            _userInteractionService = userInteractionService;
            _gameModeId = gameModeId;
            _boxItems = boxItems;
            InitializeComponent();

            boxesPage_listBoxDataBinding.ItemsSource = _boxItems;
            boxesPage_listBoxDataBinding.SelectionChanged += OnBoxItemClick;
        }
        
        private void OnBoxItemClick(object sender, RoutedEventArgs e)
        {
            int boxId = ((ListBox)sender).SelectedIndex;
            _userInteractionService.SwitchToLevelsPage(_gameModeId, boxId);
        }

        private void OnBackButtonClick(object sender, RoutedEventArgs e)
        {
            _userInteractionService.SwitchToGameModesPage();
        }
    }
}
