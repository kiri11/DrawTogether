using DrawTogether.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace DrawTogether.ViewModel
{
    public partial class GameModesPageViewModel : Page
    {
        private UserInteractionService _userInteractionService;
        private MenuGameModeItem[] _gameModeItems;

        public GameModesPageViewModel(UserInteractionService userInteractionService, MenuGameModeItem[] gameModeItems)
        {
            _userInteractionService = userInteractionService;
            _gameModeItems = gameModeItems;
            InitializeComponent();

            FillGameModeList(gameModePage_listBox, gameModeItems);
            gameModePage_listBox.SelectionChanged += OnGameModeItemClick;
        }

        private void FillGameModeList(ListBox listBox, MenuGameModeItem[] gameModeItems)
        {
            foreach (var gameModeItem in gameModeItems)
            {
                DockPanel gameModeDockPanel = MakeListBoxItem(gameModeItem.Title, gameModeItem.ImageBrush);
                listBox.Items.Add(gameModeDockPanel);
            }
        }

        private DockPanel MakeListBoxItem(string title, ImageBrush imageBrush)
        {
            DockPanel dockPanel = new DockPanel();
            dockPanel.FocusVisualStyle = new System.Windows.Style();
            dockPanel.Background = Brushes.Thistle;

            dockPanel.Width = 200;
            dockPanel.Height = 200;

            Label dockTitle = new Label();
            dockTitle.Content = title;

            dockTitle.VerticalAlignment = System.Windows.VerticalAlignment.Bottom;
            dockTitle.HorizontalAlignment = System.Windows.HorizontalAlignment.Center;

            //templateDockPanel.Children.Add(backgroundImage);
            dockPanel.Children.Add(dockTitle);

            return dockPanel;
        }

        private void OnGameModeItemClick(object sender, RoutedEventArgs e)
        {
            int gameModeId = ((ListBox)sender).SelectedIndex;
            _userInteractionService.SwitchToBoxesPage(gameModeId);
        }

        private void OnBackButtonClick(object sender, RoutedEventArgs e)
        {
            _userInteractionService.SwitchToStartPage();
        }
    }
}
