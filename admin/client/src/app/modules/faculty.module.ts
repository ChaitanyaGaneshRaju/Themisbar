import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ClarityModule } from "@clr/angular";
import { FacultyLoginComponent } from '../components/faculty-module/faculty-login/faculty-login.component';
import { FacultyHomeComponent } from '../components/faculty-module/faculty-home/faculty-home.component';
import { RouterModule } from '@angular/router';
import { GradedEssaysComponent } from '../components/faculty-module/graded-essays/graded-essays.component';
import { IndividualViewComponent } from '../components/faculty-module/individual-view/individual-view.component';
import { McqApiComponent } from '../components/faculty-module/mcq-api/mcq-api.component';
import { McqPerformanceComponent } from '../components/faculty-module/mcq-performance/mcq-performance.component';
import { PracticeExamsComponent } from '../components/faculty-module/practice-exams/practice-exams.component';
import { ReportDetailComponent } from '../components/faculty-module/report-detail/report-detail.component';

@NgModule({
  declarations: [
    FacultyLoginComponent,
    FacultyHomeComponent,
    GradedEssaysComponent,
    IndividualViewComponent,
    McqApiComponent,
    McqPerformanceComponent,
    PracticeExamsComponent,
    ReportDetailComponent
  ],
  imports: [
    CommonModule,
    ClarityModule,
    RouterModule
  ],
  exports:[
    FacultyLoginComponent,
    FacultyHomeComponent,
    GradedEssaysComponent,
    IndividualViewComponent,
    McqApiComponent,
    McqPerformanceComponent,
    PracticeExamsComponent,
    ReportDetailComponent
  ]
})
export class FacultyModule { }
