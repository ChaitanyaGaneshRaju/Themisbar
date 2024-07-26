import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { ClarityModule } from "@clr/angular";
import { AppComponent } from './app.component';
import { FacultyModule } from './components/faculty/faculty.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { GenericModule } from './components/generic/generic.module';
import { HTTP_INTERCEPTORS, HttpClientModule } from '@angular/common/http';
import { AutofocusDirective } from './directives/autofocus.directive';
import { LoadingInterceptor } from './interceptors/loading.interceptor';
import { AuthInterceptor } from './interceptors/auth.interceptor';
import { HomePageComponent } from './components/guest-pages/home-page/home-page.component';

@NgModule({
  declarations: [
    AppComponent,
    AutofocusDirective,
    HomePageComponent,
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    ClarityModule,
    FacultyModule,
    GenericModule,
    HttpClientModule
  ],
  providers: [
    {provide: HTTP_INTERCEPTORS, useClass: LoadingInterceptor, multi: true},
    {provide: HTTP_INTERCEPTORS, useClass: AuthInterceptor, multi: true}
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
