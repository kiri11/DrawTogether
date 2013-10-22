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

            if (modeId == 0)
            {
                gameSettings.Players = new Player[4];
            }
            if (modeId == 1)
            {
                gameSettings.Players = new Player[3];
            }
            if (modeId == 2)
            {
                gameSettings.Players = new Player[2];
            }

            for (int i = 0; i < gameSettings.Players.Count(); i++)
            {
                gameSettings.Players[i] = GetPlayer(i, modeId, boxId, levelId);
            }

            return gameSettings;
        }

        private Player GetPlayer(int playerId, int modeId, int boxId, int levelId)
        {
            Player player = new Player();
            player.Id = playerId;

            BitmapSource[] bitmapSources = ImageDecoder.BitmapFrames(AppSettings.DataDirectoryPath +
                @"/Challenges/mode_" + modeId + @"/box_" + boxId + @"/level_" + levelId + @"/960x540.tif");

            //возможно однажды даст сбой
            player.PlayerColor = BitmapProcessor.GetPlayerColor(bitmapSources[playerId]);
            player.SourceBitmap = bitmapSources[playerId];

            return player;
        }
    }
}
