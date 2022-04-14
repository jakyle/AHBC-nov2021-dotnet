import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { HelloWorldComponent } from './hello-world/hello-world.component';
import { PictureExampleComponent } from './picture-example/picture-example.component';

// angular modules is like a Dotnet Startup.cs, it's where you define your dependencies
// and components
@NgModule({
  declarations: [ // this is where you add all your created components
    AppComponent,
    HelloWorldComponent,
    PictureExampleComponent
  ],
  imports: [ // you will import modules to use external angular libraries / components
    BrowserModule, // the browser module allows us to run angular, in the browser
    CommonModule // Common module adds commonly used directives and component functionality
  ],
  providers: [], // this is where you import your services, for your IoC container (dependency injection)
  bootstrap: [AppComponent] // Entry point for your entire application, this will be the first 
  // component that is rendered in the ui
})
export class AppModule { }
