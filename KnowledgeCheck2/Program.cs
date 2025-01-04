Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<MyClass>();
for (int i = 0; i < numberOfRecords; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    var myClass = new MyClass();

    Console.WriteLine("Enter the value for ");
    myClass.myProperty = Console.ReadLine();

    recordList.Add(myClass);
}

// Print out the list of records using Console.WriteLine()

//Create a new object and then create another object that inherits from it.  Each object should have at least 1 property.
//   1. Example from the [pet store](https://github.com/CodeLouisville/Software-Pet-Store): first class is [Product][Product], second class is [CatFood][CatFood] and it inherits from [Product][Product].
//1. Replace `MyClass` in `Program.cs` with the child class that you made in step 5.
//1. Replace `MyClass.myProperty` in `Program.cs` with the child class property you created in step 5.
//1. You should allow the user to add data for every property in your class.  
//   1. So with the [CatFood][CatFood] example, the user should be able to add values for every property of [CatFood][CatFood] (KittenFood) which includes the properties from [Product][Product] (Price, Name, Quantity, Description).
//1. Print the objects in recordList to the screen
//   1. Hint: Look into class `ToString()` method.
//1. Upload to the repository we created earlier on your Github account.
//   1. Either through Add file > upload files
//   1. Or via git commands
//      1. `cd <to-the-project-folder>`Create a new object and then create another object that inherits from it.  Each object should have at least 1 property.
//   1. Example from the [pet store](https://github.com/CodeLouisville/Software-Pet-Store): first class is [Product][Product], second class is [CatFood][CatFood] and it inherits from [Product][Product].
//1. Replace `MyClass` in `Program.cs` with the child class that you made in step 5.
//1. Replace `MyClass.myProperty` in `Program.cs` with the child class property you created in step 5.
//1. You should allow the user to add data for every property in your class.  
//   1. So with the [CatFood][CatFood] example, the user should be able to add values for every property of [CatFood][CatFood] (KittenFood) which includes the properties from [Product][Product] (Price, Name, Quantity, Description).
//1. Print the objects in recordList to the screen
//   1. Hint: Look into class `ToString()` method.
//1. Upload to the repository we created earlier on your Github account.
//   1. Either through Add file > upload files
//   1. Or via git commands
//      1. `cd <to-the-project-folder>`