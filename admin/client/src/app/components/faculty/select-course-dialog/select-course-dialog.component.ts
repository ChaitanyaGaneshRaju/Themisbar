import { Component, EventEmitter, Output, ViewChild } from '@angular/core';
import { AutofocusDirective } from 'src/app/directives/autofocus.directive';

@Component({
  selector: 'app-select-course-dialog',
  templateUrl: './select-course-dialog.component.html',
  styleUrls: ['./select-course-dialog.component.css']
})
export class SelectCourseDialogComponent {

  @ViewChild(AutofocusDirective) autofocus!: AutofocusDirective;
  @Output() onOK: EventEmitter<Array<string>> = new EventEmitter<Array<string>>();

  options: any;

  show = false;

  courses!: Array<string>;

  open(courses: Array<string>) {
    this.show = true;
    this.courses = Object.create(courses); // clone the user (we don't want to modify the original in the dialog)

    setTimeout(() => {
      if (this.autofocus) {
        this.autofocus.setFocus();
      }
    }, 0.1);
  }

  close() {
    this.show = false;
  }

  onSubmit() {
    console.log(this.options);
    // this.close();
    // console.log("hihihih")
    // this.onOK.emit(this.courses);
  }

}
