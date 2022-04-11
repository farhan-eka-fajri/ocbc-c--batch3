import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor
} from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { AuthService } from '../services/auth.service';
import { catchError } from 'rxjs/operators';
import { Router } from '@angular/router';

@Injectable()
export class AuthInterceptor implements HttpInterceptor {

  constructor(private authService: AuthService, private router: Router) { }

  intercept(request: HttpRequest<any>, next: HttpHandler) {
    const authToken = this.authService.getAuthorizationToken()
    request = request.clone({ setHeaders: { Authorization: `Bearer ${authToken}` } })

    return next.handle(request).pipe(catchError(err => {
      if (err.status==401||err.status==403) {
          this.authService.logOut();
          window.alert("You are not authenticated. Please log in.");
          this.router.navigate(['/login']);
      }

      const error = (err && err.error && err.error.message) || err.statusText;
      return throwError(error);
  }));
  }
}
