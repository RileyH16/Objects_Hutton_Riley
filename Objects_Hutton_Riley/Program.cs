// See https://aka.ms/new-console-template for more information
using Objects_Hutton_Riley;


//Creates a new computer and passes through Apple, all-in-one, and true as arguments
Computer myComputer = new Computer("Apple", "All-in-One", true);
//Creates an IBootUp objects and assigns it to myComputer
IBootUp myBootUp = myComputer;
//Compares the two and prints the results to console
Console.WriteLine(myComputer.Equals(myBootUp));

//Creates another new computer and passes through Apple, all-in-one, and true as arguments
Computer myOtherComputer = new Computer("Apple", "All-in-One", true);
//Compares the computer and other computer and prints the results to console
Console.WriteLine(myComputer.Equals(myOtherComputer));

//Gives the value of the computers ToString method to a new string variable
string myString = myComputer.ToString();
string myOtherString = myString;

myString = "Hi!";

Console.WriteLine(myString);
Console.WriteLine(myOtherString);

//compares the string variable to the object you used to create it using ToString and print the results to console.
Console.WriteLine(myString == myComputer.ToString());
//compares the string variable to another object and print the results.
Console.WriteLine(myString == myOtherComputer.ToString());

//calls the GetType method on a computer object and print the results to console.
Console.WriteLine(myComputer.GetType());
//Calls GetType on the IBootUp object and print the results to console.
Console.WriteLine(myBootUp.GetType());

//Turns on or off one of the computer objects by calling the PowerOnOff method.
myOtherComputer.PowerOnOff();

Console.WriteLine(myString == myOtherComputer.ToString());
Console.WriteLine(myString);
Console.WriteLine(myOtherComputer.ToString());

//Checks if the string variable contains the letter "i", print the results to console.
Console.WriteLine(myString.Contains('i'));

//Calls ToUpper on the string variable and print the results.
Console.WriteLine(myString.ToUpper());