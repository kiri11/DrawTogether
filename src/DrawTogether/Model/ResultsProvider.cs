using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawTogether.Model
{
    public class ResultsProvider
    {
        private BitmapProcessor _bitmapProcessor;

        public ResultsProvider(BitmapProcessor bitmapProcessor)
        {
            _bitmapProcessor = bitmapProcessor;
        }

        public Player[] UpdatePlayersResults(Player[] players, double rateCoeff) //inject to "out" + void
        {
            foreach (var player in players)
            {
                player.Score = rateCoeff * _bitmapProcessor.GetSimilarityValue(player.SourceBitmap, player.ResultBitmap);
            }

            return players;
        }
    }
}
