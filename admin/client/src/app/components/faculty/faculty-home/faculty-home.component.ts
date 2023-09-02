import { Component } from '@angular/core';
import '@cds/core/icon/register.js';
import { FacultyIconsService } from 'src/app/services/faculty-icons.service';

@Component({
  selector: 'app-faculty-home',
  templateUrl: './faculty-home.component.html',
  styleUrls: ['./faculty-home.component.css']
})

export class FacultyHomeComponent {
  demoCollapsible = true;

  constructor(private facultyIconsService: FacultyIconsService){
    this.facultyIconsService.load();
  }

}
