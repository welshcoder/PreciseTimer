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
        public enum DisplayFormat
        {
            HoursMinutesSecondsMilliseconds,
            MinutesSecondsMilliseconds,
            SecondsMilliseconds,
            Milliseconds,
            HoursMinutesSeconds,
            MinutesSeconds,
            Seconds,
            HoursMinutes,
            Minutes,
            Hours,
            MinutesDecimal,
            HoursDecimal
        }

        public DisplayFormat TimeFormat { set; get; } = DisplayFormat.HoursMinutesSecondsMilliseconds;

        public uint Hours { set; get; } = 0;
        public uint Minutes { set; get; } = 0;
        public uint Seconds { set; get; } = 0;
        public uint Milliseconds { set; get; } = 0;

        public TimeDisplayUserControl()
        {
            InitializeComponent();
        }

        public void SetAndUpdate(uint hours, uint minutes, uint seconds, uint milliseconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
            Milliseconds = milliseconds;

            UpdateDisplay();
        }

        public void UpdateDisplay()
        {
            lblTime.Text = GetTimeFormat();
            float ratio = Math.Min(lblTime.Width / TextRenderer.MeasureText(lblTime.Text, lblTime.Font).Width, lblTime.Height / TextRenderer.MeasureText(lblTime.Text, lblTime.Font).Height);
            float newWidth = (float)Math.Floor(lblTime.Font.Size * ratio);
            lblTime.Font = new Font(lblTime.Font.FontFamily, (float)newWidth);
        }

        public long GetTotalMilliseconds()
        {
            return Hours * 3600 * 1000 +
                Minutes * 60 * 1000 +
                Seconds * 1000 +
                Milliseconds;
        }

        private string GetTimeFormat()
        {
            switch(TimeFormat)
            {
                case DisplayFormat.HoursMinutesSecondsMilliseconds:
                default:
                    return string.Format("{0:00} : {1:00} : {2:00}.{3:000}", Hours, Minutes, Seconds, Milliseconds);

                case DisplayFormat.MinutesSecondsMilliseconds:
                    return string.Format("{0:00} : {1:00}.{2:000}", (Hours*60)+ Minutes, Seconds, Milliseconds);

                case DisplayFormat.SecondsMilliseconds:
                    return string.Format("{0:00}.{1:000}", ((Hours * 60) + Minutes) * 60 + Seconds, Milliseconds);

                case DisplayFormat.HoursMinutesSeconds:
                    return string.Format("{0:00} : {1:00} : {2:00}", Hours, Minutes, Seconds);

                case DisplayFormat.MinutesSeconds:
                    return string.Format("{0:00} : {1:00}", (Hours *60) + Minutes, Seconds);

                case DisplayFormat.HoursMinutes:
                    return string.Format("{0:00} : {1:00}", Hours,  Minutes);

                case DisplayFormat.Milliseconds:
                    return string.Format("{0:0}", ((Hours*60 + Minutes) * 60 + Seconds) * 1000 + Milliseconds );

                case DisplayFormat.Seconds:
                    return string.Format("{0:0}", (Hours * 60 + Minutes) * 60 + Seconds);

                case DisplayFormat.Minutes:
                    return string.Format("{0:0}", Hours * 60 + Minutes);

                case DisplayFormat.Hours:
                    return string.Format("{0:0}", Hours );

                case DisplayFormat.MinutesDecimal:
                    return string.Format("{0:F6}", Hours * 60 + Minutes + (Seconds * 1000 + Milliseconds) / 60000.0);

                case DisplayFormat.HoursDecimal:
                    return string.Format("{0:F8}", Hours + (Minutes * 60000 + Seconds * 1000 + Milliseconds) / 3600000.0);

            }
        }
    }
}
