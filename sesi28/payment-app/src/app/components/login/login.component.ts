import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from 'src/app/services/auth.service';
import { NavbarService } from 'src/app/services/navbar.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor(public authService: AuthService, public router: Router, public navBar:NavbarService) { }

  loginForm = new FormGroup({
    password: new FormControl('', [Validators.required, Validators.minLength(5)]),
    email: new FormControl('', [Validators.required, Validators.email])
  })

  get password() {
    return this.loginForm.get('password');
  }

  get email() {
    return this.loginForm.get('email');
  }

  ngOnInit(): void {
    this.navBar.hide();
  }

  logIn() {
    this.authService
      .logIn(this.loginForm.value)
      .subscribe((res: any) => {
        if (res) {
          this.authService.setAuthorizationToken(res.token);
          this.loginForm.reset();
          this.router.navigate(['/read']);
          alert('Successfully login.');
        }
      })
  }


}
