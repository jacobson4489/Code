import { Component, OnInit } from '@angular/core';
import { Course } from '../../../models/Course'
import { CourseService } from '../../../services/course/course.service'

@Component({
  selector: 'app-course-list',
  templateUrl: './course-list.component.html',
  styleUrls: ['../../../styles/my-golf-stats.component.scss']
})

export class CourseListComponent implements OnInit {
  courses: Course[];

  constructor(private courseService: CourseService) { }

  ngOnInit() {
    this.getAllCourses();
  }

  private getAllCourses() {
    this.courseService.getAll().subscribe(response => {
      this.courses = response;
    });
  }
}
