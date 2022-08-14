import { Component, OnInit } from '@angular/core';
import { SearchService } from '../services/search.service';
import { SearchResult } from '../models/searchresult';
import { MatTable, MatTableDataSource } from '@angular/material/table';

@Component({
  selector: 'app-search-history',
  templateUrl: './search-history.component.html',
  styleUrls: ['./search-history.component.css']
})
export class SearchHistoryComponent implements OnInit {

  historyDataSource = new MatTableDataSource<SearchResult>();
  displayColumns: string[] = ['createTime','searchPhrase','matchUrl','ranks'] ;

  constructor(private searchService:SearchService) { }

  ngOnInit(): void {
  }

  searchHistory(): void {
    this.searchService.searchHistory().subscribe((res : any) => {
        console.log(res); 
        this.historyDataSource.data = res;
    });
  }
}
