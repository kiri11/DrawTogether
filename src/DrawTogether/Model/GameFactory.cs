using DrawTogether.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace DrawTogether.Model
{
    public class GameFactory
    {
        public GameFactory()
        {
            GetSettings(0,0,0);
        }

        public GameSettings GetSettings(int modeId, int boxId, int levelId)
        {
            GameSettings gameSettings = new GameSettings();
            //разграничить логику в зависимости от режима

            gameSettings.LevelId = levelId;
            gameSettings.ModeID = modeId;
            gameSettings.BoxId = boxId;

            //Таймеры?
            gameSettings.TopTimerTimeSpan = new TimeSpan(0,2,0);
            gameSettings.BottomTimerTimeSpan = new TimeSpan(0, 1, 0);

            gameSettings.Player1 = GetPlayer(0, modeId, boxId, levelId);
            gameSettings.Player2 = GetPlayer(1, modeId, boxId, levelId);
            gameSettings.Player3 = GetPlayer(2, modeId, boxId, levelId);
            gameSettings.Player4 = GetPlayer(3, modeId, boxId, levelId);

            return gameSettings;
        }

        private Player GetPlayer(int playerId, int modeId, int boxId, int levelId)
        {
            Player player = new Player();
            player.Id = playerId;

            BitmapSource[] bitmapSources = ImageDecoder.BitmapFrames(AppSettings.DataDirectoryPath +
                @"/Challenges/mode_" + modeId + @"/box_" + boxId + @"/level_" + levelId + @"/960x540.tif");

            //Затычки на цвет и рисунки
            if (playerId == 0)
            {
                player.PlayerColor = Color.FromRgb(0,255,0);
                player.SourceBitmap = bitmapSources[0];
            }
            if (playerId == 1)
            {
                player.PlayerColor = Color.FromRgb(0, 0, 255);
                player.SourceBitmap = bitmapSources[1];
            }
            if (playerId == 2)
            {
                player.PlayerColor = Color.FromRgb(255, 255, 0);
                player.SourceBitmap = bitmapSources[2];
            }
            if (playerId == 3)
            {
                player.PlayerColor = Color.FromRgb(255, 0, 0);
                player.SourceBitmap = bitmapSources[3];
            }

            return player;
        }
    }
}
