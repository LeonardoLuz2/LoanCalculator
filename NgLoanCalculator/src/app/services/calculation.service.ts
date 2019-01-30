import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Calculation } from '../models/calculation';

@Injectable()
export class CalculationService {

  API_URL = 'https://localhost:44337/api/calculation';
  header = {'Content-Type': 'application/json'};

  constructor(private http: HttpClient) { }


  Calculate(calculation: Calculation): Observable<number> {
    return this.http.post<number>(
              this.API_URL,
              calculation,
              { headers: new HttpHeaders(this.header) }
          );
  }
}
