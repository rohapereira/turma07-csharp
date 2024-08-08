import { Component, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Usermodel } from '../model/user';
import { UserService } from '../service/user.service';

@Component({
  selector: 'app-user-details-modal',
  templateUrl: './user-details-modal.component.html',
  styleUrls: ['./user-details-modal.component.scss']
})
export class UserDetailsModalComponent {

  userList!: Usermodel[];

  constructor(private userService: UserService,
    public dialogRef: MatDialogRef<UserDetailsModalComponent>,
    @Inject(MAT_DIALOG_DATA) public user: Usermodel
  ) {
    this.userList = this.userService.getUsers();
  }

  onClose(): void {
    this.dialogRef.close(this.user);
  }

  selectUser(user: Usermodel) {
    this.user = user;
    this.onClose();
  }
}
