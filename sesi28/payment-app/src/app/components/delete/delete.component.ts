import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ItemDataService } from 'src/app/services/item-data.service';

@Component({
  selector: 'app-delete',
  templateUrl: './delete.component.html',
  styleUrls: ['./delete.component.css']
})
export class DeleteComponent implements OnInit {

  constructor(private itemDataService: ItemDataService, private router: Router) { }

  ngOnInit(): void {
  }

  delete(paymentDetailId: number): void {
    if (confirm("Are you sure to delete data?")) {
      this.itemDataService.delete(paymentDetailId)
        .subscribe(
          response => {
            window.location.reload();
            alert("Successfully deleted.");
            this.router.navigate(['/read']);
          },
          error => {
            console.log(error);
          });
    }
  }
}
