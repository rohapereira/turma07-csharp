import { Component } from '@angular/core';
import { Paciente } from '../../../Models/model.paciente';
import { PacientesService } from '../../../services/pacientes/pacientes.service';

@Component({
  selector: 'app-paciente-index',
  templateUrl: './paciente-index.component.html',
  styleUrl: './paciente-index.component.css'
})
export class PacienteIndexComponent {

  Pacientes:Paciente[];

  constructor(private pacienteService:PacientesService){
    this.Pacientes = [];
  }

  pesquisar():void{
    this.pacienteService.get().subscribe({
      next: (jsonPacientes:Paciente[]) => this.Pacientes = jsonPacientes
    });
  }
}
