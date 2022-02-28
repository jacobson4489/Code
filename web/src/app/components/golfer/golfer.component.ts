import { Component, OnInit } from '@angular/core';
import { Golfer } from '../../models/Golfer/Golfer'
import { GolferService } from '../../services/golfer/golfer.service'

@Component({
  selector: 'app-golfer',
  templateUrl: './golfer.component.html',
  styleUrls: ['./golfer.component.scss']
})

export class GolferComponent implements OnInit {
  golfer: Golfer = new Golfer();

  constructor(private golferService: GolferService) { }

  ngOnInit() {
    this.getGolfer(62682);
  }

  private getGolfer(id: number) {
    this.golferService.getById(id).subscribe(response => {
      this.golfer = response;
      console.log(this.golfer);
    });
  }
}