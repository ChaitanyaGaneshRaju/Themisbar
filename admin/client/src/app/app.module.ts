import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { ClarityModule } from "@clr/angular";
import { AppComponent } from './app.component';
import { FacultyModule } from './modules/faculty.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { GenericModule } from './modules/generic.module';

@NgModule({
  declarations: [
    AppComponent,
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    ClarityModule,
    FacultyModule,
    GenericModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
