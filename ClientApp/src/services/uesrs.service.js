"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.UsersService = void 0;
//import { User } from '../classes';
/*
@Injectable({
  //providedIn: 'root'
})
*/
var UsersService = /** @class */ (function () {
    function UsersService(HttpClient) {
        this.HttpClient = HttpClient;
        this.endpoint = "http://localhost:49699/api/";
    }
    //MyUser: User
    UsersService.prototype.GetUsers = function () {
        return this.HttpClient.get(this.endpoint + 'Users/GetUsers');
    };
    UsersService.prototype.FindUser = function (password, username) {
        return this.HttpClient.get /*<User>*/(this.endpoint + 'Users/FindUser?username=' + username + '&password=' + password, { observe: 'response' });
    };
    return UsersService;
}());
exports.UsersService = UsersService;
//# sourceMappingURL=uesrs.service.js.map