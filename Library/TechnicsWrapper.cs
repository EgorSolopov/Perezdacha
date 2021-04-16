using System;
using System.Collections.Generic;
using System.Threading;

namespace task8_26
{
    public class TechnicsWrapper : AbstractWorker
    {
        private static readonly List<TechnicsWrapper> instances = new List<TechnicsWrapper>();

        private readonly ITechnics technics; 
        private readonly SemaphoreSlim semaphore;

        public static TechnicsWrapper GetRandomTechnics() { 
            if (instances.Count == 0)
            {
                return null;
            }
            return instances[new Random().Next(0, instances.Count)];
        }

        public TechnicsWrapper(ITechnics loader)
        {
            this.technics = loader;
            this.semaphore = new SemaphoreSlim(1);
            instances.Add(this);
        }

        protected override void Work()
        {
            this.timer.Stop();
            this.RaiseEvent("Работает.");
            this.technics.Tech();
            Interlocked.Add(ref this.work, -100);
            this.RaiseEvent("Простаивает.");
            this.timer.Start();
            this.semaphore.Release();
        }

        internal void RequestRoofCovering(House bolide)
        {
            this.semaphore.Wait();
            this.Request(bolide);
            Interlocked.Add(ref this.work, 100);
        }
    }
}
