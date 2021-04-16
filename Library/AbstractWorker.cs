using System;
using System.Threading;

namespace task8_26
{
    public abstract class AbstractWorker : Actor
    {
        protected long work = 0;
        private object owner;

        public int Progress { get { return (int)Math.Max(0, 100 - work); } }

        public event Action<object> ProgressEvent; 

        public AbstractWorker() : base("", 100)
        {

        }

        protected override void Tick()
        {
            if (Interlocked.Read(ref this.work) != 0)
            {
                this.Work();
                this.ProgressEvent?.Invoke(owner);
            }
        }

        protected void Request(object owner)
        {
            this.owner = owner;
        }
        protected abstract void Work();
    }
}
