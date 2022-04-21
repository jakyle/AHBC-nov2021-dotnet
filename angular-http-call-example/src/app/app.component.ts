import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { StarWarsPeopleResponse, StarWarsPerson } from './models/StarWarsApi/PeopleResponse.model';
import { StarwarsApiService } from './starwars-api.service';

// a component is just a decorator "class" that adds component functionality to
// your class.
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'angular-http-call-example';
  person$: Observable<StarWarsPerson>;
  /**
   *
   */
  // dependency injecting, injecting the StarWarsApiService that I created
  // the constructor is the method that gets CALLED when the OBJECT
  // is created into memory
  constructor(private _starWarsApiService: StarwarsApiService) { 
    this.person$ = this._starWarsApiService.getPerson(1);
  }

  starWarsPeopleResponse: string = "";

  // this method will always get called the MOMENT the component is initialized, 
  // not when the OBJECT is created, when the COMPONENT is initialized, input data
  // is already SENT to this component, and it is JUST rendered in the browser for 
  // the first time.
  ngOnInit() { 
    // by convention, we make http request in the ngOnInit method, in other words,
    // when this component is initialized and rendered for the first time.
    const subscription = this._starWarsApiService.getPeople().subscribe(response => {
      // you pass in a call back function into the subscribe method, this call back
      // function is the function that will be called, once your observable 
      // "SENDS" new data, this is why the method is called "subscribe"
      this.starWarsPeopleResponse = JSON.stringify(response, null, 2);
    });
  }

  toJson(obj: any) {
    return JSON.stringify(obj, null, 2);
  }
}
