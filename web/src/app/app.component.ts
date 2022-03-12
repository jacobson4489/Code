import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})

export class AppComponent {
  today: Date = new Date();

  showHome: boolean = true;
  showGolferList: boolean = true;
  showCourseList: boolean = true;

  showGolferForm: boolean = true;
  showCourseForm: boolean = true;

  constructor() { }

  ngOnInit() {
    this.hideAll();
  }

  private hideAll() {
    this.showHome = false;
    this.showGolferList = false;
    this.showCourseList = false;
    this.showGolferForm = false;
    this.showCourseForm = false;
  }

  onClickHome() {
    this.hideAll();
    this.showHome = true;
  }

  onClickGolfers() {
    this.hideAll();
    this.showGolferList = true;
    this.showGolferForm = true;
  }

  onClickCourses() {
    this.hideAll();
    this.showCourseList = true;
    this.showCourseForm = true;
  }
}
