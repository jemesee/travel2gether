import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PageOfferComponent } from './page-offer.component';

describe('PageOfferComponent', () => {
  let component: PageOfferComponent;
  let fixture: ComponentFixture<PageOfferComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PageOfferComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PageOfferComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
