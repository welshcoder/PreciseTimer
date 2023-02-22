using System;

namespace CustomTimers.View
{
    public class StopwatchToCountdownEventArgs : EventArgs
    {
        public long CountdownTime { get; set; }
    }
}
