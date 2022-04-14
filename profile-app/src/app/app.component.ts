import { Component } from '@angular/core';
import { profiles } from './profileData';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'My Profile app';

  // the profile class property is being assigned the profile array that is being imported
  profiles = profiles;
}
