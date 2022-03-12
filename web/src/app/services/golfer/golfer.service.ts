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

  public getGolferByGolferId(golferId: number): Observable<Golfer> {
    const path = this.golferApiUrl + `/GetGolferByGolferId/${golferId}`;
    return this.http.get<Golfer>(path);
  }

  public insertGolfer(golfer: Golfer): Observable<Golfer> {
    const path = this.golferApiUrl + '/InsertGolfer';
    return this.http.post<Golfer>(path, golfer);
  }

  public updateGolferByGolferId(golferId: number, golfer: Golfer): Observable<Golfer> {
    const path = this.golferApiUrl + `/UpdateGolferByGolferId/${golferId}`;
    return this.http.put<Golfer>(path, golfer);
  }

  public deleteGolferByGolferId(golferId: number): Observable<string> {
    const path = this.golferApiUrl + `/DeleteGolferByGolferId/${golferId}`;
    return this.http.delete<string>(path);
  }
}
