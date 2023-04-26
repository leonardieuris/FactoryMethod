namespace FactoryMethodLibrary;

public class Car : IVehicle
{
    private readonly int _wheels;
    private readonly string _description;

    public Car()
    {
        _wheels = 4;
        _description = "Tricycle";
    }
    public int Wheels() => _wheels;


    public string Description() => _description;
}