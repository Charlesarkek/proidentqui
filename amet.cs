public class PausableAnimationContext : AnimationContext
{
    public PausableState State { get; private set; } = PausableState.Stopped;

    public void Pause()
    {
        if (State == PausableState.Running)
        {
            State = PausableState.Paused;
            // Additional pause logic
        }
    }

    public void Resume()
    {
        if (State == PausableState.Paused)
        {
            State = PausableState.Running;
            // Additional resume logic
        }
    }

    public new void Start()
    {
        base.Start();
        State = PausableState.Running;
    }

    public new void Stop()
    {
        base.Stop();
        State = PausableState.Stopped;
    }
}
