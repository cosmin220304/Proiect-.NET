import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { User } from '../_models/user';
import { StalkerService } from '../_services/stalker.service';

@Component({
  selector: 'app-friends',
  templateUrl: './friends.component.html',
  styleUrls: ['./friends.component.sass']
})
export class FriendsComponent implements OnInit {
  fs:string = 'all';
  user: string;
  friends: User[] = [];
  readyToShow = 0;

  constructor(private stalker: StalkerService, private activatedRoute: ActivatedRoute) {
    this.activatedRoute.queryParams.subscribe(params => {
      this.user = params['username'];
      console.log(this.user); 
    });
   }

  ngOnInit(): void {
    this.stalker.getFriends(this.user)
      .subscribe(
        res => {
          this.friends = res;
          this.cutNames();
        },
        err => alert(err)
      );
  }

  sortFriendsByFeelings(select: string){
    //TO DO
  }

  cutNames(){
    this.friends.forEach(user => {
      var shortName = user.name.split(' ');
      if(shortName.length > 2){
        if(user.name.length > 16){
          user.name = shortName[0] + ' ' + shortName[1];
          console.log(user.name);
        }
      }
    });
    this.readyToShow = 1;
    console.log(this.friends);
  }

  seeFriendProfile(username: string){
    let url = window.location.href.split('/')[0]; 
    window.location.replace(url + '/friend-profile?username=' + username);
  }
}
