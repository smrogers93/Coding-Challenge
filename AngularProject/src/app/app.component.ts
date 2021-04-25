import { Component } from '@angular/core';
import { simpleApiService } from './services/simpleApi.service';
import { Response } from './classes/response';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  constructor(private _simpleApiService: simpleApiService) {}

  response: Response[];

  getAvailableOperations() {
    this._simpleApiService.getAvailableOperations().subscribe(
      data => 
      {
        this.response = data.value;
      }
    )
  }

  getAdd() {
    this._simpleApiService.getAdd((document.getElementById("first-number-box") as HTMLInputElement).value, (document.getElementById("second-number-box") as HTMLInputElement).value).subscribe(
      data => 
      {
        this.response = data;
      }
    )
  }

  getDivide() {
    this._simpleApiService.getDivide((document.getElementById("first-number-box") as HTMLInputElement).value, (document.getElementById("second-number-box") as HTMLInputElement).value).subscribe(
      data => 
      {
        this.response = data;
      }
    )
  }



  title = 'AngularProject';
}
