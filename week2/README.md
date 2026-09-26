## objectives 
 Reading Input with TextBox Controls
 A First Look at Variables
 Numeric Data Type and Variables
 Performing Calculations
 Inputting and Outputting Numeric Values
 Formatting Numbers with the ToString Method
 Simple Exception Handling
 Using Named Constants
Declaring Variables as Fields
 Using the Math Class
 More G U I Details
 Using the Debugger to Locate Logic Errors

## Reading Input with TextBox Control
TextBox control
a rectangular area
can accept keyboard input from the user
located in the Common Control group of the Toolbox
double click to add it to the form
default name is textBoxn

## The Text Property

A TextBox control’s Text property stores the user inputs
Text property accepts only string values, e.g.
textBox1.Text = "Hello";
To clear the content of a TextBox control, assign an empty string("")
textBox1.Text = "";
textBox1.Text = string.Empty;
textBox1.Clear();

## A First Look at Variables
A variable is a storage location in memory
A variable name represents the memory location
in C# you must declare a variable in a program before
using it to store data
The syntax to declare variables is
DataType VariableName;

## Variable Names
A variable name identifies a variable
Always choose a meaningful name for variables
Basic naming conventions are:
the first character must be a letter (upper or lowercase) or an underscore (_)
the name cannot contain spaces
do not use C# keywords or reserved words

## String Variables
A string is a combination of characters 
A variable of the string data type can hold any combination of characters, such as names, phone numbers, and social security numbers
The value of a string variable is assigned on the right of the = operator surrounded by a pair of double quotes:
productDescription = "Jamhuuriya University";
The following assigns the productDescription string to a Label control named productLabel:
productLabel = productDescription;
You can also display a string variable in a Message Box:
MessageBox.Show(productDescription);

## String Concatenation
Concatenation is the appending of one string to the end of another string
In C# the + operator is used for concatenation

## Declaring Variables Before Using Them
You can declare variables and use them later

## Numeric Literals


