using System;
using System.Diagnostics;
using System.Timers;

class Clock
{
    private static Timer _timer = new Timer();  // Clock timer
    public int ClockSpeed { get; set; } = 50; // Default clock speed in ms - 50 ms = 20 Hz

    // Event delegates and event variables
    public delegate void ChangeEvent(bool boolEvent);

    //********************  Change Event Handlers ********************
    public event ChangeEvent ChangeEventCLK;  // create the event variable
    public bool CLK = false;
    public void ToggleCLK()
    {
        CLK = !CLK;
        ChangeEventCLK?.Invoke(CLK);
    }

    // Start the clock timer using the current clock speed
    public void SetTimer()
    {
        _timer = new System.Timers.Timer(this.ClockSpeed);
        // Hook up the Elapsed event for the timer. 
        _timer.Elapsed += OnTimedEvent;
        _timer.AutoReset = true;
        _timer.Enabled = true;
    }

    // Timer event handler to single step the clock
    private void OnTimedEvent(Object source, ElapsedEventArgs e)
    {
        ToggleCLK();
    }

    // Stop the clock timer
    public void StopTimer()
    {
        _timer.Stop();
        _timer.Dispose();
    }
}
