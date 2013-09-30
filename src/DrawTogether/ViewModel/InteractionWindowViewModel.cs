using DrawTogether.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DrawTogether.ViewModel
{
    public partial class InteractionWindowViewModel : Window
    {
        private UserInteractionService _userInteractionService;

        public InteractionWindowViewModel()
        {
            _userInteractionService = new UserInteractionService(this);
            InitializeComponent();

            _userInteractionService.SwitchToStartWindow();

            var asd = new MenuItemsProvider().GetMenuGameModeItems();
        }
    }
}
