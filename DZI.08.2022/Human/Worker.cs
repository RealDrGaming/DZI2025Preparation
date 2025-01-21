namespace DZI._08._2022.Human;

public class Worker : Human
{
    public Worker(string firstName, string lastName, int age, double wage, int workHours) : base(firstName, lastName, age)
    {
        Wage = wage;
        WorkHours = workHours;
    }

    public double Wage { get; private set; }
    public int WorkHours { get; private set; }

    public double Salary() 
    {
        return Wage * WorkHours;
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName}, {Age} years old, salary: ${Salary():f2}";
    }
}