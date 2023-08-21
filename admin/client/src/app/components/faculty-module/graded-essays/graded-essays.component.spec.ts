import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GradedEssaysComponent } from './graded-essays.component';

describe('GradedEssaysComponent', () => {
  let component: GradedEssaysComponent;
  let fixture: ComponentFixture<GradedEssaysComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GradedEssaysComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(GradedEssaysComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
