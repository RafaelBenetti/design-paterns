# OOP (Object Oriented Programming)
  It is a paradigm of software development.

## What are the main concepts of object-oriented programming?
- Encapsulation, abstraction, polymorphism, and inheritance

## Encapsulation
 - It's when you encapsulates data that are not important for who is using your method or class.
 - When you have a class called Car you use the Car.Engine.Start(). Doesn't matter how the engine starts because you just want to start it.

## Abstraction
 - Abstraction is the method of exposing only the required features of the class and hiding unnecessary information.

## Polymorphism
 - It's a way to do the same thing in different types of objects.
 - For example, the method Talk exposed on Animals class, a cat can say "Meow", a dog can say "Wolf" and so on.

 ## Inheritance
 - It's a way of reusing things that are in common in a type.
 - For example, a class called Animal can have some properties:
    NumberOfLegs, Name, Race
 - You can define some Actions/Properties that all animals have.
 
## Interface
 - It's a way to create contracts in programming languages.
 - Using interface you have to respect that contract, but also can change the implementation without changing the input/response.
 - It helps a lot to test your application because you can create your own mocks to represent the concrete implementation.

## Class
 - It is a way to represent an object of real life, the body of the object.

## Abstract Class
 - It's a class that cannot be instantiated.
 - It's a good way of define base classes.

## Sealed Class
 - Cannot be inherited.

## Partial Class
 - Divide a single class file into multiple physical files.

## Object
 - It is an instance of a class, it represents the concrete implementation thinking in the real world.

## Override
 - It's a way of rewrite a method using the same input/output.
 - Both, method overloading and overriding are a type of polymorphism.

## Overload
 - It's a way of creating many methods with the same name, just changing the input. 
 - For example, you can specify many parameters you want in differents methods with the same name.
 - Both, method overloading and overriding are a type of polymorphism.

## What is the virtual method, and how is it different from the abstract method?
 - A virtual method must have a default implementation, and We can override this virtual method using the override keyword in the derived class.
 - The abstract method is without implementation, and it is created inside the abstract class only. In the case of an abstract class, the class derived from the abstract class must have an implementation of that abstract method.

### Virtual Method
```c#
public class CellPhone
{
  public virtual void Typing()
  {
      Console.WriteLine("Using old keypad");
  }
}

public class SmartPhone : CellPhone
{
  public override void Typing()
  {
      Console.WriteLine("Using qwerty keyboard");
  }
}
```

### Abstract Method
```c#
public abstract class CellPhones
{
  public abstract void Typing();
}

public class SmartPhones : CellPhones
{
  public override void Typing()
  {
      Console.WriteLine("Using Qwerty keyboard");
  }
}
```

## Delegates
 - It's a way of defining the structure of functions.
 - It allows you to pass callbacks, defining a delegate.