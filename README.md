# LearnDewey

## Changelog (21/11/22)

-  Add global.json file to manage sdk versions - dotnet 7 was released during developed though project was build with lts 6.0 in mind
- Version 1 and 2 Bug Fixes
- Created Text file to store Call Numbers for Identifying Call Numbers Game mode.
- Improved Readme.


## Description
The purpose of this POE is to create a learning application for a library which teaches the end-user the Dewey Decimal System.
## To Do - Overall
- [x] Home Page with an Introduction and Nav bar
- [x]  Menu for various Game Modes
- [ ]  Separate Code Logic from Razor Pages
- [ ]  Detailed Instructions of each Game Mode
- [ ] leaderboard - Gameification feature 2
- [ ]  Progress Bar - Gameification feature 3
- [ ]  Log In and Sign Up 
- [ ]  Connect to back end database


## To-Do Game mode 1
- [x]  Difficulty Selector - Gameification feature 1 
  - [x]  Generate Random Call Numbers 
  - [x]  Allow the user to interact and move call numbers
  - [x]  Sort Call Numbers correctly
  - [ ]  Let the user know they won


## To-Do Game mode 2
- [x] Identifying Areas feature 
	-[x] Match the column question to allow users to practice categories
	- [x]Column A - Call Number vs Column B - Description 
	- [x] User can answer as many questions as they want to 
	- [ ] Alternate between matching descriptions to call numbers and call numbers to descriptions 
	- [ ] First column should have 4 random questions
	- [x] Second Column should have seven answers 
	- [x] Implement a gamification feature to motivate users to use this feature

## To-Do Game mode 3
- [x] Finding Call Numbers 
	-[ ] Allow users to select options in a quiz using a tree
	- [ ] Read from file 
	- [x] Implement a gamification feature to motivate users to use this feature
## Installation And Running

This  Blazor Server application runs using the .NET Runtime implemented using .NET Core so various architectures and OS's are supported. 

### Requirements 
#### SDK
- .NET Core SDK 6.0 Or newer 
  #### OS 
- Windows 7 Or Later  OR
- MacOS Catalina or Later  OR
- Multiple Flavours of Linux
  #### IDE
- Visual Studio 2022 OR
-  Visual Studio Code with C# Extensions 

### Obtaining Source Code and Installation

  [The Github Repository](https://github.com/siegan-g/PROG7312_POE)
  If you have not set up Git and GitHub on your local machine please read the following [documentation](https://github.com/git-guides/install-git)
  1. If you are a contributor clone the code from GitHub use your terminal `git clone git@github.com:siegan-g/PROG7312_POE.git`. Alternatively this software is Open-source so feel free to fork this repo
  2. enter the source folder and open it using either Visual Studio 2022 or Visual Studio Code.
  3. If you are using VS Code open the terminal and run `dotnet run` (you may run `dotnet watch` if you are editting the source file)
#### Browser
- Apple Safari OR 
- Google Chrome OR 
- Microsoft Edge OR 
- Mozilla Firefox 

## Known Bugs
- An unhandled exception when comparing empty list views for the game mode **Reordering Books**. This can be both list views or one. 
- Being able to move the items from Column A in **Identifying Areas**
## Brief Summary On Blazor 
Blazor serves as a front-end framework based on ASP.NET to create dynamic websites along with HTML/CSS. This provides an alternative to using JavaScript for developers which may prefer C#. Blazor comes in two flavours, Blazor WebAssembly or Blazor Server. WebAssembly uses WASM (C# code is compiled into WebAssembly) to run on the client side where as Blazor Server runs on, well, the server. I had chose blazor server in that it is easier in the near future to implement a connection to a backend database as you don't have to utilise some kind of API to bridge the gap between the client machine and server 

## Some Interesting C# Remarks

### Sorting Algo For List<T> used in Replace Books Game Mode
A sorting algorithm had to be used to produce the correct order of Dewey Decimal Call Numbers. Fortunately `System.Collections.Generic` provides a nifty Sort() method. The algorithm used depends in the number of elements being stored in the collection. This number is dependent on the difficulty chosen (See ReplaceBooksPlay.razor). For when the Count <= 16 an insertion sort algorithm (0(n^2) average) is used. So for Level 1 and 2 it uses such, otherwise it will use Quicksort


## TroubleShooting
### Program will not run
There are multiple reasons why the program will not run, here are some common reasons:
1. .NET 7.0 was released as of writing this document. Ensure you have the .NET 6.0.111 SDK installed along with .NET 6.0 Runtime 
2. Unhandled exception. Consult the bugs section.
3. Other. In the case the program refuses to run, consult the demonstration video. 
  
## Contributing
To contribute to this project feel free to create a pull request. Though this a school assignment so I technically can't accept any help ;)


## FAQ



- Why Blazor?
  - The requirements for this assignment stated that the project had to be created in the C# programming language using any GUI framework. While there are many technologies established for C#, Blazor is quite easy to get up and running, especially for a project with little to no database CRUD (compared to more beefy frameworks which are tailored for it such as ASP.NET MVC or ADO.NET).
- Will you complete the project?
  - Absolutely.
- How do I know which features were not implemented and which were?
  - Consult the To-Do portion of this file. 


## Contact
Email: siegangovender@outlook.com
GitHub: siegan-g
## License 
[MIT](https://choosealicense.com/licenses/mit/)

## References
1. Microsoft Docs. 2022. _ASP.NET Core Blazor forms and input components_. Microsoft. Accessed From: https://learn.microsoft.com/en-us/aspnet/core/blazor/forms-and-input-components?view=aspnetcore-6.0
2. https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor 
3. https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.sort?view=net-7.0
4. https://giphy.com/bluesbear 
5. https://giphy.com/avocadastudio
6. https://www.flaticon.com/authors/pixel-perfect 

7. Coding Droplets. 2022.  Blazor Tutorial C# - Part 9 - Blazor Timer & Blazor Dispose Timer | Blazor Timer not Stopping. YouTube. Accessed From: https://www.youtube.com/watch?v=I7gBTLeiHG8
8. Jamro M. 2018._ C# Data Structures and Algorithms_. Packt Publishing
