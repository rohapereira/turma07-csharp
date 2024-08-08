import { AfterViewInit, Component, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';

interface ElementosPeriodico {
  posicao: number;
  nome: string;
  peso: number;
  simbolo: string;
}

@Component({
  selector: 'app-table',
  templateUrl: './table.component.html',
  styleUrls: ['./table.component.css']
})
export class TableComponent implements AfterViewInit {

  elementosData: ElementosPeriodico[] = [
    { posicao: 1, nome: 'Hidrogênio', peso: 1.0079, simbolo: 'H' },
    { posicao: 2, nome: 'Hélio', peso: 1.0079, simbolo: 'He' },
    { posicao: 3, nome: 'Lítio', peso: 4.0026, simbolo: 'Li' },
    { posicao: 4, nome: 'Berílio', peso: 6.941, simbolo: 'Be' },
    { posicao: 5, nome: 'Boro', peso: 9.0122, simbolo: 'B' },
    { posicao: 6, nome: 'Carbono', peso: 10.811, simbolo: 'C' },
    { posicao: 7, nome: 'Nitrogênio', peso: 12.0107, simbolo: 'N' },
    { posicao: 8, nome: 'Oxigênio', peso: 14.0067, simbolo: 'O' },
    { posicao: 9, nome: 'Flúor', peso: 15.9994, simbolo: 'F' },
    { posicao: 10, nome: 'Neônio', peso: 20.1797, simbolo: 'Ne' },
  ]

  novoElemento: ElementosPeriodico = {posicao: null, nome: '', peso: null, simbolo: ''};
  displayColunas: string[] = ['posicao', 'nome', 'peso', 'simbolo'];
  dataSource = new MatTableDataSource<ElementosPeriodico>(this.elementosData);
  linhasClicadas = new Set<ElementosPeriodico>();
  elementoSelecionado: ElementosPeriodico = null;
  elementoEditado: ElementosPeriodico = null;

  @ViewChild(MatPaginator, { static: true }) paginator: MatPaginator;

  ngAfterViewInit() {
      this.paginator._intl.itemsPerPageLabel = "Itens por página";
      this.paginator._intl.nextPageLabel = "Próxima página";
      this.paginator._intl.previousPageLabel = "Página anterior";
      this.paginator._intl.lastPageLabel = "Última página";
      this.paginator._intl.firstPageLabel = "Primeira página";

      this.dataSource.paginator = this.paginator;
  }

  AlterarDestaqueLinha(row: ElementosPeriodico){
    if (this.linhasClicadas.has(row)){
      this.linhasClicadas.delete(row);
    } else {
      this.linhasClicadas.add(row);
    }
  }

  aplicarFiltro(event: Event){
    const valorFiltrado = (event.target as HTMLInputElement).value;
    this.dataSource.filter = valorFiltrado.trim().toLowerCase();

    if (this.dataSource.paginator){
      this.dataSource.paginator.firstPage();
    }
  }

  selecionar(elemento: ElementosPeriodico){
    this.elementoSelecionado = { ... elemento };
    this.elementoEditado = { ... elemento };
  }

  salvarEdicao(){
    if (this.elementoEditado) {
      const index = this.elementosData.findIndex(e => e.posicao == this.elementoSelecionado!.posicao);

      if (index != -1) {
       this.elementosData[index] = this.elementoEditado;
       this.dataSource.data = this.elementosData.slice();
       this.elementoEditado = null;
       this.elementoSelecionado = null;
     }
    }    
  }

  cancelarEdicao(){
    if (this.elementoSelecionado){
      this.elementoEditado = { ... this.elementoSelecionado };
    }
    this.elementoSelecionado = null;
  }

  removerElemento(){
    if (this.elementoSelecionado){
      const index = this.elementosData.findIndex(e => e.posicao == this.elementoSelecionado.posicao);

      if (index != -1){
        this.elementosData.splice(index, 1);
        this.dataSource.data = this.elementosData.slice();
        this.elementoSelecionado = null;
      }
    }
  }

  adicionarElemento(){
    if (this.novoElemento.nome && this.novoElemento.peso && this.novoElemento.simbolo){
      this.elementosData.push({ ... this.novoElemento });
      this.dataSource.data = this.elementosData.slice();
      this.novoElemento = {posicao: null, nome: '', peso: null, simbolo: ''};
    }
  }
}
