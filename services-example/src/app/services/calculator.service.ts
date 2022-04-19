import { Injectable } from '@angular/core';
import { BehaviorSubject, Subject } from 'rxjs';


// you ONLY use the injectable decorator on services that you WANT to inject into other 
// components or other services.
@Injectable({
  providedIn: 'root'
})
export class CalculatorService {

  
  constructor() { }

  // behavior subject can be observed by multiple observers and has a 
  // starting default value
  totalSubject = new BehaviorSubject<number>(0);
  total = 0;

  add(a: number, b: number) { 
    this.totalSubject.next(a + b);
  }

  subtract(a: number, b: number) { 
    this.totalSubject.next(a - b);
  }

}
