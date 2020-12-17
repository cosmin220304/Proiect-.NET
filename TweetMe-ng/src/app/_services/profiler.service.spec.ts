import { TestBed } from '@angular/core/testing';

import { ProfilerService } from './profiler.service';

describe('ProfilerService', () => {
  let service: ProfilerService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ProfilerService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
