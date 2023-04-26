using FactoryMethodLibrary;

var factory = new Factory();
var apecar = factory.GetVehicle(3);
var auto = factory.GetVehicle(4);
var moto = factory.GetVehicle(2);
var nothing = factory.GetVehicle(1);

Console.WriteLine($"apecar ho {apecar.Wheels()} e sono {apecar.Description()}");
Console.WriteLine($"auto ho {auto.Wheels()} e sono {auto.Description()}");
Console.WriteLine($"moto ho {moto.Wheels()} e sono {moto.Description()}");

var descr = nothing != null ? $"moto ho {nothing.Wheels()} e sono {nothing.Description()}" : "non è previsto un veicolo con 1 ruota";

Console.WriteLine(descr);