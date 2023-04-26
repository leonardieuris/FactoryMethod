namespace FactoryMethodLibrary
{
    public class Tricycle : IVehicle
    {
        private readonly int _wheels;
        private readonly string _description;

        public Tricycle()
        {
            _wheels = 3;
            _description = "Tricycle";
        }
        public int Wheels() => _wheels;


        public string Description() => _description;
    }
}
