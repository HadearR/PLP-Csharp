## Functions in C#
This tutorial covers how C# declares and uses functions. Runnable code is in [Methods.cs]().

### 1. What is the syntax for declaring a Method?
In C#, functions are called **methods**, because they must belong to a class or struct.

The general syntax is:

```csharp
returnType MethodName(parameters)
{
    // method body
    return value;   // optional (only if returnType is not void)
}
```

There are two common ways to create a method.

**Instance method:** declared inside a class and called using an object of that class.
```csharp
void MethodName()
{
    // instance method body
}
```
**Static method:** belongs to the type rather than an object. It is declared with the `static` keyword and can be called using the class name.

```csharp
static void MethodName()
{
    // static method body
}
```
### 2. Are there any rules about where the method has to be placed?
A method is declared inside a `class`, `record`, or `struct`. Its declaration includes:

* **Access level (optional):** controls who can use the method, such as `public` or `private`. If you leave it out, the method is `private` by default.
* **Modifiers (optional):** extra keywords such as `abstract` or `sealed`.
* **Return type:** the type of value the method gives back, or `void` if it gives back nothing.
* **Name:** the identifier used to call the method.
* **Parameters:** the inputs the method accepts, written in parentheses and separated by commas. Empty parentheses mean the method takes no inputs.

### 3. Does C# support recursive functions?
Yes C# does support recursion, it is a process in which a method calls itself directly or indirectly. A method can call itself as long as it has a base case. It's most commonly used in problems such as factorial, Fibonacci, tree traversal, and DFS.

Syntax:
```csharp
returnType MethodName(parameters)
{
    if (baseCondition)
        return result;
    return MethodName(updatedParameters);
}
```
### 4. Can functions accept multiple parameters of different types?
A method can have multiple parameters, and the arguments passed during the method call should match their order and compatible data types

### 5. Can functions return multiple values at the same time?
Yes a function can return multiple values at the same time. There are a couple of approaches to do so:

| Approach | Best Used When | Advantages | Disadvantages |
|---|---|---|---|
| Reference parameters |Modifying existing variables|Direct variable modification|Variable must be initialized|
| Output parameters |Creating new return values | No initialization required | Must assign before return |
| Array | Same data types | Simple for homogeneous data | Limited to same type |
| Tuple |  Different data types | Supports mixed types | Less readable with `Item1`, `Item2` |
   
### 6. Is C# pass-by-reference or pass-by-value?
By default, C# is strictly pass by value. You can use parameter modifiers to pass arguments by reference.

* **Pass by value:** The method gets a copy of the value. The copy is stored in its own spot on the stack.
* **Pass by reference:** The method gets a copy of the reference (an alias) to the value. The reference points to the same spot on the stack as the original.

### 7. Where are the arguments, parameters and local variables stored?
arguments, parameters and local variables are stored in the stack 

* **Stack Memory:** A fast memory structure used during method execution  
* **Heap Memory:** Larger memory area used for objects that need a dynamic lifetime

| Memory | What goes in |
|---|---|
| Stack | • Value types (`int`, `float`, `bool`)<br>• Primitive local variables<br>• Method calls<br>• References to objects that live in the heap |
| Heap | • Objects (class, arrays, delegates)<br>•Fields of reference types (e.g., object properties)<br> •Data structures whose size and lifetime cannot be determined at compile time|

### 8. What are the scoping rules?
Scope of that variable, is part of the program where a variable is accessible. C# program is organized in the form of classes.

Scoping rules can be divided into three levels:

* **Class Level Scope:** Declaring the variables in a class but outside any method makes them directly accessible anywhere in the class. These variables are also called fields or class members.

* **Method Level Scope:** Variables are declared inside a method have method level scope (not accessible outside the method, but can be accessed by nested code blocks)

* **Block Level Scope:** Variables generally declared inside the for, while, or other statements.

### 9. Are side effects possible? Are there guard rails?

A method has a **side effect** when it does anything noticeable besides reading its arguments and returning a value to the code that called it.

Yes, side effects are possible in C#. A method can have side effects by:

* changing a `ref` or `out` argument
* changing the contents of an object or array that was passed in
* changing a `static` or instance field
* printing or doing input/output, such as `Console.WriteLine`

C# has some guard rails:

* **`readonly`:** a field can only be assigned in its declaration or a constructor.
* **`const`:** a value that can never change.
* **`in` parameter:** passes an argument by reference, but the method can't reassign it.
* **Immutable types:** for example, a `readonly struct` can't be changed after it is created.


### 10. Where are local variable values stored?
local variable values are stored in the stack 

```csharp
void calculate(){
    int a = 2; //stored in stack
    int b = 3; //stored in stack 
}
```
<img width="800" height="400" alt="image" src="https://github.com/user-attachments/assets/068fc6af-52d3-40b0-a9e5-b1f7d97cac67" />

(GeeksforGeeks, 2025)

### 11. Other important aspects of functions in C#
- **Overloading:** Several methods can have the same name if their parameter lists are different.
- **Static vs. instance methods:** A `static` method is called using the class name. An instance method needs an object.
- **Access modifiers:** Keywords such as `public` and `private` control who can call a method.
- **Local functions and lambdas:** A method can be declared inside another method, and short unnamed methods can be written as lambdas.
- **Static (lexical) scope:** C# finds a variable by where it is written in the code, not by the order methods were called. It is not dynamically scoped.
- **Entry point:** A program starts running at the `Main` method (or at top-level statements).

### Reference 
* [Methods (GeeksforGeeks)](https://www.geeksforgeeks.org/c-sharp/methods-in-c-sharp/)

* [Methods (Microsoft Learn)](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods)

* [Recursion](https://www.geeksforgeeks.org/c-sharp/recursion-in-c-sharp/)

* [Function Parameters in C#](https://www.geeksforgeeks.org/c-sharp/method-parameters-in-c-sharp/)

* [Return Multiple Values From a Function](https://www.tutorialspoint.com/article/how-can-we-return-multiple-values-from-a-function-in-chash)

* [Method parameters & Modifiers](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/method-parameters)

* [C# Memory Management](https://www.geeksforgeeks.org/c-sharp/c-memory-management/)

* [C# Scope of Variables](https://www.geeksforgeeks.org/c-sharp/scope-of-variables-in-c-sharp/)

* [Side effect (computer science)](https://en.wikipedia.org/wiki/Side_effect_(computer_science))

* [readonly (C# reference) (Microsoft Learn)](https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/readonly)

* [Write safe and efficient code (Microsoft Learn)](https://learn.microsoft.com/en-us/dotnet/csharp/write-safe-efficient-code)


