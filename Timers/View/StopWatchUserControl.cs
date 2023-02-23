using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using CustomTimers.Common;
using CustomTimers.Model;

namespace CustomTimers.View
{
    public partial class StopWatchUserControl : UserControl
    {
        //-----------------------------------------------
        // Private data members
        //-----------------------------------------------
        private readonly StopWatchTimer _StopWatch = new StopWatchTimer ();
        private bool _IsStopClicked = false;

        //-----------------------------------------------
        // Public properties
        //-----------------------------------------------

        public IStatusReporter StatusReporter { get; set; }

        public int Interval {  get; set; }
        public bool HighResolutionTimer { get; set; }
        public string IntervalUnit { get; set; }

        //-----------------------------------------------
        // Private member functions
        //-----------------------------------------------
        private void Init ()
        {
            _StopWatch.SynchronizingObject = this;
            _StopWatch.Elapsed += new
                EventHandler (StopWatch_Elapsed);

            _StopWatch.StateChanged += new
                EventHandler (StopWatch_StateChanged);
        }

        private void UpdateStatus ()
        {
            ReportStatus("");
        }

        private void ReportStatus (string status)
        {
            StatusReporter?.ReportStatus(status);
        }

        private void Reset ()
        {
            _StopWatch.Reset ();
            UpdateStatus();
            UpdateLabels ();
            //UpdateInputs ();
            UpdateButtons ();
        }

        private void UpdateLabels ()
        {
            if (!_IsStopClicked)
            {
                ucTimeDisplay.SetAndUpdate((uint)_StopWatch.Hour, (uint)_StopWatch.Minute, (uint)_StopWatch.Second, (uint)_StopWatch.Millisecond);
            }
        }



        private void UpdateButtons ()
        {
            btnStart.Enabled = true;
            btnStop.Enabled = true;
            btnPause.Enabled = true;
            btnReset.Enabled = true;
            switch (_StopWatch.State)
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

        //-----------------------------------------------
        // Protected member function
        //-----------------------------------------------

        //-----------------------------------------------
        // Public member functions
        //-----------------------------------------------
        public StopWatchUserControl ()
        {
            InitializeComponent ();
            Init ();
            Reset ();
        }



        //-----------------------------------------------
        // Generated Events
        //-----------------------------------------------
        public event EventHandler<StopwatchToCountdownEventArgs> SetCountdownTimer;

        //-----------------------------------------------
        // Event Handlers
        //-----------------------------------------------       
        private void StopWatch_Elapsed (
            object sender, EventArgs e)
        {
            UpdateLabels ();
        }

        private void StopWatch_StateChanged (object sender, EventArgs e)
        {
            UpdateButtons ();
        }

        private void btnStart_Click (object sender, EventArgs e)
        {
            try
            {
                if (_StopWatch.State != CustomTimer.TimerStates.Paused)
                {
                    _StopWatch.Interval = Interval;
                    _StopWatch.IntervalUnit =
                        (CustomTimer.IntervalUnits) Enum.Parse (
                        typeof (CustomTimer.IntervalUnits),
                        IntervalUnit);

                    UpdateStatus();
                    UpdateLabels ();
                }

                _IsStopClicked = false;
                _StopWatch.Start ();
            }
            catch (Exception ex)
            {
                ReportStatus(ex.Message);
            }
        }

        private void btnPause_Click (object sender, EventArgs e)
        {
            _StopWatch.Pause ();
        }
                
        private void btnStop_Click (object sender, EventArgs e)
        {
            _IsStopClicked = true;
            _StopWatch.Stop ();
        }

        private void btnReset_Click (object sender, EventArgs e)
        {
            _IsStopClicked = false;
            Reset ();
        }

        private void cbxHighResolution_CheckedChanged (object sender, EventArgs e)
        {
            _StopWatch.UseHighResolution = HighResolutionTimer;
        }

        private void btnSendToCountdown_Click(object sender, EventArgs e)
        {
            StopwatchToCountdownEventArgs ea = new StopwatchToCountdownEventArgs();
            if (_StopWatch.State == CustomTimer.TimerStates.Running)
            {
                ea.CountdownTime = _StopWatch.Millisecond;
                ea.CountdownTime += _StopWatch.Second * 1000;
                ea.CountdownTime += _StopWatch.Minute * 60 * 1000;
                ea.CountdownTime += _StopWatch.Hour * 60 * 60 * 1000;
                ea.CountdownTime /= (long)nudDivisor.Value;
            }
            else
            {
                ea.CountdownTime = ucTimeDisplay.GetTotalMilliseconds();
            }

            ea.CountdownTime /= (long)nudDivisor.Value;
            Debug.Print(ea.CountdownTime.ToString());

            RaiseSendToCountdown(ea);
        }

        protected virtual void RaiseSendToCountdown(StopwatchToCountdownEventArgs e)
        {
            SetCountdownTimer?.Invoke(this, e);
        }
    }
}
