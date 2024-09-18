import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Produto } from '../../models/model.produto';

@Injectable({
  providedIn: 'root'
})
export class ProdutosService {

  constructor(private httpClient:HttpClient) { }

  get():Observable<Produto[]>{
    return this.httpClient.get<Produto[]>('https://localhost:44352/api/produtos')
  }

  getById(id:number):Observable<Produto>{
    return this.httpClient.get<Produto>(`https://localhost:44352/api/produtos/${id}`)
  }

  getByName(nome:string):Observable<Produto[]>{
    return this.httpClient.get<Produto[]>(`https://localhost:44352/api/produtos?nome=${nome}`)
  }

  put(produto:Produto):Observable<Produto>{
    return this.httpClient.put<Produto>(`https://localhost:44352/api/produtos/${produto.Id}`, produto)
  }
  
  post(produto:Produto):Observable<Produto>{
    return this.httpClient.post<Produto>(`https://localhost:44352/api/produtos/`,produto)
  }

  delete(id:number):Observable<Produto>{
    return this.httpClient.delete<Produto>(`https://localhost:44352/api/produtos/${id}`)
  }
}
