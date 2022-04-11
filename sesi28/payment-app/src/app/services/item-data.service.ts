import { HttpClient, HttpErrorResponse, HttpHeaders } from '@angular/common/http';
import { EventEmitter, Injectable } from '@angular/core';
import { Observable, throwError } from 'rxjs';
import { catchError, map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class ItemDataService {
  endpoint: string =
    'http://localhost:5000/api/PaymentDetails';

  constructor(private http: HttpClient) { }

  invokeDeleteFunction = new EventEmitter();

  getAll(): Observable<any> {
    return this.http.get(this.endpoint)
      .pipe(catchError(this.handleError))
  }

  delete(paymentDetailId: number): Observable<any> {
    return this.http.delete(`${this.endpoint}/${paymentDetailId}`).pipe(catchError(this.handleError));
  }

  create(data: any): Observable<any> {
    return this.http.post(this.endpoint, data).pipe(catchError(this.handleError));
  }

  update(data: any, paymentDetailId: number): Observable<any> {
    return this.http.put(`${this.endpoint}/${paymentDetailId}`, data).pipe(catchError(this.handleError))
  }

  handleError(error: HttpErrorResponse) {
    let msg=alert('Invalid input.');
    return throwError(msg);
  }
}
