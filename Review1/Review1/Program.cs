Console.WriteLine("Hello, World!");



int AddTwoNumbers(int x, int y)
{
    // do logic in your function
    return x + y; // then return your output, this does NOT MEAN WRITE
    // TO THE CONSOLE
}


int x = AddTwoNumbers(1, 2);
int y = AddTwoNumbers(AddTwoNumbers(2, 3), AddTwoNumbers(3, 4));


// I'm ONLY WRITING TO THE CONSOLE AS A CONVENIANCE FOR YOU GUYS
Console.WriteLine(x);


// Lists
// a list is a collection of a single type that is dynamically sized
// a list can grow and shrink, ARRAYS CANNOT

List<string> names = new List<string>();
names.Add("James");
names.Add("Albert");
names.Add("Rachel");
names.Add("Bob");
names.Add("Carson");

List<int> numbers = new List<int>();
numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
numbers.Add(4); 
numbers.Add(5);

foreach (int number in numbers)
{
    Console.WriteLine(number);
}

foreach (string name in names)
{
    Console.WriteLine(name);
}


// if you TRY TO ACCESS an index for an element that does NOT exist
// you will get an index out of range exception, which means your 
// program will crash at runtime.
// how to get the first element out of a list.
string nameOne = names[0];


List<string> otherNamaes = names;


string myName = "James";


void PrintName(string name)
{
    string fullName = name.ToLower();
    Console.WriteLine(name);
}


PrintName(myName);



// exersize time lol
List<string> namez = new List<string>();
namez.Add("James");
namez.Add("Albert");
namez.Add("Rachel");
namez.Add("Bob");
namez.Add("Carson");



Console.WriteLine(squaredNumbers);