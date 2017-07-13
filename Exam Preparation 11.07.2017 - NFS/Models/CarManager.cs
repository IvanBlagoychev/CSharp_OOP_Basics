using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CarManager
{
    private Dictionary<int, Car> cars;
    private Dictionary<int, Race> races;
    private Garage garage;

    public CarManager()
    {
        this.Cars = new Dictionary<int, Car>();
        this.Races = new Dictionary<int, Race>();
        this.Garage = new Garage();
    }

    public Dictionary<int, Race> Races
    {
        get => this.races;
        set => this.races = value;
    }

    public Dictionary<int, Car> Cars
    {
        get => this.cars;
        set => this.cars = value;
    }

    public Garage Garage
    {
        get => this.garage;
        set => this.garage = value;
    }


    public void Register(int id, string type, string brand, string model, int yearOfProduction, int horsepower,
        int acceleration, int suspension, int durability)
    {
        Car newCar = null;
        if (type == "Performance") newCar = new PerformanceCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
        else if (type == "Show") newCar = new ShowCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
        this.Cars.Add(id, newCar);
    }

    public string Check(int id)
    {
        var desiredCar = this.Cars.FirstOrDefault(x => x.Key == id).Value;
        return desiredCar.ToString();
    }

    public void Open(int id, string type, int length, string route, int prizePool)
    {
        Race newRace = null;
        if (type.Equals("Drag")) newRace = new DragRace(length, route, prizePool);
        else if (type.Equals("Drift")) newRace = new DriftRace(length, route, prizePool);
        else if (type.Equals("Casual")) newRace = new CasualRace(length, route, prizePool);
        this.races.Add(id, newRace);
    }

    public void Participate(int carId, int raceId)
    {
        var desiredCar = this.Cars.FirstOrDefault(x => x.Key == carId).Value;
        var desiredRace = this.races.FirstOrDefault(x => x.Key == raceId).Value;
        if (!this.garage.ParkedCars.Contains(desiredCar))
        {
            desiredRace.ParticipatingCars.Add(desiredCar);
        }
    }

    public string Start(int id)
    {
        var race = races[id];
        if (race.ParticipatingCars.Count == 0)
        {
            return $"Cannot start the race with zero participants.";
        }

        if (!race.IsClosed)
        {
            var raceResults = new List<Car>();
            var results = new List<Car>();

            race.ParticipatingCars.ForEach(x => x.PerformancePoints = 0);
            race.ParticipatingCars.ForEach(x => x.MoneyWon = 0);
            if (race.GetType().Name == "CasualRace")
            {
                foreach (Car c in race.ParticipatingCars)
                {
                    c.PerformancePoints += (c.Horsepower / c.Acceleration) + (c.Suspension + c.Durability);
                    raceResults.Add(c);
                }
                results = raceResults.OrderByDescending(x => x.PerformancePoints).ToList();
            }
            else if (race.GetType().Name == "DragRace")
            {
                foreach (Car c in race.ParticipatingCars)
                {
                    c.PerformancePoints += c.Horsepower / c.Acceleration;
                    raceResults.Add(c);
                }
                results = raceResults.OrderByDescending(x => x.PerformancePoints).ToList();
            }
            else if (race.GetType().Name == "DriftRace")
            {
                foreach (Car c in race.ParticipatingCars)
                {
                    c.PerformancePoints += c.Suspension + c.Durability;
                    raceResults.Add(c);
                }
                results = raceResults.OrderByDescending(x => x.PerformancePoints).ToList();
            }
            var sb = new StringBuilder();
            var n = results.Count >= 3 ? 3 : results.Count;
            sb.AppendLine($"{race.Route} - {race.Length}");
            for (int i = 0; i < n; i++)
            {
                if (i == 0) results[i].MoneyWon += (race.PrizePool * 50) / 100;
                else if (i == 1) results[i].MoneyWon += (race.PrizePool * 30) / 100;
                else if (i == 2) results[i].MoneyWon += (race.PrizePool * 20) / 100;
                sb.AppendLine(
                    $"{i + 1}. {results[i].Brand} {results[i].Model} {results[i].PerformancePoints}PP - ${results[i].MoneyWon}");
            }
            race.IsClosed = true;
            race.ParticipatingCars.Clear();
            return sb.ToString().Trim();

        }
        return "";
    }

    public void Park(int id)
    {
        var desiredCar = this.Cars[id];
        bool isPertisipating = false;
        foreach (Race r in races.Values)
        {
            if (r.ParticipatingCars.Contains(desiredCar)) isPertisipating = true;
        }
        if (!isPertisipating && !this.garage.ParkedCars.Contains(desiredCar)) this.garage.ParkedCars.Add(desiredCar);
    }

    public void Unpark(int id)
    {
        var desiredCar = this.Cars.FirstOrDefault(x => x.Key == id).Value;
        if (this.garage.ParkedCars.Contains(desiredCar)) this.garage.ParkedCars.Remove(desiredCar);
    }

    public void Tune(int tuneIndex, string addOn)
    {
        if (this.garage.ParkedCars.Count > 0)
        {
            foreach (Car c in this.garage.ParkedCars)
            {
                c.Tune(tuneIndex, addOn);
            }
        }
    }
}