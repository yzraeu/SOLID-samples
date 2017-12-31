# SOLID - .NET Samples
Simple .NET C# project to show SOLID implemented. The projects show a simple folder with a Problem and the Solution

## SRP - Single Reponsability Principle 
 - Reference => https://en.wikipedia.org/wiki/Single_responsibility_principle

The `Problem` is a single class that encapsulates every action surrouding the Client. The model, the data validation, BD connection and e-mail action.

The `Solution` is to break into multiple classes, each one with a clear responsability on what it should take care of.
## OCP - Open-Closed Principle
 - Reference => https://en.wikipedia.org/wiki/Open/closed_principle

The `Problem` is a class that encapsulates the CarRent by type. Every new type added in the future can break the current behavior and bring up problems with unit testing.

The `Solution` is to create an Abstract class with base implementation on car rental. Each rental type comes later, without mixing the code with the implemented ones.
## LSP - Liskov Substitution Principle
 - Reference => https://en.wikipedia.org/wiki/Liskov_substitution_principle

The `Problem` is to show that even though in real life, a Square is a type of Rectangle, this can bring problems to the OO world.

The `Solution` is to split the Square and Rectangle classes - in this case, sharing an interface to caculate the area. Each class taking care of the specifics behavior.
## ISP - Interface Segregation Principle
 - Reference => https://en.wikipedia.org/wiki/Interface_segregation_principle

The `Problem` is a inteface file with multiple responsabilities. This causes troubles in the enrollment process since Product doesn't have e-mail and phone number to receive SMS.

The `Solution` is to segregate the interface, with clear definition for each one.
## DIP - Dependency Inversion Principle
 - Reference => https://en.wikipedia.org/wiki/Dependency_inversion_principle

The `Problem` show the SRP solution with coupled classes. This makes it hard to test and maintain.

The `Solution` is to create clear interfaces that are only responsible for each class. This decouples the behavior and the ClientService doesn't need to instantiate the ClientRepository nor EmailHelper directly. The cotainer needs to handle this part.
