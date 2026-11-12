## loops, if/else, switch, logical operators
This tutorial covers how C# handles conditional logic and loops. Runnable code is in [CondStat.cs](https://github.com/HadearR/PLP-Csharp/blob/main/ConsoleApp1/CondStat.cs).

### 1. What are the boolean values in C#?
Boolean values are `true` and `false` (lowercase), and their type is `bool`. Unlike C or C++, C# does not treat `1` and `0` as booleans, so `if (1)` is a compile error. Conditions must be a real `bool` expression.

### 2. What types of conditional statements are available?
 **'if' statement** is the simplest conditional statement, it executes the code only when the condition is true
 
 **'if-else' statement** runs one block of code when its condition is 'true' and a different block when it is 'false'.

**`if-else if-else` ladder Statement** allows multiple independent conditions to be checked in order. If one condition is true, it executes, and the rest of the conditions are skipped.

**`switch`** instead of using a long if-else-if statement a switch would be more efficient. It is used when a single expression needs to be compared to multiple values.

### 3. How does C# delimit code blocks in selection statements?

In C#, code blocks in selection control statements are delimited using curly braces or as a single unbraced statement.

C# doesn't treat spaces and indentation alone as significant. Braces make a scope explicit, it prevents common mistakes. Only braces decide which statements belong to the branch.

### 4. Does C# use short-circuit evaluation?

Yes, and it also offers non-short-circuit versions, like Java.
- `&&` stops if the left side is `false`.
- `||` stops if the left side is `true`.
- `&` and `|` on booleans always evaluate both sides.

### 5. How does C# handle the "dangling else" problem?

A “dangling else” problem happens when nested if statements are written without curly braces, so it's unclear which `if` an `else` belongs to. C# uses a fixed rule: an `else` attaches to the nearest preceding `if` that doesn't already have an `else`.

```csharp
if (a)
    if (b)
        Console.WriteLine("a and b");
    else
        Console.WriteLine("a but not b"); // belongs to the inner if
```

6. Does C# have to use “break” to get out of switch or case statements? Can you use “continue” to have all of the conditions evaluated?

For switch statements you can use “break” to get out, but it is not the only way. You can input any jump statement.

| Jump Statements | What it does |
|---|---|
| `break` | Terminates the closest enclosing loop or `switch`. It transfers control to the following statement, after the break. |
| `continue` | Starts the next iteration of the closest enclosing loop. |
| `return` | Terminates execution of the function where it appears. It returns control and the functions result, to the caller.|
| `goto` | Transfers control to a statement that a label marks (can be used for loops and switch statements) |
  
In C# "continue" is only used when there is a loop. If you used "continue" in a switch statement that is **not** inside a loop, there will be a compiler error.

### 7. What types of loops does C# have?

**Iteration statements** are commonly known as loops are statements that are used to execute parts of code repeatedly based on a condition.

| Loop | Description |
|---|---|
| `for` | Executes a statement (or statements) while a specific boolean expression evaluates as `true`. |
| `foreach` | Loops through every element of a collection, such as an array, a `List`, or a `Dictionary`, without needing an index. |
| `do-while` | A variant of a `while` loop that runs its code block once before checking the condition, then repeats as long as the condition remains `true`. |
| `while` | Repeats a block of code as long as its condition is `true`. |


### 8. Are loop block variables treated differently than function block variables?

**loop code block:**
A variable made inside a loop only lives inside that loop. It disappears when the loop ends.

**function code blocks:**
A variable made inside a function only lives inside that function. It disappears when the function ends.

They both have the same rule, a variable only lives inside the curly braces where it was made.

## References
[Conditional Statements](https://www.geeksforgeeks.org/c-sharp/c-sharp-decision-making-else-else-ladder-nested-switch-nested-switch/)

[Selection Statements](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/statements/selection)

[Jump Statements](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/jump-statements#the-continue-statement)

[Iteration statements](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements)
[Boolean logical operators](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/boolean-logical-operators)








