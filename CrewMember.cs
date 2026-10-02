namespace FoodTrailerCrew;

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
            int overtimeHours = HoursWorked - 40;
            decimal regularPay = 40 * HourlyRate;
            decimal overtimePay = overtimeHours * HourlyRate * 1.5m;
            return regularPay + overtimePay;
        }

        return HoursWorked * HourlyRate;
    }

    public string GetShiftStatus()
    {
        if (HoursWorked > 40) return "Overtime Shift";
        if (HoursWorked >= 30) return "Standard Shift";
        return "Part-Time Shift";
    }
}