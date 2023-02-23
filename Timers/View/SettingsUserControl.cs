using CustomTimers.Common;
using CustomTimers.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CustomTimers.View
{
    public partial class SettingsUserControl : UserControl, IMementoContainer
    {
        public IStatusReporter StatusReporter { get; set; }

        public int Interval
        {
            get
            {
                return Convert.ToInt32(nudInterval.Value);
            }
        }

        public string IntervalUnit
        {
            get
            {
                return cbxIntervalUnit.Text;
            }
        }
        public bool HighResolutionTimer
        {
            get
            {
                return cbxHighResolution.Checked;
            }
        }

        public bool AlwaysOnTop
        {
            get
            {
                return cbxIsTopMost.Checked;
            }
        }

        public bool CountdownSoundEnabled
        {
            get
            {
                return cbxCountdownSound.Checked;
            }
        }

        public string CountdownSound
        {
            get
            {
                return txtCountdownSound.Text;
            }
        }

        public int CountdownLastSeconds
        {
            get
            {
                return (int)nudLastSeconds.Value;
            }
        }

        public bool CountdownEndingSoundEnabled
        {
            get
            {
                return cbxSoundEnabled.Checked;
            }
        }

        public string CountdownEndingSound
        {
            get
            {
                return txtSound.Text;
            }
        }

        public bool CountdownMessageEnable
        {
            get
            {
                return cbxCountdownMessageEnabled.Checked;
            }
        }

        public string CountdownMessage
        {
            get
            {
                return txtMessage.Text;
            }
        }

        public SettingsUserControl()
        {
            InitializeComponent();
            UpdateInputs();
            UpdateStatus();
        }


        private void UpdateInputs()
        {
            cbxIntervalUnit.DataSource = System.Enum.GetValues(
                typeof(CustomTimer.IntervalUnits));
            //nudInterval.Value = _StopWatch.Interval;
            //cbxHighResolution.Checked = _StopWatch.UseHighResolution;
        }

        private void UpdateStatus()
        {
            ReportStatus("");
        }

        private void ReportStatus(string status)
        {
            StatusReporter?.ReportStatus(status);
        }


        public object CreateMemento()
        {
            var memento =
                new List<KeyedElement>
                {
                    new KeyedElement("IntervalUnit", cbxIntervalUnit.SelectedValue.ToString()),
                    new KeyedElement("Interval", nudInterval.Value.ToString()),
                    new KeyedElement("HighResolution", cbxHighResolution.Checked.ToString()),
                    new KeyedElement("Message", txtMessage.Text),
                    new KeyedElement("Sound", txtSound.Text),
                    new KeyedElement("SoundEnabled", cbxSoundEnabled.Checked.ToString())
                };

            return memento.ToList();
        }

        public void SetMemento(object mementoObject)
        {
            try
            {
                if (mementoObject is List<KeyedElement> mementoList)
                {
                    var memento = mementoList.ToDictionary(k => k.Key, v => v.Value);


                    cbxIntervalUnit.SelectedItem = memento["IntervalUnit"];
                    nudInterval.Value = Convert.ToUInt32(memento["Interval"]);

                    cbxHighResolution.Checked = Convert.ToBoolean(memento["HighResolution"]);
                    cbxHighResolution.Checked = Convert.ToBoolean(memento["HighResolution"]);
                    txtMessage.Text = memento["Message"];
                    txtSound.Text = memento["Sound"];
                    cbxSoundEnabled.Checked = Convert.ToBoolean(memento["SoundEnabled"]);

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


        public event EventHandler SettingsUpdated;
        protected void RaiseSettingsUpdatedEvent()
        {
            SettingsUpdated?.Invoke(this, EventArgs.Empty);
        }

        private void cbxIntervalUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            RaiseSettingsUpdatedEvent();
        }

        private void nudInterval_ValueChanged(object sender, EventArgs e)
        {
            RaiseSettingsUpdatedEvent();
        }

        private void cbxHighResolution_CheckedChanged(object sender, EventArgs e)
        {
            RaiseSettingsUpdatedEvent();
        }

        private void cbxIsTopMost_CheckedChanged(object sender, EventArgs e)
        {
            RaiseSettingsUpdatedEvent();
        }

        private void cbxSoundEnabled_CheckedChanged(object sender, EventArgs e)
        {
            txtSound.Enabled = cbxSoundEnabled.Checked;
            btnBrowseSound.Enabled = cbxSoundEnabled.Checked;
            RaiseSettingsUpdatedEvent();
        }

        private void txtSound_TextChanged(object sender, EventArgs e)
        {
            RaiseSettingsUpdatedEvent();
        }

        private void cbxCountdownSound_CheckedChanged(object sender, EventArgs e)
        {   
            txtCountdownSound.Enabled = cbxCountdownSound.Checked;
            btnCountdownSound.Enabled = cbxCountdownSound.Checked;
            nudLastSeconds.Enabled = cbxCountdownSound.Checked;
            RaiseSettingsUpdatedEvent();
        }

        private void txtCountdownSound_TextChanged(object sender, EventArgs e)
        {
            RaiseSettingsUpdatedEvent();
        }


        private void nudLastSeconds_ValueChanged(object sender, EventArgs e)
        {
            RaiseSettingsUpdatedEvent();
        }

        private void cbxCountdownMessageEnabled_CheckedChanged(object sender, EventArgs e)
        {
            txtMessage.Enabled = cbxCountdownMessageEnabled.Checked;
            RaiseSettingsUpdatedEvent();
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {
            RaiseSettingsUpdatedEvent();
        }


        private void btnCountdownSound_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgSound = new OpenFileDialog();

            if (!string.IsNullOrWhiteSpace(txtSound.Text))
            {
                dlgSound.InitialDirectory = Path.GetDirectoryName(txtSound.Text);
            }

            var dialogResult = dlgSound.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                txtCountdownSound.Text = dlgSound.FileName;
            }
        }

        private void btnBrowseSound_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgSound = new OpenFileDialog();

            if (!string.IsNullOrWhiteSpace(txtSound.Text))
            {
                dlgSound.InitialDirectory = Path.GetDirectoryName(txtSound.Text);
            }

            var dialogResult = dlgSound.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                txtSound.Text = dlgSound.FileName;
            }
        }
    }
}
