namespace FactoryMethodLibrary
{
    public class Motorbike : IVehicle
    {
        private readonly int _wheels;
        private readonly string _description;

        public Motorbike()
        {
            _wheels = 2;
            _description = "Motorcycle";
        }
        public int Wheels() => _wheels;


        public string Description() => _description;


    }
}
