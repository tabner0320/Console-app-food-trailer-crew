using FoodTrailerCrew;

namespace FoodTrailerCrew.Tests;

public class CrewMemberTests
{
    [Fact]
    public void CalculatePay_RegularHours_ReturnsRegularPay()
    {
        var member = new CrewMember("Lisa", "Cashier", 35, 13.75m);
        Assert.Equal(481.25m, member.CalculatePay());
    }

    [Fact]
    public void CalculatePay_OvertimeHours_ReturnsTimeAndAHalf()
    {
        var member = new CrewMember("Theo", "Head Chef", 42, 18.50m);
        Assert.Equal(795.50m, member.CalculatePay());
    }

    [Theory]
    [InlineData(45, "Overtime Shift")]
    [InlineData(35, "Standard Shift")]
    [InlineData(20, "Part-Time Shift")]
    public void GetShiftStatus_ReturnsExpectedStatus(int hours, string expected)
    {
        var member = new CrewMember("Test", "Crew", hours, 15m);
        Assert.Equal(expected, member.GetShiftStatus());
    }
}

public class CrewServiceTests
{
    [Fact]
    public void GetResponsibility_KnownRole_ReturnsRoleResponsibility()
    {
        Assert.Equal("Handles customer orders and payments.", CrewService.GetResponsibility("Cashier"));
    }

    [Fact]
    public void GetResponsibility_UnknownRole_ReturnsGeneralSupport()
    {
        Assert.Equal("General support role.", CrewService.GetResponsibility("Other"));
    }
}