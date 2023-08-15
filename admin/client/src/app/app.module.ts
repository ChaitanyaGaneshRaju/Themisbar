import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { ClarityModule } from "@clr/angular";
import { AppComponent } from './app.component';
import { FacultyModule } from './modules/faculty.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ReportDetailComponent } from './components/faculty-module/report-detail/report-detail.component';
// import { FacultyHomeComponent } from './components/faculty-module/faculty-home/faculty-home.component';

@NgModule({
  declarations: [
    AppComponent,
    ReportDetailComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    ClarityModule,
    FacultyModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
