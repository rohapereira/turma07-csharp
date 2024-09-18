import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Paciente } from '../../Models/model.paciente';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class PacientesService {

  constructor(private httpClient:HttpClient) { }

  get():Observable<Paciente[]>{
    return this.httpClient.get<Paciente[]>('https://localhost:44319/api/pacientes')
  }

  getById(codigo:number):Observable<Paciente>{
    return this.httpClient.get<Paciente>(`https://localhost:44319/api/pacientes/${codigo}`)
  }

  put(paciente:Paciente):Observable<Paciente>{
    return this.httpClient.put<Paciente>(`https://localhost:44319/api/pacientes/${paciente.Codigo}`, paciente)
  }
  
  post(paciente:Paciente):Observable<Paciente>{
    return this.httpClient.post<Paciente>(`https://localhost:44319/api/pacientes/`,paciente)
  }

  delete(codigo:number):Observable<Paciente>{
    return this.httpClient.delete<Paciente>(`https://localhost:44319/api/pacientes/${codigo}`)
  }
}
