import { Component } from '@angular/core';
import { MedicamentosService } from '../../../services/medicamentos/medicamentos.service';
import { Medicamento } from '../../../models/model.medicamento';

@Component({
  selector: 'app-medicamento-index',
  templateUrl: './medicamento-index.component.html',
  styleUrl: './medicamento-index.component.css'
})
export class MedicamentoIndexComponent {  

  Medicamentos:Medicamento[];

  constructor(private medicamentosService:MedicamentosService){
    this.Medicamentos = [];
  }

  pesquisar():void{
    this.medicamentosService.get().subscribe({
      next: (jsonMedicamentos:Medicamento[]) => this.Medicamentos = jsonMedicamentos
    });
  }
}