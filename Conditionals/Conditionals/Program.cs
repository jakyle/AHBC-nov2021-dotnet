// See https://aka.ms/new-console-template for more information

// LOGIC... AGAIN
// Boolean Expression.

int summedNumber = 2 + 2;

int age = 21;
bool canDrink = age >= 21;

if (age >= 21)
{
    Console.WriteLine("You can order a drink");
}
else if (age >= 18)
{
    Console.WriteLine("You cannot drink... but you can vooooote!!!");
}
else
{
    Console.WriteLine("You cannot vote or drink... :(");
}

Console.WriteLine("sup");

// Relational Operators compares two operands to evaluate an expression to either true or false
bool isEqual = age == 21; // checks if left operand is EQUAL to right operand
bool isNotEqual = age != 21; // checks if left operand is EQUAL to right operand
bool isGreaterThan = age > 20; // greater than check
bool isLessThan = age < 20; // Less than check
bool isGreaterThanAndEqualTo = age >= 21; // greater than or equal to check
bool isLessThanOrEqual = age <= 21; // Less than or equal to check

// Logical Operators, allows you to combine multiple Realtional boolean expressions or signle booleans together
// to create a much larger or complex Boolean Expression
bool hasClubId = true;
// age is 21
bool canDrinkAndHasClubId = age >= 21 && hasClubId; // && (AND), left side AND right side of the AND operator MUST evaluate to TRUE
bool canDrinkOrHasClubId = age >= 21 || hasClubId; // || (OR), Left side OR right side of the OR operator MUST be true in order for the entire expression to be true
bool canNotDrink = !isEqual; // ! (NOT), gives the OPPOSITE of the current boolean expression.

//opposite  (true       true)  
if ( !(age >= 21 && hasClubId) 
    || hasClubId 
    && age >= 18 && !hasClubId)
{
    Console.WriteLine("ain't gonna happen");
}


// Terenary operator

// syntactic sugar for this if statement below
string message; // This is an Instantiated/declaring variable, you can ONLY assign something to it, otherwise it CANNOT be used.
if (age >= 21)
{
    message = "You can order a drink";
}
else
{
    message = "ain't gonna happen";
}
//    Boolean expression      Truthey Value         Falsey Value
string newMessage = age >= 21 
    ? "You can order a drink"
    : "ain't gonna happen chump";


// AVOID THIS... THis is a complex Ternary operator, as long as your expressions evaluate to the type your Variable is ASKING for, then you can do it, however, think about readibility FIRST
string otherMessage = age >= 21
    ? age >= 30
        ? "You can vote at least!... just not drink"
        : "2"
    : age >= 18
        ? "You can vote at least!... just not drink"
        : "3";

Console.WriteLine(message);

// switch statement
// syntactic sugar for the if statement below
if (age > 26 && age < 71)
{
    Console.WriteLine("You're insurance goes down");
}
else if (age == 21)
{
    Console.WriteLine("You can legally drink and smoke");
}
else if (age == 18)
{
    Console.WriteLine("You can Vote");
}
else
{
    Console.WriteLine("You're just a baby boy/girl");
}

// the switch case
switch (age)
{
    case >= 26 and < 79:
    {
        Console.WriteLine("You're insurance goes down");
        break;
    }
    case 21:
    {
        Console.WriteLine("You can drink and smoke");
        break;
    }
    case 18:
    {
        Console.WriteLine("You can vote.");
        break;
    }
    case 15 or 13:
    {
        Console.WriteLine("You are a teenager haha");
        break;
    }
    default: break;
}


// pattern mathching
// pattern matching is an expression, at run time, one of your arms will be returned to who ever is calling it, ie. a variable
string patternMessage = age switch
{
    > 26 and < 79 => "you pretty much has all of your privelages...",
    21 => "You can drink",
    18 => "you can vote",
    > 13 and < 18 => "You are a teenager",
    < 13 => "you are a child...",
    _ => "... you are of an age I guess (っ °Д °;)っ"
};