import { TestBed } from '@angular/core/testing';

import { FacultyIconsService } from './faculty-icons.service';

describe('FacultyIconsService', () => {
  let service: FacultyIconsService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(FacultyIconsService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
