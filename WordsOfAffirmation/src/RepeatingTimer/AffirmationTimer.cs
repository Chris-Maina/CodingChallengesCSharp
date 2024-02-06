using System.Timers;

namespace RepeatingTimer;

class AffirmationTimer
{
  private System.Timers.Timer _timer;
  private static readonly Random _random = new Random();
  private static readonly string[] _affirmations = {
    "You're capable", "Progress, not perfection", "Don't quit", "Success is certain", 
    "You attract good", "You're unstoppable", "You're courageous", "You attract success",
  };

  public AffirmationTimer()
  {
    // Create the timer
    _timer = new System.Timers.Timer();
  }

  public void StartTimer(int seconds)
  { 
    // Set interval
    int milliseconds = seconds * 1000;
    _timer.Interval = milliseconds;

    // Hook up the Elapsed event for the timer. 
    _timer.Elapsed += GetWordOfAffirmation;

    // Have the timer fire repeated events
    _timer.AutoReset = true;

    // Start the timer
    _timer.Enabled = true;

    Console.WriteLine("Press the Enter key to exit the program at any time... ");
    Console.ReadLine();
    StopTimer();
  }

  private static void GetWordOfAffirmation(Object? sender, ElapsedEventArgs e)
  {
    int index = _random.Next(_affirmations.Length);
    Console.WriteLine(_affirmations[index]);
  }

  public void StopTimer() 
  {
    _timer.Stop();
    _timer.Dispose();
    Console.WriteLine("Timer stopped");
  }
}