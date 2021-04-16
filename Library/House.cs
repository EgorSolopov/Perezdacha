using System;

namespace task8_26
{
    public class House : Actor
    {
        private static readonly Random random = new Random();

        private bool running = true;

        private readonly Mason mason;

        public House(string bolideName) : base(bolideName, 100)
        {
            this.mason = new Mason();
            this.mason.ProgressEvent += (owner) => {
                this.RaiseEvent($"Получаем строематериалы({mason.Progress}%)");
                if (mason.Progress == 100)
                {
                    this.running = true;
                }
            };
        }

        protected override void Tick()
        {
            if (!this.running)
            {
                return;
            }

            var roll = random.NextDouble();
            if (roll < 0.0019d)
            {
                this.running = false;
                if (roll < 0.00094d)
                {
                    var technics = TechnicsWrapper.GetRandomTechnics();
                    this.RaiseEvent($"Необходимо крыть крышу. Ожидаем технику.");
                    technics.ProgressEvent += (owner) =>
                    {
                        if (owner == this)
                        {
                            this.running = true;
                        }
                    };
                    technics.RequestRoofCovering(this);
                } else
                {
                    mason.RequestMaterials();
                }
            }

            if (this.running)
            {
                this.RaiseEvent("Строится...");
                return;
            }
        }
    }
}
