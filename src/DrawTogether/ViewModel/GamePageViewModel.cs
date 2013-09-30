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
    public partial class GamePageViewModel : Page
    {

        private UserInteractionService _userInteractionService;
        private int _gameModeId;
        private int _boxId;
        private int _levelId;

        public GamePageViewModel(UserInteractionService userInteractionService, int gameModeId, int boxId, int levelId)
        {
            _gameModeId = gameModeId;
            _boxId = boxId;
            _levelId = levelId;

            InitializeComponent();
        }
    }
}

