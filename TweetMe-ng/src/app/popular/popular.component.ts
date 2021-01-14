import { Component, OnInit } from '@angular/core';
import { PopularTweet } from '../_models/popular-tweet';
import { User } from '../_models/user';
import { FinderService } from '../_services/finder.service';
import { StalkerService } from '../_services/stalker.service';

@Component({
  selector: 'app-popular',
  templateUrl: './popular.component.html',
  styleUrls: ['./popular.component.sass']
})
export class PopularComponent implements OnInit {
  readyToShow = 0;
  popular: string = 'profiles';
  profiles: User[] = []; 
  tweets: PopularTweet[];

  constructor(private finder: FinderService, private stalker: StalkerService) { }

  ngOnInit(): void {
    this.finder.getPopularProfiles(9).subscribe(
      res => {
        res.forEach(user => {
          this.stalker.getUser(user.username).subscribe(
            rsp => {
              this.profiles.push(rsp);
            }
          )
        });
        this.cutNames();
      },
      Error => {
        alert(Error);
      }
    );
    // this.finder.getPopularTweets(20).subscribe(
    //   res => {
    //     this.tweets = res;
    //     this.readyToShow += 1;
    //     console.log(this.tweets);
    //   },
    //   Error => {
    //     alert(Error);
    //   }
    // );
  }

  getPopular(pop: string){
    this.popular = pop;
  }

  seeProfile(username: string){
    let url = window.location.href.split('/')[0]; 
    window.location.replace(url + '/friend-profile?username=' + username);
  }

  cutNames(){
    this.profiles.forEach(user => {
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
