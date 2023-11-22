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
   Omit optional tags (optional).

   For file size optimization and scannability purposes, consider omitting optional tags. The [HTML5 specification](https://html.spec.whatwg.org/multipage/syntax.html#syntax-tag-omission) defines what tags can be omitted.

   (This approach may require a grace period to be established as a wider guideline as it’s significantly different from what web developers are typically taught. For consistency and simplicity reasons it’s best served omitting all optional tags, not just a selection.)
  ### ```type``` Attributes
   Omit ```type``` attributes for style sheets and scripts.

   Do not use ```type``` attributes for style sheets (unless not using CSS) and scripts (unless not using JavaScript).

   Specifying ```type``` attributes in these contexts is not necessary as HTML5 implies ```text/css``` and ```text/javascript``` as defaults. This can be safely done even for older browsers.
  ### ```id``` Attributes
   Avoid unnecessary ```id``` attributes.

   Prefer ```class``` attributes for styling and ```data``` attributes for scripting.
   
   Where ```id``` attributes are strictly required, always include a hyphen in the value to ensure it does not match the JavaScript identifier syntax, e.g. use ```user-profile``` rather than just ```profile``` or ```userProfile```.
 ## Html Formatting Rules
  ### General Formatting
   Use a new line for every block, list, or table element, and indent every such child element.

   Independent of the styling of an element (as CSS allows elements to assume a different role per ```display``` property), put every block, list, or table element on a new line.

   Also, indent them if they are child elements of a block, list, or table element.
   
  ### HTML Quotation Marks
   When quoting attributes values, use double quotation marks.

   Use double (```""```) rather than single quotation marks (```''```) around attribute values.
# 4 CSS
 ## CSS Style Rules
  ### CSS Validity
   Use valid CSS where possible.

   Unless dealing with CSS validator bugs or requiring proprietary syntax, use valid CSS code.
  ### Class Naming
   Use meaningful or generic class names.

   Instead of presentational or cryptic names, always use class names that reflect the purpose of the element in question, or that are otherwise generic.

   Names that are specific and reflect the purpose of the element should be preferred as these are most understandable and the least likely to change.
  ### Class Name Style
   Use class names that are as short as possible but as long as necessary.

   Try to convey what a class is about while being as brief as possible.
  ### Class Name Delimiters
   Separate words in class names by a hyphen.
  ### Type Selectors
   Avoid qualifying class names with type selectors.

   Unless necessary (for example with helper classes), do not use element names in conjunction with classes.
  ### ID Selectors
   Avoid ID selectors.

   ID attributes are expected to be unique across an entire page, which is difficult to guarantee when a page contains many components worked on by many different engineers. Class selectors should be preferred in all situations.
  ### Shorthand Properties
   Use shorthand properties where possible.

   CSS offers a variety of shorthand properties (like ```font```) that should be used whenever possible, even in cases where only one value is explicitly set.
  ### 0 and Units
   Omit unit specification after ```0``` values, unless required.
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
