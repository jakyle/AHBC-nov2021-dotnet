import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { filter, map, switchMap } from 'rxjs/operators';
import { StudentClientService } from '../student-client.service';

@Component({
  selector: 'app-student',
  templateUrl: './student.component.html',
  styleUrls: ['./student.component.css']
})
export class StudentComponent implements OnInit {

  // activated route is just the type used to "capture" any date passed
  // in through the URL. it's called activated route because it's referring to
  // the active route.
  constructor(
    private _activatedRoute: ActivatedRoute, 
    private _studentClientService: StudentClientService
  ) { }

  // PIPING allows us to make a NEW observable from an existing Observable.
  // Piping allows us to chain operators to our observable. ie, once we get
  // a subscribed data in, we can "PIPE" the data through operators IN ORDER (order matters)
  student$ = this._activatedRoute.paramMap.pipe( // we get the param maps then send it down the pipeline
    map(params => params.get('id')), // map the params to get the id 
    filter(id => id !== null), // we filter so we ONLY get a valid id from the route
    map(id => parseInt(id as string, 10)), // convert our id into a number
    switchMap((id: number) => this._studentClientService.getStudent(id)), // we make an http Request, once that observable is resolved...
  )// we reach the end of the pipeline, anyone subcribing to this, will get the student data
  // Observables will ONLY ACT if there is a subscriber

  ngOnInit(): void {
  }

}
