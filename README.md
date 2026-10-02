# Food Trailer Crew Console App

[![.NET CI](https://github.com/tabner0320/Console-app-food-trailer-crew/actions/workflows/dotnet.yml/badge.svg)](https://github.com/tabner0320/Console-app-food-trailer-crew/actions/workflows/dotnet.yml)

A C#/.NET 10 console application that simulates weekly crew management for a food trailer. The project demonstrates object-oriented programming, payroll and overtime calculations, input validation, separation of concerns, role-based responsibilities, automated testing, and Git/GitHub development workflows.

## Features

- Models crew members with a reusable `CrewMember` class
- Calculates regular and overtime pay
- Pays time-and-a-half for hours worked over 40
- Categorizes employees as part-time, standard, or overtime shifts
- Displays role-specific crew responsibilities
- Accepts and validates crew-count input
- Uses a separate service class for business logic
- Uses `List<CrewMember>` to manage crew data
- Includes automated xUnit tests
- Uses GitHub Actions for Continuous Integration

## Technologies Used

| Technology | Purpose |
| --- | --- |
| C# | Application programming language |
| .NET 10 | Application framework/runtime |
| xUnit | Automated unit testing |
| GitHub Actions | Continuous Integration (CI) |
| Git | Version control |
| GitHub | Repository hosting and pull request workflow |
| Visual Studio Code | Development environment |

## Project Structure

```text
Console-app-food-trailer-crew/
├── .github/
│   └── workflows/
│       └── dotnet.yml
├── Console-app-food-trailer-crew.Tests/
│   ├── Console-app-food-trailer-crew.Tests.csproj
│   └── CrewMemberTests.cs
├── CrewMember.cs
├── CrewService.cs
├── Program.cs
├── Console-app-food-trailer-crew.csproj
├── .gitignore
└── README.md
```

## Core Concepts Demonstrated

- Object-oriented programming (OOP)
- Classes and objects
- Properties and constructors
- Methods
- Collections with `List<T>`
- Iteration with `foreach`
- Conditional logic
- Switch expressions
- User input validation
- Payroll calculations
- Overtime calculations
- Separation of concerns
- Unit testing with xUnit
- Git feature branching
- GitHub pull requests
- Continuous Integration with GitHub Actions

## Application Design

The application separates its responsibilities into multiple components.

### `CrewMember`

The `CrewMember` class represents an individual employee and stores information such as:

- Name
- Role
- Hours worked
- Hourly rate

It also contains methods for calculating weekly pay and determining shift status.

### `CrewService`

The `CrewService` class contains business logic for determining responsibilities based on a crew member's role.

Separating this logic from `Program.cs` makes the application easier to maintain and test.

### `Program.cs`

`Program.cs` creates the crew collection, displays the weekly crew report, and handles user input.

## Payroll Logic

Crew members working 40 hours or fewer receive their standard hourly rate.

Hours worked above 40 are paid at **1.5 times the regular hourly rate**.

For example, a Head Chef working 42 hours at $18.50 per hour earns:

```text
Regular pay: 40 × $18.50 = $740.00
Overtime pay: 2 × $27.75 = $55.50
Total pay: $795.50
```

## Shift Classification

The application categorizes crew members based on the number of hours worked:

| Hours Worked | Shift Status |
| --- | --- |
| More than 40 | Overtime Shift |
| 30–40 | Standard Shift |
| Less than 30 | Part-Time Shift |

## Automated Testing

The project contains a separate xUnit test project:

```text
Console-app-food-trailer-crew.Tests
```

The automated tests verify:

- Regular weekly pay calculations
- Overtime pay calculations
- Overtime shift classification
- Standard shift classification
- Part-time shift classification
- Known crew-role responsibilities
- Default responsibilities for unknown roles

**Current test status: 7 passing tests.**

Run the tests with:

```bash
dotnet test Console-app-food-trailer-crew.Tests/Console-app-food-trailer-crew.Tests.csproj
```

## Continuous Integration

The project uses **GitHub Actions** for Continuous Integration (CI).

The workflow is located at:

```text
.github/workflows/dotnet.yml
```

The CI workflow automatically:

1. Checks out the repository
2. Sets up .NET 10
3. Restores project dependencies
4. Builds the project in Release configuration
5. Runs the automated xUnit tests

The workflow runs when changes are pushed to `main` and when pull requests target `main`.

The CI status badge at the top of this README provides a quick visual indication of the current workflow status.

## Run the Application

### 1. Clone the repository

```bash
git clone https://github.com/tabner0320/Console-app-food-trailer-crew.git
```

### 2. Navigate to the project

```bash
cd Console-app-food-trailer-crew
```

### 3. Run the application

```bash
dotnet run
```

## Example Output

```text
=== Food Trailer Crew Weekly Report ===

Name: Theo
Role: Head Chef
Hours Worked: 42
Hourly Rate: $18.50
Weekly Pay: $795.50
Shift Status: Overtime Shift
Responsibility: Oversees kitchen operations and food quality.
```

The application continues through the remaining crew members and then prompts the user to enter the number of crew members currently on shift.

## Development Workflow

This project was developed and upgraded using a feature-branch workflow:

```text
Feature Branch
      ↓
Development and Refactoring
      ↓
Local Build and Testing
      ↓
Git Commit
      ↓
Push to GitHub
      ↓
GitHub Pull Request
      ↓
GitHub Actions CI
      ↓
Review and Validation
      ↓
Merge into main
```

This workflow demonstrates practical use of Git and GitHub for managing application changes while keeping the `main` branch stable.

## Skills Demonstrated

`C#` · `.NET 10` · `Object-Oriented Programming` · `xUnit` · `Unit Testing` · `GitHub Actions` · `Continuous Integration` · `Git` · `GitHub` · `Visual Studio Code`

## Author

**Theophilus M. Abner Jr.**

Software Developer | IT Professional | U.S. Army Veteran

- GitHub: https://github.com/tabner0320
- Portfolio: https://tabner0320.github.io/theo-abner-resume/