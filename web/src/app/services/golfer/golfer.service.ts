import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Golfer } from '../../models/Golfer'
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})

export class GolferService {
  private golferApiUrl = 'https://localhost:7158/api/Golfer'

  constructor(private http: HttpClient) { }

  public getAll(): Observable<Golfer[]>{
    const path = this.golferApiUrl;
    return this.http.get<Golfer[]>(path);
  }

  public getById(golferID: number): Observable<Golfer> {
    const path = this.golferApiUrl + `/${golferID}`;
    return this.http.get<Golfer>(path);
  }
}
