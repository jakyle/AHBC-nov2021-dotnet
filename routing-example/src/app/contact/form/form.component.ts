import { ValueConverter } from '@angular/compiler/src/render3/view/template';
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-form',
  templateUrl: './form.component.html',
  styleUrls: ['./form.component.css']
})
export class FormComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {

  }

  updateForm(event: string) {
    const value = event;
  }

  // form control will be just ONE input field, it's the entire object used to 
  // MANAGE that one input field.
  public nameFormControl = new FormControl('');
  public emailFormControl = new FormControl('');

  // form group is used to manage multiple form controls
  public contactFormGroup = new FormGroup({
    name: new FormControl(""),
    email: new FormControl("")
  })

  submitForm() {
    alert(JSON.stringify(this.contactFormGroup.value));
  }

}
