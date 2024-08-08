import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ComboboxSelectComponent } from './combobox-select.component';

describe('ComboboxSelectComponent', () => {
  let component: ComboboxSelectComponent;
  let fixture: ComponentFixture<ComboboxSelectComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ComboboxSelectComponent]
    });
    fixture = TestBed.createComponent(ComboboxSelectComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
