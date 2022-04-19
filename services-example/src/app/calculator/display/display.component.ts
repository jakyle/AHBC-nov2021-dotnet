import { Component, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';
import { CalculatorService } from 'src/app/services/calculator.service';

@Component({
  selector: 'app-display',
  templateUrl: './display.component.html',
  styleUrls: ['./display.component.css']
})
export class DisplayComponent implements OnInit {

  _totalSubscription: Subscription | null = null;

  // we are injecting and storing the calculator service in the constructor, and it's being 
  // saved in a private field in this class / component
  // by doing this, we are ABLE to access this field anywhere else in this component.
  public constructor(private _calculatorService: CalculatorService) { }

  total = 0;


  // this method will be called by angular AFTER your UI is rendered.
  public ngOnInit(): void {
    this._totalSubscription = this._calculatorService.totalSubject.subscribe(nextTotalValue => {
      this.total = nextTotalValue * 2;
    });
  }

  public getTotal(): number {
    return this._calculatorService.total;
  }

}
