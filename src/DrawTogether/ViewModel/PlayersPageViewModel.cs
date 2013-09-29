using DrawTogether.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DrawTogether.ViewModel
{
    public partial class PlayersPageViewModel : Page
    {
        private UserInteractionService _userInteractionService;

        public PlayersPageViewModel(UserInteractionService userInteractionService)
        {
            _userInteractionService = userInteractionService;

            InitializeComponent();
        }
    }
}
