import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GLocationComponent } from './g-location.component';

describe('GLocationComponent', () => {
  let component: GLocationComponent;
  let fixture: ComponentFixture<GLocationComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GLocationComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GLocationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
