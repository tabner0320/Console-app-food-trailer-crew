# Food Trailer Crew Console App

A C#/.NET console application that simulates weekly crew management for a food trailer. The project demonstrates object-oriented programming, payroll calculations, input validation, role-based responsibilities, and automated testing.

## Features

- Models crew members with a reusable `CrewMember` class
- Calculates regular and overtime pay
- Pays time-and-a-half for hours worked over 40
- Categorizes employees as part-time, standard, or overtime shifts
- Displays role-specific crew responsibilities
- Accepts and validates crew-count input
- Separates business logic from console output
- Includes automated xUnit tests

## Technologies Used

- C#
- .NET 10
- xUnit
- Git
- GitHub
- Visual Studio Code

## Project Structure

```text
Console-app-food-trailer-crew/
├── Program.cs
├── CrewMember.cs
├── CrewService.cs
├── Console-app-food-trailer-crew.csproj
├── Console-app-food-trailer-crew.Tests/
│   ├── CrewMemberTests.cs
│   └── Console-app-food-trailer-crew.Tests.csproj
├── README.md
└── .gitignore
```

## Core Concepts Demonstrated

- Object-oriented programming
- Classes and objects
- Properties and constructors
- Methods
- Lists and iteration
- Conditional logic
- Switch expressions
- User input validation
- Payroll and overtime calculations
- Separation of concerns
- Unit testing with xUnit
- Git version control

## Payroll Logic

Crew members working 40 hours or fewer receive their standard hourly rate.

Hours above 40 are paid at 1.5 times the employee's hourly rate.

For example, a Head Chef working 42 hours at $18.50 per hour earns:

```text
Regular pay: 40 × $18.50 = $740.00
Overtime pay: 2 × $27.75 = $55.50
Total pay: $795.50
```

## Run the Application

Clone the repository:

```bash
git clone https://github.com/tabner0320/Console-app-food-trailer-crew.git
```

Navigate to the project:

```bash
cd Console-app-food-trailer-crew
```

Run the application:

```bash
dotnet run
```

## Run the Tests

```bash
dotnet test
```

The automated tests cover regular pay, overtime pay, shift-status classification, and crew responsibilities.

## Author

**Theophilus M. Abner Jr.**

Software Developer | IT Professional | U.S. Army Veteran

- GitHub: https://github.com/tabner0320
- Portfolio: https://tabner0320.github.io/theo-abner-resume/
