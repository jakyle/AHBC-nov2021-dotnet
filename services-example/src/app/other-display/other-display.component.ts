import { Component, OnInit } from '@angular/core';
import { CalculatorService } from '../services/calculator.service';

@Component({
  selector: 'app-other-display',
  templateUrl: './other-display.component.html',
  styleUrls: ['./other-display.component.css']
})
export class OtherDisplayComponent implements OnInit {
  private _totalSubscription: any;
  total: number = 0;;

  public constructor(private _calculatorService: CalculatorService) { }

  ngOnInit(): void {
    this._totalSubscription = this._calculatorService.totalSubject.subscribe(nextTotalValue => {
      this.total = nextTotalValue;
    });
  }

}
