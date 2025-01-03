![banner C#](images/csharp-banner.png)

# C# .NET Unit Testing Basics

This repository is designed to help developers build a strong foundation in unit testing with C#, focusing on tools like xUnit, StyleCop, and SonarQube. It includes theoretical concepts, practical examples, and best practices to improve code quality and reliability.

## How to Run Tests for Each Session

1. Navigate to the session folder:
    ```bash
        cd Session1
    ```
Build the projects:
   ```bash
   dotnet build
   ```

Run the tests:
   ```bash
   dotnet test --collect:"XPlat Code Coverage"
   ```

After running the tests, you can find the coverage report in:
   ```plaintext
   Tests/TestResults/<unique-id>/coverage.cobertura.xml
   ```
To visualize the coverage, consider using tools like **Coverage Gutters** in VS Code or uploading the XML to [Codecov.io](https://codecov.io).

## Menu

### 1. [Session 1: Fundamentals and Initial Setup](./Session1/fundamentals.md)
- Introduction to unit testing
- Setting up xUnit and Coverlet
- Writing your first unit test
- Generating and visualizing code coverage

### 2. [Session 2: Applied Unit Testing and Mocks](./Session2/applied_testing.md)
- Understanding and implementing mocks and stubs
- Writing tests for simulated services
- Analyzing code quality with StyleCop and SonarQube

### 3. [Session 3: Testing Strategies and Best Practices](./Session3/testing_strategies.md)
- Optimizing test coverage
- Structuring tests for maintainability
- Automating quality analysis workflows

---

# Detailed Content

## [Session 1: Fundamentals and Initial Setup](./Session1/fundamentals.md)
This session introduces the basics of unit testing and guides you through the initial setup of a C# project with xUnit and Coverlet. It also includes an introduction to generating and interpreting code coverage reports.

### Key Topics:
1. What is Unit Testing?
2. Understanding the AAA Pattern
3. Writing and running your first test
4. Generating and interpreting code coverage

---

## [Session 2: Applied Unit Testing and Mocks](./Session2/applied_testing.md)
This session focuses on applying unit testing concepts with mocks and stubs to simulate dependencies. You'll also explore advanced code quality analysis techniques.

### Key Topics:
1. Mocks vs. Stubs
2. Using Moq in C#
3. Testing services with external dependencies
4. Advanced SonarQube metrics

---

## [Session 3: Testing Strategies and Best Practices](./Session3/testing_strategies.md)
In this session, you'll learn how to optimize your tests for better coverage and maintainability while integrating automated quality analysis workflows.

### Key Topics:
1. Improving test coverage
2. Structuring maintainable tests
3. Avoiding false positives/negatives
4. Automating analysis with GitHub Actions

---

## How to Use This Repository
1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/CSharp-UnitTesting-Basics.git
   cd CSharp-UnitTesting-Basics
   ```
2. Navigate to the session folders to explore theoretical content and practical exercises.
3. Follow the README files in each session for step-by-step guidance.

---

## License
This project is licensed under the [MIT License](./LICENSE).

