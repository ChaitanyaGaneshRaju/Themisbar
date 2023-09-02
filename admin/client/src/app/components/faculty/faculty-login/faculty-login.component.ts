import {
  Component,
  ElementRef,
  ViewChild,
  QueryList,
  ViewChildren,
} from '@angular/core';
import { NgForm } from '@angular/forms';
import { Title } from '@angular/platform-browser';
import { Router } from '@angular/router';
import { ClrForm } from '@clr/angular';
import { Observable } from 'rxjs';
import { AccountService } from 'src/app/services/account.service';

@Component({
  selector: 'app-faculty-login',
  templateUrl: './faculty-login.component.html',
  styleUrls: ['./faculty-login.component.css'],
})
export class FacultyLoginComponent {
  model: any = {};
  loginError: boolean = false;
  @ViewChild('submitButton', { static: false }) submitButton!: ElementRef;
  @ViewChildren('errorText') errorText!: QueryList<ElementRef>;
  @ViewChild('loginFrom') form!: NgForm;

  private errorTextSubscription!: any;

  constructor(
    private titleService: Title,
    private accountService: AccountService,
    private router: Router
  ) {
    this.titleService.setTitle('Faculty Login');
  }

  login() {
    if (this.form.invalid) {
      Object.values(this.form.controls).forEach((control) => {
        control.markAsTouched();
      });
      return;
    }
    this.submitButton.nativeElement.disabled = true;
    this.accountService.facultyLogin(this.model).subscribe({
      next: (response) => {
        this.router.navigate(['/faculty/520/report-detail']);
      },
      error: (errorResponse) => {
        console.log(errorResponse);
        this.submitButton.nativeElement.disabled = false;
        this.errorTextSubscription = this.errorText.changes.subscribe(
          (comps: QueryList<ElementRef>) => {
            comps.first.nativeElement.innerText = errorResponse.error.message;
          }
        );
        this.loginError = true;
      },
    });
  }

  clearError() {
    this.loginError = false;
    this.errorTextSubscription.unsubscribe();
  }
}
