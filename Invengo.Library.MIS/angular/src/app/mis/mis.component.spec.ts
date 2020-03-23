import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MisComponent } from './mis.component';

describe('MisComponent', () => {
  let component: MisComponent;
  let fixture: ComponentFixture<MisComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MisComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MisComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
