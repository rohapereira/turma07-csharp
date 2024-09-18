import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Medicamento } from '../../models/model.medicamento';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class MedicamentosService {
  
  constructor(private httpClient:HttpClient) {}
  
  get():Observable<Medicamento[]>{
    return this.httpClient.get<Medicamento[]>('https://localhost:44333/api/medicamentos')
  }

  getById(id:number):Observable<Medicamento>{
    return this.httpClient.get<Medicamento>(`https://localhost:44333/api/medicamentos/${id}`)
  }

  put(medicamento:Medicamento):Observable<Medicamento>{
    return this.httpClient.put<Medicamento>(`https://localhost:44333/api/medicamentos/${medicamento.Id}`, medicamento)
  }
  
  post(medicamento:Medicamento):Observable<Medicamento>{
    return this.httpClient.post<Medicamento>(`https://localhost:44333/api/medicamentos/`,medicamento)
  }

  delete(id:number):Observable<Medicamento>{
    return this.httpClient.delete<Medicamento>(`https://localhost:44333/api/medicamentos/${id}`)
  }
}