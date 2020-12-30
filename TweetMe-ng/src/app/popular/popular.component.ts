import { Component, OnInit } from '@angular/core';
import { Tweet } from '../_models/tweet';
import { User } from '../_models/user';

@Component({
  selector: 'app-popular',
  templateUrl: './popular.component.html',
  styleUrls: ['./popular.component.sass']
})
export class PopularComponent implements OnInit {
  popular: string = 'profiles';
  profiles: User[] = [
    {id: 14075928, name: "The Onion", username: "TheOnion", imageUrl: "https://pbs.twimg.com/profile_images/875392068125769732/yrN-1k0Y_normal.jpg"}, 
    {id: 4914384040, name: "The Babylon Bee", username: "TheBabylonBee", imageUrl: "https://pbs.twimg.com/profile_images/1273660251246440448/P8th8oxp_normal.jpg"},
    {id: 33836629, name: "Andrej Karpathy", username: "karpathy", imageUrl: "https://pbs.twimg.com/profile_images/1296667294148382721/9Pr6XrPB_normal.jpg"},
    {id: 85891683, name: "NOGUCHI, Soichi 野口　聡－（のぐち　そういち）", username: "Astro_Soichi", imageUrl: "https://pbs.twimg.com/profile_images/1304966883133788161/8F7CKaLY_normal.jpg"},
    {id: 16736535, name: "PC Gamer", username: "pcgamer", imageUrl: "https://pbs.twimg.com/profile_images/877980023025803270/xntVDuTq_normal.jpg"},
    {id: 23116280, name: "Popular Mechanics", username: "PopMech", imageUrl: "https://pbs.twimg.com/profile_images/812327935319293952/Yuw9IY2k_normal.jpg"},
    {id: 776585502606721000, name: "PyTorch", username: "PyTorch", imageUrl: "https://pbs.twimg.com/profile_images/1306686545974362113/JYq2LGIA_normal.jpg"}];
  tweets: Tweet[] = [
    {id: 1344219458324160500, text: "Snake-head dog had my undivided attention until wi…ng through all nonchalant https://t.co/dtPMdM3TQp", data: "Wed Dec 30 09:51:07 +0000 2020", sentiment: 0},
    {id: 1344214516230307800, text: "@Tesmanian_com Seems odd that the opposition group…t‘s very far from Brande… https://t.co/M7DYvli4cx", data: "Wed Dec 30 09:31:29 +0000 2020", sentiment: 1},
    {id: 1344212785228435500, text: "@Tesmanian_com This is very sensible. Opposition from anywhere cannot mean no progress everywhere!", data: "Wed Dec 30 09:24:36 +0000 2020", sentiment: 0},
    {id: 1344210828052947000, text: "@harsimranbansal Literally", data: "Wed Dec 30 09:16:50 +0000 2020", sentiment: 0},
    {id: 1344190775182016500, text: "@tobyliiiiiiiiii Are we sure this is real?", data: "Wed Dec 30 07:57:09 +0000 2020", sentiment: 1},
    {id: 1344154578678214700, text: "Destiny, destiny↵No escaping ↵that for me", data: "Wed Dec 30 05:33:19 +0000 2020", sentiment: 0}];

  constructor() { }

  ngOnInit(): void {
    this.cutNames();
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
          console.log(user.name);
        }
      }
    });
  }

}
