import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ClarityModule } from "@clr/angular";
import { FacultyLoginComponent } from '../components/faculty/faculty-login/faculty-login.component';
import { FacultyHomeComponent } from '../components/faculty/faculty-home/faculty-home.component';
import { RouterModule } from '@angular/router';
import { GradedEssaysComponent } from '../components/faculty/graded-essays/graded-essays.component';
import { IndividualViewComponent } from '../components/faculty/individual-view/individual-view.component';
import { McqApiComponent } from '../components/faculty/mcq-api/mcq-api.component';
import { McqPerformanceComponent } from '../components/faculty/mcq-performance/mcq-performance.component';
import { PracticeExamsComponent } from '../components/faculty/practice-exams/practice-exams.component';
import { ReportDetailComponent } from '../components/faculty/report-detail/report-detail.component';
import { MyProfileComponent } from '../components/faculty/my-profile/my-profile.component';

@NgModule({
  declarations: [
    FacultyLoginComponent,
    FacultyHomeComponent,
    GradedEssaysComponent,
    IndividualViewComponent,
    McqApiComponent,
    McqPerformanceComponent,
    PracticeExamsComponent,
    ReportDetailComponent,
    MyProfileComponent
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
    ReportDetailComponent,
    MyProfileComponent
  ]
})
export class FacultyModule { }
