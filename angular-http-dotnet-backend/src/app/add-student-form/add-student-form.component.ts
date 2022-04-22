import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { PostStudent } from '../models/Student';
import { StudentClientService } from '../student-client.service';

@Component({
  selector: 'app-add-student-form',
  templateUrl: './add-student-form.component.html',
  styleUrls: ['./add-student-form.component.css']
})
export class AddStudentFormComponent {

  constructor(private _studentClientService: StudentClientService) { }


  addStudentFormGroup = new FormGroup({
    name: new FormControl(''),
    grade: new FormControl(''),
  })

  submitStudent() {
    const postStudent: PostStudent = this.addStudentFormGroup.value;
    // If you want the Observable to be resolved, you NEED TO subscribe to it.
    this._studentClientService.postStudent(postStudent).subscribe();
  }

}
