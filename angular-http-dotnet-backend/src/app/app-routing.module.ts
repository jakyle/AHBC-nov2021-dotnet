import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddStudentFormComponent } from './add-student-form/add-student-form.component';
import { StudentHomeComponent } from './student-home/student-home.component';
import { StudentComponent } from './student/student.component';

const routes: Routes = [
  {
    path: "",
    component: StudentHomeComponent
  },
  {
    // :id, is your route parameter, it is a PLACEHOLDER for an actual value when ROUTED to this route
    path: "student/:id", // the :id will be replaced with the provided route parameter
    component: StudentComponent
  },
  {
    path: "add-student",
    component: AddStudentFormComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
