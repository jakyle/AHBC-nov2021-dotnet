// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] numbers = { };



int TryGetPositiveNumber(string message)
{
    while(true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out int number) && number > 0)
        {
            return number;
        }
    }
}

try
{
    // int x = TryGetPositiveNumber("Hey, please enter a positive number");
    FirstFunctionCall();

}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine($"Index is out of range friend....{ex}");
}
catch(FormatException ex)
{
    Console.WriteLine("Oooo, you tried to get a numbet of of something that isn't a number, tsk tsk.");
}
catch(Exception ex)
{
    ex.GetType();
    Console.WriteLine($"oh oh, you had an accident! {ex.StackTrace}");
}
finally // in your try catches, the finally block will ALWAY run AFTER your trys and catches.
{
    Console.WriteLine("I will ALWAYS run! all the time, if you get an exception or if you don't!");
}


// Debugging / Stack Trace - a "Stack" of function calls, the debugger/ program keeps
// track of ALL functions being called.
void FirstFunctionCall()
{
    int x = 2;
    int y = 3;

    
    Console.WriteLine($"{nameof(FirstFunctionCall)}");
    SecondFunctionCall();
}

void SecondFunctionCall()
{
    Console.WriteLine($"{nameof(SecondFunctionCall)}");
    ThirdFunctionCall();
}

void ThirdFunctionCall()
{
    Console.WriteLine($"{nameof(ThirdFunctionCall)}");
    throw new ArgumentOutOfRangeException("OH oh, stack trace time!");
}

// Placing Readline here so my console does not close
Console.ReadLine();


