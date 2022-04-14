import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddSubNumberComponent } from './add-sub-number.component';

describe('AddSubNumberComponent', () => {
  let component: AddSubNumberComponent;
  let fixture: ComponentFixture<AddSubNumberComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddSubNumberComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AddSubNumberComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
