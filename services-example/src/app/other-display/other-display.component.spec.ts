import { ComponentFixture, TestBed } from '@angular/core/testing';

import { OtherDisplayComponent } from './other-display.component';

describe('OtherDisplayComponent', () => {
  let component: OtherDisplayComponent;
  let fixture: ComponentFixture<OtherDisplayComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ OtherDisplayComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(OtherDisplayComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
