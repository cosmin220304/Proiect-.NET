import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Tweet } from '../_models/tweet';
import { User } from '../_models/user';

@Injectable({
  providedIn: 'root'
})
export class StalkerService {
  url = environment.gatewayUrl;

  constructor(private http: HttpClient) {}

  getUser(username: string){
    return this.http.get<User>(this.url + '/stalker/users?username=' + username);
  }

  getFriends(username: string){
    return this.http.get<User[]>(this.url + '/stalker/friends/' + username);
  }

  getTweets(username: string, count: number){
    return this.http.get<Tweet[]>(this.url + '/stalker/tweets?username=' + username + '&count=' + count);
  }
}
