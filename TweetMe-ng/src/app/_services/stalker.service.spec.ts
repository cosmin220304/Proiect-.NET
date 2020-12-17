import { TestBed } from '@angular/core/testing';

import { StalkerService } from './stalker.service';

describe('StalkerService', () => {
  let service: StalkerService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(StalkerService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
