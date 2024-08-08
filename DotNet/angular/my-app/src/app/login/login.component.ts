import { Component } from '@angular/core';
import { MatSnackBar, MatSnackBarHorizontalPosition, MatSnackBarVerticalPosition } from '@angular/material/snack-bar';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent {

  public username: string = "";

  public password: string = "";

  horizontalPosition: MatSnackBarHorizontalPosition = "center";

  verticalPosition: MatSnackBarVerticalPosition = "top";

  constructor(private _snackBar: MatSnackBar, private router: Router) {}

  login() {
    //Implement your login logic here
    console.log("Username:", this.username);
    console.log("Password:", this.password);

    if (this.username == "") {
      this.openSnackBar("Informe o usuário.");
      return;
    }

    if (this.password == "") {
      this.openSnackBar("Informe a senha.");
      return;
    }

    this.router.navigate(["/home"]);
  }

  openSnackBar(message: string) {
    this._snackBar.open(message, "Ok", {
      horizontalPosition: this.horizontalPosition,
      verticalPosition: this.verticalPosition,
      duration: 5 * 1000,
    });
  }
}
