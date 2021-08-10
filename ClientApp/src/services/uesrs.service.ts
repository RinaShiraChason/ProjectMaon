

import { Injectable } from '@angular/core';
import { Observable} from 'rxjs';
import { HttpClient, HttpClientModule, HttpHeaders, HttpHandler } from '@angular/common/http';
import { HttpRequest } from '@angular/common/http';



//import { User } from '../classes';
/*
@Injectable({
  //providedIn: 'root'
})
*/
@Injectable()
export class UsersService {
  constructor(private HttpClient: HttpClient) {
  }

  endpoint = "http://localhost:44365/api/";
  //MyUser: User
  GetUsers() //:Observable<any>
  {
    return this.HttpClient.get(this.endpoint + 'Users/GetUsers');
  }
  FindUser(password: string, username: string): any {
    return this.HttpClient.get/*<User>*/
      (this.endpoint + 'Users/FindUser?username=' + username + '&password=' + password, { observe: 'response' });
    //alert(username);
    //alert(password);
  }

 

}
