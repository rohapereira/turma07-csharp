import { Component, inject } from '@angular/core';
import { Medicamento } from '../../../models/model.medicamento';
import { MedicamentosService } from '../../../services/medicamentos/medicamentos.service';
import { Route, Router } from '@angular/router';
import { MatDialog } from '@angular/material/dialog';
import { AlertaSucessooComponent } from '../../../shared/messages/alerta-sucessoo/alerta-sucessoo.component';

@Component({
  selector: 'app-medicamento-create',
  templateUrl: './medicamento-create.component.html',
  styleUrl: './medicamento-create.component.css'
})
export class MedicamentoCreateComponent {

  Medicamento: Medicamento;

  constructor(private medicamentosService:MedicamentosService,
              private router:Router,
              private dialog:MatDialog){
    this.Medicamento = new Medicamento();
  }
  //readonly dialog = inject(MatDialog); -> Adicionado na linha 18

  openDialog() {
    this.dialog.open(AlertaSucessooComponent);
  }

  enviar():void{
    if(this.validarDadosExibirMensagem()){
      this.medicamentosService.post(this.Medicamento).subscribe({
        next: () => {
          this.openDialog();
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