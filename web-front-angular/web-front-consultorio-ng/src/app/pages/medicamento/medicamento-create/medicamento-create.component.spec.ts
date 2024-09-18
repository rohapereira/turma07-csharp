import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MedicamentoCreateComponent } from './medicamento-create.component';

describe('MedicamentoCreateComponent', () => {
  let component: MedicamentoCreateComponent;
  let fixture: ComponentFixture<MedicamentoCreateComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [MedicamentoCreateComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MedicamentoCreateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
