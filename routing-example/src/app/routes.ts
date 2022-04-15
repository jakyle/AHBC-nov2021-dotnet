import { Routes } from "@angular/router";
import { AboutComponent } from "./about/about.component";
import { ContactComponent } from "./contact/contact.component";
import { HomeComponent } from "./home/home.component";


// by defining our own routes, we are telling angular that when we go to the url path 
// in the browser, the component that will render will be the component that is defined
// with the path in the route object (in the routes array)
// for example, if we go to /home, Angular will "route us" to the HomeComponent
export const routes: Routes = [
	{ 
		path: 'home', // the path used in your URL
		component: HomeComponent
	},
	{ 
		path: 'about', // the path used in your URL
		component: AboutComponent
	},
	{ 
		path: 'contact', // the path used in your URL
		component: ContactComponent
	},
	{
		path: '*',
		component: HomeComponent
	}
]



// in dotnet MVC, the routing pattern look like this   <domain>/<controller>/<action>