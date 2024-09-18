import { Component } from '@angular/core';
import { Produto } from '../../../models/model.produto';
import { ProdutosService } from '../../../services/produtos/produtos.service';

@Component({
  selector: 'app-produto-index',
  templateUrl: './produto-index.component.html',
  styleUrl: './produto-index.component.css'
})
export class ProdutoIndexComponent {

  Produtos:Produto[];
  Id:number | null;
  Nome:string;

  constructor(private produtoService:ProdutosService){
    this.Produtos = [];
    this.Id = null;
    this.Nome = '';
  }

  definirPesquisa():void{
    if(this.Id !== null){
      this.pesquisarPorId(Number(this.Id));
      this.limparCampos();
      return;
    }

    if(this.Nome !== ''){
      this.pesquisarPorNome(this.Nome);
      this.limparCampos();
      return;
    }

    this.pesquisar();
    this.limparCampos();
  }

  pesquisar():void{
    this.produtoService.get().subscribe({
      next: (jsonProdutos:Produto[]) => this.Produtos = jsonProdutos
    });
  }

  pesquisarPorId(id:number):void{
    this.produtoService.getById(Number(id)).subscribe({
      next: (jsonProduto:Produto) => {
        this.Produtos = [jsonProduto];
      },
      error:(jsonErro:any) => {
        this.exibirMensagemErro(jsonErro.status);
      }
    });
  }

  pesquisarPorNome(nome:string):void{
    this.produtoService.getByName(nome).subscribe({
      next: (jsonProdutos:Produto[]) => {
        this.Produtos = jsonProdutos;

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
      alert('Nenhum produto foi encontrado!');
    else if (status === 500)
      alert('Erro interno no servidor.\nEntre em contanto com o suporte!');
  }

  limparCampos(): void {
    this.Id = null;
    this.Nome = '';
  } 
}
