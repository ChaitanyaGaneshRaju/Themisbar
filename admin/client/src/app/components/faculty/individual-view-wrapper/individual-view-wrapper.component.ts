import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-individual-view-wrapper',
  templateUrl: './individual-view-wrapper.component.html',
  styleUrls: ['./individual-view-wrapper.component.css']
})
export class IndividualViewWrapperComponent {
  constructor(private router:Router){

  }
}
