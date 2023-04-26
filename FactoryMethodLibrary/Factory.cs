namespace FactoryMethodLibrary
{
    public class Factory
    {
        public IVehicle GetVehicle(int wheels)
        {
            IVehicle output;

            switch (wheels)
            {
                case 2:
                    output= new Motorbike();
                    break;
                case 3:
                    output = new Tricycle();
                    break;
                case 4:
                    output = new Car();
                    break;
                default: output = null;
                    break;
            }

            return output;
        }
    }
}
