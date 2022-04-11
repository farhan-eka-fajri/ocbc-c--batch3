import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ItemDataService } from 'src/app/services/item-data.service';
import { Location } from '@angular/common';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ReadComponent } from '../read/read.component';
import { NavbarService } from 'src/app/services/navbar.service';

@Component({
  selector: 'app-update',
  templateUrl: './update.component.html',
  styleUrls: ['./update.component.css']
})
export class UpdateComponent implements OnInit {

  constructor(private itemDataService: ItemDataService, private router: Router, private route: ActivatedRoute, private location: Location, private navBar: NavbarService) { }

  reads: any;
  toggleUpdate: boolean = false;

  ngOnInit(): void {
    this.navBar.show();
    this.paymentDetailId = this.route.snapshot.params['paymentDetailId'];
    this.itemDataService
      .getAll()
      .subscribe((res: any) => {
        if (res) this.reads = res
      });
  }

  paymentDetailId!: number

  updateForm = new FormGroup({
    PaymentDetailId:new FormControl(''),
    cardOwnerName: new FormControl('', [Validators.required, Validators.minLength(5)]),
    cardNumber: new FormControl('', [Validators.required, Validators.minLength(19), Validators.maxLength(19),Validators.pattern('[0-9 ]*')]),
    expirationDate: new FormControl('', [Validators.required, Validators.minLength(5), Validators.maxLength(5),Validators.pattern('[/0-9]*')]),
    securityCode: new FormControl('', [Validators.required, Validators.minLength(3), Validators.maxLength(3), Validators.pattern(/^-?(0|[1-9/]\d*)?$/)]),
  })


  get PaymentDetailId() {
    return this.updateForm.get('paymentDetailId');
  }
  get cardOwnerName() {
    return this.updateForm.get('cardOwnerName');
  }
  get cardNumber() {
    return this.updateForm.get('cardNumber');
  }
  get expirationDate() {
    return this.updateForm.get('expirationDate');
  }
  get securityCode() {
    return this.updateForm.get('securityCode');
  }

  update(paymentDetailId: number) {
    this.itemDataService.update(this.updateForm.value, paymentDetailId)
      .subscribe((res) => {
        if (res) {
          window.location.reload();
          this.updateForm.reset();
          alert("Successfully edited.");
          this.router.navigate(['/read'])
        }
      })
  }

  cancel() {
    if (confirm("Are you sure you want to quit editing?")) {
      alert("Canceled editing.");
      window.location.reload();
      this.toggleUpdate = false;
    } else {
      alert("Ok.");
      window.location.reload();
      // this.router.navigate(['/read']);
    }
  }

}
