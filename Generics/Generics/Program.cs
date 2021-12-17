// See https://aka.ms/new-console-template for more information

// Generics
// place hodlers for the type you end up supplying when calling 
// the class or function

// functions

// the T in the angle brackets is NOT NOT NOT a parameter
// it is a PLACEHOLDER for the TYPE that YOU will supply
//
// how does it work? you simply add angle brackets AFTER the name of your 
// function, and you place a "place holder word or leter or whatever, the 
// placeholder does NOT matter, by convention, most developers will start
// with T, which stands for Type.  the text you put inside the angle brackets
// is NOT a TYPE, is a a PLACEHOLDER FOR A TYPE when you CALL THIS FUNCTION
//
// when you call this function now, if it's not inferred, you place the type
// that you want to replace for T.
// When the function is called AND YOU PROVIDE YOUR TYPE, when compiled, the
// Place holder generic or "T" will be replaced by your actual Type ANYWHERE
// your generic text is being used
//
// you can reference your generic placeholder anywhere in your function, inluding,
// your type for your parameter(s) and variables inside the function body, and
// event the return type.
void WriteToConsole<T>(T type)
{
    Console.WriteLine(type);
}


// in this case, anwhere T is being used in hte WriteToConsole FUnction, it will
// be replaced with "int" BECAUSE that is the TYPE YOU ARE SUPPLYING to replace
// the generic placeholder.
WriteToConsole<int>(23);

// you can have AS MANY GENERICS AS YOU WANT!
void WriteTwoThingsToConsole<T, U>(T paramOne, U paramTwo)
{
    Console.WriteLine(paramOne);
    Console.WriteLine(paramTwo);
}

// the moment you CALL your generic function, is the moment your generics
// will 100% be replaced by YOUR Provided TYPES at runtime.
WriteTwoThingsToConsole<string, int[]>("James", new int[]{1, 2, 3, 4});


// Generic Constraints
// Add "Constraints" to the Type you can actually pass into the
// function.
bool CompareTwoThings<T>(T paramOne, T paramTwo) 
    where T : class
{
    return paramOne == paramTwo;
}
