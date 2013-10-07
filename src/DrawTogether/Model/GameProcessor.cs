using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace DrawTogether.Model
{
    public class GameProcessor
    {
        public event TimerTickEventHandler TopTimerTick;
        public event TimerTickEventHandler BottomTimerTick;

        private DispatcherTimer _topTimer;
        private DispatcherTimer _bottomTimer;

        private TimeSpan _topTimerTimeSpan;
        private TimeSpan _bottomTimerTimeSpan;

        GameSettings _settings;

        public GameProcessor(GameSettings settings)
        {
            _settings = settings;
            OnCreate();
        }


        public void OnCreate()
        {
            _topTimerTimeSpan = _settings.TopTimerTimeSpan;
            _bottomTimerTimeSpan = _settings.BottomTimerTimeSpan;

            _topTimer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, OnTopTimerTick, Application.Current.Dispatcher);
            _bottomTimer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, OnBottomTimerTick, Application.Current.Dispatcher);
        }

        public void OnStart()
        {
            _topTimer.Start();
            _bottomTimer.Start();
        }

        public void OnResume()
        {
            _topTimer.IsEnabled = true;
            _bottomTimer.IsEnabled = true;
        }

        public void OnPause()
        {
            _topTimer.IsEnabled = false;
            _bottomTimer.IsEnabled = false;
        }

        public void OnStop()
        {
            _topTimer.Stop();
            _bottomTimer.Stop();
        }

        public void OnDestroy()
        {

        }

        private void OnTopTimerTick(object sender, EventArgs e)
        {
            RaiseTopTimerTickEventEvent(_topTimerTimeSpan.ToString(@"mm\:ss"));
            if (_topTimerTimeSpan == TimeSpan.Zero) _topTimer.Stop();
            _topTimerTimeSpan = _topTimerTimeSpan.Add(TimeSpan.FromSeconds(-1));
        }

        private void OnBottomTimerTick(object sender, EventArgs e)
        {
            RaiseBottomTimerTickEventEvent(_bottomTimerTimeSpan.ToString(@"mm\:ss"));
            if (_bottomTimerTimeSpan == TimeSpan.Zero) _bottomTimer.Stop();
            _bottomTimerTimeSpan = _bottomTimerTimeSpan.Add(TimeSpan.FromSeconds(-1));
        }


        public delegate void TimerTickEventHandler(object sender, string e);

        private void RaiseTopTimerTickEventEvent(string value)
        {
            if (TopTimerTick != null)
                TopTimerTick(this, value);
        }
        private void RaiseBottomTimerTickEventEvent(string value)
        {
            if (BottomTimerTick != null)
                BottomTimerTick(this, value);
        }
    }
}
