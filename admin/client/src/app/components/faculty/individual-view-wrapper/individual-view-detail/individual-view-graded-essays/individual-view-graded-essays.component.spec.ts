import { ComponentFixture, TestBed } from '@angular/core/testing';

import { IndividualViewGradedEssaysComponent } from './individual-view-graded-essays.component';

describe('IndividualViewGradedEssaysComponent', () => {
  let component: IndividualViewGradedEssaysComponent;
  let fixture: ComponentFixture<IndividualViewGradedEssaysComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ IndividualViewGradedEssaysComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(IndividualViewGradedEssaysComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
