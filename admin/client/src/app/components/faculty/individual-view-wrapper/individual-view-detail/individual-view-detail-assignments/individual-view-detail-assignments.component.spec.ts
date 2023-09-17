import { ComponentFixture, TestBed } from '@angular/core/testing';

import { IndividualViewDetailAssignmentsComponent } from './individual-view-detail-assignments.component';

describe('IndividualViewDetailAssignmentsComponent', () => {
  let component: IndividualViewDetailAssignmentsComponent;
  let fixture: ComponentFixture<IndividualViewDetailAssignmentsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ IndividualViewDetailAssignmentsComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(IndividualViewDetailAssignmentsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
