# Style Guide
 This Guide is built from existing google style guides.
 I will go over parts of them in this guide, however please proceed to the following links if you are in need of a more in-depth summary:

 * See [here](https://google.github.io/styleguide/csharp-style.html) for the Google C# style guide
 * See [here](https://google.github.io/styleguide/htmlcssguide.html) for the Google HTML/CSS Style Guide
# Formatting Guidelines
 This part of the guide, along with the C# guidelines below, 
 ## Comments
  Explain code as needed, where possible.

  Use comments to explain code: What does it cover, what purpose does it serve, why is respective solution used or preferred?

  (This item is optional as it is not deemed a realistic expectation to always demand fully documented code. Mileage may vary heavily and depends on the project’s complexity.)
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
  * Variables and fields that can be made ```const``` should always be made ```const```.
  * If ```const``` isn’t possible, ```readonly``` can be a suitable alternative.
  * Prefer named constants to magic numbers.
 ## Lambdas vs named methods
  * If a lambda is non-trivial (e.g. more than a couple of statements, excluding declarations), or is reused in multiple places, it should probably be a named method.
 ## Field initializers
  * Field initializers are generally encouraged.
 ## Array vs List
  * In general, prefer ```List<>``` over arrays for public variables, properties, and return types.
  * Prefer ```List<>``` when the size of the container can change.
  * Prefer arrays when the size of the container is fixed and known at construction time.
  * Prefer arrays for multidimensional arrays.
  * Note:
    * array and ```List<>``` both represent linear, contiguous containers.
    * Similar to C++ arrays vs ```std::vector```, arrays are of fixed capacity, whereas ```List<>``` can be added to.
    * In some cases arrays are more performant, but in general ```List<>``` is more flexible.
 ## Folders and file locations
  * Be consistent with the project.
  * Prefer a flat structure where possible.
 ## Namespace naming
  * In general, namespaces should be no more than 2 levels deep.
  * Don’t force file/folder layout to match namespaces.
  * For shared library/module code, use namespaces. For leaf ‘application’ code, such as ```unity_app```, namespaces are not necessary.
  * New top-level namespace names must be globally unique and recognizable.
 ## The var keyword
  * Use of ```var``` is encouraged if it aids readability by avoiding type names that are noisy, obvious, or unimportant.
  * Encouraged:

    * When the type is obvious - e.g. ```var apple = new Apple();```, or ```var request = Factory.Create<HttpRequest>();```
    * For transient variables that are only passed directly to other methods - e.g. ```var item = GetItem(); ProcessItem(item);```
  * Discouraged:

    * When working with basic types - e.g. ```var success = true;```
    * When working with compiler-resolved built-in numeric types - e.g. ```var number = 12 * ReturnsFloat();```
    * When users would clearly benefit from knowing the type - e.g. ```var listOfItems = GetList();```
 ## Argument Naming

  When the meaning of a function argument is nonobvious, consider one of the following remedies:

  * If the argument is a literal constant, and the same constant is used in multiple function calls in a way that tacitly assumes they’re the same, use a named constant to make that constraint explicit, and to guarantee that it holds.
  * Consider changing the function signature to replace a bool argument with an enum argument. This will make the argument values self-describing.
  * Replace large or complex nested expressions with named variables.
  * Consider using Named Arguments to clarify argument meanings at the call site.
  * For functions that have several configuration options, consider defining a single class or struct to hold all the options and pass an instance of that. This approach has several advantages. Options are referenced by name at the call site, which clarifies their meaning. It also reduces function argument count, which    makes function calls easier to read and write. As an added benefit, call sites don’t need to be changed when another option is added.
# General CSS and HTML Guidelines
 ## Protocol
  Use HTTPS for embedded resources where possible.

  Always use HTTPS (https:) for images and other media files, style sheets, and scripts, unless the respective files are not available over HTTPS.
 ## General Formatting Rules
  ### Capitalization
   Use only lowercase.

   All code has to be lowercase: This applies to HTML element names, attributes, attribute values (unless text/CDATA), CSS selectors, properties, and property values (with the exception of strings).
  ### Trailing Whitespace
   Remove trailing white spaces.

   Trailing white spaces are unnecessary and can complicate diffs.
# 3 HTML
 ## HTML Style Rules
  ### Document type
   Use HTML5.

   HTML5 (HTML syntax) is preferred for all HTML documents: ```<!DOCTYPE html>```.

   (It’s recommended to use HTML, as ```text/html```. Do not use XHTML. XHTML, as ```application/xhtml+xml```, lacks both browser and infrastructure support and offers less room for optimization than HTML.)
  ### HTML Validity
   Use valid HTML where possible.

   Use valid HTML code unless that is not possible due to otherwise unattainable performance goals regarding file size.
  ### Semantics
   Use HTML according to its purpose.

   Use elements for what they have been created for. For example, use heading elements for headings, p elements for paragraphs, h elements for headings, etc.
  ### Multimedia Fallback
   Provide alternative contents for multimedia.

   For multimedia, such as images, videos, animated objects via canvas, make sure to offer alternative access. For images that means use of meaningful alternative text (alt) and for video and audio transcripts and captions, if available.
  ### Separation of Concerns
   Separate structure from presentation from behavior.

   Strictly keep structure (markup), presentation (styling), and behavior (scripting) apart, and try to keep the interaction between the three to an absolute minimum.

   That is, make sure documents and templates contain only HTML and HTML that is solely serving structural purposes. Move everything presentational into style sheets, and everything behavioral into scripts.

   In addition, keep the contact area as small as possible by linking as few style sheets and scripts as possible from documents and templates.

   Separating structure from presentation from behavior is important for maintenance reasons. It is always more expensive to change HTML documents and templates than it is to update style sheets and scripts.
  ### Entity References
   Do not use entity references.

   There is no need to use entity references like ```&mdash;```, ```&rdquo;```, or ```&#x263a;```, assuming the same encoding (UTF-8) is used for files and editors as well as among teams.

   The only exceptions apply to characters with special meaning in HTML (like ```<``` and ```&```) as well as control or “invisible” characters (like no-break spaces).
  ### Optional Tags
  ### ```type``` Attributes
  ### ```id``` Attributes
 ## Html Formatting Rules
  ### General Formatting
  ### HTML Line-Wrapping
  ### HTML Quotation Marks
# 4 CSS
 ## CSS Style Rules
  ### CSS Validity
   Use valid CSS where possible.

   Unless dealing with CSS validator bugs or requiring proprietary syntax, use valid CSS code.
  ### Class Naming
  ### Class Name Style
  ### Class Name Delimiters
  ### Prefixes
  ### Type Selectors
  ### ID Selectors
  ### Shorthand Properties
  ### 0 and Units
  ### Leading 0s
  ### Hexadecimal Notation
  ### Important Declarations
  ### Hacks
 ## CSS Formatting Rules
  ### Declaration Order
  ### Block Content Indentation
  ### Declaration Stops
  ### Property Name Stops
  ### Declaration Block Separation
  ### Selector and Declaration Separation
  ### Rule Separation
  ### CSS Quotation Marks
 ## CSS Meta Rules
  ### Section Comments
# Be Consistant
 If you are editing, take some time to analyse the code surrounding you to determine it's style, then mirror it as you best you can.
