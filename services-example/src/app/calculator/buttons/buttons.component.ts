import { Component, OnInit } from '@angular/core';
import { CalculatorService } from 'src/app/services/calculator.service';

@Component({
  selector: 'app-buttons',
  templateUrl: './buttons.component.html',
  styleUrls: ['./buttons.component.css']
})
export class ButtonsComponent implements OnInit {

  constructor(private _calculatorService: CalculatorService) { }

  numberOne: null | number = null;
  numberTwo: null | number = null;
  // in typescript, you can set a STRING VALUE as a type.
  // so the type for operator is "add" or "subtract" or null, it can NEVER
  // be any other string value
  operator: "add" | "subtract" | null = null;

  ngOnInit(): void {
  }

  selectNumber(number: number) {
    if (this.numberOne === null) {
      this.numberOne = number;
    } else {
      this.numberTwo = number;
    }
  }

  selectOperator(operator: "add" | "subtract") {
    this.operator = operator;
  }

  setEquals() {
    if (this.numberOne && this.numberTwo) {
      if (this.operator === "add") {
        this._calculatorService.add(this.numberOne, this.numberTwo);
      } else if (this.operator === "subtract") {
        this._calculatorService.subtract(this.numberOne, this.numberTwo);
      } else {
        return;
      }

      this.numberOne = null;
      this.numberTwo = null;
      this.operator = null;
    }
  }
}
