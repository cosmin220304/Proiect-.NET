import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor() { }

  loggedIn(): any{
    var user = localStorage.getItem('username');
    return user === "" ? false : true;
  }

  getLoggedUser(){
    return localStorage.getItem('username');
  }
}
