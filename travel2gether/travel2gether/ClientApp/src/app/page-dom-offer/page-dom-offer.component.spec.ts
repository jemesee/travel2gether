import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PageDomOfferComponent } from './page-dom-offer.component';

describe('PageDomOfferComponent', () => {
  let component: PageDomOfferComponent;
  let fixture: ComponentFixture<PageDomOfferComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PageDomOfferComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PageDomOfferComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
