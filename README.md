Timers
======

Countdown and Stopwatch timer

Based on original code by engineforce (https://github.com/engineforce/Timers)

# Descriptions

A high resolution Countdown Timer and Stop Watch written in C# .NET that pop up a message box with user defined message and play user specified sound when time is up.

It use a QueueTimer (via PInvoke) for high resolution timing and System.Timers.Timer for normal resolution.

It also allow users to save, load and remove current state to/from a XML file.


# Features

* Countdown timer and Stop Watch.
* Pop up user defined message when time is up.
* Play user specifed sound when time is up.
* Play sounds as countdown nears the end of the timer period.
* Automatically loop the countdown timer.
* Progress bar to show relative time remaining.
* Automatically imecalculate effective t from input, such as 80 seconds equal to 1 minute and 20 seconds.
* Used QueueTimer (via PInvoke) for high resolution. Used System.Timers.Timer for normal resolution.
* Support down to 1 millisecond (ms) resolution.
* Save, Load, Remove current state to/from a XML file
