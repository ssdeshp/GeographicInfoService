import { TestBed } from '@angular/core/testing';

import { ZipgeoService } from './zipgeo.service';

describe('ZipgeoService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: ZipgeoService = TestBed.get(ZipgeoService);
    expect(service).toBeTruthy();
  });
});
