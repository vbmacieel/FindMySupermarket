import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ISupermarket } from 'src/app/models/supermarket-interface.model';

@Injectable({
  providedIn: 'root'
})
export class SupermarketService {

  private baseUrl = "https://localhost:7264/api/supermarket";

  constructor(private httpClient: HttpClient) { }

  public getAll(): Observable<ISupermarket[]>
  {
    return this.httpClient.get<ISupermarket[]>(this.baseUrl);
  }
}
