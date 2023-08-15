import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ClarityModule } from "@clr/angular";
import { FacultyLoginComponent } from '../components/faculty-module/faculty-login/faculty-login.component';
import { FacultyHomeComponent } from '../components/faculty-module/faculty-home/faculty-home.component';
import { RouterModule } from '@angular/router';

@NgModule({
  declarations: [
    FacultyLoginComponent,
    FacultyHomeComponent,
  ],
  imports: [
    CommonModule,
    ClarityModule,
    RouterModule
  ],
  exports:[
    FacultyLoginComponent,
    FacultyHomeComponent,
  ]
})
export class FacultyModule { }
