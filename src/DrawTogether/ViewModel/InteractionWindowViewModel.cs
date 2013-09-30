using DrawTogether.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Drawing;

namespace DrawTogether.ViewModel
{
    public partial class InteractionWindowViewModel : Window
    {
        private UserInteractionService _userInteractionService;
        private MenuGameModeItem[] _gameModeItems;

        public InteractionWindowViewModel()
        {
            //ниже перенести на экран загрузки!

            _gameModeItems = new MenuItemsProvider().GetMenuGameModeItems();

            _userInteractionService = new UserInteractionService(this, _gameModeItems);
            _gameModeItems = new MenuItemsProvider().GetMenuGameModeItems();

            InitializeComponent();

            _userInteractionService.SwitchToStartPage();

            

            double[] asd1 = { 1, 4, 1, 1, 1};
            double[] asd2 = { 1, 1, 1 , 1, 3};
            var asd = Correlation.Correlate(asd1, asd2);

        }
    }
}
