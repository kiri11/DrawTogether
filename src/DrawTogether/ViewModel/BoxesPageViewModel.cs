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

            FillListBox(boxesPage_listBox, boxItems);
            boxesPage_listBox.SelectionChanged += OnBoxItemClick;
        }

        private void FillListBox(ListBox listBox, MenuBoxItem[] boxItems)
        {
            foreach (var boxItem in boxItems)
            {
                DockPanel boxDockPanel = MakeListBoxItem(boxItem.Title, boxItem.ImageBrush);
                listBox.Items.Add(boxDockPanel);
            }
        }

        private DockPanel MakeListBoxItem(string title, ImageBrush imageBrush)
        {
            DockPanel dockPanel = new DockPanel();
            dockPanel.FocusVisualStyle = new System.Windows.Style();
            dockPanel.Background = Brushes.Thistle;
            
            dockPanel.Width = 250;
            dockPanel.Height = 300;

            Label boxTitle = new Label();
            boxTitle.Content = title;

            boxTitle.VerticalAlignment = System.Windows.VerticalAlignment.Bottom;
            boxTitle.HorizontalAlignment = System.Windows.HorizontalAlignment.Center;

            //templateDockPanel.Children.Add(backgroundImage);
            dockPanel.Children.Add(boxTitle);

            return dockPanel;
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
