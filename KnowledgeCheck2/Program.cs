using KnowledgeCheck2;

Console.WriteLine("How many Dragons do you want to add? ");


//how many times the loop will ask for input
var numberOfWyverns = int.Parse(Console.ReadLine());

//create new list of type dragons
var wyvernList = new List<Wyvern>();

//create int i and set to 0, while i < numberOfDragons, add to i count
for (int i = 0; i < numberOfWyverns; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    var wyvern = new Wyvern();

    Console.WriteLine("Enter the value for color... ");
    wyvern.Color = Console.ReadLine();
    Console.WriteLine("Enter the value for horns... ");
    wyvern.NumHorn = int.Parse(Console.ReadLine());

    wyvernList.Add(wyvern);
}

for (int i = 0; i < numberOfWyverns; i++)
{
    Console.WriteLine(wyvernList[i].ToString());
    
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
//      1. `cd <to-the-project-folder>`