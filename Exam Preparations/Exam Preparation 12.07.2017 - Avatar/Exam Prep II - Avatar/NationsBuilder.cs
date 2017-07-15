using System;
using System.Collections.Generic;
using System.Linq;

public class NationsBuilder
{
    private Nation airNation;
    private Nation earthNation;
    private Nation waterNation;
    private Nation fireNation;
    private List<string> warRecords;

    public NationsBuilder()
    {
        this.airNation = new Nation("Air");
        this.earthNation = new Nation("Earth");
        this.waterNation = new Nation("Water");
        this.fireNation = new Nation("Fire");
        this.warRecords = new List<string>();
    }

    
    public void AssignBender(List<string> benderArgs)
    {
        var benderType = benderArgs[1];
        var name = benderArgs[2];
        var power = int.Parse(benderArgs[3]);
        var secondaryParameter = double.Parse(benderArgs[4]);

        switch (benderType)
        {
            case "Fire":
               this.fireNation.Benders.Add(new FireBender(name, power, secondaryParameter));
                break;
            case "Air":
                this.airNation.Benders.Add(new AirBender(name, power, secondaryParameter));
                break;
            case "Water":
                this.waterNation.Benders.Add(new WaterBender(name, power, secondaryParameter));
                break;
            case "Earth":
                this.earthNation.Benders.Add(new EarthBender(name, power, secondaryParameter));
                break;
        }
    }
    public void AssignMonument(List<string> monumentArgs)
    {
        var monumentType = monumentArgs[1];
        var name = monumentArgs[2];
        var affinity = int.Parse(monumentArgs[3]);
        switch (monumentType)
        {
            case "Air":
                this.airNation.Monuments.Add(new AirMonument(name, affinity));
                break;
            case "Earth":
                this.earthNation.Monuments.Add(new EarthMonument(name, affinity));
                break;
            case "Water":
                this.waterNation.Monuments.Add(new WaterMonument(name, affinity));
                break;
            case "Fire":
                this.fireNation.Monuments.Add(new FireMonument(name, affinity));
                break;
        }
    }
    public string GetStatus(string nation)
    {
        switch (nation)
        {
            case "Air":
                return this.airNation.ToString();
            case "Water":
                return this.waterNation.ToString();
            case "Fire":
                return this.fireNation.ToString();
            case "Earth":
                return this.earthNation.ToString();
            default:
                throw new ArgumentException("Inavalid nation type!");
        }
    }
    public void IssueWar(string nationsType)
    {
        var list = new List<Nation>();
        list.Add(this.fireNation);
        list.Add(this.earthNation);
        list.Add(this.waterNation);
        list.Add(this.airNation);

        foreach (Nation nation in list.OrderByDescending(x=>x.NationPower).Skip(1))
        {
            nation.Benders.Clear();
            nation.Monuments.Clear();
        }

        this.warRecords.Add($"War {this.warRecords.Count + 1} issued by {nationsType}");
    }
    public string GetWarsRecord()
    {
        return $"{string.Join(Environment.NewLine, this.warRecords)}";
    }
}