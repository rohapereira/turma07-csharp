import { Component } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';

interface ElementosPeriodicos {
  posicao: number;
  nome: string;
  peso: number;
  simbolo: string;
}

const ELEMENTOS_DATA: ElementosPeriodicos[] = [
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

@Component({
  selector: 'app-select',
  templateUrl: './select.component.html',
  styleUrls: ['./select.component.css']
})
export class SelectComponent {

  displayColunas: string[] = ['posicao', 'nome', 'peso', 'simbolo'];
  dataSource = new MatTableDataSource(ELEMENTOS_DATA);

  aplicarFiltro(event: Event){
    const valorFiltrado = (event.target as HTMLInputElement).value;
    this.dataSource.filter = valorFiltrado.trim().toLowerCase();
  }
}
