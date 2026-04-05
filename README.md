# Console Calculator Application

## Project Description
This Console Calculator Application is meant to be an interactive, menu‑driven C# program, designed to help users perform a variety of mathematical operations and manage stored numeric values. It was created as a result of my C# course at ECPI.
Over several weeks, the project evolved from a simple two‑number calculator into a fully modular, exception‑handled, multi‑number console application with memory storage and a friendly, conversational user experience. I've tried to add some personality to the calculator, with some outputs sprinkled in that aren't seen in average calculators

## Project Tasks
- **Task 1: Set up the development environment**
  - Install .NET SDK  
  - Create project structure and separate class files  

- **Task 2: Design the application**
  - Plan menu flow and user interaction  
  - Define class responsibilities  
  - Document expected behavior  

- **Task 3: Implement mathematical operations**
  - Add, subtract, multiply, and divide lists of numbers  
  - Format results to two decimal places  
  - Handle divide‑by‑zero errors  

- **Task 4: Build the memory system**
  - Store up to 10 integer values  
  - View stored values  
  - Remove individual values  
  - Clear the entire memory  

- **Task 5: Implement user input handling**
  - Validate numeric input  
  - Loop until valid input is provided  
  - Support multi‑number input  

- **Task 6: Create user‑facing messages**
  - Build menus for math and memory  
  - Provide friendly, descriptive output  
  - Add error messages for invalid input  

- **Task 7: Add exception handling**
  - Catch format errors  
  - Catch divide‑by‑zero errors  
  - Prevent crashes and guide the user  

- **Task 8: Test the application**
  - Verify menu navigation  
  - Test memory limits  
  - Test invalid inputs  
  - Confirm correct math results  

- **Task 9: Document the project**
  - Write README  
  - Add comments throughout the code  
  - Capture screenshots of program output  

## Project Skills Learned
- C# programming fundamentals  
- Object‑oriented design (classes, methods, encapsulation)  
- Exception handling and input validation  
- Working with lists and collections  
- Modular program structure  
- Console application design  
- Debugging and iterative improvement  
- Writing clear documentation  

## Language Used
- **C#** used for all classes, logic, and console interaction  

## Development Process Used
- **Iterative Development**  
  - Each week expanded the project with new features  
  - Code was refactored as complexity increased  
  - Emphasis on modularity, clarity, and maintainability  

## Notes
- Supports **multi‑number operations** (e.g., `5 6 12 3 21`)  
- Results formatted to **two decimal places**  
- Memory stores **up to 10 integer values**  
- Invalid input triggers friendly error messages  
- Application runs until the user chooses to quit  

# Features
### Multi‑Number Math Operations  
- Users can enter multiple numbers separated by spaces  
- Supports addition, subtraction, multiplication, and division  
- Division includes divide‑by‑zero protection  

### Memory System (Up to 10 Values)  
- Store integer values  
- View all stored values  
- Remove a single value  
- Clear the entire memory  
- Prevents storing more than 10 values  

### Robust Input Handling  
- Validates numeric input  
- Rejects invalid entries with helpful messages  
- Ensures memory operations use whole numbers  

### Exception Handling  
- Catches format errors  
- Catches divide‑by‑zero errors  
- Prevents crashes
### Modular Class Design  
- Each class handles a specific responsibility  
- Clean separation of concerns  
- Easy to maintain and expand  

### Friendly, Conversational Output  
- Personalized messages throughout the program  
- Encouraging, humorous, and user‑friendly tone  

### Runs Until User Quits  
- Main loop continues until the exit option is selected  

# Class Overview

## CalculatorApp.cs
**Purpose:** Main entry point of the application.  
**Responsibilities:**  
- Display main menu  
- Route user choices  
- Handle math and memory operations  
- Manage program loop  
- Provide personality through printed messages

## Maths.cs
**Purpose:** Perform all mathematical operations.  
**Responsibilities:**  
- Add, subtract, multiply, and divide lists of numbers  
- Throw exceptions for invalid operations  
- Return results for display  

## Inputs.cs
**Purpose:** Handle all user input safely.  
**Responsibilities:**  
- Read menu choices  
- Read single numeric values  
- Read lists of numbers  
- Validate and convert input  

## Outputs.cs
**Purpose:** Provide friendly, formatted output.  
**Responsibilities:**  
- Display math results  
- Display memory contents  
- Display error messages  
- Format numbers to two decimal places  

## Messages.cs
**Purpose:** Display all menus and static text.  
**Responsibilities:**  
- Print header and welcome message  
- Print main menu  
- Print math menu  
- Print memory menu  
- Print closing message  

## Memories.cs
**Purpose:** Store and manage numeric values.  
**Responsibilities:**  
- Store up to 10 integer values  
- Remove individual values  
- Clear the entire memory  
- Return stored values  
- Prevent memory overflow  

## License
This project is created for educational purposes as part of the SDC220L course.
