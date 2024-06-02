# Microsoft Learn C#

## (31/5/2024)

### Calling methods of .NET class:

*  code to simulate a dice roll:

```c#
Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);
```

* two different techniques to call methods used
	* Console.WriteLine() is a stateless(static) method; it works without referencing/changing values stored in memory
	* Random.Next() stateful method; keeps track of state in 'fields' - variables defined on class
		* Each new instance gets a copy of the fields to store state
		* To call the method an instance of the class needs to be created; method can then access state

### Creating an instance of a class:


* Instance of a class is an 'object'
	* create new instance of a class - use ```new``` operator
	* ```new``` operator:
		* requests an address in computer's memory large enough to store new object
		* creates new object and stores at memory address
		* returns memory address to be saved in a variable

#### Recap:

* format to call methods = ```ClassName.MethodName();```
	* ```.``` = member access operator: access method defined on class

	* ```()``` = method invocation operators

### Return value and parameters of methods:

* void methods - complete function; don't return a value

* arguments are concrete values passed to method to complete task; method uses arguments to assign values to parameters; parameters are defined in method's signature; the method can require 0 or more parameters

* method signature defines number if parameters; data type of each parameter
	* coding statement calling method uses requirements specified by method signature 
	* arguments must be compatible with argument type
	* argument name if used can be different to parameter name used in method

### Overloaded methods:

* 