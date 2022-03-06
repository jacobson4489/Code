import { Component, OnInit } from '@angular/core';
import { Golfer } from '../../../models/Golfer'
import { GolferService } from '../../../services/golfer/golfer.service'

@Component({
  selector: 'app-golfer-list',
  templateUrl: './golfer-list.component.html',
  styleUrls: ['../../../styles/my-golf-stats.component.scss']
})

export class GolferListComponent implements OnInit {
  golfers: Golfer[];

  constructor(private golferService: GolferService) { }

  ngOnInit() {
    this.getAllGolfers();
  }

  private getAllGolfers() {
    this.golferService.getAllGolfers().subscribe(response => {
      this.golfers = response;
    });
  }
}
