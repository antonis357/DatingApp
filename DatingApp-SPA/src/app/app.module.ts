import { BrowserModule } from "@angular/platform-browser";
import { NgModule } from "@angular/core";
import { AppRoutingModule } from "./app-routing.module";
import { HttpClientModule, HTTP_INTERCEPTORS } from "@angular/common/http";
import { FormsModule } from "@angular/forms";
import { BsDropdownModule } from 'ngx-bootstrap';

import { AppComponent } from "./app.component";
import { NavComponent } from "./nav/nav.component";
import { AuthService } from "./_services/auth.service";
import { HomeComponent } from "./home/home.component";
import { RegisterComponent } from "./register/register.component";
import { ErrorInterceptor } from "./_services/error.interceptor";
import { AlertifyService } from './_services/alertify.service';

@NgModule({
  declarations: [AppComponent, NavComponent, HomeComponent, RegisterComponent],
  imports: [BsDropdownModule.forRoot(),BrowserModule, AppRoutingModule, HttpClientModule, FormsModule],
  providers: [AuthService, 
    AlertifyService,
    //ErrorInterceptorProvider,
   {
     provide: HTTP_INTERCEPTORS,
     useClass: ErrorInterceptor,
     multi: true
   },],
  bootstrap: [AppComponent]
})
export class AppModule {}
