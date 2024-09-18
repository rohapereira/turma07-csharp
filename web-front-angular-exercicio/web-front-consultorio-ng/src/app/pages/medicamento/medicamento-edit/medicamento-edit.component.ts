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
    if(this.validarDadosExibirMensagem()){
      this.medicamentosService.put(this.Medicamento).subscribe({
        next: () => {
          alert('Medicamento alterado com sucesso');
          this.router.navigate(['/medicamentos']);
        },
        error: (jsonErro:any) => {
          this.exibirMensagemErro(jsonErro.status);
        }
      });
    }
  } 

  excluir():void{
    if (confirm(`Você tem certeza de que deseja deletar este medicamento ${this.Medicamento.Id}?`)){
      this.medicamentosService.delete(this.Medicamento.Id).subscribe({
        next: () => {
          alert('Medicamento deletado com sucesso');
          this.router.navigate(['/medicamentos']);
        },
        error: (jsonErro:any) => {
          this.exibirMensagemErro(jsonErro.status);
        }
      });
    }
  }

  exibirMensagemErro(status: number):void{
    if(status === 0)
      alert('Falha na requisição.\nEntre em contato com o suporte!');
    else if (status === 400)
      alert('Verifique os dados que estão sendo enviados!');
    else if (status === 404)
      alert('Nenhum medicamento foi encontrado!');
    else if (status === 500)
      alert('Erro interno no servidor!\nEntre em contato com o Suporte!');
  }

  validarDadosExibirMensagem():boolean{
    let msg:string = '';

    if(this.Medicamento.Nome === ''){
      msg += 'Nome;\n';
    }

    if(this.Medicamento.DataDeFabricacao.toString() === ''){
      msg += 'Data de Fabricação;\n'
    }

    if(this.Medicamento.DataDeVencimento !== null 
      && this.Medicamento.DataDeVencimento?.toString() !== ''
      && this.Medicamento.DataDeVencimento < this.Medicamento.DataDeFabricacao){
      msg += 'Data de fabricação não pode ser maior que a data de vencimento';  
    }
    
    if(msg !== ''){
      msg = 'Preencha corretamente os dados a seguir:\n' + msg;
      alert(msg);
      return false;
    }
    
    return true
  }
  
}