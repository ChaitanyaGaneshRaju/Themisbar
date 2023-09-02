import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ClarityModule } from "@clr/angular";
import { FacultyLoginComponent } from './faculty-login/faculty-login.component';
import { FacultyHomeComponent } from './faculty-home/faculty-home.component';
import { RouterModule } from '@angular/router';
import { GradedEssaysComponent } from './graded-essays/graded-essays.component';
import { IndividualViewComponent } from './individual-view/individual-view.component';
import { McqApiComponent } from './mcq-api/mcq-api.component';
import { McqPerformanceComponent } from './mcq-performance/mcq-performance.component';
import { PracticeExamsComponent } from './practice-exams/practice-exams.component';
import { ReportDetailComponent } from './report-detail/report-detail.component';
import { MyProfileComponent } from './my-profile/my-profile.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

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
    MyProfileComponent,
  ],
  imports: [
    CommonModule,
    ClarityModule,
    RouterModule,
    FormsModule,
    ReactiveFormsModule
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
