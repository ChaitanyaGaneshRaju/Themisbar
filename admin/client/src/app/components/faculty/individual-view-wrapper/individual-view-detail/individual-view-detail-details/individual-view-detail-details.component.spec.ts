import { ComponentFixture, TestBed } from '@angular/core/testing';

import { IndividualViewDetailDetailsComponent } from './individual-view-detail-details.component';

describe('IndividualViewDetailDetailsComponent', () => {
  let component: IndividualViewDetailDetailsComponent;
  let fixture: ComponentFixture<IndividualViewDetailDetailsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ IndividualViewDetailDetailsComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(IndividualViewDetailDetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
