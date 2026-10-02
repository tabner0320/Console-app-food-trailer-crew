using FoodTrailerCrew;

var crew = new List<CrewMember>
{
    new("Theo", "Head Chef", 42, 18.50m),
    new("Jordan", "Sous Chef", 38, 16.25m),
    new("Lisa", "Cashier", 35, 13.75m),
    new("Morgan", "Attendant", 29, 13.50m),
    new("Chris", "Driver", 45, 15.00m)
};

Console.WriteLine("=== Food Trailer Crew Weekly Report ===");
Console.WriteLine();

foreach (CrewMember member in crew)
{
    Console.WriteLine($"Name: {member.Name}");
    Console.WriteLine($"Role: {member.Role}");
    Console.WriteLine($"Hours Worked: {member.HoursWorked}");
    Console.WriteLine($"Hourly Rate: {member.HourlyRate:C}");
    Console.WriteLine($"Weekly Pay: {member.CalculatePay():C}");
    Console.WriteLine($"Shift Status: {member.GetShiftStatus()}");
    Console.WriteLine($"Responsibility: {CrewService.GetResponsibility(member.Role)}");
    Console.WriteLine("---------------------------------------");
}

Console.WriteLine();
Console.Write("Enter number of crew members on shift: ");

string? input = Console.ReadLine();

if (int.TryParse(input, out int crewCount) && crewCount >= 0)
{
    Console.WriteLine($"Total crew members on shift: {crewCount}");
}
else
{
    Console.WriteLine("Invalid input. Please enter a non-negative whole number.");
}
