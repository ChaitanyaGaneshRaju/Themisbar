import { Injectable } from '@angular/core';
import { BehaviorSubject, map, tap } from 'rxjs';
import { UserDataToken } from '../interfaces/user-data-token';
import { HttpClient } from '@angular/common/http';
import { LocalStorageService } from './local-storage.service';

@Injectable({
  providedIn: 'root'
})
export class AccountService {

  readonly baseUrl: string = 'http://localhost:5001/api/';

  private currentUserSource = new BehaviorSubject<UserDataToken | null>(null);
  currentUser$ = this.currentUserSource.asObservable();

  constructor(private http: HttpClient, private localStorageService: LocalStorageService ) { }


  facultyLogin(model: any){
    return this.http.post<UserDataToken>(this.baseUrl + 'account/facultyLogin', model).pipe(
      tap((response: UserDataToken) => {
        const userDataToken = response;
        if (userDataToken){
          this.localStorageService.setObject("userDataToken",userDataToken);
          this.setCurrentuserDataToken(userDataToken);
        }
      })
    )
  }

  getCurrentuserDataToken(){
    return this.localStorageService.getItem("userDataToken");
  }

  setCurrentuserDataToken(userDataToken: UserDataToken){
    this.currentUserSource.next(userDataToken);
  }

  facultyLogout(){
    this.localStorageService.removeItem("userDataToken");
    this.currentUserSource.next(null);
  }

}
