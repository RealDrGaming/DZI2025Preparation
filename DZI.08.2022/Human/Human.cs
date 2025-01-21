namespace DZI._08._2022.Human;

public class Human
{
    public Human(string firstName, string lastName, int age) 
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public int Age { get; private set; }

    public override string ToString()
    {
        return $"{FirstName} {LastName}, {Age} years old";
    }
}