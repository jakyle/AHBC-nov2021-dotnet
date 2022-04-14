import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-picture-example', // this is your component html tag
  templateUrl: './picture-example.component.html',
  styleUrls: ['./picture-example.component.scss']
})
export class PictureExampleComponent implements OnInit {

  constructor() { }

  // input properties will get their values from the parent component
  @Input() imageUrl = "";

  ngOnInit(): void {
  }

}
