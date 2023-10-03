import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class FacultyProfileService {

  readonly baseUrl: string = 'http://localhost:5001/api/';

  constructor(private http:HttpClient) { }

  getFacultyCourses(){
    return this.http.get(this.baseUrl + 'Faculty/GetCourses/')
  }

}
