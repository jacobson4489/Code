import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-golfers',
  templateUrl: './golfers.component.html'
})
export class GolfersComponent {
  public golfers: Golfer[] = [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    const apiUrl = 'golfers/get-all-golfers';
    http.get<Golfer[]>(baseUrl + apiUrl).subscribe(result => {
      console.log('result =', result);
      this.golfers = result;
    }, error => console.error(error));
  }
}

interface Golfer {
  aspNetUserId: string;
  firstName: string;
  lastName: string;
  birthDate: Date;
  isActive: number;
}
