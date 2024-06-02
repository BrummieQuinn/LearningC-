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
Console.WriteLine("Your name is ${name}" + "your age is ${age}");

Console.ReadLine();
```

* If Statements: