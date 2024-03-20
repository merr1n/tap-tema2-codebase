# *- SRP - (Single Responsibility Principle)*
Initially the `HotelReception.cs` class has too many reponsabilities and a low cohesion.
- Created the `Logger.cs` class.
    > It takes care of displaying the messages in the console.
- Created the `FileSource.cs` class.
    > It takes care of reading the content of the given source file.
- Created the `OrdersSerializer.cs` class.
    > It takes care of deserializing the contents of the source file.
<a/>

The cohesion is now higher and the program is easier to test.
  
# *- OCP - (Open/Closed Principle)*
Initially we can't add more `Order.cs` type objects without modifying the structure of the `HotelReception.cs` class. 
- Created the `OrderFactory.cs` class.
    > We can now add new `Order.cs` type objects without modifying the `HotelReception.cs` class.
<a/>

The program is easier to test and to use and now we can add new command types.

# *- LSP - (Liskov Substitution Principle)*
Initially the `HotelReception.cs` class has too many processed commands instead of using an abstract class, who's code can be modified without changing the structure of the `HotelReception.cs` class.
- Created the `Pricer.cs` abstract class.
- Created the `BreakfastOrderPricer.cs`, `ProductOrderPricer.cs`, `RoomOrderPricer.cs` and `UnknownOrderPricer.cs` classes
    > The 4 classes inherit the `Pricer.cs` class
<a/>

The program is now easier to test, the *LSP* principle is respected and the classes can be switched without affecting the main class.

# *- ISP - (Interface Segregation Principle)*
The program doesn't use interfaces, which could prompt the user to be restricted by the methods they don't use.
- Created the `IFileSource.cs` and `IOrderSerializer.cs` interfaces.
    > They are implemented by the classes that need them
<a/>

The program is easier to test and is more stable, the user doesn't depend anymore on unused methods.

# *- DIP - (Dependency Inversion Principle)*
The project doesnt inject dependencies in the `HotelReception.cs` class, using instead full implementations of the used classes.
- Created the `ILogger.cs` and `IOrderFactory.cs` interfaces.
    > Alongside the  `IFileSource.cs` and `IOrderSerializer.cs` interfaces they are injected in the `HotelReception.cs` class constructor.
<a/>

The `HotelReception.cs` class now depends on interfaces, making the code more flexible and easier to test.
