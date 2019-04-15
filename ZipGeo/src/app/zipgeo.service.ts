import { Injectable } from '@angular/core';
import { Observable, of} from 'rxjs';
//import { ZipInfo } from './ZipInfo';
import { ZipFacts } from './ZipFacts';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { catchError, map, tap } from 'rxjs/operators';
import { environment } from '../environments/environment';
import { throwError } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ZipgeoService {

  //private zipgeoUrl = 'https://localhost:44358/api/v1/zipgeo/';  // URL to web api

  constructor(private http: HttpClient) { }

  getZipGeo(zipcode: string): Observable<ZipFacts> {
    const url = `${environment.zipgeoUrl}?zipcode=${zipcode}`;
    return this.http.get<ZipFacts>(url).pipe(
      //tap(_ => this.log(`fetched zip code=${zipcode}`)),
      catchError(this.handleError<ZipFacts>(`getZipGeo zipcode=${zipcode}`))
    );
  }

  /**
 * Handle Http operation that failed.
 * Let the app continue.
 * @param operation - name of the operation that failed
 * @param result - optional value to return as the observable result
 */
  private handleError<T>(operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {

      // TODO: send the error to remote logging infrastructure
      console.error(error); // log to console instead
      console.log(result+ "Sandeep");

      // TODO: better job of transforming error for user consumption
      //this.log(`${operation} failed: ${error.message}`);

      // Let the app keep running by returning an empty result.
      //return of(result as T);
      return throwError(`${operation} failed: ${error.message}` || "Server Error! Try again later.");
    };
  }

}
