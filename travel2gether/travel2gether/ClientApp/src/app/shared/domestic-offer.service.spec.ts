import { TestBed } from '@angular/core/testing';

import { DomesticOfferService } from './domestic-offer.service';

describe('DomesticOfferService', () => {
  let service: DomesticOfferService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(DomesticOfferService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
