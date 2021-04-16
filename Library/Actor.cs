using System;
using System.Timers;

namespace task8_26
{
    public abstract class Actor
    {
        protected readonly Timer timer = new Timer();

        public string Name { get; }

        public event Action<string> ActorEvent;

        protected Actor(string name, uint ms)
        {
            this.Name = name;
            this.timer.Interval = ms;
            this.timer.AutoReset = true;
            this.timer.Elapsed += (object sender, ElapsedEventArgs e) => this.Tick();
            this.timer.Start();
        }

        protected abstract void Tick();

        protected void RaiseEvent(string eventDesc)
        {
            ActorEvent?.Invoke(eventDesc);
        }
    }
}
