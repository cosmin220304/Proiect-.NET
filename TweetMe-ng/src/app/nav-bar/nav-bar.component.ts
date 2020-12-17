import { Component, OnInit } from '@angular/core';
import { AuthService } from '../_services/auth.service';

@Component({
  selector: 'app-nav-bar',
  templateUrl: './nav-bar.component.html',
  styleUrls: ['./nav-bar.component.sass']
})
export class NavBarComponent implements OnInit {
  username = "";

  constructor(public authService: AuthService) { }

  ngOnInit(): void {
  }

  getUsername(): void{
    this.username = this.authService.user;
  }

}
