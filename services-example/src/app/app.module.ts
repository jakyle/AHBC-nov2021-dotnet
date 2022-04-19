import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { DisplayComponent } from './calculator/display/display.component';
import { ButtonsComponent } from './calculator/buttons/buttons.component';
import { OtherDisplayComponent } from './other-display/other-display.component';

@NgModule({
  declarations: [
    AppComponent,
    DisplayComponent,
    ButtonsComponent,
    OtherDisplayComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [], // this is where we put our services
  bootstrap: [AppComponent]
})
export class AppModule { }
