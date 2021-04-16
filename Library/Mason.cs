using System;
using System.Threading;

namespace task8_26
{
    public class Mason : AbstractWorker
    {
        protected override void Work()
        {
            Interlocked.Add(ref this.work, -1);
        }

        internal void RequestMaterials()
        {
            Interlocked.Add(ref this.work, 100);
        }
    }
}
