using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using CustomTimers.Common;
using CustomTimers.Properties;
using CustomTimers.View;

namespace CustomTimers
{
    public partial class TimerForm : Form, IStatusReporter
    {
        //-----------------------------------------------
        // Private data members
        //-----------------------------------------------
        private const string STATE_FILE_PATH = "State.xml";
        private readonly MessageBoxForm _messageBoxForm = new MessageBoxForm();

        //-----------------------------------------------
        // Public member functions
        //-----------------------------------------------
        public TimerForm ()
        {
            InitializeComponent();

            _messageBoxForm.StartPosition = FormStartPosition.CenterParent;

            ucCountdown.TimerCompleted += new EventHandler(UcCountdownTimerCompleted);
            ucCountdown.TimerStarted += new EventHandler(UcCountdownTimerStarted);
            ucCountdown.StatusReporter = this;

            ucStopWatch.StatusReporter = this;
            ucStopWatch.SetCountdownTimer += new EventHandler<StopwatchToCountdownEventArgs>(OnSendToCountdown);

            ucSettings.StatusReporter = this;
            ucSettings.SettingsUpdated += new EventHandler(OnSettingsUpdated);

            OnSettingsUpdated(this,EventArgs.Empty);
        }

        private void SaveState ()
        {
            try
            {
                var state = new TimeFormState
                {
                    CountDownTimerState = ucCountdown.CreateMemento(),
                    SettingsState = ucSettings.CreateMemento(),
                    TopMost = ucSettings.AlwaysOnTop,
                    SelectedTabIndex = tabTimer.SelectedIndex
                };

                using (var streamWriter = new StreamWriter(STATE_FILE_PATH))
                {
                    var xmlSerializer = new XmlSerializer(typeof(TimeFormState));
                    xmlSerializer.Serialize(streamWriter, state);
                }
                
                ReportStatus(string.Format("Current state has been saved successfully to {0}.", STATE_FILE_PATH));
            }
            catch (Exception ex)
            {
                ReportStatus(ex.Message);
            }
        }
         
        private void LoadState (bool reportError = true)
        {
            try
            {
                TimeFormState state = null;

                using (var streamReader = new StreamReader(STATE_FILE_PATH))
                {
                    var xmlSerializer = new XmlSerializer(typeof(TimeFormState));
                    state = xmlSerializer.Deserialize(streamReader) as TimeFormState;
                }

                if (state != null)
                {
                    ucCountdown.SetMemento(state.CountDownTimerState);
                    ucSettings.SetMemento(state.SettingsState);
                    tabTimer.SelectedIndex = state.SelectedTabIndex;
                }
            }
            catch (Exception ex)
            {
                if (reportError)
                {
                    ReportStatus(ex.Message);
                }
            }
        }

        //-----------------------------------------------
        // Event Handlers
        //-----------------------------------------------

        private void TimerFormResize (object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                Hide();
                nicoMain.Text = string.Format("{0}", ucCountdown.TimerState);
            }
        }

        private void NicoMainDoubleClick (object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void AboutToolStripMenuItemClick (object sender, EventArgs e)
        {
            // Show Message
            _messageBoxForm.Message = string.Format(
                "\n" +
                "Original Author: Paul Li\n" +
                "Date Updated: 1st May 2012 \n" +
                "Email: pong_ho80@hotmail.com \n");
            _messageBoxForm.ShowDialog(this);
        }

        private void UcCountdownTimerCompleted (object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            TopMost = true;

            // Update Tray Icon message
            nicoMain.Text = string.Format("{0}", ucCountdown.TimerState);

            // Show Message
            if (ucSettings.CountdownMessageEnable)
            {
                _messageBoxForm.Message = string.Format("{0}", ucSettings.CountdownMessage);
                _messageBoxForm.ShowDialog(this);
            }
            TopMost = false;
        }

        private void UcCountdownTimerStarted (object sender, EventArgs e)
        {
            nicoMain.Text = string.Format("{0}", ucCountdown.TimerState);
        }

        private void TimerFormFormClosed (object sender, FormClosedEventArgs e)
        {
            nicoMain.Dispose();
        }

        private void TimerFormLoad (object sender, EventArgs e)
        {
            // tabTimer.SelectedIndex = 1;
            TopMost = ucSettings.AlwaysOnTop;

            if (Settings.Default.LoadSettingsAtStart)
            {
                LoadState(false);
                OnSettingsUpdated(this, EventArgs.Empty);
            }
        }

        private void ExitToolStripMenuItemClick (object sender, EventArgs e)
        {
            Close();
        }

        private void saveToolStripMenuItem_Click (object sender, EventArgs e)
        {
            SaveState();
        }

        private void loadToolStripMenuItem_Click (object sender, EventArgs e)
        {
            LoadState();
        }

        private void resetStateToolStripMenuItem_Click (object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(STATE_FILE_PATH))
                {
                    File.Delete(STATE_FILE_PATH);
                }

                ReportStatus("Saved state has been removed successfully.");
            }
            catch (Exception ex)
            {
                ReportStatus(ex.Message);
            }
        }

        public void ReportStatus (string status)
        {
            lblStatus.Text = status;
        }

        private void OnSettingsUpdated(object sender, EventArgs e)
        {
            ucStopWatch.Interval = ucSettings.Interval;
            ucStopWatch.IntervalUnit= ucSettings.IntervalUnit;
            ucStopWatch.HighResolutionTimer= ucSettings.HighResolutionTimer;

            ucCountdown.Interval = ucSettings.Interval;
            ucCountdown.IntervalUnit = ucSettings.IntervalUnit;
            ucCountdown.HighResolutionTimer = ucSettings.HighResolutionTimer;
            ucCountdown.CountdownSoundPath = ucSettings.CountdownSound;
            ucCountdown.CountdownSoundEnable = ucSettings.CountdownSoundEnabled;
            ucCountdown.CountdownLastSeconds = ucSettings.CountdownLastSeconds;
            ucCountdown.EndingSoundEnable = ucSettings.CountdownEndingSoundEnabled;
            ucCountdown.EndingSoundPath = ucSettings.CountdownEndingSound;

            TopMost = ucSettings.AlwaysOnTop;
        }

        private void OnSendToCountdown(object sender, StopwatchToCountdownEventArgs e)
        {
            ucCountdown.SetTimeInMilliseconds=e.CountdownTime;
        }

    }

    [XmlInclude(typeof(List<KeyedElement>))]
    public class TimeFormState
    {
        public object CountDownTimerState { get; set; }
        public object StopWatchTimerState { get; set; }

        public object SettingsState { get; set; }
        public bool TopMost { get; set; }
        public int SelectedTabIndex { get; set; }
    }
}
