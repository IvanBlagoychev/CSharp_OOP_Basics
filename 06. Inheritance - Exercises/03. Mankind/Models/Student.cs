using System;
using System.Text;
using System.Text.RegularExpressions;

public class Student : Human
{
    private string facultyNumber;

    public Student(string firstName, string lastName, string facNum) : base(firstName, lastName)
    {
        this.FacultyNumber = facNum;
    }

    public string FacultyNumber
    {
        get => this.facultyNumber;
        set
        {
            if (!IsFacNumValid(value)) throw new ArgumentException("Invalid faculty number!");
            this.facultyNumber = value;
        }
    }

    private bool IsFacNumValid(string value)
    {
        var pattern = @"^([0-9a-zA-Z]{5,10})$";
        var regex = new Regex(pattern);
        return regex.IsMatch(value);
    }



    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"First Name: {this.FirstName}").AppendLine($"Last Name: {this.LastName}").AppendLine($"Faculty number: {this.FacultyNumber}");

        return sb.ToString();
    }
}
