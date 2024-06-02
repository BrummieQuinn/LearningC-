# FreeCodeCamp Learn C# video tutorial notes:
## (31/5/2024)

### Notes:

* add the line
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
 




