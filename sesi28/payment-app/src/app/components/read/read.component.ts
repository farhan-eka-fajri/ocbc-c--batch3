import { Component, Input, OnInit, TemplateRef, ViewChild } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { AuthService } from 'src/app/services/auth.service';
import { ItemDataService } from 'src/app/services/item-data.service';
import { NavbarService } from 'src/app/services/navbar.service';
import { CreateComponent } from '../create/create.component';
import { DeleteComponent } from '../delete/delete.component';
import { Location } from '@angular/common';
import { UpdateComponent } from '../update/update.component';

@Component({
  selector: 'app-read',
  templateUrl: './read.component.html',
  styleUrls: ['./read.component.css']
})
export class ReadComponent implements OnInit {
  @Input()
  paymentDetailId?: number;
  reads: any;
  createData: any;
  updateData:any;
  constructor(public itemDataService: ItemDataService, private router: Router, private navBar: NavbarService, public location: Location, public activatedRoute: ActivatedRoute) { }

  ngOnInit(): void {
    this.createData = new CreateComponent(this.itemDataService, this.router, this.navBar,this.location);
    this.updateData = new UpdateComponent(this.itemDataService, this.router, this.activatedRoute,this.location,this.navBar);
    this.navBar.show();
    this.itemDataService
      .getAll()
      .subscribe((res: any) => {
        if (res) this.reads = res
      });

  }

  delete(paymentDetailId: number): void {
    let deleteComponent = new DeleteComponent(this.itemDataService, this.router);
    deleteComponent.delete(paymentDetailId);
  }


  create(): void {
    this.createData.toggleCreate = true;
  }

  data = false;
  edit(paymentDetailId: number) {
    this.paymentDetailId = paymentDetailId;
    this.data = true;
    this.updateData.toggleUpdate = true;
    // this.router.navigate(['/update', paymentDetailId]);
  }
  

}
