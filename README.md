[![Build status](https://ci.appveyor.com/api/projects/status/sy29el4cxp4ytb8g?svg=true)](https://ci.appveyor.com/project/RafaelBenetti/design-paterns)

# Design Patterns
In software engineering, a design pattern is a general repeatable solution to a commonly occurring problem in software design. A design pattern isn't a finished design that can be transformed directly into code. It is a description or template for how to solve a problem that can be used in many different situations.

 - Using design patterns help us to maintain, refactor and extend software.
 - They are final version, but templates that help us to solve specific problems.
 - They help Oriented Object Programming solve it's problems.
 - They help us to understand codes in the entire world. (We speak the same)

# Creational Design Patterns 
 - These design patterns are all about class instantiation.

## Singleton
 - One static reference in the entire project or process.
 - Used to share data between multi-threads.
 - Used when you need just one instance of a class or service.
 - Examples (Reports, Logs and Share data)

## Abstract Factory
 - Used to create a group of type or family.
 - Returns an implementation of an abstract family.
 - Examples: Can be used for create different types of families. (PdfReader, TxtReader)

## Factory Method
 - Factory Method is similar to Abstract Factory but without the emphasis on families.
 - Factory Method represents a factory but for only methods or uniques objects.
 - Examples: Can be used to identify which object must be instantiated. 

# References:
 - [Source Making - Design Patterns](https://sourcemaking.com/design_patterns) 