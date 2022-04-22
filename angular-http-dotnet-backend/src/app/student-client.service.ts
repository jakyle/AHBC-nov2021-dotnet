import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { PostStudent, Student } from './models/Student';



// THIS ENTIRE SERVICE is an ABSTRACTION for CALLING YOUR API STUDENTS CONTROLLER
@Injectable({
  providedIn: 'root'
})
export class StudentClientService {

  constructor(private httpClient: HttpClient) { }
  baseUrl = "https://localhost:5001/Student";

  getStudents() { 
    return this.httpClient.get<Array<Student>>(this.baseUrl);
  }

  // Angular -> Http Request -> API Controller -> Sql Database -> API Controller -> Http Response -> Angular Subscribes to response data
  getStudent(id: number) { 
    return this.httpClient.get<Student>(`${this.baseUrl}/${id}`);
  }

// Angular -> Http Request -> API Controller -> Sql Database -> API Controller -> Http Response -> Angular Subscribes to response data
  postStudent(student: PostStudent) {
    return this.httpClient.post<Student>(this.baseUrl, student);
  }

  // Angular -> Http Request -> API Controller -> Sql Database -> API Controller -> Http Response -> Angular Subscribes to response data
  deleteStudent(id: number) {
    return this.httpClient.delete<Student>(`${this.baseUrl}/${id}`);
  }

}
