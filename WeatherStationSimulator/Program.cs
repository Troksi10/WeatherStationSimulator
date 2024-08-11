
Console.WriteLine("Enter the number of days to simulate: ");
int days = Convert.ToInt32(Console.ReadLine());

int[] temperature = new int[days];
string[] conditions = { "Sunny", "Rainy", "Cloudy", "Snowy" };
string[] weatherConditions = new string[days];

Random random = new Random();

for (int i = 0; i < days; i++)
{
    temperature[i] = random.Next(-10, 40);
    weatherConditions[i] = conditions[random.Next(conditions.Length)];
}

temperature.Max();
temperature.Min();

Console.WriteLine($"Average Temperature is : {CalculateAverage(temperature)}");
Console.WriteLine($"The max temp was: {temperature.Max()}");
Console.WriteLine($"The min temp was: {temperature.Min()}");
Console.WriteLine($"Most common condition was: {MostCommonCondition(weatherConditions)}");

Console.ReadLine();


static string MostCommonCondition(string[] condition)
{
    int count = 0;
    string mostCommon = condition[0];

    for (int i = 0; i < condition.Length; i++)
    {
        int tempCount = 0;
        for (int j = 0; j < condition.Length; j++)
        {
            if (condition[j] == condition[i])
            {
                tempCount++;
            }
        }

        if (tempCount > count)
        {
            count = tempCount;
            mostCommon = condition[i];
        }
    }

        return mostCommon;
    
    }
    
static double CalculateAverage(int[] temperature)
{
    double sum = 0;

    foreach(int i in temperature) 
    {
        sum += i;
    }

    double average = sum / temperature.Length;

    return average;
}
