import { ComponentFixture, TestBed } from '@angular/core/testing';

import { IndividualViewDetailPracticeExamsComponent } from './individual-view-detail-practice-exams.component';

describe('IndividualViewDetailPracticeExamsComponent', () => {
  let component: IndividualViewDetailPracticeExamsComponent;
  let fixture: ComponentFixture<IndividualViewDetailPracticeExamsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ IndividualViewDetailPracticeExamsComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(IndividualViewDetailPracticeExamsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
