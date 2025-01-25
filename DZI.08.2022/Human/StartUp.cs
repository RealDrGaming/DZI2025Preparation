namespace DZI._08._2022.Human;

public class StartUp
{
    public static void Main() 
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("First Name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Last Name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Your choice[s - student] , [w - worker]:");
            string choice = Console.ReadLine();

            List<Human> people = new List<Human>();

            if (choice == "s")
            {
                Console.WriteLine("Grade: ");
                double grade = double.Parse(Console.ReadLine());

                Student student = new Student(firstName, lastName, age, grade);
            
                people.Add(student);
            }
            else if (choice == "w")
            {
                Console.WriteLine("Wage: ");
                double wage = double.Parse(Console.ReadLine());

                Console.WriteLine("Work Hours: ");
                int workHours = int.Parse(Console.ReadLine());

                Worker worker = new Worker(firstName, lastName, age, wage, workHours);

                people.Add(worker);
            }

            foreach (var person in people) 
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}