namespace Task6_26
{
    public interface ISpaceObject
    {   
        double Mass { get; set; }

        double CalcDensity();

        string GetInfoAboutSpaceObject();

    }
}