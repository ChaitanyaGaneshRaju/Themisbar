import { Component } from '@angular/core';

@Component({
  selector: 'app-individual-view-graded-essays',
  templateUrl: './individual-view-graded-essays.component.html',
  styleUrls: ['./individual-view-graded-essays.component.css']
})
export class IndividualViewGradedEssaysComponent {
  assignments = Array.apply(null, Array(224)).map(function(){return {
    seq: Math.floor(Math.random() * 100) + 1,
    name: 'Read: Agency Outline',
    type: 'outline',
    subject: 'AGENCY',
    completed: '03/03/2023'
  }})
}
