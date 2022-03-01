import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Golfer } from '../../models/Golfer/Golfer'
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})

export class GolferService {
  private golferApiUrl = 'https://localhost:7158/api/Golfers'

  constructor(private http: HttpClient) { }

  public getAll(): Observable<Golfer[]>{
    const path = this.golferApiUrl + `/GetAll`;
    return this.http.get<Golfer[]>(path);
  }

  public getById(id: number): Observable<Golfer> {
    const path = this.golferApiUrl + `/${id}`;
    return this.http.get<Golfer>(path);
  }
}
