# Session 1: Fundamentals and Initial Setup

This document covers the content for the first session, focusing on the fundamentals of unit testing, setting up a development environment, and writing your first test with xUnit.

## Objectives
- Understand what unit testing is and its benefits.
- Learn key concepts like the AAA pattern and code coverage.
- Set up a C# project with xUnit and Coverlet.
- Write and execute your first unit test.
- Generate a code coverage report and understand how to interpret it.

---

## 1. Introduction to Unit Testing

### **What is Unit Testing?**
Unit testing involves testing individual units or components of a program to ensure they work as intended.

#### **Key Benefits**
- **Early Error Detection:** Catch bugs in the development phase.
- **Code Maintenance:** Easier to refactor with confidence.
- **Improved Code Quality:** Encourages better design and practices.

#### **Comparison with Other Types of Testing**
- **Unit Testing:** Tests individual methods/functions.
- **Integration Testing:** Verifies interactions between components.
- **End-to-End Testing:** Validates the entire system's functionality.

### **Key Concepts**
1. **Mocks and Stubs:**
   - **Mocks:** Simulate behavior of external dependencies.
   - **Stubs:** Provide hardcoded data for testing.

2. **AAA Pattern (Arrange, Act, Assert):**
   - **Arrange:** Set up the test data.
   - **Act:** Execute the code being tested.
   - **Assert:** Verify the results.

3. **Code Coverage:**
   - Measures how much of your code is covered by tests.

4. **Test-Driven Development (TDD) Cycle:**
   - **Red:** Write a failing test.
   - **Green:** Write minimal code to pass the test.
   - **Refactor:** Improve code while keeping tests green.

---

## 2. Setting Up the Environment

### **Prerequisites**
Before you start, ensure the following are installed:
- .NET SDK 7.0: [Download and install .NET 7](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)
- A code editor like Visual Studio Code or Rider.

### **Creating the Project**

1. Navigate to the `practice` directory:
   ```bash
   cd Session1/practice
   ```

2. Create a new solution:
   ```bash
   dotnet new sln -n UnitTestingBasics
   ```

3. Create a class library for the main application:
   ```bash
   dotnet new classlib -n UnitTestingBasics
   ```

4. Create a test project using xUnit:
   ```bash
   dotnet new xunit -n Tests
   ```

5. Add both projects to the solution:
   ```bash
   dotnet sln UnitTestingBasics.sln add UnitTestingBasics/UnitTestingBasics.csproj
   dotnet sln UnitTestingBasics.sln add Tests/Tests.csproj
   ```

6. Link the test project to the main application:
   ```bash
   dotnet add Tests/Tests.csproj reference UnitTestingBasics/UnitTestingBasics.csproj
   ```

### **Writing Code and Tests**

1. In `UnitTestingBasics/Class1.cs`, add the following:
   ```csharp
   namespace UnitTestingBasics
   {
       public class Calculator
       {
           public int Add(int a, int b)
           {
               return a + b;
           }
       }
   }
   ```

2. In `Tests/UnitTest1.cs`, write the test:
   ```csharp
   using Xunit;
   using UnitTestingBasics;

   namespace Tests
   {
       public class UnitTests
       {
           [Fact]
           public void Add_ReturnsCorrectSum()
           {
               // Arrange
               var calculator = new Calculator();

               // Act
               var result = calculator.Add(2, 3);

               // Assert
               Assert.Equal(5, result);
           }
       }
   }
   ```

---

## 3. Running the Tests

1. Navigate to the `practice` directory:
   ```bash
   cd Session1/practice
   ```

2. Run the tests with coverage:
   ```bash
   dotnet test --collect:"XPlat Code Coverage"
   ```

3. After running the tests, locate the coverage report:
   ```plaintext
   /Session1/practice/Tests/TestResults/<unique-id>/coverage.cobertura.xml
   ```

---

## 4. Generating a Visual Coverage Report

### **Option 1: Using VS Code Extensions**
- Install the **Coverage Gutters** extension in VS Code.
- Add `coverage.cobertura.xml` as a coverage file in the extension settings.
- Open the project in VS Code and enable the extension to visualize coverage directly in the editor.

### **Option 2: Using Online Tools**
- Upload the `coverage.cobertura.xml` file to [Codecov.io](https://codecov.io) or another online tool to view coverage metrics.

---

## 5. Best Practices and Tips
- Use meaningful test names to describe what is being tested.
- Cover edge cases to ensure robustness.
- Maintain a balance between high coverage and meaningful tests.
- Use coverage tools to identify untested code but don’t rely solely on them.

---

## 6. Understanding the Relationship Between Tests and the Program

In this session, you wrote two pieces of code:

1. **`Program.cs`:**
   - This file is the entry point for your application. It allows you to execute the logic in the `Calculator` class interactively. For example, it outputs the result of adding two numbers.
   - It is used primarily for manual testing, demonstrations, or to execute the application as a standalone program.

2. **Unit Tests (in `Tests`):**
   - These are automated tests written to ensure that the logic in the `Calculator` class works as expected. They test specific scenarios like verifying that `Add(2, 3)` returns `5`.
   - Unlike `Program.cs`, they do not require manual execution or interaction.

### **Why Do We Need Both?**
- **`Program.cs`:**
  - Helps you validate the logic manually and demonstrate how the application behaves.
  - Useful for debugging or running a simple demo.

- **Unit Tests:**
  - Ensure the code works correctly in all defined scenarios.
  - Provide confidence that future changes will not break existing functionality.
  - Serve as documentation for how your code is expected to behave.

In summary, the program (`Program.cs`) demonstrates the logic in action, while the tests validate its correctness in an automated and repeatable way.

