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
**Static method:** belongs to the type rather than an object. It is declared with the `static` keyword and can bee called using the class name.

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
Yes C# does support recursion, it is a process which a method calls itself directly or indirectly. A method can call itself as long as it has a base case. It's most commonly used in problem such as factorial, Fibonacci, tree traversal, and DFS.

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
A method can have multiple parameters,and the arguments passed during the method call should match their order and compatible data types

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

* **Stack Memory:** Is a fast memory structure used during method execution  
* **Heap Memory:** Larger memory area used for objects that need a dynamic lifetime

| Memory | What goes in |
|---|---|
| Stack | • Value types (`int`, `float`, `bool`)<br>• Primitive local variables<br>• Method calls<br>• References to objects that love in the heap |
| Heap | • Objects (class, arrays, delegates)<br>•Fields of reference types (e.g., object properties)<br> •Data structures whose size and lifetime cannot be determined at compile time|

### 8. What are the scoping rules?
Scoping rules can be divided into three levels:
* **Class Level Scope:** 
* **Method Level Scope:**
* **Block Level Scope:**

### 9. Are side effects possible? Are there guard rails?

### 10. Where are local variable values stored?

### 11. Other important aspects of functions in C#


### Reference 
[Methods (GeeksforGeeks)](https://www.geeksforgeeks.org/c-sharp/methods-in-c-sharp/)

[Methods (Microsoft Learn)](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods)

[Recursion](https://www.geeksforgeeks.org/c-sharp/recursion-in-c-sharp/)

[Function Parameters in C#](https://www.geeksforgeeks.org/c-sharp/method-parameters-in-c-sharp/)

[Return Multiple Values From a Function](https://www.tutorialspoint.com/article/how-can-we-return-multiple-values-from-a-function-in-chash)

[Method parameters and Modifiers](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/method-parameters)

[C# Memory Management](https://www.geeksforgeeks.org/c-sharp/c-memory-management/)

[C# Scope of Variables](https://www.geeksforgeeks.org/c-sharp/scope-of-variables-in-c-sharp/)
