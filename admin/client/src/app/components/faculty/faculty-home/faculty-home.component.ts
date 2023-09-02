import { Component } from '@angular/core';
import '@cds/core/icon/register.js';
import { UserToken } from 'src/app/interfaces/user-token';
import { AccountService } from 'src/app/services/account.service';
import { FacultyIconsService } from 'src/app/services/faculty-icons.service';

@Component({
  selector: 'app-faculty-home',
  templateUrl: './faculty-home.component.html',
  styleUrls: ['./faculty-home.component.css']
})

export class FacultyHomeComponent {
  demoCollapsible = true;

  constructor(private facultyIconsService: FacultyIconsService, private accountService: AccountService){
    this.facultyIconsService.load();
  }

  ngOnInit(): void {
  }

  setCurrentUserToken(){
    const userToken = localStorage.getItem("userToken");

    if(!userToken) return;
    const userTokenParsed: UserToken = JSON.parse(userToken);

    this.accountService.setCurrentUserToken(userTokenParsed);

  }

  logout(){
    this.accountService.facultyLogout();
  }

}
