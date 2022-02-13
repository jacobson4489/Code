import { Component, OnInit, ChangeDetectionStrategy } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css'],
  changeDetection: ChangeDetectionStrategy.OnPush
})

export class HomeComponent implements OnInit {
  constructor() { }

  ngOnInit(): void {
    this.getMessage();
  }

  getMessage() {
    var golferName = "NOT_FOUND_ERROR";

    this.getMessageFromAPI().this.service.function
      .subscribe(response => golferName = response['FirstName'] + response['LastName']);

    return golferName;
  }

  getMessageFromAPI() : Promise {
    const url = new URL('https://localhost:7020/golf-stats/GetGolferById?golferId=2');
  }
}
