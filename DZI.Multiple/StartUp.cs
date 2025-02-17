namespace DZI.Multiple
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
				int n = int.Parse(Console.ReadLine());

				ItemList list = new ItemList();

				for (int i = 0; i < n; i++)
				{
					string description = Console.ReadLine();
					double price = double.Parse(Console.ReadLine());

					Item item = new Item(description, price);
					list.Add(item);
				}

				for (int i = 0; i < n; i++)
				{
					Console.WriteLine(list.Get(i));
				}
			}
			catch (Exception)
			{
				throw;
			}
        }
    }
}
