import { Component } from '@angular/core';

@Component({
  selector: 'app-individual-view-details-detail-individual-view-detail-mbe-pqs',
  templateUrl: './individual-view-detail-mbe-pqs.component.html',
  styleUrls: ['./individual-view-detail-mbe-pqs.component.css']
})
export class IndividualViewDetailMbePqsComponent {
  assignments = Array.apply(null, Array(224)).map(function(){return {
    seq: Math.floor(Math.random() * 100) + 1,
    name: 'Read: Agency Outline',
    type: 'outline',
    subject: 'AGENCY',
    completed: '03/03/2023'
  }})
}
