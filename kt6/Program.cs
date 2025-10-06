using System;

enum DayOfWeek
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

enum Color
{
    Red,
    Green,
    Blue,
    Yellow,
    Cyan,
    Magenta
}

enum Operation
{
    Add,
    Subtract,
    Multiply,
    Divide
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Дни недели ===");
        PrintDayOfWeekInRussian(DayOfWeek.Monday);
        PrintDayOfWeekInRussian(DayOfWeek.Wednesday);
        PrintDayOfWeekInRussian(DayOfWeek.Sunday);

        Console.WriteLine("\n=== Цвета ===");
        Console.WriteLine($"Red: {GetHexCode(Color.Red)}");
        Console.WriteLine($"Green: {GetHexCode(Color.Green)}");
        Console.WriteLine($"Blue: {GetHexCode(Color.Blue)}");

        Console.WriteLine("\n=== Арифметические операции ===");
        Console.WriteLine($"10 + 5 = {Calculate(10, 5, Operation.Add)}");
        Console.WriteLine($"10 - 5 = {Calculate(10, 5, Operation.Subtract)}");
        Console.WriteLine($"10 * 5 = {Calculate(10, 5, Operation.Multiply)}");
        Console.WriteLine($"10 / 5 = {Calculate(10, 5, Operation.Divide)}");
    }

    static void PrintDayOfWeekInRussian(DayOfWeek day)
    {
        string russianDay = day switch
        {
            DayOfWeek.Monday => "Понедельник",
            DayOfWeek.Tuesday => "Вторник",
            DayOfWeek.Wednesday => "Среда",
            DayOfWeek.Thursday => "Четверг",
            DayOfWeek.Friday => "Пятница",
            DayOfWeek.Saturday => "Суббота",
            DayOfWeek.Sunday => "Воскресенье",
            _ => "Неизвестный день"
        };

        Console.WriteLine($"{day} -> {russianDay}");
    }

    static string GetHexCode(Color color)
    {
        return color switch
        {
            Color.Red => "#FF0000",
            Color.Green => "#00FF00",
            Color.Blue => "#0000FF",
            Color.Yellow => "#FFFF00",
            Color.Cyan => "#00FFFF",
            Color.Magenta => "#FF00FF",
            _ => "#000000"
        };
    }

    static double Calculate(double a, double b, Operation operation)
    {
        return operation switch
        {
            Operation.Add => a + b,
            Operation.Subtract => a - b,
            Operation.Multiply => a * b,
            Operation.Divide => b != 0 ? a / b : throw new DivideByZeroException("Деление на ноль!"),
            _ => throw new ArgumentException("Неизвестная операция")
        };
    }
}