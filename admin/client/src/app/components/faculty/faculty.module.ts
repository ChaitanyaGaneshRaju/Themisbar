import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ClarityModule } from "@clr/angular";
import { FacultyLoginComponent } from './faculty-login/faculty-login.component';
import { FacultyHomeComponent } from './faculty-home/faculty-home.component';
import { RouterModule } from '@angular/router';
import { GradedEssaysComponent } from './graded-essays/graded-essays.component';
import { IndividualViewComponent } from './individual-view-wrapper/individual-view/individual-view.component';
import { McqApiComponent } from './mcq-api/mcq-api.component';
import { McqPerformanceComponent } from './mcq-performance/mcq-performance.component';
import { PracticeExamsComponent } from './practice-exams/practice-exams.component';
import { ReportDetailComponent } from './report-detail/report-detail.component';
import { MyProfileComponent } from './my-profile/my-profile.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { SelectCourseDialogComponent } from './select-course-dialog/select-course-dialog.component';
import { IndividualViewWrapperComponent } from './individual-view-wrapper/individual-view-wrapper.component';
import { IndividualViewDetailComponent } from './individual-view-wrapper/individual-view-detail/individual-view-detail.component';
import { IndividualViewDetailDetailsComponent } from './individual-view-wrapper/individual-view-detail/individual-view-detail-details/individual-view-detail-details.component';
import { IndividualViewDetailAssignmentsComponent } from './individual-view-wrapper/individual-view-detail/individual-view-detail-assignments/individual-view-detail-assignments.component';
import { IndividualViewDetailMbePqsComponent } from './individual-view-wrapper/individual-view-detail/individual-view-detail-mbe-pqs/individual-view-detail-mbe-pqs.component';
import { IndividualViewDetailPracticeExamsComponent } from './individual-view-wrapper/individual-view-detail/individual-view-detail-practice-exams/individual-view-detail-practice-exams.component';

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
    SelectCourseDialogComponent,
    IndividualViewDetailComponent,
    IndividualViewDetailDetailsComponent,
    IndividualViewWrapperComponent,
    IndividualViewDetailAssignmentsComponent,
    IndividualViewDetailMbePqsComponent,
    IndividualViewDetailPracticeExamsComponent
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
