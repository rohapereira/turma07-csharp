import { Component } from '@angular/core';
import { Usermodel } from '../model/user';
import { Router } from '@angular/router';
import { MatSnackBar, MatSnackBarHorizontalPosition, MatSnackBarVerticalPosition } from '@angular/material/snack-bar';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent {

  horizontalPosition: MatSnackBarHorizontalPosition = "center";

  verticalPosition: MatSnackBarVerticalPosition = "top";

  public user: Usermodel = this.limpar();

  constructor(private _snackBar: MatSnackBar, private router: Router) {}

  private limpar(): Usermodel {
    return {
      id: 0,
      nome: '',
      endereco: '',
      email: ''
    }
  }

  openSnackBar(message: string) {
    this._snackBar.open(message, 'Ok', {
      horizontalPosition: this.horizontalPosition,
      verticalPosition: this.verticalPosition,
      duration: 5 * 1000,
    });
  }

  public register() {
    if (this.user.nome == '') {
      this.openSnackBar('Informe o nome.');
      return;
    } if (this.user.endereco == '') {
      this.openSnackBar('Informe o endereço.');
      return;
    } if (this.user.email == '') {
      this.openSnackBar('Informe o e-mail.');
      return;
    }

    localStorage.setItem('usuario', JSON.stringify(this.user));

    this.user = this.limpar();

    this.openSnackBar('Usuário cadastrado.');
  }

  goBack() {
    this.router.navigate(['/home']);
  }
}
