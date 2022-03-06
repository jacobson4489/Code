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

  public getAll(): Observable<Course[]>{
    const path = this.courseApiUrl;
    return this.http.get<Course[]>(path);
  }

  public getById(courseID: number): Observable<Course> {
    const path = this.courseApiUrl + `/${courseID}`;
    return this.http.get<Course>(path);
  }
}
