import { Component } from '@angular/core';
import { Medicamento } from '../../../models/model.medicamento';
import { MedicamentosService } from '../../../services/medicamentos/medicamentos.service';
import { Route, Router } from '@angular/router';

@Component({
  selector: 'app-medicamento-create',
  templateUrl: './medicamento-create.component.html',
  styleUrl: './medicamento-create.component.css'
})
export class MedicamentoCreateComponent {

  Medicamento: Medicamento;

  constructor(private medicamentosService:MedicamentosService,
              private router:Router){
    this.Medicamento = new Medicamento();
  }

  enviar():void{
    this.medicamentosService.post(this.Medicamento).subscribe({
      next: () => {
        alert('Medicamento adicionado com sucesso');
        this.router.navigate(['/medicamentos']);
      }
    });
    console.log(this.Medicamento);
  }
}