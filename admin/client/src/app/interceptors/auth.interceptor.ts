import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor
} from '@angular/common/http';
import { Observable } from 'rxjs';
import { UserDataToken } from '../interfaces/user-data-token';

@Injectable()
export class AuthInterceptor implements HttpInterceptor {

  constructor() {}

  intercept(request: HttpRequest<unknown>, next: HttpHandler): Observable<HttpEvent<unknown>> {

    const userDataToken = localStorage.getItem("userDataToken");

    const userDataTokenParsed: UserDataToken = JSON.parse(userDataToken || '{}');

    const token = userDataTokenParsed["token"]

    if (!token) {
      return next.handle(request);
    }

    const requestClone = request.clone({
      headers: request.headers.set('Authorization', `Bearer ${token}`),
    });


    return next.handle(requestClone);
  }
}
