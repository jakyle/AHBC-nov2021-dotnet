// create an array of objects, each object will represent
// a coffee order

// string interpolation in typescript
// C#s version of string interpolation $"{variable}"
// js version of string interpolation `${variable}`

const personNoun = "James";
const personVerb = "likes";
const personAdjective = "awesome";

const madLib = `the great ${personAdjective} ${personNoun}, really ${personVerb} to dance`;


interface CoffeeItem {
	id: number;
	name: string,
	price: number,
}

// square brackets are used to create an array.
// an array is like a List<T> in js/ts
const coffeeItems: Array<CoffeeItem> = [
	{
		id: 1,
		name: "Cappuccino",
		price: 2.5,
	},
	{
		id: 2,
		name: "Latte",
		price: 3.4
	},
	{
		id: 3,
		name: "Espresso",
		price: 2.1
	},
];

const coffeeList = document.getElementById("coffee-list");


// checking if coffeeList is NOT NULL
if (coffeeList) {
	coffeeList.style.padding = "0";
	coffeeList.style.margin = "0";
	coffeeList.style.display = "flex";
	coffeeList.style.flexDirection = "column";
	coffeeList.style.width = "500px";

	for (const coffeeItem of coffeeItems) {
		const coffeeItemElement = document.createElement("li");
		coffeeItemElement.style.listStyle = "none";
		coffeeItemElement.style.margin = "0px";
		coffeeItemElement.style.padding = "0px";
		coffeeItemElement.style.display = "flex";
		coffeeItemElement.style.flexDirection = "row";
		coffeeItemElement.style.justifyContent = "space-between";
		coffeeItemElement.style.width = "100%";



		
		coffeeItemElement.innerHTML = `
				<h3>${coffeeItem.id}</h3>
				<h3>${coffeeItem.name}</h3>
				<p>$${coffeeItem.price}</p>
		`;
		coffeeList.appendChild(coffeeItemElement);
	}
}

const orderForm = document.getElementById("order-form");
const coffeeIdInput = document.getElementById("coffee-id") as HTMLInputElement | null;
if (orderForm && coffeeIdInput) {
	orderForm.addEventListener("submit", (formEvent) => {
		// this stops the form from refreshing the page
		formEvent.preventDefault();

		const inputValue = coffeeIdInput.value;

		// if the users input IS a valid integer
		const parsedInput = parseInt(inputValue);
		if (!isNaN(parsedInput) && parsedInput > 0 && parsedInput < 4) {
			const coffeeItem = coffeeItems[parsedInput - 1];
			alert(orderString(coffeeItem));
		} else {
			alert("invalid order friend!");
		}
	})
}

function orderString(coffeeItem: CoffeeItem) {
	return `
~~~~~ Here is your order ~~~~~
name: ${coffeeItem.name},
cost: $${coffeeItem.price}
`;
}