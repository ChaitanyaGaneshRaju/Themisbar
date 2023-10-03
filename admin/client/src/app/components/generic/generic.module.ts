import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { SpinnerComponent } from './spinner/spinner.component';
import { ClarityModule } from '@clr/angular';

@NgModule({
  declarations: [
    PageNotFoundComponent,
    SpinnerComponent
  ],
  imports: [
    CommonModule,
    ClarityModule
  ],
  exports :[
    PageNotFoundComponent,
    SpinnerComponent
  ]
})
export class GenericModule { }
