import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { simpleApiService } from './services/simpleApi.service';
import { NumbersOnlyDirective } from './directives/numbersOnly.directive';

import { AppComponent } from './app.component';

@NgModule({
  declarations: [
    AppComponent,
    NumbersOnlyDirective
  ],
  imports: [
    BrowserModule,
    HttpClientModule
  ],
  providers: [simpleApiService],
  bootstrap: [AppComponent]
})
export class AppModule { }
