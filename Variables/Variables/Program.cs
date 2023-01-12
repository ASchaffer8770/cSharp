// See https://aka.ms/new-console-template for more information

/*
int x;
int y;

x = 7;
y = x + 3;
Console.WriteLine(y);
*/

//var myFirstName = "Alex";

//myFirstName = "Alex";

//Console.WriteLine(myFirstName);

int x = 7;
//string y = "Alex";
string y = "5";
string myFirstTry = x.ToString() + y;

//int mySecondTry = x + y;
int mySecondTry = x + int.Parse(y);


Console.WriteLine(mySecondTry);

Console.ReadLine();