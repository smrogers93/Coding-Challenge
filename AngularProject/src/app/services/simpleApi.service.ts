import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable() 
export class simpleApiService
{
    constructor(private httpclient: HttpClient) {}

    getAvailableOperations(): Observable<any> {
        return this.httpclient.get("https://localhost:5001/calculator/api/calculator/availableoperations");
    }

    getAdd(firstNumber: any, secondNumber: any): Observable<any> {
        return this.httpclient.get("https://localhost:5001/calculator/api/calculator/add/" + firstNumber + "/" + secondNumber);
    }

    getDivide(firstNumber: any, secondNumber: any): Observable<any> {
        return this.httpclient.get("https://localhost:5001/calculator/api/calculator/divide/" + firstNumber + "/" + secondNumber);
    }
}