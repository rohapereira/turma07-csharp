import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Medico } from '../../Models/model.medico';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class MedicosService {

  constructor(private httpClient:HttpClient) { }

  get():Observable<Medico[]>{
    return this.httpClient.get<Medico[]>('https://localhost:44319/api/medicos')
  }

  getById(id:number):Observable<Medico>{
    return this.httpClient.get<Medico>(`https://localhost:44319/api/medicos/${id}`)
  }

  put(medico:Medico):Observable<Medico>{
    return this.httpClient.put<Medico>(`https://localhost:44319/api/medicos/${medico.Id}`, medico)
  }
  
  post(medico:Medico):Observable<Medico>{
    return this.httpClient.post<Medico>(`https://localhost:44319/api/medicos/`,medico)
  }

  delete(id:number):Observable<Medico>{
    return this.httpClient.delete<Medico>(`https://localhost:44319/api/medicos/${id}`)
  }
}
