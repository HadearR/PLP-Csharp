# C# Programming Language

## History 

### What is C#
C# (C Sharp) is a cross-platform, general-purpose programming language developed by Microsoft. It is an object-oriented language in the C family and is part of the .NET platform.
### When/where was it created, and by whom was C# created?
- when: Created by Microsoft in 2000 as part of the .NET framework
- Where: It was developed internally at Microsoft's headquarters in Redmond, Washington, USA
- Who: The principal designers of the C# programming language were Anders Hejlsberg, Scott Wiltamuth, and Peter Golde from Microsoft 

### What is C# primarily used for?
- Games 
  - Unity game engine, one of the most popular game engines, for developing 2D, 3D, AR, and VR games.
- Windows Applications
  - Microsoft created C# for Microsoft  
- Web Application Development
  - Regardless of the platform, you can use C# to build dynamic websites and web apps using the .Net platform
    
### Where can I get information about C#? 
- Microsoft learn
- geeksforgeeks
- W3Schools

# Getting Started
For context I am using a MacOS and will be using Visual Studio Code
## Installing C#
1. Open Visual Studio Code on MacOS
2. Click on the Extension button
<img width="384" height="431" alt="Screenshot 2026-09-29 at 2 28 02 PM" src="https://github.com/user-attachments/assets/55f69670-ccef-4a55-a151-fed39ff9362b" />

3. Type in C# and download the official "C#" and the "C# Dev Kit" by Microsoft
4. In the walkthrough, select Set up your environment and select Install .NET SDK
## Hello World
1. Type in and select >.NET:New Project into the explorer
   
<img width="660" height="249" alt="Screenshot 2026-09-29 at 4 43 07 PM" src="https://github.com/user-attachments/assets/e414644e-2ebe-4061-983a-055af508e1ac" />

3. After selecting the command select Console App
   
<img width="582" height="190" alt="Screenshot 2026-09-29 at 4 43 46 PM" src="https://github.com/user-attachments/assets/df3993c7-c7f9-4972-9df2-ddd74d05484c" />

4.Open 'Program.cs' file (renamed 'HelloWord.cs' to find easily)

<img width="371" height="141" alt="Screenshot 2026-09-29 at 9 03 39 PM" src="https://github.com/user-attachments/assets/2ed388f8-390b-4dbf-b0b3-267c8aa10559" />

5. Run the program, your output will be, "Hello, World!"

## Comments

C# supports both single line and multiple line comments.
- Like other C-family languages they all share the same baseline syntax for comments
  
  A single line comment starts with //

  A multiple line comment starts with /* and ends with */

## Data Types & Naming Conventions in C#
This tutorial will cover how C# handles data types and how to properly name files and variables. Runnable code is in [DataTypes.cs](https://github.com/HadearR/PLP-Csharp/blob/main/ConsoleApp1/DataType.cs) 


1. Does C# have keywords or reserved words? How many?

**Keywords or Reserved Words** are words with special meanings in a programming language that cannot normally be used as variable names or objects. To use a keyword as an identifier, add @ as a prefix (e.g., double @int = 23.4;). C# has a total of 78 reserved keywords.


#### Categories of Keywords

    a.  Value Type Keyword: 15 keywords to define various data types (e.g, bool, char, double)

    b. Reference Type Keywords: 6 keywords used to store refrences of the data or objects (e.g, class, string, void)

    c. Modifiers Keywords: 17 keywords used to modify the declarations of type member (e.g, public, private, static)

    d. Statements Keywords: 18 keywords used in program instructions (e.g, if, else, while)

    e. Method Parameters Keywords: 4 keywords used to change how parameters are passed to a   method.

    f. Namespace Keywords: 3 keywords used in namespaces (e.g,namespace, using, extern)

    g. Operator Keywords: 8 keywords used for different purposes (e.g,as, is, new)

    h. Conversion Keywords: 3 keywords used in type conversation (e.g, explicit, implicit, operator)

    i. Access Keywords: 2 keywords used in accessing and refrencing class(e.g,base, this)

    j. Literal Keywords: 2 keywords used as literal/constant (e.g, null, default)


2. Naming requirments & conventions; are they enforced?
   
**Requirments** (enforced by the compiler)
- Identifiers are case-sensitive.
- Identifiers must start with a letter or underscore, not a digit.
- Identifiers can contain letters, digits, and underscores.

**Conventions** (community standard):
- PascalCase: Used for class names and method names.
- camelCase: Used for method parameters, local variables, and private or internal non-constant fields.
- Avoid abbreviations and acronyms in names unless they are widely known.
  
3. Statically or dynamically typed?

**Statically Typed**: By default each variable's type is checked during compile time so errors like **int x = "hello";** are caught before the program runs.

