// See https://aka.ms/new-console-template for more information
// Test
using Internship2022.Alimente;
using System.Globalization;
using Internship;
using Internship.DataTipes;
using Lists.Classes;

//int age = 22;

/*
Console.WriteLine("Wellness");

Populatie test = new Populatie();
test.Run();

//const int age = 18;
//age = 20;

var alimente = new Alimente("paine", "moara", DateTime.ParseExact("04.08.2022", "dd.MM.yyyy", null), 10);
Console.WriteLine("Pret paine = " + alimente.Pret);

string s = "2022-08-02 10:25";
DateTime dt = DateTime.ParseExact(s, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);

var infoApa = new InfoApa();
infoApa.Run();

//var alimente = new Alimente();

Console.WriteLine("Hello, World!");

Console.Write("Press key");
Console.ReadKey();
*/

#region samples
// bit flag
var manyDays = WeekdayEnums.Monday | WeekdayEnums.Tuesday | WeekdayEnums.Wednesday | WeekdayEnums.Thursday;
//Console.WriteLine(manyDays.HasFlag(WeekdayEnums.Monday));
Console.WriteLine((int)manyDays);
#endregion samples

// nullable bool
bool? myBool = null;
int? myInt = null;
int myOtherInt = 2;
int fallbackInt = 3;
string myString = null;

myOtherInt = myInt ?? fallbackInt;
Console.WriteLine(myOtherInt);

myInt ??= myOtherInt;
Console.WriteLine(myInt);

Console.WriteLine(myBool.GetValueOrDefault());
//Console.WriteLine(myBool.Value);

#region lifted operations
int? x = null;
int? y = null;
int? z = x + y;
Console.WriteLine(z);
#endregion

int[] myArray = new int[101];
for (int i = 0; i < 100; i++)
{

    if(i >= 90)
    {
        myArray[i] = i + 5;
    }
    else
    {
        myArray[i] = i + 1;
    }
}
/*
for(int i = 0; i < 100; i++)
{

    if (i >= 90)
    {
        myArray[i] = i + 5;
    }
}
*/

//Console.WriteLine(myArray[0]);
/*
List<string> dinosaurs = new List<string>();

Console.WriteLine("\nCapacity: {0}", dinosaurs.Capacity);

dinosaurs.Add("Tyrannosaurus");
dinosaurs.Add("Amargasaurus");
dinosaurs.Add("Mamenchisaurus");
dinosaurs.Add("Deinonychus");
dinosaurs.Add("Compsognathus");
Console.WriteLine();
foreach (string dinosaur in dinosaurs)
{
    Console.WriteLine(dinosaur);
}

Console.WriteLine("\nCapacity: {0}", dinosaurs.Capacity);
Console.WriteLine("Count: {0}", dinosaurs.Count);

Console.WriteLine("\nContains(\"Deinonychus\"): {0}",
    dinosaurs.Contains("Deinonychus"));

Console.WriteLine("\nInsert(2, \"Compsognathus\")");
dinosaurs.Insert(2, "Compsognathus");
*/

List<Customer> customers = new();
customers.Add(new Customer());
//List<Customer> customers = CreateCustomers();

static List<Customer> CreateCustomers()
{
    List<Customer> customers = new List<Customer>()
            {
                new Customer
                {
                    Name = "Customer One",
                    ContractDate = DateTime.Today.AddYears(-1)
                },
                new Customer
                {
                    Name = "Customer Two",
                    ContractDate = DateTime.Today.AddYears(-2)
                },
                new Customer
                {
                    Name = "Customer Three",
                    ContractDate = DateTime.Today.AddYears(-3)
                },
                new Customer
                {
                    Name = "Customer Four",
                    ContractDate = DateTime.Today.AddYears(-4)
                },
                new Customer
                {
                    Name = "Customer Five",
                    ContractDate = DateTime.Today.AddYears(-5)
                },
            };

    return customers;
}