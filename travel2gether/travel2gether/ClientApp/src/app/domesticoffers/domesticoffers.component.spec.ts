import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DomesticoffersComponent } from './domesticoffers.component';

describe('DomesticoffersComponent', () => {
  let component: DomesticoffersComponent;
  let fixture: ComponentFixture<DomesticoffersComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DomesticoffersComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DomesticoffersComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
