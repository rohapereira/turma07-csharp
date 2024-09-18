import { Component } from '@angular/core';
import { Observable } from 'rxjs';
import { Medicamento } from '../../../Models/model.medicamento';
import { MedicamentosService } from '../../../services/medicamentos/medicamentos.service';

@Component({
  selector: 'app-medicamento-index',
  templateUrl: './medicamento-index.component.html',
  styleUrl: './medicamento-index.component.css'
})
export class MedicamentoIndexComponent {

  Medicamentos:Medicamento[]; //Propriedade Medicamentos do tipo array (lista)
  Id:number | null;
  Nome:string;

  constructor(private medicamentoService:MedicamentosService){ //Eu preciso instanciar (injetar) o MedicamentosService no MedicamentoIndexComponent para enxergar os métodos de requisição da minha API
    this.Medicamentos = []; //Iniciar a propriedade com valor (inicialmente vazio)
    this.Id = null;
    this.Nome = '';
  }

  definirPesquisa():void{
    if(this.Id !== null){
      this.pesquisarPorId(Number(this.Id));
      return;
    }

    if(this.Nome !== ''){
      this.pesquisarPorNome(this.Nome);
      return;
    }

    this.pesquisar();
  }

  pesquisar():void{
    this.medicamentoService.get().subscribe({
      next: (jsonMedicamentos:Medicamento[]) => this.Medicamentos = jsonMedicamentos
    });
  }

  pesquisarPorId(id:number):void{
    this.medicamentoService.getById(Number(id)).subscribe({
      next: (jsonMedicamento:Medicamento) => {
        this.Medicamentos = [jsonMedicamento];
      },
      error:(jsonErro:any) => {
        this.exibirMensagemErro(jsonErro.status);
      }
    });
  }

  pesquisarPorNome(nome:string):void{
    this.medicamentoService.getByName(nome).subscribe({
      next: (jsonMedicamento:Medicamento[]) => {
        this.Medicamentos = jsonMedicamento;

      },
      error:(jsonErro:any) => {
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
      alert('Erro interno no servidor.\nEntre em contanto com o suporte!');
  }
}
