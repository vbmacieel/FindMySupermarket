import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { ISupermarket } from 'src/app/models/supermarket-interface.model';
import { SupermarketService } from 'src/app/service/supermarket.service';

@Component({
  selector: 'app-supermarket-list',
  templateUrl: './supermarket-list.component.html',
  styleUrls: ['./supermarket-list.component.scss']
})
export class SupermarketListComponent implements OnInit  {

  public supermarkets: ISupermarket[];

  constructor(private service: SupermarketService) 
  {
    this.supermarkets = [];
  }
  
  ngOnInit(): void 
  {
    this.service.getAll().subscribe({
      next: (supermarketArr) => {
          this.supermarkets = supermarketArr;
      },
      error: (error) => {
          console.log(error)
      },
    });
  }

}
