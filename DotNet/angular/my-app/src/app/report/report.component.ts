import { Component } from '@angular/core';
import { Usermodel } from '../model/user';
import { MatDialog, MatDialogRef } from '@angular/material/dialog';
import { UserDetailsModalComponent } from '../user-details-modal/user-details-modal.component';
import { Router } from '@angular/router';

@Component({
  selector: 'app-report',
  templateUrl: './report.component.html',
  styleUrls: ['./report.component.scss']
})
export class ReportComponent {

  user: Usermodel = new Usermodel('', '', '', 0);

  constructor(public dialog: MatDialog, private router: Router) {}

  openUserDetailsModal(user: Usermodel): void {
    const dialogRef = this.dialog.open(UserDetailsModalComponent, {
      width: '300px',
      data: user
    });

    dialogRef.afterClosed().subscribe(result => {
      console.log('The dialog was closed');
    });
  }

  openAllUsersModal(): void {
    const dialogRef = this.dialog.open(UserDetailsModalComponent, {
      width: '500px',
      data: {}
    });

    dialogRef.afterClosed().subscribe(result => {
      if (result)
        this.user = result;
    });
  }

  goBack() {
    this.router.navigate(['/home']);
  }
}
