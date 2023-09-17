import { ComponentFixture, TestBed } from '@angular/core/testing';

import { IndividualViewWrapperComponent } from './individual-view-wrapper.component';

describe('IndividualViewWrapperComponent', () => {
  let component: IndividualViewWrapperComponent;
  let fixture: ComponentFixture<IndividualViewWrapperComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ IndividualViewWrapperComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(IndividualViewWrapperComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
