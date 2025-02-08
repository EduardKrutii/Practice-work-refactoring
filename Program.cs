using System;

// Дублювання коду: Один і той же алгоритм використовується в двох різних місцях.
class DuplicateCodeExample
{
    public void PrintPersonInfo(string role, string name, int age)
    {
        Console.WriteLine($"{role}: {name}, Age: {age}");
    }
}

// Довгий метод: Метод містить багато логіки, яка могла б бути розбита на менші методи.
class LongMethodExample
{
    public void ProcessData()
    {
        Console.WriteLine("Fetching data...");
        // Імітація отримання даних
        string data = "Some important data";

        Console.WriteLine("Processing data...");
        // Імітація обробки
        data = data.ToUpper();

        Console.WriteLine("Saving data...");
        // Імітація збереження
        Console.WriteLine("Data saved: " + data);
    }
}

// Заздрісні функції: Метод працює більше з іншими класами, ніж зі своїми власними даними.
class User
{
    public string Name { get; set; }
    public string Email { get; set; }
}

class FeatureEnvyExample
{
    public void DisplayUserDetails(User user)
    {
        Console.WriteLine("User Name: " + user.Name);
        Console.WriteLine("User Email: " + user.Email);
    }
}

class Program
{
    static void Main()
    {
        var duplicateExample = new DuplicateCodeExample();
        duplicateExample.PrintPersonInfo("User", "Alice", 30);
        duplicateExample.PrintPersonInfo("Employee", "Bob", 40);

        var longMethodExample = new LongMethodExample();
        longMethodExample.ProcessData();

        var user = new User { Name = "Charlie", Email = "charlie@example.com" };
        var featureEnvy = new FeatureEnvyExample();
        featureEnvy.DisplayUserDetails(user);
    }
}