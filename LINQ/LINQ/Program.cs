using System.Linq;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<string> namez = new List<string>();
namez.Add("James");
namez.Add("Albert");
namez.Add("Rachel");
namez.Add("Carson");
namez.Add("Bob");
namez.Add("Leon");
namez.Add("Corn");


// LINQ "Where" implemented yourself
// This is a LOOP that is FILTERING OUT elements you DO NOT WANT
// or another way to look at it, is to FILTER to WHAT WE DO WANT
List<string> evenNames = new List<string>();
foreach (string name in namez)
{
    if (name.Length % 2 == 0)
    {
        evenNames.Add(name);
    }
}

List<int> numberz = new List<int>();
numberz.Add(1); // index 0
numberz.Add(2); // index 1
numberz.Add(3); // index 2
numberz.Add(4); // index 3
numberz.Add(5); // index 4

// Linq "Select" implemented yourself
// we are Mapping our Elements to a NEW form of our element
// f(a) -> f(b)
// here we are taking  data A and TRANSFORMING IT into B
// where A is your initial data, and B is what you are transforming
// A INTO.
List<int> squaredNumbers = new List<int>();
foreach (int number in numberz)
{
    int squaredNumber = number * number; // B in this context is your number squared
    squaredNumbers.Add(squaredNumber);
}


// using Linq to filter out data.
List<string> evenNamez = namez.Where(name => name.Length % 2 == 0).ToList();

// using Linq to transform each element, from A -> B
List<int> squaredNumberz = numberz.Select(number => number * number).ToList();

List<string> finalNames = namez
    .Where(name => name.Length % 2 == 0)
    .Select(name => name.ToUpper())
    .OrderBy(name => name)
    .ToList();

Console.WriteLine(finalNames);

string[] namesArray = { "James", "Wendy", "Anna" };

IEnumerable<string> finalNamesEnemerable = namesArray
    .Where(name => name.Length % 2 == 0) // does not loop
    .Select(name => name.ToUpper()) // does not loop
    .OrderBy(name => name) // does loop
    .ToList(); // this does loop

// Linq is a collection of Helper Methods that work on 
// IEnumberable.  IEnemerable is simply a TYPE that can
// be LOOPED over, or Iterated over. example types that 
// implement IEnumerable: List<T>, Arrays, Dictionaries, 
// Stacks, Queues, Sets... etc. etc. most Collections.

// there are THREE type of Linq Functions, a DEFERRED execution
// and and Non DEFERRED EXECUTION, and AGGREGATORS.

// in the context of Linq, Lazy evaluated functions will NOT 
// make your collection Iterate (loop) until it's TOLD
// to loop.


// example lazy evaluated linq functions, Select(), Where(), 
// GroupBy, Reverse, ThenBy

// example Aggregators, Min(), Max(), Sum(), Any(), All()
// FirstOrDefault(), LastOrDefault()
// Aggregators will Aggregate into a single value, not a new collection
List<int> numberzz = new List<int>();
numberz.Add(1); // index 0
numberz.Add(2); // index 1
numberz.Add(3); // index 2
numberz.Add(4); // index 3
numberz.Add(5); // index 4
// int sumOFNumbers = numberzz.Sum(); // Sums all values in IEnumerable
numberz.Add(1); // index 0
numberz.Add(2); // index 1
numberz.Add(3); // index 2
numberz.Add(4); // index 3
numberz.Add(5); // index 4

// int MaxNumber = numberzz.Max();// gets the highest value in IEnumerable
numberz.Add(1); // index 0
numberz.Add(2); // index 1
numberz.Add(3); // index 2
numberz.Add(4); // index 3
numberz.Add(5); // index 4

// int minNumber = numberzz.Min(); // gets the lowest value in IEnumerable
numberz.Add(1); // index 0
numberz.Add(2); // index 1
numberz.Add(3); // index 2
numberz.Add(4); // index 3
numberz.Add(5); // index 4

