## Data Types & Naming Conventions in C#
This tutorial covers how C# handles data types and how to name variables and files. Runnable code is in [DataTypes.cs](https://github.com/HadearR/PLP-Csharp/blob/main/ConsoleApp1/DataType.cs).


### 1. Does C# have keywords or reserved words? How many?

**Keywords or Reserved Words** are words with special meanings in a programming language that cannot normally be used as variable names or objects. To use a keyword as an identifier, add @ as a prefix (e.g., double @int = 23.4;). C# has a total of 78 reserved keywords.


| Category | Count | Examples |
|---|---|---|
| Value type | 15 | `bool`, `char`, `double` |
| Reference type | 6 | `class`, `string`, `void` |
| Modifier | 17 | `public`, `private`, `static` |
| Statement | 18 | `if`, `else`, `while` |
| Method parameter | 4 | `params`, `ref`, `out` |
| Namespace | 3 | `namespace`, `using`, `extern` |
| Operator | 8 | `as`, `is`, `new` |
| Conversion | 3 | `explicit`, `implicit`, `operator` |
| Access | 2 | `base`, `this` |
| Literal | 2 | `null`, `default` |


### 2. Naming requirments & conventions; are they enforced?
   
**requirements (enforced by the compiler)**
- Identifiers are case-sensitive (`age` and `Age` are different).
- Identifiers must start with a letter or underscore, not a digit.
- Identifiers can contain letters, digits, and underscores.

**Conventions (community standard, not enforced):**
- `PascalCase` for classes, methods, and properties.
- `camelCase` for parameters and local variables.
- Avoid abbreviations unless they are widely known.
  
### 3. Statically or dynamically typed?

**Statically Typed**: By default each variable's type is checked during compile time so errors like **int x = "hello";** are caught before the program runs.

### 4. Strong or weakly typed?

Strongly typed. Every variable and expression has a type, and C# won't silently apply unsafe conversions (e.g., `double` to `int` needs a cast).

### 5. Explicitly or implicitly typed?

C# supports both explicit and implicit typing
- **Explicitly typed**: The programmer specifies the variable's data type (e.g., `int age = 20;`)
- **implicitly typed**: The compiler determines the variable's data type using var (e.g., `var age = 20;`)

### 6. Mutable vs. immutable

- Immutable(can't be changed after creation)
  - 'string'
  - 'const' values
  
- Mutable(can be changed after creation)
  - arrays
  - `List<T>`
  - `Dictionary<TKey, TValue>`
  - most classes


### 7. Operators by data type

| Category | Operators | Used with | Description |
|---|---|---|---|
| **Arithmetic** | `+` `-` `*` `/` `%` | `int`, `double`, `decimal` | Used mainly with numeric types. |
| **Comparison** | `<` `>` `<=` `>=` `==` `!=` | Numeric types (all six); `bool`, `string`, `char` (`==` and `!=` only) | Compares values and returns a `bool` (`true` or `false`). |
| **Logical** | `&&` `\|\|` `!` | `bool` | Combines or reverses conditions. |


### 8. Are mixed operations allowed?

Yes, if there is an *implicit* conversion between the types.
- `int` + `double` works: the `int` is widened to `double`.
- `double` + `decimal` is a compile error. Cast explicitly: `(decimal)d + m`.

### 9. When are names and operators bound?
- **Static binding (compile time)**: Most identifier names and operator symbols are bound during compilation, based on the known types of expressions.

- **Dynamic binding (runtime)**: Only when using the dynamic type, the compiler delays binding until the program runs. The operation is then determined based on the actual runtime types.

### 10. Limitations

- **Memory Management**: uses Garbage Collection (GC) to free unused memory, but this can sometimes cause brief pauses.
- **.NET**" need .NET installed to run, which increases file size.
- **Slow**:is often compiled at runtime, which can make it slower and use more memory than languages like C++ or Rust.
  
### 11. Built-in complex types

`string`, arrays, `List<T>`, `Dictionary<TKey, TValue>`

  
### References
[Keywords](https://www.geeksforgeeks.org/c-sharp/c-sharp-keywords/)

[Naming Rules](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/identifier-names)

[C# Type System](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/)

[Casting and type conversions](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/casting-and-type-conversions)


