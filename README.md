# Habit Tracker

A console-based habit tracking application built with C# and .NET 8, using SQLite via ADO.NET for data persistence.

## Features

- **Create** a new habit with a name, date, and quantity (how many times you did it)
- **View** all habits stored in the database
- **Delete** a habit by its ID
- **Update** a habit's name or date by its ID
- Input validation with clear error messages for invalid or empty inputs

## Project Structure

```
Kerem.HabitTracker/
├── Kerem.HabitTracker/          # Main application
│   ├── Program.cs               # Entry point — sets up DB and starts menu
│   ├── ConsoleMenu.cs           # Menu loop and user navigation
│   ├── HabitService.cs          # Business logic for CRUD operations
│   ├── SqlService.cs            # Raw SQL commands using ADO.NET
│   ├── DataAccess.cs            # Connection management and table setup
│   ├── ValidationHelper.cs      # Input validation utilities
│   ├── Habit.cs                 # Habit model
│   └── Database/habit.db        # SQLite database file
└── Kerem.HabitTracker.UnitTests/ # Unit test project
    └── ValidationHelperTests.cs  # NUnit tests for ValidationHelper
```

## Technologies

- **Language:** C# (.NET 8)
- **Database:** SQLite via `Microsoft.Data.Sqlite` (ADO.NET)
- **Testing:** NUnit

## How to Run

1. Clone the repository
2. Open `Kerem.HabitTracker.sln` in Visual Studio or Rider
3. Build and run the `Kerem.HabitTracker` project

On startup, the application drops and recreates the habit table, then presents the main menu.

## How to Run Tests

Run the `Kerem.HabitTracker.UnitTests` project using your IDE's test runner or via the CLI:

```bash
dotnet test
```

## What I Learned

Working on this project was a fun and interesting experience. One of the highlights was using **ADO.NET directly** to talk to the SQLite database — manually writing `SqliteConnection`, `SqliteCommand`, and reading results with `SqliteDataReader`. It's a great way to see and understand the magic that happens under the hood.

Coming from a Java background, **Spring Boot** abstracts away a huge amount of the database interaction — things like connection management, query execution, and result mapping are all handled for you by JPA/Hibernate. Working with raw ADO.NET made me appreciate both sides: ORMs are incredibly productive, but knowing what they're doing underneath makes you a much better developer.

Writing **unit tests** with NUnit was also a valuable exercise. Testing input validation logic — even something as simple as checking for empty strings or negative numbers — builds the habit (pun intended) of thinking about edge cases and verifying behaviour in isolation. It's always worth doing.
