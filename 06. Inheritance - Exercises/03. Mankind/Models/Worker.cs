using System;
using System.Text;

public class Worker : Human
{
    private decimal weekSalary;
    private decimal workHoursPerDay;

    public Worker(string firstName, string lastName, decimal weekSalary, decimal workHours) : base(firstName, lastName)
    {
        this.WeekSalaray = weekSalary;
        this.WorkHoursPerDay = workHours;
    }

    public override string LastName
    {
        get => base.LastName;
        protected set
        {
            if(value.Length <= 3) throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName");
            base.LastName = value;
        }
    }

    public decimal WeekSalaray
    {
        get => this.weekSalary;
        private set
        {
            if (value <= 10.00m) throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
            this.weekSalary = value;
        }
    }

    public decimal WorkHoursPerDay
    {
        get => this.workHoursPerDay;
        private set
        {
            if (value < 1 || value > 12) throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
            this.workHoursPerDay = value;
        }
    }

    private decimal CountSalaryPerHour()
    {
        return this.WeekSalaray / (this.workHoursPerDay * 5);
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"First Name: {this.FirstName}")
            .AppendLine($"Last Name: {this.LastName}")
            .AppendLine($"Week Salary: {this.WeekSalaray:f2}")
            .AppendLine($"Hours per day: {this.workHoursPerDay:f2}")
            .Append($"Salary per hour: {this.CountSalaryPerHour():f2}");

        return sb.ToString();
    }
}
