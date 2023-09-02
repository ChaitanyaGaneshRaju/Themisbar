import { Injectable } from '@angular/core';
import { BehaviorSubject, map, tap } from 'rxjs';
import { UserToken } from '../interfaces/user-token';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class AccountService {

  readonly baseUrl: string = 'http://localhost:5001/api/';

  private currentUserSource = new BehaviorSubject<UserToken | null>(null);
  currentUser$ = this.currentUserSource.asObservable();

  constructor(private http: HttpClient ) { }


  facultyLogin(model: any){
    return this.http.post<UserToken>(this.baseUrl + 'account/facultyLogin', model).pipe(
      tap((response: UserToken) => {
        const userToken = response;
        if (userToken){
          localStorage.setItem("userToken", JSON.stringify(userToken))
          this.setCurrentUserToken(userToken);
        }
      })
    )
  }

  getCurrentUserToken(){
    return localStorage.getItem("userToken");
  }

  setCurrentUserToken(userToken: UserToken){
    this.currentUserSource.next(userToken);
  }

  facultyLogout(){
    localStorage.removeItem("userToken");
    this.currentUserSource.next(null);
  }

}
