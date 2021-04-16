namespace Task6_26
{
    public class RedGiantStar : Star
    {
        public override double Temperature { get; set; }
        public override string Color { get; set; }
        public double Luminosity { get; set; }
        public int SpectralClass { get; set; }


        public RedGiantStar(double mass, double volume, double temperature, string color, int spectralClass)
            : base(mass, volume)
        {
            Temperature = temperature;
            Color = color;
            SpectralClass = spectralClass;
        }

        public override double CalcTemperaturePerKg()
        {
            return Temperature / Mass;
        }
        
        public double CalcLuminosityPerKg()
        {
            return Luminosity / Mass;
        }

        public string RegGiantInfo()
        {
            return "Star color: " + Color + " Star temperature: " + Temperature;
        }

        public override string GetInfoAboutSpaceObject()
        {
            return "Star color: " + Color + " Star temperature: " + Temperature + " Star luminosity: " + Luminosity +
                   " Star spectralClass: " + SpectralClass;
        }
    }
}