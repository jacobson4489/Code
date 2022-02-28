import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { GolferComponent } from './components/golfer/golfer.component';
import { GolferService } from './services/golfer/golfer.service'

@NgModule({
  declarations: [
    AppComponent,
    GolferComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [
    GolferService
  ],
  bootstrap: [AppComponent]
})

export class AppModule { }
