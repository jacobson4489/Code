import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Course } from '../../models/Course'
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})

export class CourseService {
  private courseApiUrl = 'https://localhost:7158/api/Course'

  constructor(private http: HttpClient) { }

  public getAllCourses(): Observable<Course[]>{
    const path = this.courseApiUrl + '/GetAllCourses';
    return this.http.get<Course[]>(path);
  }

  public getCourseByCourseId(courseId: number): Observable<Course> {
    const path = this.courseApiUrl + `/GetCourseByCourseId/${courseId}`;
    return this.http.get<Course>(path);
  }

  public insertCourse(course: Course): Observable<Course> {
    const path = this.courseApiUrl + '/InsertCourse';
    return this.http.post<Course>(path, course);
  }

  public updateCourseByCourseId(courseId: number, course: Course): Observable<Course> {
    const path = this.courseApiUrl + `/UpdateCourseByCourseId/${courseId}`;
    return this.http.put<Course>(path, course);
  }

  public deleteCourseByCourseId(courseId: number): Observable<string> {
    const path = this.courseApiUrl + `/DeleteCourseByCourseId/${courseId}`;
    return this.http.delete<string>(path);
  }
}
