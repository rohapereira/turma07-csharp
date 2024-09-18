import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AlertaSucessooComponent } from './alerta-sucessoo.component';

describe('AlertaSucessooComponent', () => {
  let component: AlertaSucessooComponent;
  let fixture: ComponentFixture<AlertaSucessooComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [AlertaSucessooComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AlertaSucessooComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
