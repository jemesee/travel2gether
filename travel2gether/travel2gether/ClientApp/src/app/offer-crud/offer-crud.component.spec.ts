import { ComponentFixture, TestBed } from '@angular/core/testing';

import { OfferCRUDComponent } from './offer-crud.component';

describe('OfferCRUDComponent', () => {
  let component: OfferCRUDComponent;
  let fixture: ComponentFixture<OfferCRUDComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ OfferCRUDComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(OfferCRUDComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
