import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Produto } from '../../../models/model.produto';
import { ProdutosService } from '../../../services/produtos/produtos.service';

@Component({
  selector: 'app-produto-edit',
  templateUrl: './produto-edit.component.html',
  styleUrl: './produto-edit.component.css'
})
export class ProdutoEditComponent {

  Produto:Produto;

  constructor(private activatedRoute:ActivatedRoute,
              private produtosService:ProdutosService,
              private router: Router){

    this.Produto = new Produto();
    const id: string | null = this.activatedRoute.snapshot.paramMap.get('id');

    this.produtosService.getById(Number(id)).subscribe({
      next: (jsonProduto:Produto) => {
        this.Produto = jsonProduto;
      }
    });
  }

  alterar():void{
    if(this.validarDadosExibirMensagem()){
      this.produtosService.put(this.Produto).subscribe({
        next: () => {
          alert('Produto alterado com sucesso');
          this.router.navigate(['/produtos']);
        },
        error:(jsonErro:any) => {
          this.exibirMensagemErro(jsonErro.status);
        }
      });
    }    
  } 

  excluir():void{
    if (confirm(`Você tem certeza de que deseja deletar este produto ${this.Produto.Id}?`)){
      this. produtosService.delete(this.Produto.Id).subscribe({
        next: () => {
          alert('Produto deletado com sucesso');
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
