import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { PacientesService } from '../../../services/pacientes/pacientes.service';
import { Paciente } from '../../../Models/model.paciente';

@Component({
  selector: 'app-paciente-edit',
  templateUrl: './paciente-edit.component.html',
  styleUrl: './paciente-edit.component.css'
})
export class PacienteEditComponent {

  Paciente:Paciente;

  constructor(private activatedRoute:ActivatedRoute,
              private pacientesService:PacientesService,
              private router: Router){

    this.Paciente = new Paciente();
    const codigo: string | null = this.activatedRoute.snapshot.paramMap.get('codigo');

    this.pacientesService.getById(Number(codigo)).subscribe({
      next: (jsonPacientes:Paciente) => {
        this.Paciente = jsonPacientes;
      }
    });
  }

  alterar():void{
    this.pacientesService.put(this.Paciente).subscribe({
      next: () => {
        alert('Paciente alterado com sucesso');
        this.router.navigate(['/pacientes']);
      }
    });
  } 

  excluir():void{
    if (confirm(`Você tem certeza de que deseja deletar este paciente ${this.Paciente.Codigo}?`)){
      this.pacientesService.delete(this.Paciente.Codigo).subscribe({
        next: () => {
          alert('Paciente deletado com sucesso');
          this.router.navigate(['/pacientes']);
        }
      });
    }
  }
}
