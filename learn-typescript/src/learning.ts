import './style.css' //<-  we will talk about modules later

// Variables
// let variable, the let keyword declares a variable that can be changed later on. (Typescript: you have to 
// adhere to the original type. Javascript: you can change the type if you re-assign the variable)
// "let variables" are mutable, the data in the variable CAN be changed
let name = "James";
name = "John";
// name = 2; cannot be done, like C#, once a variable is given a type, that variable
// is always that type.


// C# 
/// string name = "James";
// name = "John";


// const variables are IMMUTABLE, which means when you declare / assign them, the value
// of said variable CANNOT be changed (true for both javascript and typescript)
const age = 33;


// C# constants are KNOWN at compile time. js/ts constants are not known at compile time
// and can be assigned at run time.
const otherAge = age;


// Type annotations
// in typescript, you can exlicitly declare the type of a variable. with 
// the syntax below.  this is only required IF you are not assigning the variable
// on the same line.
let otherName: string = "James";

// var type, this is DEPRICATED, you will see examples of var being used throughout the web,
// but this is the OLD way of declaring variables in javascript/typescript.
// var is just like let, it's a mutable variable, however, var is ALWAYS hoisted to the 
// global scope.  var is DEPRICATED.
var otherNameTwo = "also James";
// we will NOT be using var in this class, just know it exist

// the most preferred variable declaration type to use is "const" the only time you use "let"
// is if YOU plan on changing the value of said variable.


// SIMPLE types in typescript
const num: number = 2;  // the number type (all numbers are "doubles" in js/ts)
const str: string = "James"; // no chars, only strings
const firstCharString = str[0]; // you will be capturing a "string" not a "char"
const isBool = true; // booleans are exactly the same in js as in c#


// two null simple types
const nullVal = null; // null is just like c#s null, it means the memory location is empty
const undefinedVal = undefined; // undefined is like null except this means the VARIABLE ITSELF does not exist...


// complex types in ts/js

// Arrays, just like Lists in C#
// arrays are dynamically sized collection of a certain type, EXACTLY how LISTS are in C#
const numArr: Array<number> = [1, 2, 3];
const names: Array<string> = ["James", "John", "Joe"];

// C# equivalent ->   var numList = new List<int>() {1, 2, 3};


// objects,  will talk about how to interact with objects later below.
const person = {
  name: "James",
  salary: 180_000, // underscore makes large numbers more readable for the programmer, underscore is like a ","
  age: 33,
  isMarried: true
}

// JSON objects, property names are strings, in js/ts, you do NOT have to make the property names
// strings.
// {
//  "name": "James",
//  "salary": 180000,
//  "age": 33,
//  "isMarried": true
//}

// CONTROL FLOW, if statments and loops and shit
// equality operators
// == equals non strict <- never use this guy
// === (three equal signs) strict equality, which will check for both "value" and "type", ONLY use this 
// operator for equality checks  

// > greater than
// < less than
// >= greater than or equal to
// <= less than or equal to 
// != not equal, not strict <- never use this guy
// !== Strict inequality, ie. does NOT equal <- ALWAYS prefer to use this guy

// Logical Operators
// these guys work EXACTLY the same as they do in C#
// && <- AND
// || <- OR
// ! <- NOT

if (age > 21) {
  // console log is just like C#s, Console.WriteLine(...);
  console.log("you are old enough to drink!");
} else {
  console.log("You are not old enough to drink!");
}

const message = age > 21
  ? "you are old enough to drink!" 
  : "You are not old enough to drink!";


// assignment operators
// += <- add and assign
// -= <- subtract and assign
// *= <- multiply and assign
// /= <- divide and assign
// exact same functionality as C#
let i = 2;
i += 2; // i = i + 2;
i++; // i = i + 1;

// LOOPS

i = 0;
// guess what.... While loops behave EXACTLY the same as C# while loops
while (i > 10) {
  console.log(i);
  i++;
}


//do while loop is the same as C# do while loops
i = 0;
do {
  console.log(i);
  i++;
} while (i > 10);

