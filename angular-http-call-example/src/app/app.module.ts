import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppComponent } from './app.component';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule // if you want to use the http client to make request
    // to a backend service, you NEED to include this module
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
