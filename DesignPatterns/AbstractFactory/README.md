# AbstractFactory

## Definition

Provide an interface for creating families of related or dependent objects without specifying their concrete classes.

Usage     ![Usage](../../docs/Pictures/DesignPatterns/Usage5.png)     High

## UML class diagram

![Screenshot](../../docs/Pictures/DesignPatterns/abstract.gif)

## Structural code

This structural code demonstrates the Abstract Factory pattern creating parallel hierarchies of objects. Object creation has been abstracted and there is no need for hard-coded class names in the client code.

[AbstractFactory.cs](./AbstractFactory.cs)

## Output

```
ProductB1 interacts with ProductA1
ProductB2 interacts with ProductA2
```
