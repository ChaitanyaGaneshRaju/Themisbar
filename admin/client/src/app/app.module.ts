import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { ClarityModule } from "@clr/angular";
import { AppComponent } from './app.component';
import { FacultyModule } from './modules/faculty.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ReportDetailComponent } from './components/faculty-module/report-detail/report-detail.component';
import { McqPerformanceComponent } from './components/faculty-module/mcq-performance/mcq-performance.component';
import { McqApiComponent } from './components/faculty-module/mcq-api/mcq-api.component';
import { GradedEssaysComponent } from './components/faculty-module/graded-essays/graded-essays.component';
import { PracticeExamsComponent } from './components/faculty-module/practice-exams/practice-exams.component';
import { IndividualViewComponent } from './components/faculty-module/individual-view/individual-view.component';
// import { FacultyHomeComponent } from './components/faculty-module/faculty-home/faculty-home.component';

@NgModule({
  declarations: [
    AppComponent,
    ReportDetailComponent,
    McqPerformanceComponent,
    McqApiComponent,
    GradedEssaysComponent,
    PracticeExamsComponent,
    IndividualViewComponent
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
