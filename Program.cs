Console.WriteLine("=== Rolling Bistro: Crew Assignment System ===\n");

string[] foodTrailerCrew =
{
    "Head Chef",
    "Sous Chef",
    "Attendant",
    "Cashier",
    "Driver"
};

int kitchenStaff = 0;
int supportStaff = 0;

for (int i = 0; i < foodTrailerCrew.Length; i++)
{
    string role = foodTrailerCrew[i];

    Console.WriteLine($"Crew Member #{i + 1}: {role}");

    switch (role)
    {
        case "Head Chef":
            Console.WriteLine("Role Duty: Leads kitchen operations and manages food prep.");
            break;

        case "Sous Chef":
            Console.WriteLine("Role Duty: Assists the Head Chef and helps prepare meals.");
            break;

        case "Attendant":
            Console.WriteLine("Role Duty: Greets customers and takes food orders.");
            break;

        case "Cashier":
            Console.WriteLine("Role Duty: Handles payments and customer transactions.");
            break;

        case "Driver":
            Console.WriteLine("Role Duty: Transports the trailer and helps with setup.");
            break;

        default:
            Console.WriteLine("Role Duty: Unknown role.");
            break;
    }

    if (role.Contains("Chef"))
    {
        Console.WriteLine("Category: Kitchen Staff");
        kitchenStaff++;
    }
    else
    {
        Console.WriteLine("Category: Support Staff");
        supportStaff++;
    }

    Console.WriteLine();
}

Console.WriteLine("=== Staff Summary ===");
Console.WriteLine($"Kitchen Staff: {kitchenStaff}");
Console.WriteLine($"Support Staff: {supportStaff}");
Console.WriteLine($"Total Crew Members: {foodTrailerCrew.Length}");
Console.WriteLine("\n=== All staff successfully assigned ===");
