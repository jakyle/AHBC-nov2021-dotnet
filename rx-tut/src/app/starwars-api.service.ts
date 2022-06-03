import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class StarwarsApiService {

  constructor(private _httpClient: HttpClient) { }

  private baseUrl = 'https://swapi.dev/api';

  public getPerson(id: number) {
    return this._httpClient.get<StarWarsPersonResponse>(`${this.baseUrl}/people/${id}`)
  }
}


interface StarWarsPersonResponse {
  name: string;
  height: string;
  mass: string;
  hair_color: string;
  skin_color: string;
  eye_color: string;
  birth_year: string;
  gender: string;
  homeworld: string;
  films: string[];
  species: string[];
  vehicles: string[];
  starships: string[];
  created: Date;
  edited: Date;
  url: string;
}