4. Strong or weakly typed?

  **C# is a strongly typed language** 
  - Every variable, constant, and expression has a type.

5. Explicitly typed or implicitly typed?

C# supports both explicit and implicit typing
- **Explicitly typed**: The programmer specifies the variable's data type (e.g., int age = 20;)
- **implicitly typed**: The compiler determines the variable's data type using var (e.g., var age = 20;)

6. Are some variables mutable while other are immutable?

- Immutable(can't be changed after creation)
  - string
  - constant
  
- Mutable(can be changed after creation)
  - Arrays
  - List<T>
  - Dictionary<K,V>
  - most classes


7. What are the operators available for each data type?

**Arithmetic operators (+ - * / %)**: Used mainly with numeric types such as int, double, decimal

**Comparison operators (< > <= >= == !=)**: Used to compare values and return a bool (true or false). Numeric types support these operators.

**Logical operators (&&, ||, !)**:Used with the bool type to combine or reverse conditions.

8. Are mixed operations allowed?
mixed operations are allowed in C# between different numerical types; however, the types must be compatible.
For Example:
- Mixing int and double is allowed because C# automatically converts the int to a double
- Mixing double and decimal is not allowed because it is not automatically converted to the other. 

9. At what point are identifier names and operator symbols bound?
- **Static binding (compile time)**: Most identifier names and operator symbols are bound during compilation, based on the known types of expressions.

- **Dynamic binding (runtime)**: When using the dynamic type, the compiler delays binding until the program runs. The operation is then determined based on the actual runtime types.

10. Describe the limitations of C#. Are there other restrictions that the documentations mentions that you need to be aware of?

- **Memory Management**: uses Garbage Collection (GC) to free unused memory, but this can sometimes cause brief pauses.
- **.NET**" need .NET installed to run, which increases file size.
- **Slow**:is often compiled at runtime, which can make it slower and use more memory than languages like C++ or Rust.
  
11. Are there built in complex data types that are commonly used in C#?
    
There are built in complex data types that are commenly used.
- string
- Arrays
- List<T>
- Dictionary<TKey, TValue>

## loops, if/else, switch, logical operators
Runnable code is in ' '

1. What are the boolean values in C# 
bool values are writen as true false.

2. What types of conditional statements are available?
### If Statement
The if statement is the simplest conditional statement, it executes the code only when the condition is true
### if-else Statement
An if-else statement is used when the first condition is true and the second is false

### If-else-if ladder Statement
Allows multiple independent conditions to be checked in order. If one condition is true, it executes, and the rest of the conditions are skipped.

### Switch
Instead of using a long if-else-if statement a switch would be more efficent. It is used when a single expression needs to be compared to multiple values.

3. How does C# fix code blocks under each condition in selection control statements?

In C#, code blocks in selection control statements are delimited using curly braces or as a single unbraced statement.

C# doesn't treat spaces and indentation alone as significant. Braces make a scope explicit, it prevents common mistakes. Only braces decide which statements belong to the branch.

4. Does C# use short-circuit evaluation? Include an example of the short-circuit logic working or not working (or both, if your language is like Java and supports both!)
Yes, C# does use short-circuit evaluation, like Java it supports both.

5. How does your programming language deal with the “dangling else” problem?
A "dangling else" problem happens when there is a nested if statement written without curly braces, creating confusion about which if statement the else clause belongs to. To avoid this issue, be sure to use curly braces properly.

6. Does C# have to use “break” to get out of switch or case statements? Can you use “continue” to have all of the conditions evaluated?

For switch statements you can use “break” to get out, but it is not the only way. You can input any jump statement.

#### Jump Statements
- break: terminated the closest enclosing loop or switch statement. It transfers control to the following statement, after the break.  
- continue: starts a new iteration of the closest enclosing loop statement
- return: terminiates execution of the function where it appears. It returns control and the functions result, to the caller.
- goto: transfers control to a statement that a label marks (can be used for loops and switch statements)
  
In C# "continue" is only used when there is a loop. If you used "continue" in a switch statement that is **not** inside a loop, there will be a compiler error.

7. Does your language include multiple types of loops (while, do/while, for, foreach)? If so, what are they and how do they differ from each other? 


8. Are loop code block variables treated differently than function code blocks?

## References
[Keywords](https://www.geeksforgeeks.org/c-sharp/c-sharp-keywords/)

[Naming Rules](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/identifier-names)

[C# Type System](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/)

[Casting and type conversions](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/casting-and-type-conversions)

[Conditional Statements](https://www.geeksforgeeks.org/c-sharp/c-sharp-decision-making-else-else-ladder-nested-switch-nested-switch/)

[Selection Statements](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/statements/selection)

[Jump Statements](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/jump-statements#the-continue-statement)










