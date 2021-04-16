namespace Task6_26
{
    public abstract class Star : ISpaceObject
    {
        public double Mass { get; set; }
        public double Volume { get; set; }
        public abstract double Temperature { get; set; }
        public abstract string Color { get; set; }

        public Star(double mass, double volume)
        {
            Mass = mass;
            Volume = volume;
        }
        
        
        public double CalcDensity()
        {
            return Mass / Volume;
        }

        public abstract double CalcTemperaturePerKg();

        public abstract string GetInfoAboutSpaceObject();
    }
}