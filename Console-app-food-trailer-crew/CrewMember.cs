public class CrewMember
{
    public string Name { get; set; }
    public string Role { get; set; }
    public int HoursWorked { get; set; }
    public decimal HourlyRate { get; set; }

    public CrewMember(string name, string role, int hoursWorked, decimal hourlyRate)
    {
        Name = name;
        Role = role;
        HoursWorked = hoursWorked;
        HourlyRate = hourlyRate;
    }

    public decimal CalculatePay()
    {
        if (HoursWorked > 40)
        {
            int overtime = HoursWorked - 40;
            decimal regularPay = 40 * HourlyRate;
            decimal overtimePay = overtime * (HourlyRate * 1.5m);
            return regularPay + overtimePay;
        }

        return HoursWorked * HourlyRate;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Role: {Role}");
        Console.WriteLine($"Hours: {HoursWorked}");
        Console.WriteLine($"Pay: ${CalculatePay():F2}");
        Console.WriteLine("------------------------");
    }
}