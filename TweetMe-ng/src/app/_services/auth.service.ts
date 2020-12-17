import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  public user = ""

  constructor() { }

  loggedIn(): any{
    this.user = localStorage.getItem('username');
    return this.user === "" ? false : true;
  }
}
