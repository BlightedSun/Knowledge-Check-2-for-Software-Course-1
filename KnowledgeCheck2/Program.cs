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


