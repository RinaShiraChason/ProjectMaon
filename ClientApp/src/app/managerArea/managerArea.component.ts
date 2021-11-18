
import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { NgForm } from '@angular/forms';
import { UsersService } from '../../services/uesrs.service';


@Component({
  selector: 'app-managerArea',
  templateUrl: './managerArea.component.html'
})



export class ManagerAreaComponent {
  constructor(private UsersService: UsersService) {}
   user = { name: '', password: '' };
    onSubmit(f: NgForm) {
      this.UsersService.FindUser(this.user.password,this.user.name);
  }
}


