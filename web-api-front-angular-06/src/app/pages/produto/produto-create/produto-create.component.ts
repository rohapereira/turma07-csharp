import { Component } from '@angular/core';
import { Produto } from '../../../models/model.produto';
import { ProdutosService } from '../../../services/produtos/produtos.service';
import { Route, Router } from '@angular/router';

@Component({
  selector: 'app-produto-create',
  templateUrl: './produto-create.component.html',
  styleUrl: './produto-create.component.css'
})
export class ProdutoCreateComponent {

  Produto: Produto;

  constructor(private produtosService:ProdutosService,
              private router:Router){
    this.Produto = new Produto();
  }

  enviar():void{
    if(this.validarDadosExibirMensagem()){
      this.produtosService.post(this.Produto).subscribe({
        next: () => {
          alert('Produto adicionado com sucesso');
          this.router.navigate(['/produtos']);
        },
        error:(jsonErro:any) => {
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
      alert('Nenhum produto foi encontrado!');
    else if (status === 500)
      alert('Erro interno no servidor.\nEntre em contanto com o suporte!');
  }

  validarDadosExibirMensagem():boolean{
    let msg:string = '';

    if(this.Produto.Nome === ''){
      msg += 'Nome;\n';
    }

    if(this.Produto.Estoque.toString() === ''){
      msg += 'Estoque;\n';
    }

    if(msg !== ''){
      msg = 'Preencha corretamente os dados a seguir:\n' + msg;
      alert(msg);
      return false;
    }
    return true
  }
}
