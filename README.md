# Number Guessing Game CLI

A simple command-line number guessing game built with C# and .NET.

This project was created to practice fundamental C# concepts while building an interactive console application. The player selects a difficulty level and attempts to guess a randomly generated number within a limited number of attempts.

## Features

* Multiple difficulty levels
* Random number generation
* Limited attempts based on difficulty
* Input validation using `TryParse`
* Feedback for incorrect guesses ("Too high" or "Too low")
* Attempt counter
* Win and lose conditions
* Method-based program structure

## Difficulty Levels

| Difficulty | Range | Attempts |
|------------|--------|----------|
| Easy | 0–100 | 10 |
| Medium | 0–150 | 5 |
| Hard | 0–200 | 3 |

## Technologies

* C#
* .NET

## Getting Started

### Prerequisites

Make sure you have the .NET SDK installed.

Verify your installation:

```bash
dotnet --version
```

### Running the Application

Clone the repository and run:

```bash
dotnet run
```

## Usage

When the application starts, you will be asked to select a difficulty level:

```text
Select a difficulty:
1 - Easy   (0-100, 10 attempts)
2 - Medium (0-150, 5 attempts)
3 - Hard   (0-200, 3 attempts)
```

After selecting a difficulty, the game generates a random number within the chosen range.

```text
Guess a number between 0 and 100.
You have 10 attempts.
```

Enter your guesses until you either find the correct number or run out of attempts.

### Example

```text
Guess a number: 50

Too high.
You have 9 attempts remaining...

Guess a number: 25

Too low.
You have 8 attempts remaining...

Guess a number: 37

You win! The number was 37
You guessed the correct number in 3 attempts.
```

### Invalid Input Handling

The application validates user input and prompts the user again when an invalid value is entered.

```text
Guess a number: abc

Invalid value. Please enter a valid number:
```

### Losing the Game

If all attempts are used without guessing the correct number, the game reveals the answer.

```text
You reached the limit of attempts.
The number was 73
```

## Concepts Practiced

This project was built to practice:

* Variables and data types
* Methods
* Tuples
* User input validation with `TryParse`
* Random number generation
* Conditional statements (`if`, `else if`, `else`)
* Loops (`while`)
* Method decomposition and separation of responsibilities
* Console input and output

## Future Improvements

Possible future enhancements include:

* Play-again functionality
* Custom difficulty settings
* Score tracking
* High score system
* Hint system (e.g., "within 10 numbers")
* Multiple rounds
* Unit tests
* Refactoring classes into separate files

## License

This project is available for educational and learning purposes.
