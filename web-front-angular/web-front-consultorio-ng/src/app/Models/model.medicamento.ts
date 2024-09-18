export class Medicamento{
    Id!: number;
    Nome: string;
    DataDeFabricacao: Date;
    DataDeVencimento!: Date | null;

    public constructor(){
        this.Nome = '';
        this.DataDeFabricacao = new Date();
    }
}