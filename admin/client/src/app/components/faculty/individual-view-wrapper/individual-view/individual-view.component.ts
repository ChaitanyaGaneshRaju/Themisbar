import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ClrDataGridComparator } from 'src/app/comparators/clr-data-grid.comparator';

@Component({
  selector: 'app-individual-view',
  templateUrl: './individual-view.component.html',
  styleUrls: ['./individual-view.component.css']
})
export class IndividualViewComponent {

  public customComparator = new ClrDataGridComparator();

  users = Array.apply(null, Array(224)).map(function(){return {
    name: 'Chaitanya GaneshRaju Sarikonda',
    email: 'csarikonda_learner@uworld.in',
    course: 'Illinois Bar Review - 520',
    percentageCompleted: Math.floor(Math.random() * 100) + 1,
  }})

  constructor(private router: Router, private activatedRoute: ActivatedRoute){
  }

  gotoUserIndividualView(){
    this.router.navigate(['./detail/1222'], {relativeTo: this.activatedRoute})
  }

}
