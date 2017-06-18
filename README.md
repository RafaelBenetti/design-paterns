[![Build status](https://ci.appveyor.com/api/projects/status/sy29el4cxp4ytb8g?svg=true)](https://ci.appveyor.com/project/RafaelBenetti/design-paterns)

# Design Patterns
In software engineering, a design pattern is a general repeatable solution to a commonly occurring problem in software design. A design pattern isn't a finished design that can be transformed directly into code. It is a description or template for how to solve a problem that can be used in many different situations.

 - Using design patterns help us to maintain, refactor and extend software.
 - They are not the final version, but templates that help us to solve specific problems.
 - They help Oriented Object Programming solve its problems.
 - They help us to understand codes in the entire world. (We speak the same)

# Creational Design Patterns 
  These design patterns are all about class instantiation.

## Abstract Factory
 - Used to create a group of type or family.
 - Returns an implementation of an abstract family.
 - Examples: Can be used for creating different types of families. (PdfReader, TxtReader)

## Factory Method
 - Factory Method is similar to Abstract Factory but without the emphasis on families.
 - Factory Method represents a factory but for only methods or unique objects.
 - Examples: Can be used to identify which object must be instantiated. 

 ## Singleton
 - One static reference in the entire project or process.
 - Used to share data between multi-threads.
 - Used when you need just one instance of a class or service.
 - Examples (Reports, Logs, and Share data)

# Structural Design Patterns
  These design patterns are all about Class and Object composition. 

## Bridge
 - The Bridge pattern encapsulates complexity behind an abstraction.
 - When you have two separates structures and have to use it together.
 - Examples: You have many colors and many shapes and you need to use it together.

## Decorator
 - Provides extra functionalities without changes in the main process.
 - Examples:
   - You can decorate a request/response with a decorator to log each request.
   - You can customize something, for example, you can customize a weapon with more accessories.

## Facade
 - An easy way to control many subsystems.
 - Design a 'wrapper' class that encapsulates the subsystem.
 - The facade/wrapper captures the complexity and collaborations of the component and delegates to the appropriate methods.
 - Examples: 
   - TODO

# Behavioral Design Patterns
  These design patterns are all about Class's objects communication.

## Null Object
 - Provides an implementation for objects that are null.
 - It prevents a lot of validations when the object is null.
 - Examples: 
   - When an instance of an object is no required to continue with the program.
   - When you want to stop the program if you do not have an instance.

## State
 - Allow an object to alter its behavior when its internal state changes.
 - Each state knows what to do.
 - Examples:
   - When you have a process based on states.
   - Each state can do actions differents.

## Strategy
 - Lets the algorithm vary independently from clients that use it.
 - Enables an algorithm's behavior to be selected at runtime. 
 - Examples:
   - You can change an internal service based on an interface.
   - product.SetPaymentMethod(new CreditCardPayment());

## Template Method
 - Define the skeleton of an algorithm in an operation, deferring some steps to client subclasses. 
 - Template Method lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure.
 - Examples:
   - When you have a validation in some part of the process and you would like to expose this validation for the customer choose which validation must be done.
   - You can define a template method to send e-mail and implements it for Yahoo or Google.


# References:
 - [Source Making - Design Patterns](https://sourcemaking.com/design_patterns) 
 - [Dofactory - Design Patterns](http://www.dofactory.com/net/design-patterns)