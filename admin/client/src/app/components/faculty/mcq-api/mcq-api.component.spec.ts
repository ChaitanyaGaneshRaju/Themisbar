import { ComponentFixture, TestBed } from '@angular/core/testing';

import { McqApiComponent } from './mcq-api.component';

describe('McqApiComponent', () => {
  let component: McqApiComponent;
  let fixture: ComponentFixture<McqApiComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ McqApiComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(McqApiComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
