import { HttpClient, HttpErrorResponse, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { Observable, throwError } from 'rxjs';
import { catchError, map } from 'rxjs/operators';
import { User } from '../models/User';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  endpoint: string =
    'http://localhost:5000/api';
    headers = new HttpHeaders().set('Content-Type', 'application/json');

  constructor(private http: HttpClient, private router: Router) { }

  logIn(user: User) {
    const api = `${this.endpoint}/AuthManagement/Login`;
    return this.http
    .post(api, user)
    .pipe( catchError(this.handleError) )
  }

  logOut(){
    return localStorage.removeItem('app_token');
  }
  
  get isAuthenticated() {
    return !!this.getAuthorizationToken();
  }

  getAuthorizationToken () {
    return localStorage.getItem('app_token');
  }

  setAuthorizationToken (token: string) {
    return localStorage.setItem('app_token', token);
  }

  handleError(error: HttpErrorResponse) {
    let msg=alert('Invalid input.');
    return throwError(msg);
  }
}
