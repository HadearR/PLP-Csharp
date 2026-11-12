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

3. Does your language support recursive functions?
4. Can functions in your language accept multiple parameters? Can they be of different data types?
5. Can functions in your language return multiple values at the same time? How is that implemented? If not, are there ways around that problem? What are they?
6. Is your language pass-by reference or value? Check your code against outside sources in case there is anything tricky going on (like in Perl).
7. Where are the arguments, parameters and local variables stored (value-on-stack, ref-to-heap-on stack) during execution?
8. What are the scoping rules in your language (visibility and lifetime of variables before, during and after code blocks)?
9. Are side-effects possible? Are there guard rails against side-effects?
10. Are side-effects possible? Are there guard rails against side-effects?
11. Are there any other aspects of functions in your language that aren't specifically asked about here, but that are important to know in order to write one? What are they? (e.g. dynamic vsstatic scope)

### Reference 
[Methods (GeeksforGeeks)](https://www.geeksforgeeks.org/c-sharp/methods-in-c-sharp/)

[Methods (Microsoft Learn)](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods)
