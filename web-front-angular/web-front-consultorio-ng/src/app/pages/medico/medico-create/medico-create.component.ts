import { Component } from '@angular/core';
import { Medico } from '../../../Models/model.medico';
import { MedicosService } from '../../../services/medicos/medicos.service';
import { Route, Router } from '@angular/router';

@Component({
  selector: 'app-medico-create',
  templateUrl: './medico-create.component.html',
  styleUrl: './medico-create.component.css'
})
export class MedicoCreateComponent {

  Medico: Medico;

  constructor(private medicosService:MedicosService,
              private router:Router){
    this.Medico = new Medico();
  }

  enviar():void{
    this.medicosService.post(this.Medico).subscribe({
      next: () => {
        alert('Medico adicionado com sucesso');
        this.router.navigate(['/medicos']);
      }
    });
    console.log(this.Medico);
  }
}
