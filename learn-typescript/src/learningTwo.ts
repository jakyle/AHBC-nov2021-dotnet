// like C#, interfaced describe what the class or object SHOULD contain,
// in typescript, they are also used liberally to describe the contract 
// for models.
export interface Person {
	name: string,
	age: number
}

// this is a javacript / ts object, note that it looks very simillar to 
// JSOn, that is not a coincidence as JSON is a "Javascript Object Notation" in other
// words, JSON is just a javascript object.
const person = {
	name: "Carson",
	age: 34,
	driveCar() {
		return "vroom vroom!";
	}
}

console.log(person.name);
console.log(person.age);
console.log(person.driveCar);

// this is A WAY  to add "types" to regular objects (objects that are NOT)
// instanced from a class.
const stronglyTypedPerson: Person = {
	name: "Leon",
	age: 31,
}


// rule of thumb, if you need to create an object that requires functionality, ie.
// it will have methods built in, and you plan on making mutiple versions of 
// said object, use a class.


// if you object only has data, define the contract of that object 
// using an interface.