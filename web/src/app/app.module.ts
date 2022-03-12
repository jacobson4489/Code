import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { FormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { HomeComponent } from './components/home/home.component';

import { GolferListComponent } from './components/golfer/golfer-list/golfer-list.component';
import { CourseListComponent } from './components/course/course-list/course-list.component';

import { GolferFormComponent } from './components/golfer/golfer-form/golfer-form.component';
import { CourseFormComponent } from './components/course/course-form/course-form.component';

import { GolferService } from './services/golfer/golfer.service';
import { CourseService } from './services/course/course.service';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    GolferListComponent,
    CourseListComponent,
    GolferFormComponent,
    CourseFormComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [
    GolferService,
    CourseService
  ],
  bootstrap: [AppComponent]
})

export class AppModule { }
