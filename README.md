# Collections Manipulation in C#

This project demonstrates various operations on collections in C#. It includes functionalities to manipulate and display lists, dictionaries, and hash sets, as well as some utility methods for common tasks such as generating a random password and finding the second largest element in an array.

## Table of Contents

- [Introduction](#introduction)
- [Features](#features)
  - [List Manipulation](#list-manipulation)
  - [Dictionary Operations](#dictionary-operations)
  - [HashSet Operations](#hashset-operations)
  - [Utility Methods](#utility-methods)
- [Getting Started](#getting-started)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)

## Introduction

This C# project focuses on demonstrating various collection manipulations. It includes methods to perform operations such as displaying, removing, and analyzing elements within lists, dictionaries, and hash sets. Additionally, it offers utility methods for generating random passwords and counting unique words in a sentence.

## Features

### List Manipulation

- **Display List**: Displays all elements of a list.
- **Remove Elements**: Removes all names from the list that start with a specified character.
- **Display Length of Each Item**: Displays the length of each element in the list.

### Dictionary Operations

- **Print Oldest Person**: Finds and prints the oldest person's name and age from a dictionary of people's ages.

### HashSet Operations

- **Display HashSet**: Displays all elements of a HashSet.
- **Print Union**: Finds and prints the union of two HashSets.
- **Print Intersection**: Finds and prints the intersection of two HashSets.

### Utility Methods

- **Print Unique Elements from List**: Converts a list of integers to a HashSet to display only unique elements.
- **Find Second Largest**: Finds the second largest element in an array of integers.
- **Print Unique Word Count**: Reads a sentence from the user and prints the count of each unique word.
- **Random Password Generator**: Generates a random password of a given length, ensuring it contains a mix of uppercase letters, lowercase letters, numbers, and special characters.

## Getting Started

1. **Clone the repository:**

```sh
git clone https://github.com/yourusername/collections-manipulation.git
cd collections-manipulation
```

2. **Open the project in your preferred IDE (e.g., Visual Studio, Visual Studio Code).**

3. **Build and run the project.**

## Usage

Uncomment the desired method calls in the `Main` method of `Program.cs` to run specific examples:

```csharp
public static void Main()
{
    // ListWork();
    // DictionaryWork();
    // HashSetWork();
    // PrintUniqueElementFromList();
    // FindSecondLargest(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
    // PrintUniqueWordCount();
    // RandomPasswordGenerator();
}
```

Run the application to see the results of the selected methods.

## Contributing

Contributions are welcome! Feel free to open issues or submit pull requests for any improvements or new features.
