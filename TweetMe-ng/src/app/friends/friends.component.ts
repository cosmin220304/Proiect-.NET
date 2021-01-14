import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { User } from '../_models/user';
import { FriendsService } from '../_services/friends.service';
import { StalkerService } from '../_services/stalker.service';

@Component({
  selector: 'app-friends',
  templateUrl: './friends.component.html',
  styleUrls: ['./friends.component.sass']
})
export class FriendsComponent implements OnInit {
  feeling:string = 'all';
  user: string;
  friends: User[] = [];
  happyFriends: User[]= [];
  sadFriends: User[]= [];
  readyToShow = 0;
  readyToShowSortedFriends = 0;

  constructor(private stalker: StalkerService, private activatedRoute: ActivatedRoute, private friendChecker: FriendsService) {
    this.activatedRoute.queryParams.subscribe(params => {
      this.user = params['username'];
    });
   }

  ngOnInit(): void {
    this.stalker.getFriends(this.user).subscribe(
      res => {
        this.friends = res;
        this.cutNames();
      },
      err => alert(err)
    );
    this.friendChecker.getFriends('elonmusk', 10).subscribe(
      res => {
        this.happyFriends = res.happyFriends;
        this.sadFriends = res.sadFriends;
        this.readyToShow += 1;
        this.readyToShowSortedFriends = 1;
      },
      err => alert(err)
    );
  }

  seeFriendsByFeelings(feel: string){
    if (feel !== 'all'){
      if (this.readyToShowSortedFriends === 0){
        this.readyToShow -= 1;
      }
    }
    else{
      this.readyToShow = 1;
    }
    this.feeling = feel;
  }

  cutNames(){
    this.friends.forEach(user => {
      var shortName = user.name.split(' ');
      if(shortName.length > 2){
        if(user.name.length > 16){
          user.name = shortName[0] + ' ' + shortName[1];
        }
      }
    });
    this.readyToShow = 1;
  }

  seeFriendProfile(username: string){
    let url = window.location.href.split('/')[0]; 
    window.location.replace(url + '/friend-profile?username=' + username);
  }
}
