import { Component, OnInit } from '@angular/core';
import { Course } from '../../../models/Course'
import { CourseService } from '../../../services/course/course.service'

@Component({
  selector: 'app-course-form',
  templateUrl: './course-form.component.html',
  styleUrls: ['../../../app.component.scss']
})

export class CourseFormComponent implements OnInit {
  course: Course = new Course;
  courses: Course[];
  isInsert: boolean = false;

  constructor(private courseService: CourseService) { }

  ngOnInit() {
    this.getAllCourses();
    this.getCourse(1);
  }

  private getAllCourses() {
    this.courseService.getAllCourses().subscribe(response => {
      this.courses = response;
    });
  }

  private getCourse(courseId: number) {
    this.courseService.getCourseByCourseId(courseId).subscribe(response => {
      this.course = response;
    });
  }

  onSubmit() {
    if (this.isInsert) {
      this.insertCourse();
    }
    else {
      this.updateCourse();
    }
  }

  onNew() {
    this.course = new Course();
    this.isInsert = true;
  }

  onDelete() {
    this.courseService.deleteCourseByCourseId(this.course.courseId).subscribe((response) => {
    });
  }

  onCancel() {
  }

  insertCourse() {
    this.courseService.insertCourse(this.course).subscribe((response) => {
      this.course = response;
      this.isInsert = false;
    });
  }

  updateCourse() {
    this.courseService.updateCourseByCourseId(this.course.courseId, this.course).subscribe((response) => {
      this.course = response;
    })
  }
}
