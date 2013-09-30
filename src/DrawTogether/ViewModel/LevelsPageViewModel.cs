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
        private int _gameModeId;
        private MenuLevelItem[] _levelItems;
        private int _boxId;

        public LevelsPageViewModel(UserInteractionService userInteractionService, int gameModeId, int boxId, MenuLevelItem[] levelItems)
        {
            _userInteractionService = userInteractionService;
            _gameModeId = gameModeId;
            _levelItems = levelItems;
            _boxId = boxId;
            InitializeComponent();


            FillLevelsList(levelsPage_listBox, _levelItems);
            levelsPage_listBox.SelectionChanged += OnLevelItemClick;
        }

        private void FillLevelsList(ListBox listBox, MenuLevelItem[] levelItems)
        {
            foreach (var levelItem in levelItems)
            {
                DockPanel dockPanel = MakeListBoxItem(levelItem.Title, levelItem.ImageBrush);
                listBox.Items.Add(dockPanel);
            }
        }

        private DockPanel MakeListBoxItem(string title, ImageBrush imageBrush)
        {
            DockPanel dockPanel = new DockPanel();
            dockPanel.FocusVisualStyle = new System.Windows.Style();
            dockPanel.Background = Brushes.Thistle;

            dockPanel.Width = 250;
            dockPanel.Height = 300;

            Label dockTitle = new Label();
            dockTitle.Content = title;

            dockTitle.VerticalAlignment = System.Windows.VerticalAlignment.Bottom;
            dockTitle.HorizontalAlignment = System.Windows.HorizontalAlignment.Center;

            //templateDockPanel.Children.Add(backgroundImage);
            dockPanel.Children.Add(dockTitle);

            return dockPanel;
        }


        private void OnLevelItemClick(object sender, RoutedEventArgs e)
        {
            int levelId = ((ListBox)sender).SelectedIndex;
            _userInteractionService.SwitchToGamePage(_gameModeId, _boxId, levelId);
        }

        private void OnBackButtonClick(object sender, RoutedEventArgs e)
        {
            _userInteractionService.SwitchToBoxesPage(_gameModeId);
        }
    }
}
