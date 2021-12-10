// Strings and Things... mostly just strings
// strings are ASCII encoded
using System.Text;

string name = "James";  
Console.WriteLine(name);

// strings are IMMUTABLE
// the values in this STRING CANNOT change!!!
// name[0] = 'c';  <-- cannot be done!

// Anytime we are doing string concat or string inter, we are CREATING
// new STRINGS into memory, brand new strings.
string fullName = $"{name} Jackson";

Console.WriteLine(name);
Console.WriteLine(fullName);


// Other neato ways to create strings!
// call the string constructor to make a repeat of a character
string pattern = new string('*', 10);
Console.WriteLine(pattern); // "**********"

// pass in an array of characters to constructor
char[] helloWorldArray = new []{ 'h', 'e', 'l', 'l', 'o', ' ', 'w', 'o', 'r', 'l', 'd' };
string helloWorld = new string(helloWorldArray);

// joining strings
// string concat
string joinedStringOne = "Hey" + " " + "guys!";

// concat function
string joinedStringTwo = string.Concat("hey", " ", "guys");

// string interopolation, basically madlibs for strings
string joinedStringThree = $"{joinedStringOne} {joinedStringTwo}";


// String Functions! or really, string Methods.  (they are called Methods
// because they are Functions that EXIST inside of the TYPE you are 
// working with!


// string.Equals(..) checks equality against another string AND can
// ignore CASING
// THIS is the PREFERED way to check string equality
if (fullName.Equals("James Jackson", StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("Yep, it's you teacher...");
}

// string.IndexOf() - returns the starting index of your SUB string
//  0123456789
// "James Jackson" -> a substring if this string COULD be "James"
int indexOfJackson = fullName.IndexOf("Jackson"); // the most used version of this
indexOfJackson = fullName.IndexOf('J', 12);

// string.LastIndexOf() - Just like IndexOf, except it starts BACKWARDS
string pizzas = "pizza pizza pizza";
int lastIndexOfPizzas = pizzas.LastIndexOf("pizza"); // 12 because
// that is the LAST index of "pizza", we check from BEHIND not the front

// string.EndsWith() - returns bool for string ENDS with a substring
bool endsWithPizza = pizzas.EndsWith("pizza");


// string.StartsWith() - return bool for string STARTS with substring
bool startsWithPizza = pizzas.StartsWith("pizza");

// string methods that are used more often!
// Split() - splits the string into multiple sub strings, and it splits
// on the provided delemiter, for example, '.', '-', "sup"...

string[] names = fullName.Split();
foreach (var nameVal in names)
{
    Console.WriteLine(nameVal);
}
//                                    0              1
// jamesbmjackson@gmail.com       ["jamesbm...." "gmail.com"]
string emailAddressParts = "jamesbmjackson@gmail.com".Split('@')[1];

// string.Trim()
string spaceyWord = "               sup                ";
string trimmedWord = spaceyWord.Trim();
// "sup"

string rightTrimmedWord = spaceyWord.TrimEnd(); // remove trailing white space
// "               sup"

string leftTrimmedWord = spaceyWord.TrimStart(); // removes starting white space
// "sup                "


// "     hello class, how               are you guys?       "
//"hello class, how               are you guys?"

// string.SubString() - provide an index, and get a substring 
// from that index on, and if you provide a length, it will
// get a sub string of said length.  also, a substring is simply
// a potential string inside of a string
string sentance = "    The quick brown fox jumps over the lazy dog     ";
string quick = sentance.Substring(4, 5);
Console.WriteLine(quick);


// string.Replace() - replace a sub string with another sup string
// putting this here so my console does not close out.
string newSentence = sentance.Replace("quick", "slow");
string dashQuickBrown = sentance.Replace(' ', '-');
Console.WriteLine(dashQuickBrown);

// method chaining
string edited = sentance.Trim().ToLower().Replace("the", "thine");

string trimmedSentence = sentance.Trim();
string loweredCaseSentence = trimmedSentence.ToLower();
string replaceTheWithThineSentence = loweredCaseSentence.Replace("the", "thine");

sentance = "    The quick brown fox jumps over the lazy dog     ";
string trimmedSetenceTakeTwo = sentance.Trim();
string[] wordsFromSentance = trimmedSetenceTakeTwo.Split(' ');

//   
//  "cool" Length = 4
string lastWord = wordsFromSentance[wordsFromSentance.Length - 1];

Console.WriteLine(lastWord);

// String Builder
StringBuilder sb = new StringBuilder();

// simply append strings as many times as you want to the builder
// then ToString() the builder to get the final string result.
sb.Append("sup");

string result = sb.ToString();

Console.ReadLine();