// Any() returns a boolean, if Any has no argumements, it simply
// checks if there are any elements in the collectiont
if (numberzz.Any()) // Any without any arguments simply checks if 
    // your IEnumerable contains elements.
{
    Console.WriteLine("I have numbers!");
}
numberz.Add(1); // index 0
numberz.Add(2); // index 1
numberz.Add(3); // index 2
numberz.Add(4); // index 3
numberz.Add(5); // index 4

// Any() with a predicate, or a function, you pass in your boolean 
// expression, and if ANY of the elements is TRUE for your condition
// the entire result is true. in other words, only ONE element needs
// to evaluate to true in order for ANY(...) to return true.
if (numberzz.Any(x => x > 4))
{
    Console.WriteLine("yep, theres a number greater than 4 in here!");
}
numberz.Add(1); // index 0
numberz.Add(2); // index 1
numberz.Add(3); // index 2
numberz.Add(4); // index 3
numberz.Add(5); // index 4


// All(), ALL ELEMENTS HAVE TO PASS THE CONDITION in order for 
// for All() to return true
if (numberzz.All(x => x % 2 == 0))
{
    Console.WriteLine("All numbers are even");
}
numberz.Add(1); // index 0
numberz.Add(2); // index 1
numberz.Add(3); // index 2
numberz.Add(4); // index 3
numberz.Add(5); // index 4

// FirstOrDefault(), returns the FiRST element, IF the element does NOT 
// exist, you will get the DEFAULT value of that type instead.
// FirstOrDefault is the PREFERRED WAY to get the first element, why?
// because it will NOT crash your app, because if the element does NOT
// exist, you will simply get a default value instead, and ALL types
// have a default value, where Reference types is Null, value types
// depends on the value type itself.
string firstNameInNames = namez.FirstOrDefault();

// there is a First() method... avoid it like the plague
firstNameInNames = namez.First(); // never use this guy, use FirstOrDefault();

string lastNameInNames = namez.LastOrDefault(); // gets the last element... or default value

// Including this so my COnsole does not close out

// STrings are an IEnumberable<char>, this means you can use
// some linq methods on strings.
string james = "James".Where(x => x == 'a').ToString();


// you can write Linq using the "Query Syntax"
IEnumerable<int> scoreQuery =
    from number in numberzz // your "for each loop.... foreach (int number in numberzz)
    where number % 2 == 0 // the Where() method...
    select number * number; // the Select Method() ...

//        4
int z = 2 + 2;

//              true
bool isTrue = 10 > 5;

// Lambda expressions
// a A lambda expression is just a function.. just a FUNCTION
// a lambda expression does not need to have it's type declared, 
// it will be inferred by the function using it.
// lambda expression are often USED as call back functions
// in the example below, the letter 'c' is the parameter for
// this lambda expression, where a lambda expression is JUST 
// A FUNCTION.  the '=>' is the Arrow for your lambda expression, 
// the Arrow is POINTING to the BODY of your function. the body
// of your lambda expression can either be ONE LINE OF CODE OR
// an entire BLOCK of code with a return statement. if it's ONE
// LINE OF CODE, it's implied whatever expression is being evaluated
// will be it's return type.
string example = "Albert".Where(c => c == 't').ToString(); // the function (c => c == 't') is an argument for the Where() function
string exampleTwo = "James".Where(c =>
{
    return c == 'm';
}).ToString();


string exampleThree = "Rachel"
    .Where( /* parameter */ c /* arrow pointing to body*/=> /* implied return expression */ c == 'R').ToString();

// call back functions is a Function that is PASSED INTO FUNCTION A as an ARGUMENT (parameter)
// for FUNCTION A.

//                      type Func is a function... first generic is the parameter type, second is the return type
IEnumerable<char> MyWhere(string name, Func<char, bool> fn)
{
    List<char> filteredLetters = new List<char>();
    foreach (char letter in name)
    {
        if (fn(letter))
        {
            filteredLetters.Add(letter);
        }
    }

    return filteredLetters;
}

IEnumerable<char> filteredLetters = MyWhere("James", c => c == 'a');

Console.ReadLine();