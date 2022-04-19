import { Injectable } from '@angular/core';

// the Injectable decorator ADDS the decorated class INTO
// the IoC or Inversion of Control container for you for free
// this means that ANY other SERVICES OR COMPONENTS, will have 
// access to this class (service)
@Injectable({
  providedIn: 'root'
})
export class CoffeeShopService {

  constructor() { }

  getCoffeeShopName(): string {
    return "James' Fresh Beans!";
  }
}
