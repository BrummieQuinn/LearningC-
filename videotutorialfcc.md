# FreeCodeCamp Learn C# video tutorial notes:
## (31/5/2024)

### Notes:

#### Visual Studio console applications:
In order to run multiple .cs files within a solution OOP must be used

Change initial Program.cs code to:
```c#
namespace ProjectName
{
class Program
{
static void Main(string[] args)
{
var .csFileName = new .CsFileName();
// to run each file change .cs file name after new keyword - runs as an instance of the class in file
.csFileName.Run()
}
}
}
```
add new cs files as classes to be run through Main in Program.cs
```c#
namespace ProjectName
{
public class .csFileName
{
public void Run()
{
// code to run through Maingoes here
}
}
}
```


#### To keep console open after running add the line:
```c#
Console.ReadLine(); 
```
to all new program.cs files to ensure when run the window remains open until key press <br>

VS shortcut:

cw + tab:
```c#
 Console.WriteLine();
```

* when declaring variables of same type:
```c#
int x = 10;
int y = 20;
int z = 30;

//neater style - saves time:

int x = 10,
	y = 20,
	z = 30;
```
 
 * Convert string numbers to numbers: <br>
      does not work with string characters in "" e.g. "20h"(exceptions to be dealt with later on)
 ```c#
 Convert.To
 ```

 Convert.To is followed by number type required e.g.

 ```c#
 string textAge = "20";
 int age = Convert.ToInt32(textAge);

 ```

 * Operators:
 when dividing ```int``` use the actual types e.g. ```double``` etc to ensure precision
 
 ```c#
 double age = 23;
 age /= 10;
 ```
 
* var: compiler figures out the type based on value assigned to variable
    * use for easy implicit conversions e.g.
	```c#
	var age = 23;
	var name = "Ariel";
	```
	* use sparingly throughout code!

* const: use to disable the ability to reassign a variable
    - can change the constant to allow the variable to be changed throughout code(reusability)

#### Exercise - storing user data:

* Define a variable to hold a name
* Define a variable to hold a phone number
* Define a variable to hold an age
* Print variables line-by-line to the screen
* Extra: Define variables using var keyword

```c#
string name = "Ariel";
string phoneNumber = "(+44)0987-765-4456";
/** in c# phone numbers should be stored as strings due to leading zeros, length and non-numerical characters
	int is not enough to store phone numbers*/
int age = 23; 

Console.WriteLine(name);
Console.WriteLine(phoneNumber);
Console.WriteLine(age);
```

* Extra:
```c#
var name = "Ariel";
var phoneNumber = "(+44)0987-765-4456";
var age = 23;

Console.WriteLine(name);
Console.WriteLine(phoneNumber);
Console.WriteLine(age);
```

#### Exercise: Odd/Even checker:

* Create and initialise two ints
* Make a variable to work out the reamainder
* Outpur remainder to the screeb
* Change the first int variable to another number
    * recalculate remainder
	* output new remainder

```c#
int number1 = 12;
int number2 = 123;
int remainder = number1 % number2;

Console.WriteLine(remainder);
```

* input/output (i/o) for console applications:

```c#
Console.Readline();
```

store in a string variable e.g.
```c#
Console.Write("Enter your name: ");
string name = Console.ReadLine();

Console.Write("Enter your age:");
string ageInput = Console.ReadLine();

// explicitly convert and store string ageInput to int age
int age = Convert.ToInt32(ageInput);
/* shorter way to convert directly from input - remove string age variable
int age = Convert.ToInt32(Console.Readline());
*/*
Console.WriteLine(); // empty space for format
Console.WriteLine($"Your name is: {name}" + $"your age is: {age}");

Console.ReadLine();
```

* Else Statements:
else statements don't need an if condition if there is  an obvious opposite condition e.g. "=="/"!="

* To create random numbers using ```do-while```:
```c#
Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);


Random random = new Random();
int current = 0;

do
{
    current = random.Next(1, 11); // value range of 1 - 10
    Console.WriteLine(current);
} while (current != 7);
// while statement stops random number loop at when current = 7
```

* Switch statements: 
```c#
// basically means if variable equal to case value run associated code
switch (variable)
{
	case // match goes here: // code to execute here
		break;
	default: // default code to execute in the event variable doesn't match case
		break;

}
```

* For Loops:

 To allow a user to define number of loops and message repeated
```c#
Console.Write("What do you want to repeat?: ");
string message = Console.ReadLine());
Console.Write("How many times do you want to say hi?: "); // user sets loop counter number
	int loopCounter = Convert.ToInt32(Console.Readline()); // read user input and convert to int
if (loopCounter <= 0)
{
Console.WriteLine("Sorry, please enter a value above 0");
}
for (int i = 0; i < loopCounter; i++)
{
Console.WriteLine(message);
}
Console.ReadLine();
```

* While Loops:
continue until condition true (when you don't know the number of times you will loop)

checks condition first before entering while loop

```c#
// recreating a for loop

int i = 0;
while (i < 10)
{
Console.WriteLine(i);
i++;
}
```

* do-while Loops: Good when you need/doesn't matter if the code runs atleast once

do will check the condition is true/false before entering the while loop and condtition checked
