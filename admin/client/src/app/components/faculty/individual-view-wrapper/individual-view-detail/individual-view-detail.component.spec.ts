import { ComponentFixture, TestBed } from '@angular/core/testing';

import { IndividualViewDetailComponent } from './individual-view-detail.component';

describe('IndividualViewDetailComponent', () => {
  let component: IndividualViewDetailComponent;
  let fixture: ComponentFixture<IndividualViewDetailComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ IndividualViewDetailComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(IndividualViewDetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
