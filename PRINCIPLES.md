# Principles of Software Development

## DRY
 - Don't repeat yourself.
 - In software engineering, Don't Repeat Yourself (DRY) or Duplication is Evil (DIE) is a principle of software development.

## KISS
 - KISS is an acronym for the design principle "Keep it simple, Stupid!".

## YAGNI
 - “You Aren’t Gonna Need It” - Sometimes, as developers, we try to think a lot in the future of the project coding some extra features “just in case we need them” or “we will eventually need them”. Just one word… Wrong! I’ll repeat it this way: You didn’t need it, you don’t need it and in most of the cases… “You Aren’t Gonna Need It”.

## SOLID
 - The S.O.L.I.D principle when well applied help us to maintain, refactor and extend our software.

### 
    S - Single Responsibility Principle
### 
    O - Open/Closed Principle
### 
    L - Liskov Substitution Principle
###
    I - Interface Segregation Principle
###
    D - Dependency Inversion Principle

## Single Responsibility Principle
 - It means that each class or method should only be responsible for one thing. 
 - This helps us to make smaller classes and smaller methods, which are easier to understand. Most importantly, if we need to edit one of our classes or methods, we can change the one that is specific to what needs to be changed without having to worry about it affecting the way the rest of the code works.

## Open/Closed Principle
 - The Open/Closed Principle (OCP) states that classes or methods should be open for extension, but closed to modification.
 - It means that it's better to extend a functionality than modify itself.

## Liskov Substitution
 - States that any instance of a child class should be able to replace the parent class without any unexpected errors or behaviors. 
 - It means that if we have three classes, “Vehicle” (the parent class), “Car,” and “Truck” (its two children), you should be able to put “Car” or “Truck” anywhere you have “Vehicle,” and it should work exactly the same.

## Interface Segregation Principle
 - It's better to expose specific interfaces than generic ones.
 - A client should not be forced to depend on methods that it does not use.
 - It is another way of encouraging programmers to write smaller classes and methods with a singular purpose.

## Dependency Inversion Principle
 - It's better depends on interfaces than implementations.
 - High-level modules should not depend on low-level modules. Both should depend on abstractions.
 - Abstractions should not depend on details. Details should depend on abstractions.

 # References:
 - [SOLID - Medium](https://medium.com/@mlgiardina/solid-principles-443b21cc6a0e)
 - [SOLID - Medium Android](https://android.jlelse.eu/solid-principles-the-definitive-guide-75e30a284dea)
 - [SOLID - Team Coder](https://team-coder.com/solid-principles/) 
 - [SOLID - Code Project](https://www.codeproject.com/Articles/703634/SOLID-architecture-principles-using-simple-Csharp)
 - [SOLID - Wikipedia](https://en.wikipedia.org/wiki/SOLID_(object-oriented_design))