using System.Collections.Generic;

public abstract class Race
{
    private int length;
    private string route;
    private int prizePool;
    private List<Car> participatingCars;
    private bool isClosed;

    protected Race(int length, string route, int prizePool)
    {
        this.Length = length;
        this.Route = route;
        this.PrizePool = prizePool;
        this.ParticipatingCars = new List<Car>();
        this.IsClosed = false;
    }
    public bool IsClosed
    {
        get => this.isClosed;
        set => this.isClosed = value;
    }

    public List<Car> ParticipatingCars
    {
        get => this.participatingCars;
        set => this.participatingCars = value;
    }

    public int PrizePool
    {
        get { return prizePool; }
        set { prizePool = value; }
    }

    public string Route
    {
        get { return this.route; }
        set { this.route = value; }
    }

    public int Length
    {
        get { return this.length; }
        set { this.length = value; }
    }
}

// The basic race has the following properties: length (int), route (string), a prizePool (int), and participants (Collection of Cars)