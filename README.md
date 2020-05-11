# _Leetspeak_

#### _Epicodus Project May 11, 2020_

#### By _**Jessica Hvozdovich and Nathan Watkins-Hoagland**_

## Description

_A project to introduce the C# language and the .NET Core framework. The console application will take user input and convert it into leetspeak. The lesson is meant to practice creating automated testing methods using MSTest and behavior driven development._

## Setup/Installation Requirements

1. Clone this repository from GitHub.
2. Open the downloaded directory in a text editor of your choice.
  (VSCode, Atom, etc.)
3. To install the REPL dotnet script, run dotnet tool install -g dotnet-script in your terminal.
4. Run the program with the command dotnet build.

## Known Bugs

There are no known bugs at the time of this update.
 
## Support and contact details

_Have a bug or an issue with this application? [Open a new issue](https://github.com/WiseFool92/TriangleTestCSharp) here on GitHub._

## Technologies Used

* C#
* .NET Core
* Git and GitHub

### Specs
| Spec | Input | Output |
| :------------- | :------------- | :------------- |
| **Special characters are not transformed** | User Input:”!!!” | Output: "!!!" |
| **"e" is replaced with "3"** | User Input:”e” | Output: "3" |
| **"o" is replaced with "0"** | User Input:”o” | Output: "0" |
| **capital "I" is repalced with "1"** | User Input:”I” | Output: "1" |
| **lowercase "i" is not transformed** | User Input:”i” | Output: "i" |
| **"t" is replaced with "7"** | User Input:”t” | Output: "7" |
| **"s" is replaced with "z"** | User Input:”s” | Output: "z" |
| **"s" is not replaced with "z" if it is the first letter of a word** | User Input:”see” | Output: "s33" |

### License

This software is licensed under the MIT license.

Copyright (c) 2020 **_Jessica Hvozdovich and Nathan Watkins-Hoagland_**