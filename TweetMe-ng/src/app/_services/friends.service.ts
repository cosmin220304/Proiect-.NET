import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Friends } from '../_models/friends';

@Injectable({
  providedIn: 'root'
})
export class FriendsService {
  url = environment.gatewayUrl;

  constructor(private http: HttpClient) { }

  getFriends(username: string, tweetCount: number){
    return this.http.get<Friends>(this.url + '/friendChecker/getByUsername?username=' + username + '&tweetsPerUser=' + tweetCount);
  }
}
