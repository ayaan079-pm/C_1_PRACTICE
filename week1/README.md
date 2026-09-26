## objectives
 Objects
 The Program Development Process
 Getting Started with Visual Studio
 Getting Started with Forms and Controls
 Creating the G U I for Your First Visual C# Application
 Introduction to C# code
 Writing Code for the Hello World Application
 Label Controls
 Making Sense of IntelliSense
 PictureBox Controls
 Comments, Blank Lines, and Indentation
 Writing the Code to Close an Application’s Form
 Dealing with Syntax Errors

## objectives
An object is a program component that contains data and performs operations, Programs use objects to perform specific tasks.
Most programming languages use object-oriented programming in which a program component is called an ""object"
Program objects have properties (or fields) and methods
Properties - data stored in an object
Methods - the operations an object can perform

## controls
Objects that are visible in a program G U I are known as controls
Commonly used controls are Labels, Buttons, and TextBoxes
They enhance the functionality of your programs
There are invisible objects in a G U I such as Timers, and OpenFileDialog
A class is code that describes a particular type of object

## .NET Framework
NET is a collection of classes and other code that can be used to create programs for Windows operating system
C# is a language supported by .NET
Controls are defined by specialized classes provided by .NET
You can also write your own class to perform a special task


## Getting Started with Visual Studio
Visual Studio is a professional integrated development environment (I D E)
The Visual Studio Environment includes:
Designer Window
Solution Explorer Window
Properties Window

## Message Boxes
A message box (a k a dialog box) displays a message
.NET provides a method named MessageBox.Show
The method displays a window with a message. A sample code is (bold line):

private void myButton_Click(object sender, EventArgs e)
{
    MessageBox.Show("Thanks for clicking the button!");
}
## Label Controls
A Label control displays text on a form and can be used to display unchanging text or program output
Commonly used properties are:
Text: gets(read) or sets(write/change) the text associated with Label control
Name: gets or sets the name of Label control
Font: allows you to set the font, font style, and font size
BorderStyle: allows you to display a border around the control’s text
AutoSize: controls the way they can be resized
TextAlign: set the text alignments 

## PictureBox Controls
A PictureBox control displays a graphic image on a form
Commonly used properties are:
Image: specifies the image that it will display
SizeMode: specifies how the control’s image is to be displayed
Visible: determines whether the control is visible on the form at run time

## Dealing with Syntax Errors
The Visual Studio code editor examines each statement as you type it and reports any syntax errors that are found
If a syntax error is found, it is underlined with a jagged line

If a syntax error exists and you attempt to compile and execute, you will see the following window






