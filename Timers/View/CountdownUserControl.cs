using CustomTimers.Common;
using CustomTimers.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CustomTimers.View
{
    public partial class CountdownUserControl : UserControl, IMementoContainer
    {
        //-----------------------------------------------
        // Private data members
        //-----------------------------------------------

        private readonly CustomTimer _countdownTimer = new CountdownTimer();
        private readonly WMPLib.WindowsMediaPlayer _player = new WMPLib.WindowsMediaPlayer();
        private bool _isStopClicked;

        //-----------------------------------------------
        // Public properties
        //-----------------------------------------------
        public CustomTimer.TimerStates TimerState
        {
            get { return _countdownTimer.State; }
        }

        public int Interval { get; set; }
        public string IntervalUnit { get; set; }
        public bool HighResolutionTimer { get; set; }

        public bool EndingSoundEnable { get; set; }
        public string EndingSoundPath { get; set; } = string.Empty;
        public bool CountdownSoundEnable { get; set; } = false;
        public string CountdownSoundPath { get; set; } = string.Empty;
        public int CountdownLastSeconds { get; set; }
        public long SetTimeInMilliseconds { set
            {
                nudMillisecond.Value = value % 1000;
                value /= 1000;
                nudSecond.Value = value % 60;
                value /= 60;
                nudMinute.Value = value % 60;
                value /= 60;
                nudHour.Value = value;
            }
        }
        public bool AutoLoop { get; set; } = false;

        public IStatusReporter StatusReporter { get; set; }

        //-----------------------------------------------
        // Private member functions
        //-----------------------------------------------
        private void Init ()
        {
            _countdownTimer.Elapsed += CustomTimerElapsed;
            _countdownTimer.Completed += CustomTimerCompleted;
            _countdownTimer.StateChanged += CountdownTimerStateChanged;

            _countdownTimer.SynchronizingObject = this;
        }

        private void UpdateStatus ()
        {
            ReportStatus("");
        }

        private void ReportStatus (string status)
        {
            if (StatusReporter != null)
            {
                StatusReporter.ReportStatus(status);
            }
        }

        private void UpdateLabels ()
        {
            if (!_isStopClicked)
            {
                lblHour.Text =
                    string.Format("{0:00}", _countdownTimer.Hour);
                lblMinute.Text =
                    string.Format("{0:00}", _countdownTimer.Minute);
                lblSecond.Text =
                    string.Format("{0:00}", _countdownTimer.Second);
                lblMillisecond.Text =
                    string.Format("{0:000}", _countdownTimer.Millisecond);

                lblMillisecond.Update();
                lblSecond.Update();
                lblMinute.Update();
                lblHour.Update();
            }
        }

        private void UpdateInputs ()
        {
            nudHour.Value = _countdownTimer.Hour;
            nudMinute.Value = _countdownTimer.Minute;
            nudSecond.Value = _countdownTimer.Second;
            nudMillisecond.Value = _countdownTimer.Millisecond;
        }

        private void UpdateButtons ()
        {
            btnStart.Enabled = true;
            btnStop.Enabled = true;
            btnPause.Enabled = true;
            btnReset.Enabled = true;
            switch (_countdownTimer.State)
            {
                case CustomTimer.TimerStates.Stopped:
                    btnPause.Enabled = false;
                    break;
                case CustomTimer.TimerStates.Paused:
                    btnPause.Enabled = false;
                    btnReset.Enabled = false;
                    break;
                case CustomTimer.TimerStates.Running:
                    btnStart.Enabled = false;
                    btnReset.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void PlaySound (string path)
        {
            if (path ==string.Empty)
                return;

            try
            {
                _player.URL = path;
                _player.controls.play();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Reset ()
        {
            _countdownTimer.Reset();
            UpdateStatus();
            UpdateLabels();
            UpdateInputs();
            UpdateButtons();
        }

        private void Cleanup ()
        {
            _player.controls.stop();
        }

        //-----------------------------------------------
        // Public member functions
        //-----------------------------------------------
        public CountdownUserControl ()
        {
            InitializeComponent();
            Init();
            Reset();
        }

        public object CreateMemento ()
        {
            var memento =
                new List<KeyedElement>
                {
                    new KeyedElement("Hour", nudHour.Value.ToString()),
                    new KeyedElement("Minute", nudMinute.Value.ToString()),
                    new KeyedElement("Second", nudSecond.Value.ToString()),
                    new KeyedElement("Millisecond", nudMillisecond.Value.ToString()),
                    new KeyedElement("AutoLoop", AutoLoop.ToString())
                };

            return memento;
        }

        public void SetMemento (object mementoObject)
        {
            try
            {
                var mementoList = mementoObject as List<KeyedElement>;
                if (mementoList != null)
                {
                    var memento = mementoList.ToDictionary(k => k.Key, v => v.Value);

                    nudHour.Value = Convert.ToUInt32(memento["Hour"]);
                    nudMinute.Value = Convert.ToUInt32(memento["Minute"]);
                    nudSecond.Value = Convert.ToUInt32(memento["Second"]);
                    nudMillisecond.Value = Convert.ToUInt32(memento["Millisecond"]);
                    AutoLoop = Convert.ToBoolean(memento["AutoLoop"]);

                    ReportStatus("Saved state has been restored successfully.");
                }
                else
                {
                    ReportStatus("Cannot load saved state.");
                }
            }
            catch (Exception ex)
            {
                ReportStatus(ex.Message);
            }
        }

        //-----------------------------------------------
        // Generated Events
        //-----------------------------------------------
        public event EventHandler TimerCompleted;
        protected virtual void OnTimerCompleted (EventArgs e)
        {
            TimerCompleted(this, e);
        }

        public event EventHandler TimerStarted;
        protected virtual void OnTimerStarted (EventArgs e)
        {
            CountdownSoundLastSec = CountdownLastSeconds;
            TimerStarted(this, e);
        }

        //-----------------------------------------------
        // Event Handlers
        //-----------------------------------------------
        private int CountdownSoundLastSec = 0;
        private void CustomTimerElapsed (object sender, EventArgs e)
        {
            UpdateLabels();

            if (CountdownSoundEnable)
            {
                int sec = _countdownTimer.Second + _countdownTimer.Minute * 60 + _countdownTimer.Hour * 3600;
                if (sec < CountdownSoundLastSec)
                {
                    PlaySound(CountdownSoundPath);
                    CountdownSoundLastSec=sec;
                }
            }

        }

        private void CustomTimerCompleted (object sender, EventArgs e)
        {
            if(EndingSoundEnable)
                PlaySound(EndingSoundPath);
            
            if(!AutoLoop)
                OnTimerCompleted(e);
            else
            {
                _isStopClicked = false;
                _countdownTimer.Restart();
                OnTimerStarted(new EventArgs());
            }
        }

        private void CountdownTimerStateChanged (object sender, EventArgs e)
        {
            UpdateButtons();
        }


        private void BtnStartClick (object sender, EventArgs e)
        {
            try
            {
                if (_countdownTimer.State != CustomTimer.TimerStates.Paused)
                {
                    _countdownTimer.Hour = Convert.ToInt32(nudHour.Value);
                    _countdownTimer.Minute = Convert.ToInt32(nudMinute.Value);
                    _countdownTimer.Second = Convert.ToInt32(nudSecond.Value);
                    _countdownTimer.Millisecond =
                        Convert.ToInt32(nudMillisecond.Value);
                    _countdownTimer.Interval = Interval;
                    _countdownTimer.IntervalUnit =
                        (CustomTimer.IntervalUnits)Enum.Parse(
                        typeof(CustomTimer.IntervalUnits),
                        IntervalUnit);

                    _countdownTimer.UseHighResolution = HighResolutionTimer;

                    _countdownTimer.FindEffectivTime();

                    UpdateStatus();
                    UpdateLabels();
                }

                _isStopClicked = false;
                _countdownTimer.Start();
                OnTimerStarted(new EventArgs());
            }
            catch (Exception ex)
            {
                ReportStatus(ex.Message);
            }
        }

        private void BtnPauseClick (object sender, EventArgs e)
        {
            _countdownTimer.Pause();
        }

        private void BtnStopClick (object sender, EventArgs e)
        {
            _isStopClicked = true;
            _player.controls.stop();
            _countdownTimer.Stop();
        }

        private void BtnResetClick (object sender, EventArgs e)
        {
            _isStopClicked = false;
            _player.controls.stop();
            Reset();
        }

        protected override void OnCreateControl ()
        {
            base.OnCreateControl();

            if (ParentForm != null)
            {
                ParentForm.FormClosing += ParentFormFormClosing;
            }
        }

        private void ParentFormFormClosing (object sender, FormClosingEventArgs e)
        {
            _countdownTimer.Stop();
            Cleanup();
        }

        private void cbxAutoLoop_CheckedChanged(object sender, EventArgs e)
        {
            AutoLoop= cbxAutoLoop.Checked;
        }
    }
}
