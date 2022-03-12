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
  showAddressList: boolean = true;

  showGolferForm: boolean = true;

  constructor() { }

  ngOnInit() {
    this.hideAll();
  }

  private hideAll() {
    this.showHome = false;
    this.showGolferList = false;
    this.showCourseList = false;
    this.showAddressList = false;
  }

  onClickHome() {
    this.hideAll();
    this.showHome = true;
  }

  onClickGolfers() {
    this.hideAll();
    this.showGolferList = true;
  }

  onClickCourses() {
    this.hideAll();
    this.showCourseList = true;
  }

  onClickAddresses() {
    this.hideAll();
    this.showAddressList = true;
  }
}
