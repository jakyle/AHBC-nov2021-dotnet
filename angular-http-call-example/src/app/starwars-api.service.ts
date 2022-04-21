import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { StarWarsPeopleResponse, StarWarsPerson } from './models/StarWarsApi/PeopleResponse.model';
import { Observable } from 'rxjs';

// SErvices USE the INJECTABLE decorator
@Injectable({
  providedIn: 'root'
})
export class StarwarsApiService {

  constructor(private _httpClient: HttpClient) { }

  private baseUrl = 'https://swapi.dev/api/';


  // get people because we are making an http GET request
  // also, the modles we are getting back is relative to the "people" data
  // from this api
  public getPeople(): Observable<StarWarsPeopleResponse> {
    return this._httpClient.get<StarWarsPeopleResponse>(`${this.baseUrl}people/`);
  }

  // this returns of type Observable, it's an idea of OBSERVERVING the data
  // when it returns, and when it returns, it will be of type <T>, where T
  // is the type you provide
  getPerson(id: number) {
    return this._httpClient.get<StarWarsPerson>(`${this.baseUrl}people/${id}`);
  }
}
