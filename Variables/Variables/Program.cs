// See https://aka.ms/new-console-template for more information


Console.WriteLine("Hello, World!");


// Variable

// assignment operator
int number = 33;


Console.WriteLine(number);


// simple scalar types, or VALUE types
// integer types
int integerExample = 2; // more than likey going to be using this integer the most
long longExample = 22;
short shortExample = 22;
byte byteExample = 22;

// floating point types, decimal types
float floatExample = 22.2f;
double doubleExample = 22.2; // more than likely going to be using this floating point type the most
decimal decimalExample = 22.2m; // isnt actually floating point...

// boolean 
bool isExample = true;

// char
char charExample = 'a';

// Reference Type 
// string
string name = "James";
name = "Jimmy"; // re assign an already existing variable, you DO NOT re declare the TYPE when re assigning a variable.
// name = 23; this code will not run because you cannot reassign a string as a different type 

// constant variable
const double PI = 3.14;

// user input :)

//Console.WriteLine("Hey, give me your name user.... :)");
//string userInput = Console.ReadLine();

//Console.WriteLine(userInput);


Console.WriteLine("Hey user, how old are you?");
string userInputAge = Console.ReadLine();
int age = int.Parse(userInputAge);

Console.WriteLine(age);

// maths...
int x = 1 + 1 - 2 * (1 * 2) / 2;
int ageIncreased = age + 2;


// string concatenation
string combinedAge = userInputAge + 22;

// userInputAge and 22 expression will EVALUATE into a value, and that will be passed into Console.WriteLine()
Console.WriteLine(userInputAge + 22);

Console.WriteLine("Provide your first name...");
string firstName = Console.ReadLine();

Console.WriteLine("Provide your last name...");
string lastName = Console.ReadLine();

// "James Jackson"
string fullName = firstName + " " + lastName;

// string interpolation
string betterFullName = $"{firstName} {lastName}";

Console.WriteLine(fullName);
Console.WriteLine(betterFullName);

// incrementors and decrementors
int y = 5;
y = y + 3;
y += 3;
y = y + 1;
y += 1;
y++;

y -= 1;
y--;

y *= 2;
y /= 2;
y %= 2;

// Casting
// implicit casting
int z = 245;
long a = z;
z = (int)a;

// explicit casting
short b = (short)z;

string c = z.ToString();

// some logical stuff guys... boolean expression
int drinkingAge = 17;
bool canBuyBooze = drinkingAge >= 21;

// if statement
if (drinkingAge >= 21)
{
    Console.WriteLine("Whats your poison heheh.");
}
else
{
    Console.WriteLine("You're not old enough to drink, fuck off!");
}


// relational operators
bool isEqual = drinkingAge == 21; // checks if left operand is EQUAL to right operand
bool isNotEqual = drinkingAge != 21; // checks if left operand is EQUAL to right operand
bool isGreaterThan = drinkingAge > 20; // greater than check
bool isLessThan = drinkingAge < 20; // Less than check
bool isGreatThanOrEqual = drinkingAge >= 21; // greater than or equal to check
bool isLessThanOrEqual = drinkingAge <= 21; // Less than or equal to check

// can only use relational operators on Like types
// bool notGoingToWork = "21" == 21;  THIS CANNOT BE DONE, we cannot compare different types
