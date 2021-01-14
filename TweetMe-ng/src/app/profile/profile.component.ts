import { Component, OnInit } from '@angular/core';
import { Profile } from '../_models/profile';
import { User } from '../_models/user';
import { ProfilerService } from '../_services/profiler.service';
import { StalkerService } from '../_services/stalker.service';
import { Tweet } from '../_models/tweet';
import { ActivatedRoute } from '@angular/router';
import { ProgressSpinnerMode } from '@angular/material/progress-spinner';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.sass']
})
export class ProfileComponent implements OnInit {
  readyToShow = 0;
  friendList: User[]  = [];
  tweets: Tweet[] = [];
  profile : Profile = {
    id: 0,
    name: '',
    username: '',
    imageUrl: '',
    tweets: []
  };
  user: string;
  sort:string = "day";
  prediction: number;
  setPrediction = 0;
  ts:string = "all";

  color: 'red';
  mode: ProgressSpinnerMode = 'indeterminate';
  value = 50;
  
  constructor(private profiler: ProfilerService, private stalker: StalkerService, private activatedRoute: ActivatedRoute) {
    this.activatedRoute.queryParams.subscribe(params => {
      this.user = params['username'];
    });
  }

  ngOnInit():void {
    this.profiler.getProfile(this.user, 50)
      .subscribe(
        res => {
          this.profile = res;
          this.sortTweetsByDate(this.ts);
        },
        err => alert(err)
      );
    this.stalker.getFriends(this.user)
      .subscribe(
        res => {this.friendList = res;
          this.cutNames();
        },
        err => alert(err)
      );
  }

  changeTweetsSelector(select: string){
    this.ts = select;
    if(this.ts === 'happy'){
      this.tweets = this.tweets.filter(t => t.sentiment === 1);
      this.prediction = 100;
    }
    else{
      this.tweets = this.tweets.filter(t => t.sentiment === 0);
      this.prediction = 0;
    }
    if (this.readyToShow < 2){
      this.readyToShow += 1;
    }
  }

  sortTweetsByDate(select: string){
    var date =  new Date().toString().slice(0,10);    
    var days = ['Mon','Tue','Wed','Thu','Fri','Sat','Sun'];
    this.tweets = [];
    this.profile.tweets.forEach(tweet => {
      if(this.sort === 'day'){
        if (tweet.data.includes(date)){
          this.tweets.push(tweet);
        }
      }
      if(this.sort === 'week'){
        var dayOfWeek = days.indexOf(date.slice(0,3));
        var day = parseInt(date.slice(8,10));
        var firstDayOfWeek = day - dayOfWeek;
        var lastDayOfWeek = day + (days.indexOf('Sun') - dayOfWeek);
        if (tweet.data.includes(date.slice(3,6)))
          if (parseInt(tweet.data.slice(8,10)) >= firstDayOfWeek && parseInt(tweet.data.slice(8,10)) <= lastDayOfWeek){
            this.tweets.push(tweet);
          }
      }
      if(this.sort === 'month'){
        if (tweet.data.includes(date.slice(3,6))){
          this.tweets.push(tweet);
        }
      }
    });
    if(select !== 'all'){
      this.changeTweetsSelector(select);
    }
    else{
      this.ts = select;
      this.getPrediction();
    }
  }

  getPrediction(){
    var happyTweetsCount = 1;
    this.tweets.forEach(tweet => {
      if (tweet.sentiment === 1){
        happyTweetsCount += 1;
      }
    });
    if (happyTweetsCount === 0){
      this.prediction = 0;
    }
    else{
      this.prediction = ~~((happyTweetsCount / this.tweets.length) * 100) % 100;
    }
    if (this.readyToShow < 2){
      this.readyToShow += 1;
    }
  }

  seeFriendProfile(username: string){
    let url = window.location.href.split('/')[0]; 
    window.location.replace(url + '/friend-profile?username=' + username);
  }

  cutNames(){
    this.friendList.forEach(user => {
      var shortName = user.name.split(' ');
      if(shortName.length > 2){
        if(user.name.length > 16){
          user.name = shortName[0] + ' ' + shortName[1];
        }
      }
    });
    this.readyToShow += 1;
  }
  
}
