import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Golfer } from '../../models/Golfer/Golfer'
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})

export class GolferService {
  private golferApiUrl = 'http://localhost:7158/Golfer'

  constructor(private http: HttpClient) { }

  public getAll(): Observable<Golfer[]> {
    return this.http.get<Golfer[]>(this.golferApiUrl + '/GetAll');
  }

  public getById(id: number): Observable<Golfer> {
    return this.http.get<Golfer>(this.golferApiUrl + `/GetById/${id}`);
  }
}
