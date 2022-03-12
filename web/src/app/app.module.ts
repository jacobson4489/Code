import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { FormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { HomeComponent } from './components/home/home.component';
import { GolferListComponent } from './components/golfer/golfer-list/golfer-list.component';
import { GolferFormComponent } from './components/golfer/golfer-form/golfer-form.component';
import { CourseListComponent } from './components/course/course-list/course-list.component';
import { AddressListComponent } from './components/address/address-list/address-list.component';

import { GolferService } from './services/golfer/golfer.service';
import { CourseService } from './services/course/course.service';
import { AddressService } from './services/address/address.service';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    GolferListComponent,
    GolferFormComponent,
    CourseListComponent,
    AddressListComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [
    GolferService,
    CourseService,
    AddressService
  ],
  bootstrap: [AppComponent]
})

export class AppModule { }
