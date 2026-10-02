namespace FoodTrailerCrew;

public static class CrewService
{
    public static string GetResponsibility(string role)
    {
        return role switch
        {
            "Head Chef" => "Oversees kitchen operations and food quality.",
            "Sous Chef" => "Assists with meal prep and cooking.",
            "Cashier" => "Handles customer orders and payments.",
            "Attendant" => "Supports customers and keeps the area clean.",
            "Driver" => "Delivers supplies and helps with setup.",
            _ => "General support role."
        };
    }
}