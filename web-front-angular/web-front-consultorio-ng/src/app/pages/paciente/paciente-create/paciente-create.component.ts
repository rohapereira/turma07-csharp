import { Component } from '@angular/core';
import { Paciente } from '../../../Models/model.paciente';
import { PacientesService } from '../../../services/pacientes/pacientes.service';
import { Route, Router } from '@angular/router';

@Component({
  selector: 'app-paciente-create',
  templateUrl: './paciente-create.component.html',
  styleUrl: './paciente-create.component.css'
})
export class PacienteCreateComponent {

  Paciente: Paciente;

  constructor(private pacientesService:PacientesService,
              private router:Router){
    this.Paciente = new Paciente();
  }

  enviar():void{
    this.pacientesService.post(this.Paciente).subscribe({
      next: () => {
        alert('Paciente adicionado com sucesso');
        this.router.navigate(['/pacientes']);
      }
    });
    console.log(this.Paciente);
  }
}
