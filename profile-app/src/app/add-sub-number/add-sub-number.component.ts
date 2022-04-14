import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-add-sub-number',
  templateUrl: './add-sub-number.component.html',
  styleUrls: ['./add-sub-number.component.scss']
})
export class AddSubNumberComponent {

  constructor() { }

  public number = 0;

  public add(): void {
    this.number++;
  }

  public sub(): void { 
    this.number--;
  }
}