// for loops, works exactly the same as C# for loops, literally no difference
for (let idx = 0; idx < numArr.length; idx++) {
  const element = numArr[idx];
}

// two ways to handle the so called c# foreach loop in TS/JS,
numArr.forEach(x => console.log(x));  // this is kind of like the foreach loop in C#, difference is,
// we are using a built in function that exist on js/ts arrays, think of the Select in linq, except it is
// NOT returning A-> B, it's just doing reading A, and returning nothing else
// this is the older way to "foreach" loop

// the second way to C# foreach loop is to use a "for of" loop


// this behaves almost exactly like the C# foreach loop.
// use this loop most of the time
for (const num of numArr) { // you can use a const here because the variable is being recreated each time it loops
  console.log(num);
} // <- USE THIS KIND OF LOOP 99% OF THE TIME!!!


// foreach (var num in numArr)
// {
//   Console.WriteLine(num)
// }


// not to be confused with a "for in" loop
// for in loops will loop over the objects PROPERTY names, not the value, if you are for
// in looping over an array, the property will be the index value instead
// [2, 4, 6]
for (const num in numArr) {
  console.log(num); // 0, 1, 2
}


// OBJECTS, lets start famalliar first...
// OOP in typescript.. .which looks almost exactly like C# OOP


// in typescript, the default access modifier is PUBLIC, in C# it's private by default
class Dog {
  constructor(public name: string, public age: number) {} // you can use public, private, or protected, by
  // using the access modifiers in the constructor, it will inline CREATE properties automatically for you,
  // as opposed to manually creating properties.

  public bark() { // you do NOT have to explicitly type in the return type, it is implied within the function
    return "woof woof!";
  }

  public makeNoise(): string {
    return "bark bark!";
  }

  public static growl() {
    return "grr";
  } // static methods are like C# static methods, they are not attached to a specific object
}

// C# equivalent of creating a class
// public class Dog 
// {
//   public string Name {get; set;}
//   public int Age {get; set;}

//   public Dog(string name, int age) 
//   {
//     Name = name;
//     Age = age;
//   }
// }

// creating an object derived from a class in memory.

// only TS will complain about this
const dog = new Dog("Coco", 2);
dog.age = 3;
console.log(dog.age);
console.log(dog.bark());


class Poodle extends Dog { // this is inheritance, works just like C# inheritence
  constructor(name: string, age: number, public color: string) {
    super(name, age); // "super" is like C#s "base" keyword, refers to the parent class
    // calling the parent constructor and passing in the required parameters
  }
}

// you can also use polymorphism like C#, but ONLY in Typescript
const poodle: Dog = new Poodle("Ted", 3, "white");



// int AddNumbers(int x, int y) { return x + y;}

// Functions

// traditional functions
function addNumbers(x: number, y: number) {

  // in TS, the return type or "output" of the function is implied when you return from 
  // the function itself
  return "hello world";
}


function subtractNumbers(x: number, y: number): number {
  return x - y;
}
// call the functions just like you would in C#
console.log(addNumbers(1, 2));
console.log(subtractNumbers(2, 1));

// storing an anonymous function in a variable
// the function just exist inside of a variable, but will be called
// like any other function
const multiplyNumbers = function(x: number, y: number): number { 
  return x * y;
}

// Fat Arrow Functions, they are defined JUST LIKE lambda functions in C#
// I will be teaching functions in javascript using the fat arrow function syntax
const divideNumbers = (x: number, y: number) => x / y;
console.log(divideNumbers(10, 2));


// C# Linq, 
// var nums = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
// var numsSquared = nums.Select(x => x * x).ToList();

// javascript relies HEAVILY ON CALL BACK FUNCTIONS

// calling the anon function above, it's called (or invoked) like a traditional function
console.log(multiplyNumbers(2, 2));

// in C#, we have the idea of POCO, or Models, plain old C# objects, this also 
// exist in Typescript, but you will RARELY use classes to define Models, you will use 
// interfaces and plain old javascript objects instead.