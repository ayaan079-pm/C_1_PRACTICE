
# C# File Handling System

## Project Description

This project is a Windows Forms application developed using C#. It demonstrates how to create, write, read, and delete files using the System.IO namespace.

The application uses different buttons to perform file operations and displays the results in a ListBox.

## Project Objectives

- Learn how to manage files using C#.
- Create and save information in text files.
- Understand different file writing methods.
- Practice reading files using different methods.
- Learn how to remove items from a ListBox.
- Understand how to check and delete files.

## Writing Functions

### 1. WriteLine
Uses StreamWriter and File.CreateText() to create a new file and write information line by line.

### 2. WriteAsync
Uses asynchronous writing to add new information to an existing file using WriteLineAsync().

### 3. WriteAllText
Uses File.WriteAllText() to write multiple lines of text into a file. It replaces the previous content.

## Reading Functions

### 1. ReadLines
Uses File.ReadLines() to read the file one line at a time.

### 2. ReadAllLines
Uses File.ReadAllLines() to retrieve all lines and store them in a string array.

### 3. ReadBlock
Uses StreamReader and ReadBlock() to read a specific number of characters from the file.

## Other Features

### Delete One Item
Removes only the selected item from the ListBox using RemoveAt().

### Clear
Removes all displayed items from the ListBox without deleting the file.

### Delete File
Checks whether the file exists and deletes it using File.Delete().

### Exit
Closes the Windows Forms application.

## Technologies Used

- C#
- Windows Forms
- Visual Studio
- System.IO
- StreamWriter
- StreamReader
- ListBox

## What I Learned

Through this project, I improved my knowledge of C# file handling. I practiced creating files, writing information, reading file contents in different ways, and deleting files.

I also learned how to use asynchronous writing, work with arrays and loops, and manage ListBox items through Windows Forms event handlers.

## Conclusion

This project helped me understand how file operations work in C#. It also gave me practical experience in building a simple desktop application with different file management features.
