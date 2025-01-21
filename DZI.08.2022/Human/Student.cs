namespace DZI._08._2022.Human;
public class Student : Human
{
    public Student(string firstName, string lastName, int age, double grade) : base(firstName, lastName, age)
    {
        Grade = grade;
    }

    public double Grade { get; private set; }

    public override string ToString()
    {
        return $"{FirstName} {LastName}, {Age} years old, grade: {Grade:f2}";
    }
}