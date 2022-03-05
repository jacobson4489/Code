import { Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { Golfer } from '../../../models/Golfer'
import { GolferService } from '../../../services/golfer/golfer.service'
import { Course } from '../../../models/Course'
import { CourseService } from '../../../services/course/course.service'

@Component({
  selector: 'app-golfer-form',
  templateUrl: './golfer-form.component.html',
  styleUrls: ['../../../styles/my-golf-stats.component.scss']
})

export class GolferFormComponent implements OnInit {
  golfer: Golfer = new Golfer;
  courses: Course[];
  isInsert: boolean = false;

  constructor(private golferService: GolferService, private courseService: CourseService) { }

  ngOnInit() {
    this.getAllCourses();
    this.getGolfer(1);
  }

  private getAllCourses() {
    this.courseService.getAll().subscribe(response => {
      this.courses = response;
    });
  }

  private getGolfer(golferID: number) {
    this.golferService.getGolferById(golferID).subscribe(response => {
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
  }

  onCancel() {
  }

  insertGolfer() {
    console.log('insert =', this.golfer);
    this.golferService.insertGolfer(this.golfer).subscribe((response) => {
      this.golfer = response;
    });
  }

  updateGolfer() {
    console.log('update =', this.golfer);
    this.golferService.updateGolfer(this.golfer.golferID, this.golfer).subscribe((response) => {
      this.golfer = response;
    })
  }
}
