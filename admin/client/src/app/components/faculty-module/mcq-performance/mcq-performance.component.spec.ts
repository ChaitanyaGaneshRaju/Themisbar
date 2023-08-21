import { ComponentFixture, TestBed } from '@angular/core/testing';

import { McqPerformanceComponent } from './mcq-performance.component';

describe('McqPerformanceComponent', () => {
  let component: McqPerformanceComponent;
  let fixture: ComponentFixture<McqPerformanceComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ McqPerformanceComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(McqPerformanceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
