namespace DZI.Factory
{
    public class StartUp
    {
        static async Task Main(string[] args)
        {
            StreamReader sr = new StreamReader("input.txt");

            int n = int.Parse(await sr.ReadLineAsync());
            List<Wood> matList = new List<Wood>();

            for (int i = 0; i < n; i++) 
            {
                string[] line = (await sr.ReadLineAsync()).Split(" ");

                string code = line[0];
                string name = line[1];
                double amountInCubic = double.Parse(line[2]);
                int daysViable = int.Parse(line[3]);
                char type = line[4][0];
                string comeInDate = line[5];
                string siloPosition = line[6];
                int? neededHumidity = int.Parse(line[7]);

                Wood wood = new Wood(code, name, amountInCubic, daysViable, type, comeInDate, siloPosition, neededHumidity);

                matList.Add(wood);
            }

            sr.Close();

            matList.OrderBy(x => x.SiloPosition);

            foreach (Wood wood in matList)
            {
                Console.WriteLine(wood.ToString());
            }

            matList.OrderBy(x => x.ComeInDate).ThenByDescending(x => x.DaysViable);

            foreach (Wood wood in matList)
            {
                if (wood.Type == 'E')
                {
                    Console.WriteLine(wood.ToString());
                }
            }


        }
    }
}
