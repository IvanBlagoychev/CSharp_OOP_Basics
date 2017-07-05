using System.Collections.Generic;


public class Car
{
    public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType, double tire1Pressure, int tire1Age, double tire2Pressure, int tire2Age, double tire3Pressure, int tire3Age, double tire4Pressure, int tire4Age)
    {
        this.Model = model;
        this.CarEngine = new Engine(engineSpeed, enginePower);
        this.CarCargo = new Cargo(cargoWeight, cargoType);
        this.CarTires = new List<Tire>(4);
        this.CarTires.Add(new Tire(tire1Pressure, tire1Age));
        this.CarTires.Add(new Tire(tire2Pressure, tire2Age));
        this.CarTires.Add(new Tire(tire3Pressure, tire3Age));
        this.CarTires.Add(new Tire(tire4Pressure, tire4Age));
    }

    public string Model { get; set; }
    public Engine CarEngine { get; set; }
    public Cargo CarCargo { get; set; }
    public List<Tire> CarTires { get; set; }
}