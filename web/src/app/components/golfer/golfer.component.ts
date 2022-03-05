import { Component, OnInit } from '@angular/core';
import { Golfer } from '../../models/Golfer'
import { GolferService } from '../../services/golfer/golfer.service'

@Component({
  selector: 'app-golfer',
  templateUrl: './golfer.component.html',
  styleUrls: ['./golfer.component.scss']
})

export class GolferComponent implements OnInit {
  golfers: Golfer[];

  constructor(private golferService: GolferService) { }

  ngOnInit() {
    this.getAllGolfers();
  }

  private getAllGolfers() {
    this.golferService.getAll().subscribe(response => {
      this.golfers = response;
    });
  }
}
