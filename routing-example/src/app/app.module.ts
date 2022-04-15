import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { NavBarComponent } from './nav-bar/nav-bar.component';
import { HomeComponent } from './home/home.component';
import { AboutComponent } from './about/about.component';
import { ContactComponent } from './contact/contact.component';
import { RouterModule } from '@angular/router';
import { routes } from './routes';
import { FormComponent } from './contact/form/form.component';
import { ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    NavBarComponent,
    HomeComponent,
    AboutComponent,
    ContactComponent,
    FormComponent
  ],
  imports: [
    RouterModule.forRoot(routes), // anytime you add a class library or functionality to your app, you need to import the module
    BrowserModule,
    ReactiveFormsModule 
  ],
  providers: [], // services injected in providers
  bootstrap: [AppComponent]
})
export class AppModule { }
