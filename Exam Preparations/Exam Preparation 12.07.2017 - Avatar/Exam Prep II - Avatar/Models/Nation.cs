using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Nation
{
    private List<Bender> benders;
    private List<Monument> monuments;
    private string nationType;

    public Nation(string type)
    {
        this.Benders = new List<Bender>();
        this.Monuments = new List<Monument>();
        this.NationType = type;
    }

    public string NationType
    {
        get => this.nationType;
        set => this.nationType = value;
    }

    public List<Bender> Benders
    {
        get => this.benders;
        set => this.benders = value;
    }

    public List<Monument> Monuments
    {
        get => this.monuments;
        set => this.monuments = value;
    }

    public double NationPower
    {
        get => this.CalcNationPower();
    }

    private double CalcNationPower()
    {
        var bendersPower = this.Benders.Sum(x => x.GetBenderTotalPower());
        var monumentPower = this.Monuments.Sum(x => x.GetAffinity());
        return ((bendersPower / 100) * monumentPower) + bendersPower;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{this.NationType} Nation");
        if (this.Benders.Count > 0)
        {
            sb.AppendLine("Benders:");
            foreach (var b in this.Benders)
            {
                sb.AppendLine($"###{b}");
            }
        }
        else sb.AppendLine("Benders: None");
        if (this.Monuments.Count > 0)
        {
            sb.AppendLine("Monuments:");
            foreach (var m in this.Monuments)
            {
                sb.AppendLine($"###{m}");
            }
        }
        else sb.AppendLine("Monuments: None");

        return sb.ToString().Trim();
    }
}
