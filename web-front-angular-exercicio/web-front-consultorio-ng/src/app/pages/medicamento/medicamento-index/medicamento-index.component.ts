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
  Id: number | null;
  Nome: string;


  constructor(private medicamentosService:MedicamentosService){
    this.Medicamentos = [];
    this.Id = null;
    this.Nome = '';
  }

  definirPesquisar():void{

    if(this.Id !== null){
      this.pesquisarPorId(this.Id);
      return;
    }

    if(this.Nome !== ''){
      this.pesquisarPorNome(this.Nome);
      return;
    }

    this.pesquisar();
  }

  pesquisar():void{
    this.medicamentosService.get().subscribe({
      next: (jsonMedicamentos:Medicamento[]) => {
        this.Medicamentos = jsonMedicamentos
      },
      error: (jsonErro:any) => {
        this.exibirMensagemErro(jsonErro.status);
      }
    });
  }

  pesquisarPorId(id:number):void{
    this.medicamentosService.getById(id).subscribe({
      next: (jsonMedicamento:Medicamento) => {
        this.Medicamentos = [jsonMedicamento];
      },
      error: (jsonErro:any) => {
        this.exibirMensagemErro(jsonErro.status);
      }
    });
  }
  pesquisarPorNome(nome:string):void{
      this.medicamentosService.getByName(nome).subscribe({
        next: (jsonMedicamentos:Medicamento[]) => {
          this.Medicamentos = jsonMedicamentos;
        },
        error: (jsonErro:any) => {
          this.exibirMensagemErro(jsonErro.status);
        }
      });
  }

  exibirMensagemErro(status: number):void{
    if(status === 0)
      alert('Falha na requisição.\nEntre em contato com o suporte!');
    else if (status === 404)
      alert('Nenhum medicamento foi encontrado!');
    else if (status === 500)
      alert('Erro interno no servidor!\nEntre em contato com o Suporte!');
  }

}