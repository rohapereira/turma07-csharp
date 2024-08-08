import { Injectable } from '@angular/core';
import { Usermodel } from '../model/user';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor() { }

  getUsers(): Usermodel[] {
    // Simulated data for demonstration
    const userListJason = [
      { "id": 1, "nome": "John Doe", "endereco": "teste", "email": "john@example.com" },
      { "id": 2, "nome": "Jane Smith", "endereco": "teste", "email": "jane@example.com" },
      { "id": 3, "nome": "Alice Johnson", "endereco": "teste", "email": "alice@example.com" }
    ];

    // Parse JSON data and map to UserModel objects
    return userListJason.map(user => new Usermodel(user.nome, user.endereco, user.email, user.id));
  }
}
