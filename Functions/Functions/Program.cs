// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Functions
//vvOutput|vvName|  vvInput (parameters)
int SumTwoNumbers(int x, int y) // Parameters are placeholders for the ACTUAL input that will be sent in
{
    // Body of the FUNCTION has ACCESS to the parameters of the function
    int z = x + y;
    return z; // The RETURN keyword KICKS us out of the function call AND "RETURNS" the OUTPUT WITH IT
}

//    vvCalling function|vv arguments
int sum = SumTwoNumbers(2, 3); // order of the arguments passed in the function call, MATTERS, it maps 1:1 with the order of the parameters
int sumTwo = SumTwoNumbers(3, 4);
Console.WriteLine(sum);



string GetUserInput(string userMessage) // parameters are optional
{
    Console.WriteLine(userMessage);
    string userInput = Console.ReadLine();
    return userInput;
}

bool CanLegallyDrink(int age)
{
    return age >= 21;
}

string GetDrinkingMessage(bool canDrink)
{
    if (canDrink)
    {
        return "You can drink, what will you have?";
    }
    else
    {
        return "Get the fuck outta here!";
    }
}

string userInput = GetUserInput("Give me your age!"); // When calling a function, simply Write the name of the function
// followed by paranthesis and any "arguments" the function takes in.

int userAge = int.Parse(userInput);
bool canDrink = CanLegallyDrink(userAge);
string drinkingMessage = GetDrinkingMessage(canDrink);
Console.WriteLine(drinkingMessage);