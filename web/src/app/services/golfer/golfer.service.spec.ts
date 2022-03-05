import { TestBed, inject } from '@angular/core/testing';
import { GolferService } from './golfer.service';

describe('Service: Golfer', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [GolferService]
    });
  });

  it('should ...', inject([GolferService], (service: GolferService) => {
    expect(service).toBeTruthy();
  }));
});
