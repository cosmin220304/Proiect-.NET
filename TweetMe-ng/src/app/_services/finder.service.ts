import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { PopularProfile } from '../_models/popular-profile';
import { PopularTweet } from '../_models/popular-tweet';

@Injectable({
  providedIn: 'root'
})
export class FinderService {
  url = environment.gatewayUrl;
  
  constructor(private http: HttpClient) { }

  patchProfileSearch(username: string){
    return this.http.patch(this.url + '/profilefinder/' + username, username).subscribe(
      res => { },
      Error => {
        alert(Error);
      }
    );
  }

  getPopularProfiles(max_profiles: number){
    return this.http.get<PopularProfile[]>(this.url + '/profilefinder/populars/' + max_profiles);
  }

  patchTweetSearch(tweetId: number){
    return this.http.patch(this.url + '/tweetfinder/' + tweetId, tweetId).subscribe(
      res => { },
      Error => {
        alert(Error);
      }
    )
  }

  getPopularTweets(max_tweets: number){
    return this.http.get<PopularTweet[]>(this.url + '/tweetfinder/populars/' + max_tweets);
  }
}
