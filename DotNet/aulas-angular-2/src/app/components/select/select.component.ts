import { Component } from '@angular/core';

interface Carros {
  codigo: number;
  marca: string;
};

@Component({
  selector: 'app-select',
  templateUrl: './select.component.html',
  styleUrls: ['./select.component.css']
})
export class SelectComponent {

  carroSelecionado: string;

  carros: Carros[] = [
    { codigo: 1, marca: "Toyota Corolla" },
    { codigo: 2, marca: "Ford Ka" },
    { codigo: 3, marca: "Toyota SW4" },
  ];
}
