import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { FacultyLoginComponent } from './components/faculty-module/faculty-login/faculty-login.component';
import { FacultyHomeComponent } from './components/faculty-module/faculty-home/faculty-home.component';
import { ReportDetailComponent } from './components/faculty-module/report-detail/report-detail.component';
import { McqPerformanceComponent } from './components/faculty-module/mcq-performance/mcq-performance.component';
import { McqApiComponent } from './components/faculty-module/mcq-api/mcq-api.component';
import { PracticeExamsComponent } from './components/faculty-module/practice-exams/practice-exams.component';
import { IndividualViewComponent } from './components/faculty-module/individual-view/individual-view.component';
import { GradedEssaysComponent } from './components/faculty-module/graded-essays/graded-essays.component';

const routes: Routes = [
  { path: 'login', component: FacultyLoginComponent },
  {
    path: 'home',
    component: FacultyHomeComponent,
    children: [
      { path: 'report-detail', component: ReportDetailComponent },
      { path: 'mcq-performance', component: McqPerformanceComponent },
      { path: 'mcq-api', component: McqApiComponent },
      { path: 'graded-essays', component: GradedEssaysComponent },
      { path: 'practice-exams', component: PracticeExamsComponent },
      { path: 'individual-view', component: IndividualViewComponent },
    ],
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
