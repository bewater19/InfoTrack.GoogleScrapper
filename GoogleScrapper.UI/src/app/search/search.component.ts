import { Component, OnInit } from '@angular/core';
import { SearchResult } from '../models/searchresult';
import { SearchQuery } from '../models/searchquery';
import { SearchService } from '../services/search.service';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent implements OnInit {
  
  searchQuery : SearchQuery = { matchUrl : "", searchPhrase : "" } ;
  searchResult = {} as SearchResult;

  constructor(private searchService:SearchService) { }

  ngOnInit(): void {

  }

  search(): void {
    if (this.searchQuery.matchUrl.length > 0 && this.searchQuery.searchPhrase.length > 0){
      this.searchService.search(this.searchQuery).subscribe((res : any) => {
          this.searchResult.ranks = res.ranks;
          console.log(this.searchResult); 
      });
    }
  }
}
