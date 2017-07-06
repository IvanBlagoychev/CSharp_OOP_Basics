using System;

public class Mankind
{
    static void Main()
    {
        try
        {
            var studentTokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var studentFirstName = studentTokens[0];
            var studentLastName = studentTokens[1];
            var facNum = studentTokens[2];
            var workerTokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var workerFirstName = workerTokens[0];
            var workerLastName = workerTokens[1];
            var weekSalary = decimal.Parse(workerTokens[2]);
            var workHoursPerDay = decimal.Parse(workerTokens[3]);
            Student student = new Student(studentFirstName, studentLastName, facNum);
            Worker worker = new Worker(workerFirstName, workerLastName, weekSalary, workHoursPerDay);

            Console.WriteLine(student);
            Console.WriteLine(worker);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}