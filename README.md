# Scrabble Scorer (C# Console Application)

#### A console-based application to determine Scrabble points where the user can input a word and see the score, hosted on [GitHub](https://github.com/KristaRutz/Scrabble-scorer-ConsoleApp). _Last Updated 03.05.2020._

#### By _**Krista Rutz, Steven Fleming**_

## Description

This application lets the user input a word and returns the scrabble point value of the word. The program then begins again, allowing the user to continuously enter new words. It does so using regular expressions, exception handling, and MSTest.
It can be found on [GitHub](https://github.com/KristaRutz/Scrabble-scorer-ConsoleApp).

_Sample program output:_

```
Enter your word to calculate it's Scrabble score.
=>
ERROR: Your word length cannot be zero.
Enter your word to calculate it's Scrabble score.
000
ERROR: Scrabble does not have scores for non-letter characters.
Enter your word to calculate it's Scrabble score.
joy
'joy' is worth 13 points.
Enter your word to calculate it's Scrabble score.
opopo
'opopo' is worth 9 points.
Enter your word to calculate it's Scrabble score.
banana
'banana' is worth 8 points.
Enter your word to calculate it's Scrabble score.
krista
'krista' is worth 10 points.
```

## Installation / Set-up

Download or clone the repository to run this program locally! _This program requires .NET Core SDK to run. [Here is a free tutorial](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-c-and-net) for installing .NET on Mac or Windows 10._

- Download or clone this repo.
  - **To Download ZIP:**
    - Select "Download" on the [GitHub Repository](https://github.com/KristaRutz/Scrabble-scorer-ConsoleApp) site
    - Once downloaded, open the ZIP and extract files. The new folder will be created as 'Scrabble-Scorer-...'.
  - **To Clone:**
    - Clone from command line into your Desktop: `$ git clone https://github.com/KristaRutz/Scrabble-scorer-ConsoleApp.git`
    - The new directory will be created as 'Desktop/Scrabble-scorer-ConsoleApp'.
- Once you have stored the files locally, execute the following commands.
  - Navigate to the application directory: `$ cd Scrabble-scorer-ConsoleApp/ScrabbleScore`
  - `dotnet build`
  - `dotnet run`
- Upon success, the program will begin running in your console.

## Technologies Used

- C#
- .NET Core 2.2

## Specs

<details>
  <summary>Expand specs for this project</summary>

| Spec                                                                          | Example Input                                    | Expected Output |
| :---------------------------------------------------------------------------- | :----------------------------------------------- | :-------------- |
| user types in a word, program returns number                                  |                                                  |                 |
| program returns 1 for certain letters                                         | "a"                                              | 1               |
| program correctly counts letters in a word                                    | "rat"                                            | 3               |
| program correctly gives a "bonus" score for certain letters                   | "q"                                              | 10              |
| program correctly adds up all letters with differing values and returns total | "dog"                                            | 5               |
|                                                                               | exception handling: user enters zero letter word | ""              | "nope" |
| exception handling: user enters non-letter characters                         | "b! a!"                                          | "nope"          |

</details>
<details>
  <summary>Expand user stories for this project</summary>

| As a _User-Type_,    | I want...                                    | so that...                                           |
| :------------------- | :------------------------------------------- | :--------------------------------------------------- |
| As a Scrabble Player | I want an app that can add up my tile scores | so that I can calculate potential scores more easily |

</details>

## Known Bugs

- No known bugs

## Support and contact details

Please contact me if you run into any issues or have questions, ideas or concerns. Krista can be contacted at <krista.rutz@pomona.edu>. Feel free to fork and create a pull request for updates - _contributions to the code are encouraged!_

### License

Copyright (c) 2020 **_Krista Rutz, Steven Fleiming_**

_This software is licensed under the MIT license._

<details>
  <summary>View license details</summary>

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

</details>
