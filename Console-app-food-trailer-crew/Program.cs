using System;

Console.WriteLine("=== Crew Member Class Demo ===");

CrewMember member1 = new CrewMember("Theo", "Head Chef", 42, 18.50m);
CrewMember member2 = new CrewMember("Lisa", "Cashier", 35, 13.75m);

member1.DisplayInfo();
member2.DisplayInfo();

string[] crewRoles = { "Head Chef", "Sous Chef", "Cashier", "Attendant", "Driver" };
int[] hoursWorked = { 42, 38, 29, 33, 45 };
decimal[] hourlyRates = { 18.50m, 16.25m, 13.75m, 13.50m, 15.00m };

Console.WriteLine("=== Food Trailer Crew Weekly Report ===");
Console.WriteLine();

for (int i = 0; i < crewRoles.Length; i++)
{
    decimal pay = CalculateWeeklyPay(hoursWorked[i], hourlyRates[i]);
    string status = GetShiftStatus(hoursWorked[i]);

    Console.WriteLine($"Role: {crewRoles[i]}");
    Console.WriteLine($"Hours Worked: {hoursWorked[i]}");
    Console.WriteLine($"Hourly Rate: ${hourlyRates[i]:F2}");
    Console.WriteLine($"Weekly Pay: ${pay:F2}");
    Console.WriteLine($"Shift Status: {status}");

    if (hoursWorked[i] > 40)
    {
        Console.WriteLine("Note: This employee earned overtime.");
    }
    else if (hoursWorked[i] >= 30)
    {
        Console.WriteLine("Note: This employee worked a regular full schedule.");
    }
    else
    {
        Console.WriteLine("Note: This employee worked a reduced schedule.");
    }

    Console.WriteLine("-----------------------------");
}

Console.WriteLine();
Console.WriteLine("=== Crew Responsibilities ===");

foreach (string role in crewRoles)
{
    switch (role)
    {
        case "Head Chef":
            Console.WriteLine($"{role}: Oversees kitchen operations and food quality.");
            break;
        case "Sous Chef":
            Console.WriteLine($"{role}: Assists with meal prep and cooking.");
            break;
        case "Cashier":
            Console.WriteLine($"{role}: Handles customer orders and payments.");
            break;
        case "Attendant":
            Console.WriteLine($"{role}: Supports customers and keeps the area clean.");
            break;
        case "Driver":
            Console.WriteLine($"{role}: Delivers supplies and helps with setup.");
            break;
        default:
            Console.WriteLine($"{role}: General support role.");
            break;
    }
}

decimal CalculateWeeklyPay(int hours, decimal rate)
{
    if (hours > 40)
    {
        int overtimeHours = hours - 40;
        decimal regularPay = 40 * rate;
        decimal overtimePay = overtimeHours * (rate * 1.5m);
        return regularPay + overtimePay;
    }

    return hours * rate;
}

string GetShiftStatus(int hours)
{
    if (hours > 40)
    {
        return "Overtime Shift";
    }
    else if (hours >= 30)
    {
        return "Standard Shift";
    }
    else
    {
        return "Part-Time Shift";
    }
}