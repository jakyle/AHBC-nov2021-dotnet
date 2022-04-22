import { Component, OnInit } from '@angular/core';
import { switchMap } from 'rxjs';
import { Student } from '../models/Student';
import { StudentClientService } from '../student-client.service';

@Component({
  selector: 'app-student-home',
  templateUrl: './student-home.component.html',
  styleUrls: ['./student-home.component.css']
})
export class StudentHomeComponent implements OnInit {

  // by convention, if your variable type is an observable, we suffix it with a $
  students$ = this.studentClientService.getStudents();

  students: Student[] = [];

  constructor(private studentClientService: StudentClientService) { }

  ngOnInit(): void {
    this.studentClientService.getStudents().subscribe(students => {
      this.students = students;
    })
  }

  deleteStudent(id: number) {
    this.studentClientService.deleteStudent(id).pipe(
      switchMap(() => this.studentClientService.getStudents()) // switch map allows us to call
      // an observable while piping.
    ).subscribe(students => {
      this.students = students
    });
  }
}
