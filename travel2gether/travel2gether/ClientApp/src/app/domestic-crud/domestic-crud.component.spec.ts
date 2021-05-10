import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DomesticCRUDComponent } from './domestic-crud.component';

describe('DomesticCRUDComponent', () => {
  let component: DomesticCRUDComponent;
  let fixture: ComponentFixture<DomesticCRUDComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DomesticCRUDComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DomesticCRUDComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
