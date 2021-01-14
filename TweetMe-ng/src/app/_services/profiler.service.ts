import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Profile } from '../_models/profile';

@Injectable({
  providedIn: 'root'
})
export class ProfilerService {
  profileGatewayUrl = environment.gatewayUrl;

  constructor(private http: HttpClient) { }

  getProfile(username: string, count: number){
    return this.http.get<Profile>(this.profileGatewayUrl + '/meprofiler/profileByUsername?username=' + username + '&count=' + count);
  }
}
