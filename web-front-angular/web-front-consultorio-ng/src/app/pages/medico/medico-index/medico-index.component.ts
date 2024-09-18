import { Component } from '@angular/core';
import { Medico } from '../../../Models/model.medico';
import { MedicosService } from '../../../services/medicos/medicos.service';

@Component({
  selector: 'app-medico-index',
  templateUrl: './medico-index.component.html',
  styleUrl: './medico-index.component.css'
})
export class MedicoIndexComponent {

  Medicos:Medico[];

  constructor(private medicoService:MedicosService){
    this.Medicos = [];
  }

  pesquisar():void{
    this.medicoService.get().subscribe({
      next: (jsonMedicos:Medico[]) => this.Medicos = jsonMedicos
    });
  }
}
