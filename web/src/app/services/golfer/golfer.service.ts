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

  public getAllGolfers(): Observable<Golfer[]>{
    const path = this.golferApiUrl + '/GetAllGolfers';
    return this.http.get<Golfer[]>(path);
  }

  public getGolferById(golferID: number): Observable<Golfer> {
    const path = this.golferApiUrl + `/GetGolferByGolferID/${golferID}`;
    return this.http.get<Golfer>(path);
  }

  public insertGolfer(golfer: Golfer): Observable<Golfer> {
    const path = this.golferApiUrl + '/InsertGolfer';
    return this.http.post<Golfer>(path, golfer);
  }

  public updateGolfer(golferID: number, golfer: Golfer): Observable<Golfer> {
    const path = this.golferApiUrl + `/UpdateGolferByGolferID/${golferID}`;
    return this.http.put<Golfer>(path, golfer);
  }
}
