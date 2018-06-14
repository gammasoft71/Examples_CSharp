// Abstract Factory pattern -- Creational example

using System;

namespace DesignPatterns {
  // The 'AbstractFactory' abstract class
  abstract class AbstractFactory {
    public abstract AbstractProductA CreateProductA();
    public abstract AbstractProductB CreateProductB();
  }

  // The 'ConcreteFactory1' class
  class ConcreteFactory1 : AbstractFactory {
    public override AbstractProductA CreateProductA() {return new ProductA1();}
    public override AbstractProductB CreateProductB() {return new ProductB1();}
  }

  // The 'ConcreteFactory2' class
  class ConcreteFactory2 : AbstractFactory {
    public override AbstractProductA CreateProductA() {return new ProductA2();}
    public override AbstractProductB CreateProductB() {return new ProductB2();}
  }

  // The 'AbstractProductA' abstract class
  abstract class AbstractProductA {
  }

  // The 'AbstractProductB' abstract class
  abstract class AbstractProductB {
    public abstract void Interact(AbstractProductA a);
  }

  // The 'ProductA1' class
  class ProductA1 : AbstractProductA {
  }

  // The 'ProductB1' class
  class ProductB1 : AbstractProductB {
    public override void Interact(AbstractProductA a) {
      Console.WriteLine(this.GetType().Name + " interacts with " + a.GetType().Name);
    }
  }

  // The 'ProductA2' class
  class ProductA2 : AbstractProductA {
  }

  // The 'ProductB2' class
  class ProductB2 : AbstractProductB {
    public override void Interact(AbstractProductA a) {
      Console.WriteLine(this.GetType().Name + " interacts with " + a.GetType().Name);
    }
  }

  // The 'Client' class. Interaction environment for the products.
  class Client {
    private AbstractProductA abstractProductA;
    private AbstractProductB abstractProductB;

    // Constructor
    public Client(AbstractFactory factory) {
      this.abstractProductB = factory.CreateProductB();
      this.abstractProductA = factory.CreateProductA();
    }

    public void Run() {
      this.abstractProductB.Interact(this.abstractProductA);
    }
  }

  // MainApp startup class for Structural
  // Abstract Factory Design Pattern.
  class MainApp {
    // The main entry point for the application.
    public static void Main() {
      // Abstract factory #1
      AbstractFactory factory1 = new ConcreteFactory1();
      Client client1 = new Client(factory1);
      client1.Run();

      // Abstract factory #2
      AbstractFactory factory2 = new ConcreteFactory2();
      Client client2 = new Client(factory2);
      client2.Run();
    }
  }
}

// This code produces the following output:
//
// ProductB1 interacts with ProductA1
// ProductB2 interacts with ProductA2
