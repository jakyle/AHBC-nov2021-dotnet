// See https://aka.ms/new-console-template for more information

// Loops
// While Loop


using System.Text.RegularExpressions;

int i = 1;
while (i < 10)
{
    Console.WriteLine($"I'm while looping {i} time(s)");
    i++;
}

// do- while
i = 11;
do
{
    Console.WriteLine($"I'm Do while looping {i} time(s)");
    i++;
} while (i < 10);


i = 11;

while (i > 0)
{
    Console.WriteLine($"I'm while looping {i} time(s)");
    i -= 2;
}

i = 10;
while (i < 10) 
{ 
    Console.WriteLine($"I'm while looping {i} time(s)");
    i -= 2;
}


int x = 7 % 2; // 1

i = 0;
bool isEven = i % 2 == 0;
while  (i < 10)
{
    // 6       3,  remainder = 1
    // 7 / 2 = 2, remainder = 0
    if (isEven)
    {
        Console.WriteLine("lol I'm even");
    }
    i++;
}


i = 0;
// continue and break
while (i < 10)
{
    if (i == 5)
    {
        break;
    }
    Console.WriteLine("Sup guys!");
    i++;
}

i = 0;
while (i < 10)
{
    if (i % 2 == 0)
    {
        int j = 0;
        while (j < 10)
        {
            if (j == 5)
            {
                break;
            }
            Console.WriteLine("good look figuring out how many times I print");
            j++;
        }
    }
    i++;
}


i = 0;
while (i < 10)
{
    i++;
    if (i % 2 != 0)
    {
        continue;
    }
    Console.WriteLine("I printed dude");
}

// for loop ➰

// 0. initialize your index variable. WE ONLY DO THIS ONCE
// 1. check boolean expression to see if we loop again, if false, BREAK from loop
// 2. run the body of the loop
// 3. either increment OR decrement index
// 4. repeat steps 1 - 4
for (int index = 0; index < 10; index++)
{
    Console.WriteLine($"I've looped {index+1} times.");
}

int sum = 0;
for (int index = 0; index < 10; index++)
{
    // sum = sum + index;
    sum += index;
    Console.WriteLine($"I've looped {index + 1} times.");
}


int totalEvenNumbers = 0;
for (int index = 0; index <= 36; index+=2)
{
   totalEvenNumbers++; 
}
Console.WriteLine(totalEvenNumbers);

//               01234
string vowels = "aeiou";
for (int index = 0; index < vowels.Length; index++) 
{
    char letter = vowels[index];
    Console.WriteLine(letter);
}



// Foreach loop
foreach (char vowel in vowels)
{
    Console.WriteLine(vowel);
}

Console.WriteLine("Give us a word!");
string userInput = Console.ReadLine();  // taco

var vowelCount = new Regex(@"[aeiouAEIOU]+").Matches(userInput).Count();

//int vowelCount = 0;  // taco 
foreach (char letter in userInput)
{ 
    // vowelCount = vowelCount + leter switch {...;
    vowelCount += letter switch
    {
        'a' or 'e' or 'i' or 'o' or 'u' => 1,
        _ => 0,
    };
}

Console.WriteLine(vowelCount);

