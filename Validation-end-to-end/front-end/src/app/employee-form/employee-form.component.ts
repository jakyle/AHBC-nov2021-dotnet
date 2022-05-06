import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';


@Component({
  selector: 'app-employee-form',
  templateUrl: './employee-form.component.html',
  styleUrls: ['./employee-form.component.css']
})
export class EmployeeFormComponent {




  forecastFormGroup = new FormGroup({
    date: new FormControl("", [Validators.required, Validators.pattern(/^(([0-9]{4})((-[0-9]{2}){2}(( |T)?([0-9]{2}:){2}[0-9]{2}((\+[0-9]{2}(:[0-9]{2})?)|Z)?)?|(-W[0-9]{2}(-[1-7])?)|(-[1-3]?[0-9]{2})))$/)]),
    temperatureC: new FormControl(""),
    summary: new FormControl("")
  })  

  onSubmit() {
    if (this.forecastFormGroup.valid) {
      alert("making a call to the backend...");
    } else{
      alert("this not valid bro...");
    }
  }

}
