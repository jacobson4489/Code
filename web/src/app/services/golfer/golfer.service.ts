import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Golfer } from '../../models/Golfer/Golfer'
import { Observable } from 'rxjs';

@Injectable()
export class GolferService {
  private _golferApiUrl: string = 'http://localhost:7158/Golfer'
  constructor(httpClient: HttpClient) { }

  public getAll() : Observable<Golfer[]> {
    return this.httpClient.get(this._golferApiUrl + '/GetAll').map();
  }
}
