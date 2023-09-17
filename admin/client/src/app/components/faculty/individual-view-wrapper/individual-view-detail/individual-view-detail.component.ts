import { Component } from '@angular/core';
import { FacultyIconsService } from 'src/app/services/faculty-icons.service';

@Component({
  selector: 'app-individual-view-detail',
  templateUrl: './individual-view-detail.component.html',
  styleUrls: ['./individual-view-detail.component.css']
})
export class IndividualViewDetailComponent {

  constructor(private facultyIconsService: FacultyIconsService){
    this.facultyIconsService.load();
  }

}
