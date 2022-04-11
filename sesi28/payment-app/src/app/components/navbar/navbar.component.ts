import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from 'src/app/services/auth.service';
import { NavbarService } from 'src/app/services/navbar.service';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {

  constructor(private authService: AuthService, private router:Router, public nav: NavbarService) { }

  logout:any;

  ngOnInit(): void {
    
  }

  logOut(){
    this.logout=this.authService.logOut();
    this.router.navigate(['/login']);
    alert('Successfully logging out.');
  }

}
