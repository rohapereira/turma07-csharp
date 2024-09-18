import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { MedicosService } from '../../../services/medicos/medicos.service';
import { Medico } from '../../../Models/model.medico';

@Component({
  selector: 'app-medico-edit',
  templateUrl: './medico-edit.component.html',
  styleUrl: './medico-edit.component.css'
})
export class MedicoEditComponent {

  Medico:Medico;

  constructor(private activatedRoute:ActivatedRoute,
              private medicosService:MedicosService,
              private router: Router){

    this.Medico = new Medico();
    const id: string | null = this.activatedRoute.snapshot.paramMap.get('id');

    this.medicosService.getById(Number(id)).subscribe({
      next: (jsonMedicos:Medico) => {
        this.Medico = jsonMedicos;
      }
    });
  }

  alterar():void{
    this.medicosService.put(this.Medico).subscribe({
      next: () => {
        alert('Medico alterado com sucesso');
        this.router.navigate(['/medicos']);
      }
    });
  } 

  excluir():void{
    if (confirm(`Você tem certeza de que deseja deletar este medico ${this.Medico.Id}?`)){
      this.medicosService.delete(this.Medico.Id).subscribe({
        next: () => {
          alert('Medico deletado com sucesso');
          this.router.navigate(['/medicos']);
        }
      });
    }
  }
}
