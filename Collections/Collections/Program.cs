// See https://aka.ms/new-console-template for more information
using System.Drawing;

Console.WriteLine("Hello, World!");


// Arrays... jk not yet, Ref type vs Value Type!

// Value type in C# is any type that is a "Struct" as opposed to a "class"
int number = 3;
bool isTrue = true;
DateTime rightNow = DateTime.Now;

// ALL types have a default value, VALUE types have a SET default value.
// for number types, it will always be Zero
// rule of thumb, the default set value for value types will be values
// that is close to "nothing"

// pretty much any number types, some types that ONLY contain numbers
// and DateTimes, AND any STRUCTS YOU create, is a Value Type.

// how do value types work, and why do we care?
// Value types use whats called copying semantics.
int x = 5;
int y = x;  // COPYING the RAW VALUE of X and storing it into Y

x += 2; // We are changing the value of x, also, Y maintains it's original
// COPIED value

Console.WriteLine($"x: {x}");
Console.WriteLine($"y: {y}");

int z = TakeMyNumber(y);

Console.WriteLine($"y: {y}");
Console.WriteLine($"y: {z}");



int TakeMyNumber(int x) // don't write a function that does this...
{
    x += 2;
    return x;
}

// Arrays for real this time

// arrays are a static collection of a certain type
// by static I mean they are of FIXED length, which means once
// you create an array into memory, the SIZE of that array 
// can NEVER change, it is ALWAYS that size. 
// by a certain type, I mean an array can only hold, one type.
// Arrays are just that, an array of "things" or that type.
// an Array is the most BASIC collection type you can work with.
char[] letters = { 'a', 'b', 'c' }; // this array is of Length 3, this cannot change

// how do we access the things inside of an array?
// Arrays (or any NON hashed - collection frankly) are zero indexed
// each element will be stored in the array at an assigned index.
// think of the index as an address to access that element in that array
// zero-index means the First element in said collection will start
// at index 0

// this is how you GET an element out of an array
char letterAtIndexOne = letters[1];

// this is how you SET an element in an array at a defined index
letters[1] = 'd';

// this will give you an Index Out of Range exception (error)
// which means you tried to access an element at an INDEX that 
// DOES NOT exist.
// char letterAtIndexThree = letters[3];


// You CANNOT SET a value at the given index IF that index is also
// out of range.
// letters[3] = 'e';

//         indexes       0    1    2
char[] otherLetters = { 'x', 'y', 'z' }; // elements can only be characters
// an element is simply an item in an array

// this is how you can combine two arrays together, keep in mind though
// this WILL GIVE YOU A BRAND NEW ARRAY, BECAUSE arrays are of 
// static length. which means they CANNOT increase or decrease
// in size.
char[] combinedLetters = letters.Concat(otherLetters).ToArray();


// IF you are working with a collection... you are probably going to 
// loop (enumerate.. more on that later, heh heh heh) in order
// to READ or SET the values in that collection.
foreach (var letter in combinedLetters)
{
    Console.WriteLine(letter);
}

// other ways to create array;
int[] numbers = { 1, 2, 3, };  // assign with only curly brackets.
int[] otherNumbers = new[] { 1, 2, 3 }; // include the new keyword with brackets
int[] finalNumbers = new int[4] { 1, 2, 3, 4 }; // include new keyword, with type, and Length number
int[] arrayWithDefaultValues = new int[4]; // declared set length array WITH default values.

int elementAtIndexThree = arrayWithDefaultValues[3];
foreach (int num in arrayWithDefaultValues)
{
    Console.WriteLine(num);
}



// Reference Types!!!
// Reference types, the variables owns a REFERENCE to the value, NOT 
// the actual VALUE itself.
string[] names = { "James", "Wendy", "Anna" }; // names is a REFERENCE
// to this array, NOT the actual array in memory.


// if you assign a new variable to a reference type, BOTH variables are 
// POINTING to the exact same Value in memory.
string[] otherNames = names;

// think of a reference type to an ADDRESS to the actual value in memory.
// that means when you ASSIGN a NEW variable with a reference type,
// you are ACTUALLY copying the ADDRESS, however, BOTH addresses
// STILL POINT to the same value in memory.

Console.WriteLine(names[0]);
Console.WriteLine(otherNames[0]);

otherNames[0] = "Bob";

Console.WriteLine(names[0]);
Console.WriteLine(otherNames[0]);

// Classes are Reference types, Structs are Value types

// default value for ALL reference types is NULL.
// The REASON all REFERENCE types default value is NULL, is because
// a reference type POINTS to a value in memory.  IF There is 
// NOTHING TO POINT TO, there is NOTHING in MEMORY, Therefore,
// the value is null
string IFailed = null;


// how to null check... NULL CHECK ALL THE REFERENCE TYPES
if (IFailed == null)
{
    IFailed = "sup";
    
}

char firstLetterInIFailed = IFailed[0];
Console.WriteLine(firstLetterInIFailed);


string definedName = "James";
string otherDefinedName = "Bob";

void ReadMyName(string name)
{
    foreach (var letter in name)
    {
        Console.WriteLine(letter);
    }
}

int[] totallyOriginalNumbers = new int[5] { 1, 2, 3, 4, 5 };
void ReadMyNumbers(int[] numbers)
{
    foreach (var num in numbers)
    {
        Console.WriteLine(num);
    }
}

// array lenghts can be defined elsewhere, it does not have to be 
// a developer defined length
//int userInput = int.Parse(Console.ReadLine());
//int[] someDatOkay = new int[userInput];


