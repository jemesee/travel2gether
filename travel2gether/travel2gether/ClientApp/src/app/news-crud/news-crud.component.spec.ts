import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NewsCRUDComponent } from './news-crud.component';

describe('NewsCRUDComponent', () => {
  let component: NewsCRUDComponent;
  let fixture: ComponentFixture<NewsCRUDComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NewsCRUDComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(NewsCRUDComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
