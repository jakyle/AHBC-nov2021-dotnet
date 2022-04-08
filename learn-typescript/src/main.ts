// Typescript Transpiles down to Javascript, Typescript is a SuperSet of 
// javascript, which means it's just javascript with extra features.


// we use javascript in the browser primarly so we can manipulate the 
// DOM = Document Object Model
// Document: the HTML Document that is loaded browser
// Object: the in memory object, (like a c# object) version of the HTML Document
// Model: just data!

// the DOM is simply the html in javascript Object form.

// the whole point of adding javascript to the browser is to give 
// developers the ability to manipulate the DOM after it is loaded in memory. 
// in other words, we can add behavior to our web site / web app long after the 
// initial html is displayed to the user.

// we are using the document object, (which represents our entire DOM) 
// and we are calling the getElementById method on the document object.
const paragraphElement = document.getElementById("message") as HTMLParagraphElement | null; // we are casting to narrow our html type to paragraph type

// in typescript, if you use if statements to handle null or undefined, your 
// type WILL be narrowed down to the type of the variable, without null or undefined
if (paragraphElement !== null) {
	console.log(paragraphElement);
}


const counterElement = document.getElementById("counter") as HTMLParagraphElement | null;
const buttonIncrementorElement = document.getElementById("incrementor") as HTMLButtonElement | null;
const buttonDecrementorElement = document.getElementById("decrementor") as HTMLButtonElement | null;

if (buttonIncrementorElement !== null && buttonDecrementorElement !== null && counterElement !== null) {
	// an event is a function that will be called when a certain condition is 
	// met. in this case, when the user clicks on this button, the function passed
	// into the event listener will be called.
	buttonIncrementorElement.addEventListener("click", () => { 
		counterElement.innerText = (parseInt(counterElement.innerText) + 1).toString();
	});

	// public class Element 
	// {
	// 	public string InnerText {get; set;}
	// }

	// var element = new Element();
	// element.InnerText = "0";
	// element.InnerText = (int.Parse(element.InnerText) + 1).ToString();

	buttonDecrementorElement.addEventListener("click", () => { 
		counterElement.innerText = (parseInt(counterElement.innerText) - 1).toString();
	});
}



const namesListElement = document.getElementById("names") as HTMLUListElement | null;

if (namesListElement !== null) {
	// array.map == LInq IEnumerable.Select();
	const names = ["Carson", "Kyle", "Leon", "Rachel", "Bob", "Corn"];
	const elements: Array<HTMLLIElement> = names.map(name => {
		const liElement = document.createElement("li"); // <li>Leon</li>
		liElement.innerText = name;
		return liElement;
	})

	for (const element of elements) {
		namesListElement.appendChild(element);
	}
}

// var names = new List<string> { "Carson", "Kyle", "Leon", "Rachel", "Bob", "Corn" };
// var elements = names.Select(name => 
//{ 
// 	var liElement = new Element();
// 	liElement.InnerText = name;
// 	return liElement;
// });


const colorChangerButton = document.getElementById("color-changer") as HTMLButtonElement | null;

let isWhite = true;
const appElement = document.getElementById("app") as HTMLElement | null;

// javascript / ts way of checking if a variable is not null or not undefined
if (colorChangerButton && appElement) {
	colorChangerButton.addEventListener("click", () => {
		appElement.style.backgroundColor = isWhite ? "white" : "lightblue";
		isWhite = !isWhite;
	})
}



console.log("Hey class!");
