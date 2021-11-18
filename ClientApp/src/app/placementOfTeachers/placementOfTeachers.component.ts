
import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { NgForm } from '@angular/forms';
import { UsersService } from '../../services/uesrs.service';


@Component({
  selector: 'app-placementOfTeachers',
  templateUrl: './placementOfTeachers.component.html'
})

  //דף שיבוץ גננות

export class PlacementOfTeachersComponent {
  constructor(private UsersService: UsersService) {}
   user = { name: '', password: '' };
    onSubmit(f: NgForm) {
      this.UsersService.FindUser(this.user.password,this.user.name);
  }
}


