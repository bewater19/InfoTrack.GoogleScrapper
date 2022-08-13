import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { catchError, map, tap } from 'rxjs/operators';
import { SearchQuery } from '../models/searchquery';
import { MessageService } from './message.service';

@Injectable({
  providedIn: 'root'
})
export class SearchService {

  apiUrl = "http://localhost:5000/Search"
  headers = new HttpHeaders({ 'Content-Type': 'application/json','Accept': 'application/json', 'Access-Control-Allow-Origin': '*' });

  constructor(private http: HttpClient, private messageService:MessageService) { }

  search(searchQuery: SearchQuery): Observable<any> {
      let getparams = new HttpParams().set('MatchUrl', searchQuery.matchUrl).set('SearchPhrase', searchQuery.searchPhrase);
      let httpOptions = { headers : this.headers, params : getparams };
      return this.http.get<any>(this.apiUrl, httpOptions).pipe(
        tap(),
        catchError(this.handleError<any>('get'))
      )
  }

  private handleError<T>(operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {
  
      console.log(error);
  
      //this.log(`${operation} failed: ${error.message}`);
      this.log("Service error.");
      let res = {} as any
      return of(res as any);
    };
  }

  private log(message: string) {
    this.messageService.add(`Service: ${message}`);
  }
}
