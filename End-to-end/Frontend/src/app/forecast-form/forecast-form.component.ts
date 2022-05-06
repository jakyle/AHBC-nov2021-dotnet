import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { ForecastService } from '../forecast.service';

@Component({
  selector: 'app-forecast-form',
  templateUrl: './forecast-form.component.html',
  styleUrls: ['./forecast-form.component.css']
})
export class ForecastFormComponent implements OnInit {

  constructor(private forecastService: ForecastService) { }

  ngOnInit(): void {
  }

  forecastFormGroup = new FormGroup({
    date: new FormControl(""),
    temperatureC: new FormControl(""),
    summary: new FormControl("")
  })

  onSubmit() {
    const requestJson = JSON.stringify(this.forecastFormGroup.value);
    this.forecastService.post(this.forecastFormGroup.value).subscribe();
  }

}
