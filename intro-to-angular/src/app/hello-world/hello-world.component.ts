import { Component, Input, OnInit } from '@angular/core';


// The component decorator is used to define a class as a component. 
// it also defines the metadata for the component. for example,
// where the html and css files are located.
@Component({
  selector: 'app-hello-world',
  templateUrl: './hello-world.component.html',
  styleUrls: ['./hello-world.component.scss']
})
export class HelloWorldComponent implements OnInit {

  // will use this later, we need constructors for dependency injection
  constructor() { }

  // this is property in Typescript, and with angular, we use properties
  // as a means to display data in your html. by default, properties
  // are public in Typescript, so you will often not see public modifiers
  // for properties in TS.
  //
  // in Angular, ANY PUBLIC MEMBERS can be USED in the HTML!!!
  internalMessage = "Hello world! I really like coffee!";
  names = ["Bob", "Sally", "Joe"];

  // the Input decorator is used to define a property as an input, in other words,
  // a "parent" component will be able to pass DATA into this component by accessing 
  // the NAME of the property that the Input decorator is used on.
  @Input() message = "lol";

  displayText(subMessage: string): string {
    return `${subMessage} ${this.message}`;
  }

  ngOnInit(): void {
  }

}
