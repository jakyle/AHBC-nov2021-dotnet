import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { ProfileCardComponent } from './profile-card/profile-card.component';
import { AddSubNumberComponent } from './add-sub-number/add-sub-number.component';

@NgModule({
  declarations: [
    AppComponent,
    ProfileCardComponent,
    AddSubNumberComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
