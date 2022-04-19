import { Component } from '@angular/core';
import { CoffeeShopService } from './coffee-shop.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {


  /**
   *  the way you handle dependency injection in Angular is the same way you handle
   * dependency injection in C# (Dotnet), through the constructor.  you pass in the type.
   * and Angular will find that exiting type and inject it into the constructor.
   */

  // by using an access modifier, this will AUTO create your field / property for you,
  // this works with dependency injection as well.
  constructor(private _coffeeShopService: CoffeeShopService) { }

  getCoffeeShopName(): string {
    return this._coffeeShopService.getCoffeeShopName();
  }

  title = 'services-example';
}
