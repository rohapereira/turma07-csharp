import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { MedicamentosService } from '../../../services/medicamentos/medicamentos.service';
import { Medicamento } from '../../../models/model.medicamento';

@Component({
  selector: 'app-medicamento-edit',
  templateUrl: './medicamento-edit.component.html',
  styleUrl: './medicamento-edit.component.css'
})
export class MedicamentoEditComponent {

  Medicamento:Medicamento;

  constructor(private activatedRoute:ActivatedRoute,
              private medicamentosService:MedicamentosService,
              private router: Router){

    this.Medicamento = new Medicamento();
    const id: string | null = this.activatedRoute.snapshot.paramMap.get('id');

    this.medicamentosService.getById(Number(id)).subscribe({
      next: (jsonMedicamento:Medicamento) => {
        this.Medicamento = jsonMedicamento;
      }
    });
  }

  alterar():void{
    this.medicamentosService.put(this.Medicamento).subscribe({
      next: () => {
        alert('Medicamento alterado com sucesso');
        this.router.navigate(['/medicamentos']);
      }
    });
  } 

  excluir():void{
    if (confirm(`Você tem certeza de que deseja deletar este medicamento ${this.Medicamento.Id}?`)){
      this.medicamentosService.delete(this.Medicamento.Id).subscribe({
        next: () => {
          alert('Medicamento deletado com sucesso');
          this.router.navigate(['/medicamentos']);
        }
      });
    }
  }
  
}