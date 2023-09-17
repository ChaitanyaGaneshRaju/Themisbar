import { ComponentFixture, TestBed } from '@angular/core/testing';

import { IndividualViewDetailMbePqsComponent } from './individual-view-detail-mbe-pqs.component';

describe('IndividualViewDetailMbePqsComponent', () => {
  let component: IndividualViewDetailMbePqsComponent;
  let fixture: ComponentFixture<IndividualViewDetailMbePqsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ IndividualViewDetailMbePqsComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(IndividualViewDetailMbePqsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
