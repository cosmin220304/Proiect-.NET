import { Component, Input, OnInit } from '@angular/core';
import { Profile } from '../_models/profile';
import { User } from '../_models/user';
import { AuthService } from '../_services/auth.service';
import { ProfilerService } from '../_services/profiler.service';
import { StalkerService } from '../_services/stalker.service';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.sass']
})
export class ProfileComponent implements OnInit {
  friendList: User[]  = [];
  profile : Profile = {
    id: 0,
    name: '',
    username: '',
    imageUrl: '',
    tweets: []
  };
  sort:string = "week";
  prediction: number = 90;
  
  constructor(private profiler: ProfilerService, private auth: AuthService, private stalker: StalkerService) { }

  ngOnInit():void {
    this.profiler.getProfile(this.auth.getLoggedUser(), 3)
      .subscribe(
        res => this.profile = res,
        err => alert(err)
      );
    // this.stalker.getFriends(this.auth.getLoggedUser())
    //   .subscribe(
    //     res => this.friendList = res,
    //     err => alert(err)
    //   );
    console.log(this.sort);
  }
}
