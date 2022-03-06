import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Address } from '../../models/Address'
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})

export class AddressService {
  private addressApiUrl = 'https://localhost:7158/api/Address'

  constructor(private http: HttpClient) { }

  public getAll(): Observable<Address[]>{
    const path = this.addressApiUrl;
    return this.http.get<Address[]>(path);
  }

  public getById(addressID: number): Observable<Address> {
    const path = this.addressApiUrl + `/${addressID}`;
    return this.http.get<Address>(path);
  }
}
