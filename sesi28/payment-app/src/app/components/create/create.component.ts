import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { ItemDataService } from 'src/app/services/item-data.service';
import { Location } from '@angular/common';
import { ReadComponent } from '../read/read.component';
import { NavbarService } from 'src/app/services/navbar.service';
declare var jQuery: any;

@Component({
  selector: 'app-create',
  templateUrl: './create.component.html',
  styleUrls: ['./create.component.css']
})

export class CreateComponent implements OnInit {
  constructor(private itemDataService: ItemDataService, private router: Router, private navBar: NavbarService, private location: Location,) { }

  createForm = new FormGroup({
    cardOwnerName: new FormControl('', [Validators.required, Validators.minLength(5)]),
    cardNumber: new FormControl('', [Validators.required, Validators.minLength(19), Validators.maxLength(19),Validators.pattern('[0-9 ]*')]),
    expirationDate: new FormControl('', [Validators.required, Validators.minLength(5), Validators.maxLength(5),Validators.pattern('[/0-9]*')]),
    securityCode: new FormControl('', [Validators.required, Validators.minLength(3), Validators.maxLength(3), Validators.pattern(/^-?(0|[1-9/]\d*)?$/)]),
  })

  submitted = false;
  toggleCreate: boolean = false;

  get cardOwnerName() {
    return this.createForm.get('cardOwnerName');
  }
  get cardNumber() {
    return this.createForm.get('cardNumber');
  }
  get expirationDate() {
    return this.createForm.get('expirationDate');
  }
  get securityCode() {
    return this.createForm.get('securityCode');
  }

  ngOnInit(): void {

  }

  create() {
    this.itemDataService.create(this.createForm.value).subscribe((res) => {
      if (res) {
        this.submitted = true;
        window.location.reload();
        this.createForm.reset();
        alert("Successfully added.");
        this.router.navigate(['/read']);
      }
    })
  }

  cancel() {
    if (confirm("Are you sure you want to quit submitting?")) {
      alert("Canceled submitting.");
      this.toggleCreate = false;
      this.createForm.reset();
    } else {
      alert("Ok.");
      this.createForm.reset();
      // this.router.navigate(['/read']);
    }
  }
}
