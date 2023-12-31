import { Component, ViewChild } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { Router } from '@angular/router';
import { AccountService } from 'src/app/services/account.service';
import { FacultyIconsService } from 'src/app/services/faculty-icons.service';
import { SelectCourseDialogComponent } from '../select-course-dialog/select-course-dialog.component';

@Component({
  selector: 'app-faculty-home',
  templateUrl: './faculty-home.component.html',
  styleUrls: ['./faculty-home.component.css'],
})
export class FacultyHomeComponent {
  @ViewChild(SelectCourseDialogComponent) modal!: SelectCourseDialogComponent;

  currentYear = (new Date()).getFullYear();

  courses: Array<string> = [
    'Illinois Bar Review 520',
    'Florida Bar Review 518',
    'California Bar Review 516',
  ];

  constructor(
    private titleService: Title,
    private facultyIconsService: FacultyIconsService,
    private accountService: AccountService,
    private router: Router
  ) {
    titleService.setTitle("Faculty | Themis Bar Review");
    this.facultyIconsService.load();
  }

  ngOnInit(): void {}


  logout() {
    this.accountService.facultyLogout();
    this.router.navigate(['/login']);
  }
}
