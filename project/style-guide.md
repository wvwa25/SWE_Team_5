# Formatting Guidelines
* This part of the guide uses the Google C# style guide as displayed in-depth [here](https://google.github.io/styleguide/csharp-style.html)
* I will go over it briefly in this guide however please proceed to the prior link if you are in need of a more in-depth summary.
## Naming rules

### Code
* Names of classes, methods, enumerations, public fields, public properties, namespaces are in PascalCase.
* Names of local variables, parameters: camelCase.
* The names of private, protected, internal and protected internal fields and properties are in _camelCase.
* Naming convention is unaffected by modifiers such as const, static, readonly, etc.
* For casing, a “word” is anything written without internal spaces, including acronyms. For example, BrentsAdhd instead of BrentsADHD.
* The names of interfaces must start with I, e.g. IInterface.
  
### Files
* Filenames and directory names are PascalCase, e.g. MyFile.cs.
* Where possible the file name should be the same as the name of the main class in the file, e.g. MyClass.cs.
* In general, prefer one core class per file.

## Organization
* Modifiers occur in the following order: public protected internal private new abstract virtual override sealed static readonly extern unsafe volatile async.
* Namespace using declarations go at the top, before any namespaces. using import order is alphabetical, apart from System imports which always go first.
* Class member ordering:
  * Group class members in the following order:
    * Nested classes, enums, delegates and events.
    * Static, const and readonly fields.
    * Fields and properties.
    * Constructors and finalizers.
    * Methods.
  * Within each group, elements should be in the following order:
    * Public.
    * Internal.
    * Protected internal.
    * Protected.
    * Private.
  * Where possible, group interface implementations together.

## Whitespace rules
Developed from Google Java style, see [here](https://google.github.io/styleguide/javaguide.html)
* A maximum of one statement per line.
* A maximum of one assignment per statement.
* Indentation of 2 spaces, no tabs.
* Column limit: 100.
* No line break before opening brace.
* No line break between closing brace and else.
* Braces used even when optional.
* Space after if/for/while etc., and after commas.
* No space after an opening parenthesis or before a closing parenthesis.
* No space between a unary operator and its operand. One space between the operator and each operand of all other operators.
* Line wrapping developed from Google C++ style guidelines, with minor modifications for compatibility with Microsoft’s C# formatting tools:
  * In general, line continuations are indented 4 spaces.
  * Line breaks with braces (e.g. list initializers, lambdas, object initializers, etc) do not count as continuations.
  * For function definitions and calls, if the arguments do not all fit on one line they should be broken up onto multiple lines, with each subsequent line aligned with the first argument. If there is not enough room for this, arguments may instead be placed on subsequent lines with a four space indent. The code example below illustrates this.
# C# guidelines
## Constants
## IEnumerable vs IList vs IReadOnlyList
## Generators vs containers
## Property styles
## Expression body syntax
## Structs and classes:
## Lambdas vs named methods
## Field initializers
## Extension methods
## ref and out
## LINQ
## Array vs List
## Folders and file locations
## Use of tuple as a return type
## String interpolation vs String.Format() vs String.Concat vs operator+
## using
## Object Initializer syntax
## Namespace naming
* In general, namespaces should be no more than 2 levels deep.
* Don’t force file/folder layout to match namespaces.
* For shared library/module code, use namespaces. For leaf ‘application’ code, such as unity_app, namespaces are not necessary.
* New top-level namespace names must be globally unique and recognizable.
## Default values/null returns for structs
## Removing from containers while iterating
## Calling delegates
## The var keyword
## Attributes
## Argument Naming
Derived from the Google C++ style guide, see [here](https://google.github.io/styleguide/cppguide.html)

When the meaning of a function argument is nonobvious, consider one of the following remedies:

* If the argument is a literal constant, and the same constant is used in multiple function calls in a way that tacitly assumes they’re the same, use a named constant to make that constraint explicit, and to guarantee that it holds.
* Consider changing the function signature to replace a bool argument with an enum argument. This will make the argument values self-describing.
* Replace large or complex nested expressions with named variables.
* Consider using Named Arguments to clarify argument meanings at the call site.
* For functions that have several configuration options, consider defining a single class or struct to hold all the options and pass an instance of that. This approach has several advantages. Options are referenced by name at the call site, which clarifies their meaning. It also reduces function argument count, which makes function calls easier to read and write. As an added benefit, call sites don’t need to be changed when another option is added.
# CSS and HTML Guidelines
## 1 Background
## 2 General
## 3 HTML
## 4 CSS