ReadMyName(definedName);
ReadMyName(otherDefinedName);
ReadMyNumbers(totallyOriginalNumbers);
ReadMyNumbers(numbers);


// some examples and exersises
void ModifyElement(int[] numbers)  // Parameters ARE LIKE VARIABLES, therefore if it's a refernce type, it STORES the reference
{
    numbers[0] = 9;
}

//                        0  1  2  3  4
int[] modifyMeCaptain = { 1, 2, 3, 4, 5 };

ModifyElement(modifyMeCaptain);

Console.WriteLine(modifyMeCaptain[0]);


int SumOfAllInts(int[] numbers)
{
    // For loop, the developer has to pull out the element 
    // out of the collection themselves
    for (int i = 0; i < numbers.Length; i++)
    {
        // getting the element at index 'i' and storing it
        // into the variable number
        int number = numbers[i];
    }

    int sum = 0;
    // { 8, 3, 5, 7, 13 }
    // foreach loop, loops over each element, and stores
    // the CURRENT element in the defined variable in the 
    // for each loop for you. in other words, number will 
    // be the CURRENT element being looped over, ie, 8, or 5
    foreach (int number in numbers)
    {
        sum += number;
    }

    return sum;
}

int[] listOfInts = { 1, 2, 3, 4, 5};
int sum = SumOfAllInts(listOfInts);
Console.WriteLine(sum);


// Generic Collections

// List
// A list is Dynamically sized collection of one single type
// Which is to say a List can shrink or Grow (When Googling, a List is
// called a Vector in other languages, like c, c++, Rust, Haskell)
// in javascript they are called Arrays.
// This is BY FAR THE MOST USED Collection withen the dotnet ecosystem
// especially in web development, List is the most preferred data structure

// the '<' '>' brackets are GENERIC brackets, which means YOU the dev
// needs to state the TYPE you want to use, ie, a List<int>, List<string>..
// in the case for list, literally ANY type can be placed in the 
// brackets
List<string> namesList = new List<string>();

// you can elements to a list as much as you want
// when ADDING an element, you are actively INCREASING the COUNT of 
// your list
namesList.Add("James");

// like an array, you can Access elements using bracket / index notation
string myName = namesList[0];

// LIst do NOT have a LENGTH property associated with it, in order to
// figure out how many elements exist inside of a List, you call the
// .Count property instead
Console.WriteLine($"My names List contains {namesList.Count} elements");

// you can also remove an element from a List, which will decrease 
// it's Count
namesList.Remove("James");

namesList.Add("Jimmy");

// changing the value at a specified index does NOT increase the count of
// a list, you are simply modifying an existing index element.
namesList[0] = "James";

foreach (string name in namesList)
{
    Console.WriteLine(name);
}


int VowelCount(List<string> words)
{
    int sum = 0;
    string vowels = "aeiou";
    // {"Dog", "Cat", "Mouse"}
    foreach (string word in words)
    {
        foreach (char letter in word)
        {
            if (vowels.Contains(letter))
            {
                sum++;
            }
        }
    }

    return sum;
}


// this is called List Literal, or Literal expression, essentially
// we are creating a new List with starting "data". also known as
// Object initilization syntax.
List<string> animals = new List<string> { "Dog", "Cat", "Mouse" };
List<string> otherAnimals = animals;
int vowelsInAnimals = VowelCount(animals);
Console.WriteLine(vowelsInAnimals);

// Dictionary 
// A dictionary is a collection of Key Value Pairs, where you the developer
// assigns a Key, which is the Lookup for your Value


// Dictionaries are used for lookups, if you happen to have the Key, you then
// look up your value with that key.  Dictionaries are collections you RARELY want
// to loop over.  WHy is this? because they are NOT NATIVELY Loopable.

// behind the scenes, a Dictionary is a Hash Table. (google it)
// the main reason we use dictionaries is because they are extrmely fast at looking
// up key values.

// Dictionaries Like List are dynamic in size. you can continue to add key values
// to a dictionary.

// Keys are UNIQUE... let me repeat that, KEYS ARE UNIQUE, which means, you can 
// ONLY have one key for a value

// when creating a dictionary, the Key is "usually" going to be an enum or 
// a string, value.. skies the limit
Dictionary<string, string> classDictionary = new Dictionary<string, string>();

// the Key here is "James", the Value is WHAT is being assigned to that "Key"
classDictionary["James"] = "Instructor for the AHBC Dotnet class";
// There can ONLY be One key of that value in a dictionary
classDictionary["James"] = "A big doo doo head";
classDictionary["Bob"] = "A student in the AHBC Dotnet class, works for the FOC";

// classDictionary.Add("James", "lol jk, he's the instructor again");

// to get a value, is just like getting a value in an array or list, except you do 
// not provide an index number, you provide the key!
string personDescription = classDictionary["James"];

string otherPersonDescription = classDictionary["Albert"];

// defensively get and set data in your dictionary
// this will ONLY add this Key Value IF the key does NOT exist already
if (!classDictionary.TryAdd("James", "lol jk he's an instructor again"))
{
    Console.WriteLine("Hey, this key James already exist, cannot overwrite key value");
}

// how to get a value from a dictionary by Key Safely, you can Try and Get
// the value by key, if the key value does not exist, TryGetValue will
// return false
if (classDictionary.TryGetValue("James", out string instructorDescription))
{

}



// This only exist so my program does not close
Console.ReadLine();