while (true)
{
    Console.WriteLine("Enter the year (Enter n to stop)");
    string? s = Console.ReadLine();
    if (s == "n" || s == "N")
    {
        return;
    }
    else if (Int32.TryParse(s, out int year))
    {
        LeapYear(year);
    }
}

void LeapYear(int year)
{
    if (year % 400 == 0)
    {
        Console.WriteLine("It is a leap year");
    }
    else if (year % 100 == 0)
    {
        Console.WriteLine("It is not a leap year");
    }
    else if (year % 4 == 0)
    {
        Console.WriteLine("It is a leap year");
    }
    else
    {
        Console.WriteLine("It is not a leap year");
    }

}