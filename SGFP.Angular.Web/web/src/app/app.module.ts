import 'hammerjs';

import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import {MatButtonModule, MatCheckboxModule} from '@angular/material';
import { AppComponent } from './app.component';
import { FormsModule , ReactiveFormsModule} from '@angular/forms';
import { HomeComponent } from './home/home.component';
import {MatTooltipModule} from '@angular/material/tooltip';

import {DemoMaterialModule} from './material-module';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent
  ],
  imports: [
    DemoMaterialModule,
    BrowserModule,
    BrowserAnimationsModule,
    MatButtonModule,
    MatCheckboxModule,
    FormsModule,
    MatTooltipModule,
    ReactiveFormsModule,
  ],
  providers: [],
  bootstrap: [AppComponent , HomeComponent ]
})
export class AppModule { }
