import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { FriendsComponent } from './friends/friends.component';
import { HomeComponent } from './home/home.component';
import { PopularComponent } from './popular/popular.component';
import { ProfileComponent } from './profile/profile.component';
import { SearchComponent } from './search/search.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'search', component: SearchComponent },
  { path: 'popular', component: PopularComponent },
  { path: 'friends', component: FriendsComponent },
  { path: 'profile', component: ProfileComponent },
  { path: 'friend-profile', component: ProfileComponent },
  { path: 'search-profile', component: ProfileComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
