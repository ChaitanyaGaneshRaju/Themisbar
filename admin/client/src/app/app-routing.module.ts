import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { FacultyLoginComponent } from './components/faculty-module/faculty-login/faculty-login.component';
import { FacultyHomeComponent } from './components/faculty-module/faculty-home/faculty-home.component';
import { ReportDetailComponent } from './components/faculty-module/report-detail/report-detail.component';

const routes: Routes = [
  { path: 'login', component: FacultyLoginComponent },
  {
    path: 'home',
    component: FacultyHomeComponent,
    children: [{ path: 'report-detail', component: ReportDetailComponent }],
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
