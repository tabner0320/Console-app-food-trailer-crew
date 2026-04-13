string[] foodtrailerCrew = { "Head Chef", "Sous Chef", "Attendant", "Cashier", "Driver" };

Console.WriteLine("--- Rolling Bistro: Staff Shift ---");

foreach (string role in foodtrailerCrew)
{
    Console.WriteLine($"Now On Duty: {role}");
}

Console.WriteLine("--- All staff clocked in. ---");