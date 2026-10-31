# C# File Management Application

## Introduction

This project is a simple Windows Forms application built with C#. It is designed to demonstrate how files can be managed through programming. Users can create a file, save information, view its contents in different ways, and remove the file when needed.

The application uses buttons and a ListBox to make file operations easy to perform.

## Main Goals

- Learn the basics of handling files in C#.
- Practice creating files and storing text inside them.
- Understand different techniques for retrieving file information.
- Learn how to read a limited number of characters from a file.
- Practice checking files before performing operations.
- Improve understanding of Windows Forms and button click events.

## Application Functions

### 1. WriteLine
This option generates a new file called `myfile.desktop` and saves several text lines inside it using `StreamWriter`.

### 2. Read Lines
This function retrieves the file information one line at a time through `File.ReadLines()` and shows the results in the ListBox.

### 3. Read All Lines
This option loads every line from the file at once using `File.ReadAllLines()`. The retrieved information is then displayed in the ListBox.

### 4. Read Block
This function uses `StreamReader` to collect a limited number of characters from the file with the help of `ReadBlock()`.

### 5. Delete Items
This option removes the displayed information from the ListBox while keeping the original file saved on the computer.

### 6. Delete File
This function checks whether the file is available before removing it using `File.Delete()`.

### 7. Clear
Allows the user to empty the ListBox and remove the displayed text.

### 8. Exit
Closes the Windows Forms application when the user clicks the Exit button.

## Skills and Knowledge Gained

While developing this application, I gained practical experience in C# file management. I learned how to save and retrieve information, work with different reading methods, and use `StreamWriter` and `Stream