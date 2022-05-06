import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { WeatherForecast } from './models/Forecast';

@Injectable({
  providedIn: 'root'
})
export class ForecastService {

  constructor(private httpClient: HttpClient) { }
  baseUrl = "https://localhost:5001/WeatherForecast";


  post(forecast: WeatherForecast) {
    return this.httpClient.post(this.baseUrl, forecast);
  }
}
