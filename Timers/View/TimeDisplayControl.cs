using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomTimers.View
{
    public partial class TimeDisplayUserControl : UserControl
    {
        public uint Hours { set; get; } = 0;
        public uint Minutes { set; get; } = 0;
        public uint Seconds { set; get; } = 0;
        public uint Milliseconds { set; get; } = 0;

        public TimeDisplayUserControl()
        {
            InitializeComponent();
        }

        public void SetAndUpdate(uint hours,uint minutes,uint seconds,uint milliseconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
            Milliseconds = milliseconds;

            
            UpdateDisplay();
        }

        public void UpdateDisplay()
        {
            lblTime.Text = string.Format("{0:00} : {1:00} : {2:00}.{3:000}", Hours, Minutes, Seconds, Milliseconds);
        }

        public long GetTotalMilliseconds()
        {
            return Hours * 3600 * 1000 +
                Minutes * 60 * 1000 +
                Seconds * 1000 +
                Milliseconds;
        }
    }
}
