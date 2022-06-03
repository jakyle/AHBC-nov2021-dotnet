import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

interface RandomDogResponse {
  message: string;
  status: string;
}


@Injectable({
  providedIn: 'root'
})
export class DogApiService {

  constructor(private _httpclient: HttpClient) { }


  public getRandomDog() {
    return this._httpclient.get<RandomDogResponse>('https://dog.ceo/api/breeds/image/random');
  }
}
