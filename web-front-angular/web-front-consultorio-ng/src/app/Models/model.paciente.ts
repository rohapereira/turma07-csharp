export class Paciente{
    Codigo!: number;
    Nome: string;
    DataNascimento: Date;

    public constructor(){
        this.Nome = '';
        this.DataNascimento = new Date();
    }
}