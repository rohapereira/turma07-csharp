export class Produto{
    Id!: number;
    Nome: string;
    Estoque: number | string;

    public constructor(){
        this.Nome = '';
        this.Estoque = '';
    }
}