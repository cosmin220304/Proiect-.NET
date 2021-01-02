
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { map } from 'rxjs/operators';
import { User } from '../_models/user';
import { StalkerService } from '../_services/stalker.service';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.sass']
})
export class SearchComponent implements OnInit {
  searchForm: FormGroup;
  username = new FormControl();
  showSearchBar = true;
  searchResult: User;
  notFound = 0;

  constructor(fb: FormBuilder, private stalker: StalkerService) {
    this.searchForm = fb.group({
      username: this.username
    });
  }

  ngOnInit(): void {

  }

  startSearch(): any{
    this.stalker.getUser(this.username.value)
      .subscribe(
        res => {
          if (res.name === null){
            this.notFound = 1;
          }
          else{
            this.notFound = 0;
            this.searchResult = res;
            this.showSearchBar = !this.showSearchBar;
          }
        },        
        err => alert('Problem receiving data'),
      );
  }

  resetSearch(): any{
    this.showSearchBar = !this.showSearchBar;
    this.username.setValue("");
  }
}
