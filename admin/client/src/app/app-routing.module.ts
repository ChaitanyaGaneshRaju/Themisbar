import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { FacultyLoginComponent } from './components/faculty/faculty-login/faculty-login.component';
import { FacultyHomeComponent } from './components/faculty/faculty-home/faculty-home.component';
import { ReportDetailComponent } from './components/faculty/report-detail/report-detail.component';
import { McqPerformanceComponent } from './components/faculty/mcq-performance/mcq-performance.component';
import { McqApiComponent } from './components/faculty/mcq-api/mcq-api.component';
import { PracticeExamsComponent } from './components/faculty/practice-exams/practice-exams.component';
import { IndividualViewComponent } from './components/faculty/individual-view-wrapper/individual-view/individual-view.component';
import { GradedEssaysComponent } from './components/faculty/graded-essays/graded-essays.component';
import { PageNotFoundComponent } from './components/generic/page-not-found/page-not-found.component';
import { MyProfileComponent } from './components/faculty/my-profile/my-profile.component';
import { IndividualViewDetailComponent } from './components/faculty/individual-view-wrapper/individual-view-detail/individual-view-detail.component';
import { IndividualViewWrapperComponent } from './components/faculty/individual-view-wrapper/individual-view-wrapper.component';

const routes: Routes = [
  { path: 'login', component: FacultyLoginComponent },
  {
    path: 'faculty/:courseId',
    component: FacultyHomeComponent,
    children: [
      { path: '', redirectTo: 'report-detail', pathMatch: 'full' },
      { path: 'report-detail', component: ReportDetailComponent },
      { path: 'mcq-performance', component: McqPerformanceComponent },
      { path: 'mcq-api', component: McqApiComponent },
      { path: 'graded-essays', component: GradedEssaysComponent },
      { path: 'practice-exams', component: PracticeExamsComponent },
      { path: 'individual-view', component: IndividualViewWrapperComponent,
      children:[
        { path: '', component: IndividualViewComponent,},
        { path: 'detail/:regId', component: IndividualViewDetailComponent }
      ]},
      { path: 'my-profile', component: MyProfileComponent },
    ],
  },
  {path:'**', component: PageNotFoundComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
