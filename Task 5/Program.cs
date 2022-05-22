using System;

internal class Program
{
    static void Main(string[] args)
    {
        string firstName = "Чебышев";
        string lastName = "Александр";
        string buffer;

        Console.WriteLine("До замены");
        Console.WriteLine("Имя : " + firstName);
        Console.WriteLine("Фамилия : " + lastName);
        buffer = firstName;
        firstName = lastName;
        lastName = buffer;
        Console.WriteLine("После замены");
        Console.WriteLine("Имя : " + firstName);
        Console.WriteLine("Фамилия : " + lastName);
    }
}
