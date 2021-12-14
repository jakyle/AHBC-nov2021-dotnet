// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//    vvCalling function|vv arguments
int sum = SumTwoNumbers(2, 3); // order of the arguments passed in the function call, MATTERS, it maps 1:1 with the order of the parameters
int sumTwo = SumTwoNumbers(3, 4);
Console.WriteLine(sum);

// Functions
//vvOutput|vvName|  vvInput (parameters)
int SumTwoNumbers(int x, int y) // Parameters are placeholders for the ACTUAL input that will be sent in
{
    // Body of the FUNCTION has ACCESS to the parameters of the function
    int z = x + y;
    return z; // The RETURN keyword KICKS us out of the function call AND "RETURNS" the OUTPUT WITH IT
}

/// <summary>
/// /////////////////////////////////
/// </summary>
string GetUserInput(string userMessage) // parameters are optional
{
    Console.WriteLine(userMessage);
    string userInput = Console.ReadLine();
    return userInput;
}

bool CanLegallyDrink(int userAge)
{
    // passing in an age that will check for an inaquality
    // that will determine if the user can drink or not
    if (userAge > 20)
    {
        return true;
    }
    else
    {
        return false;
    }
}


// a string is anything wrapped in double quotes, ie. "sup guys" <--- this is a string
string GetDrinkingMessage(bool canDrink)
{
    if (canDrink)
    {
        return "You can drink if you want to, you can bring your friends along!";
    }

    return "um, you can't drink... get outta here!";
}  // <--- defining the INPUT for our function 

// the actual program ""
string userInput = GetUserInput("Give me your age!"); // When calling a function, simply Write the name of the function
// followed by paranthesis and any "arguments" the function takes in.


// step 1   
// step 2
// step 3
//
//
//
int userAge = int.Parse(userInput);
bool canDrink = CanLegallyDrink(userAge);
string drinkingMessage = GetDrinkingMessage(canDrink);
Console.WriteLine(drinkingMessage);
////
///
// Validation Functions


int GetValidPositiveNumber(string messageForUser)
{
    while (true)
    {
        string userInputTwo = GetUserInput(messageForUser);

        if (int.TryParse(userInputTwo, out int age) && age > 0)
        {
            return age;
        }

        Console.WriteLine("Invalid age");
    }
}

// Recursion... is it confusing? fair... moving on
int CallMySelfAgain(int number)
{
    if (number <= 0)
    {
        return 0;
    }

    return CallMySelfAgain(number - 1);
}


// FUnction OUT parameter
// out parameter is an ADDITIONAL parameter assigned to your 
// function definition, the entire point of the out parameter
// is to provide additional OUTPUT for your function.  however
// only use this in a TryGet pattern if you can.
// YOU HAVE to assign your out parameter a VALUE in all 
// valid code paths to finish the function, JUST like
// the return keyword
bool TryGetLegalDrinkingAge(string userInput, out int age)
{
    if (int.TryParse(userInput, out int parsedAge) && parsedAge >= 21 && parsedAge < 150)
    {
        age = parsedAge;
        return true;
    }

    age = -1;
    return false;
}

if (TryGetLegalDrinkingAge("23", out int age))
{
    Console.WriteLine(age);
}
else
{
    Console.WriteLine("get ouuta here");
}











