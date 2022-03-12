import { Component, OnInit } from '@angular/core';
import { Golfer } from '../../../models/Golfer'
import { GolferService } from '../../../services/golfer/golfer.service'
import { Course } from '../../../models/Course'
import { CourseService } from '../../../services/course/course.service'

@Component({
  selector: 'app-golfer-form',
  templateUrl: './golfer-form.component.html',
  styleUrls: ['../../../app.component.scss']
})

export class GolferFormComponent implements OnInit {
  golfer: Golfer = new Golfer;
  courses: Course[];
  isInsert: boolean = false;

  constructor(private golferService: GolferService, private courseService: CourseService) { }

  ngOnInit() {
    this.getAllCourses();
  }

  private getAllCourses() {
    this.courseService.getAllCourses().subscribe(response => {
      this.courses = response;
    });
  }

  private getGolfer(golferId: number) {
    this.golferService.getGolferByGolferId(golferId).subscribe(response => {
      this.golfer = response;
    });
  }

  onSubmit() {
    if (this.isInsert) {
      this.insertGolfer();
    }
    else {
      this.updateGolfer();
    }
  }

  onNew() {
    this.golfer = new Golfer();
    this.isInsert = true;
  }

  onDelete() {
    this.golferService.deleteGolferByGolferId(this.golfer.golferId).subscribe((response) => {
    });
  }

  onCancel() {
  }

  insertGolfer() {
    this.golferService.insertGolfer(this.golfer).subscribe((response) => {
      this.golfer = response;
      this.isInsert = false;
    });
  }

  updateGolfer() {
    this.golferService.updateGolferByGolferId(this.golfer.golferId, this.golfer).subscribe((response) => {
      this.golfer = response;
    })
  }
}
